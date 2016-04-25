Imports System.Net.Sockets
Imports System.Text
Imports System.IO
Imports System.Net
Imports System.Threading
Public Class Form1
    Private OutgoingString As String = ""
    Private startTicks As Long = Now.Ticks
    Private currentTicks As Long = 0
    Private elapsedTime As Date = Now
    Private lastOutput As String = ""
    Private udpClientIncoming As New UdpClient()
    Private udpClient1 As New UdpClient()
    Private udpClient2 As New UdpClient()
    Private udpClient3 As New UdpClient()
    Private udpClient4 As New UdpClient()
    Private udpClient5 As New UdpClient()
    Private udpClient6 As New UdpClient()
    Private udpClient7 As New UdpClient()
    Private udpClient8 As New UdpClient()
    Dim bteSendData() As Byte
    Private UDPConnected1 As Boolean = False
    Private UDPConnected2 As Boolean = False
    Private UDPConnected3 As Boolean = False
    Private UDPConnected4 As Boolean = False
    Private UDPConnected5 As Boolean = False
    Private UDPConnected6 As Boolean = False
    Private UDPConnected7 As Boolean = False
    Private UDPConnected8 As Boolean = False
    Private UDPConnectedIncoming As Boolean = False
    Private COMConnected As Boolean = False
    Public RemoteIpEndPoint As New IPEndPoint(IPAddress.Any, 0)
    Private Shared thdUdp As Thread
    Private Loading As Boolean = True
    Private WithEvents SerialOmega As New clsSerial
    Private currentOmegaTime As String = ""
    Private currentOmegaStatus As String = ""
    Private lastTX As Date = Now
    Private lastBroadcastTimestamp As Date = Now
    Private ClockRunning As Boolean = False
    Private GoogleDriveFilename As String = "ipaddresses.txt"
    Private GoogleDriveFileID As String = ""
    Private saveFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\TimingServer"
    Private dataList As List(Of String) = New List(Of String)
    Private client As TcpClient
    Const READ_BUFFER_SIZE As Integer = 8192 * 2
    Dim dtLastData As Date = Now
    Private readBuffer(READ_BUFFER_SIZE) As Byte
    Public bConnectedToServer As Boolean = False


    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            If bConnectedToServer = True Then
                SendData("DISCONNECT|" & My.Computer.Name & "-TimingServer" & "|Network|")
                Threading.Thread.Sleep(1000)
            End If

        Catch ex As Exception

        End Try
        If UDPConnectedIncoming Then
            Try
                thdUdp.Abort()
                udpClientIncoming.Close()
            Catch ex As Exception

            End Try
        End If
        If My.Settings.COMPortEnabled Then
            SerialOmega.Disconnect()
        End If
        CloseUDPConnections()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loading = True
        Me.Text = "Piranha Timing Server v." & Application.ProductVersion
        If (System.IO.Directory.Exists(saveFolder) = False) Then
            System.IO.Directory.CreateDirectory(saveFolder)
        End If

        SetupIncoming()
        SetupUDP()  'outgoing
        SetupOutput()
        ShowRunningStatus()
        TimerHeartbeat.Start()
        Me.timerCheckConnections.Enabled = True
        ResizeForm()
        Loading = False
    End Sub
    Private Sub GetUDPData()
        Do While True
            Try
                RemoteIpEndPoint = New IPEndPoint(IPAddress.Any, Val(My.Settings.UDPListenPort))
                Dim RData As String = Encoding.ASCII.GetString(udpClientIncoming.Receive(RemoteIpEndPoint))
                ProcessIncomingUDP(RData)
                'If RData = "CloseMe" Then Exit Do
                'Thread.Sleep(0)
            Catch e As Exception
                ' RaiseEvent SockError("Error in UDP.Get: " & e.ToString)
            End Try
        Loop
    End Sub
    Sub ProcessIncomingUDP(incomingString As String)
        ShowIncomingUDP(incomingString)
        If My.Settings.SourceUDP Then
            OutgoingString = incomingString
            Broadcast(True)
        End If
    End Sub
    Private Sub ProcessCommands(ByVal strMessage As String)
        Dim dataArray() As String
        ' Message parts are divided by "|"  Break the string into an array accordingly.
        Try
            dtLastData = Now
            dataArray = strMessage.Split(Chr(124))
            ' dataArray(0) is the command.
            Select Case dataArray(0)
                'Case "HEARTBEAT"
                '    ShowIncomingUDP("SS HEARTBEAT")
                '    'Select Case dataArray(1)
                '    '    Case "FTP"
                '    '        dtLastPAHeartbeat = Now
                '    '        dtLastLocalHeartbeat = Now
                '    '        dtLastRemoteHeartbeat = Now
                '    '        ShowHeartbeat(1)
                '    '        ShowHeartbeat(2)
                '    '        ShowHeartbeat(3)
                '    '    Case "REMOTESPORTSERVER"
                '    '        dtLastRemoteHeartbeat = Now
                '    '        dtLastLocalHeartbeat = Now
                '    '        ShowHeartbeat(2)
                '    '        ShowHeartbeat(3)
                '    '    Case "SPORTSERVER"
                '    '        dtLastLocalHeartbeat = Now
                '    '        ShowHeartbeat(2)
                '    'End Select
                Case "TS"
                    'broadcast data
                    'show if TX device ??
                    ShowIncomingUDP(strMessage)
                    If RadioButtonTCPIncoming.Checked Then
                        OutgoingString = strMessage
                        Broadcast(True)   'will not go to TCP outgoing
                    End If
            End Select
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Sub

    Private Sub SocketM_ClientData(ByVal message As String) Handles SerialOmega.DataArrival
        ProcessOmegaClock(message)
    End Sub
    Sub ProcessOmegaClock(ByVal thisData As String)
        'can arrive 10 per second
        'should already be filtered by Serial class
        'logger.Debug(thisData)
        Dim sendClock As Boolean = False
        Dim sendCount As Integer = 1
        Select Case thisData.Substring(0, 1)
            Case "R", "S"
                If thisData.Length > 18 Then
                    Dim extractedTime As String = thisData.Substring(9, 11)
                    Console.WriteLine("Decoded: " & thisData)

                    'If (extractedTime.Substring(0, 1) = " ") Then
                    '    extractedTime = extractedTime.Replace(" ", "0")
                    'End If

                    Dim extractedStatus As String = thisData.Substring(0, 3)
                    If extractedTime <> currentOmegaTime Then
                        currentOmegaTime = extractedTime
                        sendClock = True
                        'AddToLog("Omega Time", currentOmegaTime)
                    ElseIf DateDiff(DateInterval.Second, lastTX, Now) > 0 Then
                        sendClock = True 'use as heartbeat and sync if any client has gone offline
                    End If
                    If extractedStatus <> currentOmegaStatus Then
                        'may not have changed time, but started
                        currentOmegaStatus = extractedStatus
                        sendClock = True
                    End If
                    If sendClock Then
                        ShowIncomingOmega(currentOmegaTime)
                        Select Case currentOmegaStatus
                            Case "S02"
                                If ClockRunning Then
                                    '## change of status
                                    sendCount = Val(My.Settings.RepeatCount)
                                End If
                                ClockRunning = False
                            Case "R02"
                                If Not (ClockRunning) Then
                                    '## change of status
                                    sendCount = Val(My.Settings.RepeatCount)
                                End If
                                ClockRunning = True
                        End Select
                        ShowRunningStatus()
                        Dim TXStatus As String = ""
                        Select Case currentOmegaStatus
                            Case "R00"
                                TXStatus = "T"
                            Case "R02"
                                TXStatus = "R"
                            Case "S02"
                                Select Case Val(thisData.Substring(7, 1))
                                    Case Is > 0
                                        TXStatus = "O"
                                    Case Else
                                        TXStatus = "U"
                                End Select
                        End Select
                        If My.Settings.SourceCOM Then
                            If currentOmegaTime.Trim <> "" Then
                                OutgoingString = "TS|" & My.Settings.LocationCode & "|" & currentOmegaTime & "|" & TXStatus & "|"
                                lastTX = Now
                                Dim interval As Integer = Val(My.Settings.RepeatInterval)
                                If interval < 0 Then interval = 0
                                If interval > 1000 Then interval = 1000 'limit to 1 sec
                                For inc As Integer = 1 To sendCount
                                    Broadcast(True)
                                    If (TXStatus = "U") And (interval > 0) Then
                                        Thread.Sleep(interval)
                                    End If
                                Next
                            End If
                        End If

                    End If
                End If

        End Select
        ShowOmegaOK()
    End Sub
    Delegate Sub ShowRunningStatusCallback()
    Sub ShowRunningStatus()
        If lablRunning.InvokeRequired Then
            Dim d As New ShowRunningStatusCallback(AddressOf ShowRunningStatus)
            Me.Invoke(d, New Object() {})
        Else
            If ClockRunning Then
                lablRunning.Text = "RUNNING"
                lablRunning.BackColor = Color.DarkGreen
                lablRunning.ForeColor = Color.White
            Else
                lablRunning.Text = "STOPPED"
                lablRunning.BackColor = Color.DarkRed
                lablRunning.ForeColor = Color.White
            End If
        End If
    End Sub

    Delegate Sub ShowOmegaOKCallback()
    Sub ShowOmegaOK()
        Try
            If Me.lablOmega.InvokeRequired Then
                Dim d As New ShowOmegaOKCallback(AddressOf ShowOmegaOK)
                Me.Invoke(d, New Object() {})
            Else
                Me.lablOmega.Visible = True
                Me.lablRunning.Visible = True
                Me.TimerOmega.Enabled = False
                Me.TimerOmega.Enabled = True  'clear OK after 1 second
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Sub CloseAllConnections()
    '    If SerialOmega.Connected Then
    '        SerialOmega.Disconnect()
    '    End If
    '    If UDPConnectedIncoming Then
    '        udpClientIncoming.Close()
    '    End If
    '    If UDPConnected1 Then
    '        udpClient1.Close()
    '    End If
    '    If UDPConnected2 Then
    '        udpClient2.Close()
    '    End If
    '    If UDPConnected3 Then
    '        udpClient3.Close()
    '    End If
    '    If UDPConnected4 Then
    '        udpClient4.Close()
    '    End If
    '    If UDPConnected5 Then
    '        udpClient5.Close()
    '    End If
    '    If UDPConnected6 Then
    '        udpClient6.Close()
    '    End If
    '    If UDPConnected7 Then
    '        udpClient7.Close()
    '    End If
    '    If UDPConnected8 Then
    '        udpClient8.Close()
    '    End If
    '    lablCOMError.Visible = False
    '    lablCOMOK.Visible = False
    '    lablUDPIncomingError.Visible = False
    '    lablUDPIncomingOK.Visible = False
    '    lablError1.Visible = False
    '    lablOK1.Visible = False
    '    lablError2.Visible = False
    '    lablOK2.Visible = False
    '    lablError3.Visible = False
    '    lablOK3.Visible = False
    '    lablError4.Visible = False
    '    lablOK4.Visible = False
    '    lablerror5.Visible = False
    '    lablOK5.Visible = False
    '    lablError6.Visible = False
    '    lablOK6.Visible = False
    '    lablError7.Visible = False
    '    lablOK7.Visible = False
    '    lablError8.Visible = False
    '    lablOK8.Visible = False
    'End Sub
    Sub CloseUDPConnections()
        If UDPConnected1 Then
            udpClient1.Close()
        End If
        If UDPConnected2 Then
            udpClient2.Close()
        End If
        If UDPConnected3 Then
            udpClient3.Close()
        End If
        If UDPConnected4 Then
            udpClient4.Close()
        End If
        If UDPConnected5 Then
            udpClient5.Close()
        End If
        If UDPConnected6 Then
            udpClient6.Close()
        End If
        'If UDPConnected7 Then
        '    udpClient7.Close()
        'End If
        'If UDPConnected8 Then
        '    udpClient8.Close()
        'End If
        lablError1.Visible = False
        lablOK1.Visible = False
        lablError2.Visible = False
        lablOK2.Visible = False
        lablError3.Visible = False
        lablOK3.Visible = False
        lablError4.Visible = False
        lablOK4.Visible = False
        lablerror5.Visible = False
        lablOK5.Visible = False
        lablError6.Visible = False
        lablOK6.Visible = False
        'lablError7.Visible = False
        'lablOK7.Visible = False
        'lablError8.Visible = False
        'lablConnected.Visible = False
        UDPConnected1 = False
        UDPConnected2 = False
        UDPConnected3 = False
        UDPConnected4 = False
        UDPConnected5 = False
        UDPConnected6 = False
        'UDPConnected7 = False
        'UDPConnected8 = False
    End Sub
    Sub SetupUDP()
        If My.Settings.UDP1Enabled Then
            Try
                udpClient1 = New UdpClient
                udpClient1.Connect(My.Settings.UDP1, My.Settings.UDP1Port)
                UDPConnected1 = True
                lablError1.Visible = False
                lablOK1.Visible = True
            Catch ex As Exception
                UDPConnected1 = False
                lablError1.Visible = True
                lablOK1.Visible = False
            End Try
        End If
        If My.Settings.UDP2Enabled Then
            Try
                udpClient2 = New UdpClient
                udpClient2.Connect(My.Settings.UDP2, My.Settings.UDP2Port)
                UDPConnected2 = True
                lablError2.Visible = False
                lablOK2.Visible = True
            Catch ex As Exception
                UDPConnected2 = False
                lablError2.Visible = True
                lablOK2.Visible = False
            End Try
        End If
        If My.Settings.UDP3Enabled Then
            Try
                udpClient3 = New UdpClient
                udpClient3.Connect(My.Settings.UDP3, My.Settings.UDP3Port)
                UDPConnected3 = True
                lablError3.Visible = False
                lablOK3.Visible = True
            Catch ex As Exception
                UDPConnected3 = False
                lablError3.Visible = True
                lablOK3.Visible = False
            End Try
        End If
        If My.Settings.UDP4Enabled Then
            Try
                udpClient4 = New UdpClient
                udpClient4.Connect(My.Settings.UDP4, My.Settings.UDP4Port)
                UDPConnected4 = True
                lablError4.Visible = False
                lablOK4.Visible = True
            Catch ex As Exception
                UDPConnected4 = False
                lablError4.Visible = True
                lablOK4.Visible = False
            End Try
        End If
        If My.Settings.UDP5Enabled Then
            Try
                udpClient5 = New UdpClient
                udpClient5.Connect(My.Settings.UDP5, My.Settings.UDP5Port)
                UDPConnected5 = True
                lablerror5.Visible = False
                lablOK5.Visible = True
            Catch ex As Exception
                UDPConnected5 = False
                lablerror5.Visible = True
                lablOK5.Visible = False
            End Try
        End If
        If My.Settings.UDP6Enabled Then
            Try
                udpClient6 = New UdpClient
                udpClient6.Connect(My.Settings.UDP6, My.Settings.UDP6Port)
                UDPConnected6 = True
                lablError6.Visible = False
                lablOK6.Visible = True
            Catch ex As Exception
                UDPConnected6 = False
                lablError6.Visible = True
                lablOK6.Visible = False
            End Try
        End If
        'If My.Settings.UDP7Enabled Then
        '    Try
        '        udpClient7 = New UdpClient
        '        udpClient7.Connect(My.Settings.UDP7, My.Settings.UDP7Port)
        '        UDPConnected7 = True
        '        lablError7.Visible = False
        '        lablOK7.Visible = True
        '    Catch ex As Exception
        '        UDPConnected7 = False
        '        lablError7.Visible = True
        '        lablOK7.Visible = False
        '    End Try
        'End If
        'If My.Settings.UDP8Enabled Then
        '    Try
        '        udpClient8 = New UdpClient
        '        udpClient8.Connect(My.Settings.UDP8, My.Settings.UDP8Port)
        '        UDPConnected8 = True
        '        lablError8.Visible = False
        '        lablConnected.Visible = True
        '    Catch ex As Exception
        '        UDPConnected8 = False
        '        lablError8.Visible = True
        '        lablConnected.Visible = False
        '    End Try
        'End If


    End Sub
    Sub SetupIncoming()
        If My.Settings.COMPortEnabled Then
            Try
                With SerialOmega
                    .PortName = My.Settings.IncomingCOMPort
                    .BaudRate = 9600
                    .DataBits = 8
                    .Parity = Ports.Parity.None
                    .StopBits = Ports.StopBits.One
                    .HandShaking = Ports.Handshake.None

                    .Connect()
                    If .Connected = True Then
                        COMConnected = True
                        lablCOMError.Visible = False
                        lablCOMOK.Visible = True
                    Else
                        COMConnected = False
                        lablCOMError.Visible = True
                        lablCOMOK.Visible = False
                    End If
                End With
            Catch ex As Exception
                COMConnected = False
                lablCOMError.Visible = False
                lablCOMOK.Visible = False
            End Try
        End If

        If My.Settings.UDPListenEnabled Then
            If Val(My.Settings.UDPListenPort) > 0 Then
                Try
                    Dim iPort As Integer = Val(My.Settings.UDPListenPort)
                    udpClientIncoming = New UdpClient(iPort)
                    thdUdp = New Thread(AddressOf GetUDPData)
                    thdUdp.Start()
                    UDPConnectedIncoming = True
                    lablUDPIncomingError.Visible = False
                    lablUDPIncomingOK.Visible = True
                Catch e As Exception
                    UDPConnectedIncoming = False
                    lablUDPIncomingError.Visible = True
                    lablUDPIncomingOK.Visible = False
                End Try
                Dim headingText As String = ""
                Dim hostName As String = (System.Net.Dns.GetHostName())
                Dim host As IPHostEntry = System.Net.Dns.GetHostEntry(hostName)
                For Each ipAddressName As IPAddress In host.AddressList
                    If ipAddressName.IsIPv6LinkLocal = False Then
                        If headingText <> "" Then
                            headingText += ", "
                        End If
                        headingText += ipAddressName.ToString
                    End If
                Next
                lablListenAddresses.Text = headingText
            Else
                UDPConnectedIncoming = False
                lablUDPIncomingError.Visible = False
                lablUDPIncomingOK.Visible = False
            End If
        End If
    End Sub

    Delegate Sub ShowOutgoingCallback()
    Private Sub ShowOutgoing()
        If lablOutgoing.InvokeRequired Then
            Dim d As New ShowOutgoingCallback(AddressOf ShowOutgoing)
            Me.Invoke(d, New Object() {})
        Else
            lablOutgoing.Text = OutgoingString
        End If
    End Sub
    Delegate Sub ShowIncomingUDPCallback(textString As String)
    Private Sub ShowIncomingUDP(textString As String)
        If lablIncomingUDP.InvokeRequired Then
            Dim d As New ShowIncomingUDPCallback(AddressOf ShowIncomingUDP)
            Me.Invoke(d, New Object() {textString})
        Else
            lablIncomingUDP.Text = textString
            Console.WriteLine(textString)
        End If
    End Sub
    Delegate Sub ShowIncomingOmegaCallback(textString As String)
    Private Sub ShowIncomingOmega(textString As String)
        If lablOmega.InvokeRequired Then
            Dim d As New ShowIncomingOmegaCallback(AddressOf ShowIncomingOmega)
            Me.Invoke(d, New Object() {textString})
        Else
            lablOmega.Text = textString
        End If
    End Sub
    Sub Broadcast(forceSend As Boolean)
        If ((OutgoingString <> lastOutput) Or (forceSend)) Then
            ShowOutgoing()
            Try
                bteSendData = Encoding.ASCII.GetBytes(OutgoingString)
                If (bConnectedToServer) And (My.Settings.UDP8Enabled) Then
                    Dim localString As String = OutgoingString + Now.ToString("HH:mm:ss.ff") + "|"
                    SendData(localString)
                    Console.WriteLine("Sent to TCP: " & localString)
                End If
                If UDPConnected1 Then
                    Dim localString As String = OutgoingString + Now.ToString("HH:mm:ss.ff") + "|"
                    bteSendData = Encoding.ASCII.GetBytes(localString)
                    udpClient1.Send(bteSendData, bteSendData.Length)
                    Console.WriteLine("Sent to UDP1: " & localString)
                End If
                If UDPConnected2 Then
                    Dim localString As String = OutgoingString + Now.ToString("HH:mm:ss.ff") + "|"
                    bteSendData = Encoding.ASCII.GetBytes(localString)
                    udpClient2.Send(bteSendData, bteSendData.Length)
                    Console.WriteLine("Sent to UDP2: " & localString)
                End If
                If UDPConnected3 Then
                    Dim localString As String = OutgoingString + Now.ToString("HH:mm:ss.ff") + "|"
                    bteSendData = Encoding.ASCII.GetBytes(localString)
                    udpClient3.Send(bteSendData, bteSendData.Length)
                    Console.WriteLine("Sent to UDP3: " & localString)
                End If
                If UDPConnected4 Then
                    Dim localString As String = OutgoingString + Now.ToString("HH:mm:ss.ff") + "|"
                    bteSendData = Encoding.ASCII.GetBytes(localString)
                    udpClient4.Send(bteSendData, bteSendData.Length)
                    Console.WriteLine("Sent to UDP4: " & localString)
                End If
                If UDPConnected5 Then
                    Dim localString As String = OutgoingString + Now.ToString("HH:mm:ss.ff") + "|"
                    bteSendData = Encoding.ASCII.GetBytes(localString)
                    udpClient5.Send(bteSendData, bteSendData.Length)
                    Console.WriteLine("Sent to UDP5: " & localString)
                End If
                If UDPConnected6 Then
                    Dim localString As String = OutgoingString + Now.ToString("HH:mm:ss.ff") + "|"
                    bteSendData = Encoding.ASCII.GetBytes(localString)
                    udpClient6.Send(bteSendData, bteSendData.Length)
                    Console.WriteLine("Sent to UDP6: " & localString)
                End If
                'If UDPConnected7 Then
                '    Dim localString As String = OutgoingString + Now.ToString("HH:mm:ss.ff") + "|"
                '    bteSendData = Encoding.ASCII.GetBytes(localString)
                '    udpClient7.Send(bteSendData, bteSendData.Length)
                '    Console.WriteLine("Sent to UDP7: " & localString)
                'End If
                'If UDPConnected8 Then
                '    Dim localString As String = OutgoingString + Now.ToString("HH:mm:ss.ff") + "|"
                '    bteSendData = Encoding.ASCII.GetBytes(localString)
                '    udpClient8.Send(bteSendData, bteSendData.Length)
                '    Console.WriteLine("Sent to UDP8: " & localString)
                'End If
                lastOutput = OutgoingString
                lastBroadcastTimestamp = Now
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnTestClock_Click(sender As Object, e As EventArgs)
        TimerClock.Stop()
        TimerTimer.Stop()
        startTicks = Now.Ticks
        TimerTimer.Start()
    End Sub

    Private Sub TimerClock_Tick(sender As Object, e As EventArgs) Handles TimerClock.Tick
        If My.Settings.SourceTestClock Then
            elapsedTime = Date.Now
            OutgoingString = "TS|" & My.Settings.LocationCode & "|" & elapsedTime.ToString(My.Settings.TestClockFormat) & "||"
            Broadcast(False)
        End If
    End Sub

    Private Sub btnTestTimer_Click(sender As Object, e As EventArgs)
        TimerClock.Stop()
        TimerTimer.Stop()

        TimerClock.Start()
    End Sub

    Private Sub TimerTimer_Tick(sender As Object, e As EventArgs) Handles TimerTimer.Tick
        If My.Settings.SourceTestTimer Then
            currentTicks = Now.Ticks - startTicks
            elapsedTime = New Date(currentTicks)
            OutgoingString = "TS|" & My.Settings.LocationCode & "|" & elapsedTime.ToString(My.Settings.TestTimerFormat) & "|R|"
            Broadcast(False)
        End If
    End Sub

    Private Sub btnBroadcastUDP_Click(sender As Object, e As EventArgs)
        TimerClock.Stop()
        TimerTimer.Stop()

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.Click, RadioButton2.Click, RadioButton3.Click, RadioButton4.Click
        If Not (Loading) Then
            SetupOutput()
        End If
    End Sub
    Sub SetupOutput()
        TimerClock.Stop()
        TimerTimer.Stop()
        btnTimerReset.Enabled = My.Settings.SourceTestTimer
        btnTimerStart.Enabled = My.Settings.SourceTestTimer
        btnTimerStop.Enabled = My.Settings.SourceTestTimer
        TimerClock.Enabled = My.Settings.SourceTestClock
    End Sub

    Private Sub btnTimerStart_Click(sender As Object, e As EventArgs) Handles btnTimerStart.Click
        startTicks = Now.Ticks
        TimerTimer.Start()
    End Sub

    Private Sub btnTimerStop_Click(sender As Object, e As EventArgs) Handles btnTimerStop.Click
        TimerTimer.Stop()
        If My.Settings.SourceTestTimer Then
            elapsedTime = New Date(currentTicks)
            OutgoingString = "TS|" & My.Settings.LocationCode & "|" & elapsedTime.ToString(My.Settings.TestTimerFormat) & "|U|"
            Broadcast(True)
        End If

    End Sub
    Private Sub btnTimerReset_Click(sender As Object, e As EventArgs) Handles btnTimerReset.Click
        TimerTimer.Stop()
        If My.Settings.SourceTestTimer Then
            currentTicks = 0
            elapsedTime = New Date(currentTicks)
            OutgoingString = "TS|" & My.Settings.LocationCode & "|" & elapsedTime.ToString(My.Settings.TestTimerFormat) & "|U|"
            Broadcast(True)
        End If
    End Sub

    Private Sub TimerOmega_Tick(sender As Object, e As EventArgs) Handles TimerOmega.Tick
        Me.lablOmega.Visible = False 'constant flow of data keeps visible
        Me.lablRunning.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '        ProcessOmegaClock("D 0:00 00000000000000000000000000000000000")
        ProcessOmegaClock("S02      1:23                         00000000000000000000000000000000000")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '        ProcessOmegaClock("D 0:19 00000000000100000000000000000000000")
        ProcessOmegaClock("R02      0:00                         00000000000000000000000000000000000")
    End Sub

    Private Sub TimerHeartbeat_Tick(sender As Object, e As EventArgs) Handles TimerHeartbeat.Tick
        If DateDiff(DateInterval.Second, lastBroadcastTimestamp, Now) > 9 Then
            OutgoingString = "TS|" & My.Settings.LocationCode & "|HBT " & Now.ToString("HH:mm:ss") & "|-1|"
            Broadcast(False)
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        CloseUDPConnections()
        SetupUDP()
    End Sub
    Private Sub ReadLocalFile()
        Dim strFileName As String, strTextline As String = ""
        dataList.Clear()

        Dim inputFile As System.IO.StreamReader
        strFileName = saveFolder & "\" & GoogleDriveFilename
        If Not System.IO.File.Exists(strFileName) Then
            MessageBox.Show("No File")
            Exit Sub
        End If
        inputFile = System.IO.File.OpenText(strFileName)
        Try
            Do
                strTextline = inputFile.ReadLine
                If strTextline.Trim = "" Then
                    Exit Do
                Else
                    'read empty line, avoid next batch of tests on it
                    'Date|Name|Ipaddress
                    If strTextline.Contains("|") Then
                        Console.WriteLine(strTextline)
                        dataList.Add(strTextline)
                    End If
                    'logger.Debug(CourseLookup(iEntry).SourceName & " > " & CourseLookup(iEntry).OutputName)
                End If
            Loop Until strTextline Is Nothing
        Catch ex As Exception
            'if no CR at end of last entry, loop fails
        End Try
        inputFile.Close()

    End Sub

    Private Sub btnLoadConnections_Click(sender As Object, e As EventArgs) Handles btnLoadConnections.Click
        ClearIPAddressActives()
        CloseUDPConnections()
        Dim strSplit As Char = Convert.ToChar("|")
        ReadLocalFile()
        Dim inc As Integer = 1  'inc'd but keep index 1 free for RUK
        For Each thisString As String In dataList
            If thisString.Contains("|") Then
                Dim split() As String = thisString.Split(strSplit)
                If split.GetUpperBound(0) > 2 Then
                    If split(0) = Now.ToString("yyyy-MM-dd") Then
                        If split(1).Contains("*") Then
                            'readonly system
                        Else
                            inc += 1
                            AssignIPAddress(split(2), split(3), split(1), inc)
                        End If
                    End If
                End If
            End If
        Next
    End Sub
    Private Sub ClearIPAddressActives()
        My.Settings.UDP1Enabled = True  'RUK
        My.Settings.UDP2Enabled = False
        My.Settings.UDP3Enabled = False
        My.Settings.UDP4Enabled = False
        My.Settings.UDP5Enabled = False
        My.Settings.UDP6Enabled = False
        My.Settings.UDP7Enabled = False
        My.Settings.UDP8Enabled = False

        My.Settings.UDP2 = ""
        My.Settings.UDP3 = ""
        My.Settings.UDP4 = ""
        My.Settings.UDP5 = ""
        My.Settings.UDP6 = ""
        My.Settings.UDP7 = ""
        My.Settings.UDP8 = ""

        My.Settings.UDP2Port = ""
        My.Settings.UDP3Port = ""
        My.Settings.UDP4Port = ""
        My.Settings.UDP5Port = ""
        My.Settings.UDP6Port = ""
        My.Settings.UDP7Port = ""
        My.Settings.UDP8Port = ""

        My.Settings.Destination2 = ""
        My.Settings.Destination3 = ""
        My.Settings.Destination4 = ""
        My.Settings.Destination5 = ""
        My.Settings.Destination6 = ""
        My.Settings.Destination7 = ""
        My.Settings.Destination8 = ""
    End Sub
    Private Sub AssignIPAddress(addressString As String, portString As String, nameString As String, index As Integer)
        Select Case index
            Case 1
                My.Settings.UDP1 = addressString
                My.Settings.UDP1Port = portString
                My.Settings.UDP1Enabled = True
                My.Settings.Destination1 = nameString & ":"
            Case 2
                My.Settings.UDP2 = addressString
                My.Settings.UDP2Port = portString
                My.Settings.UDP2Enabled = True
                My.Settings.Destination2 = nameString & ":"
            Case 3
                My.Settings.UDP3 = addressString
                My.Settings.UDP3Port = portString
                My.Settings.UDP3Enabled = True
                My.Settings.Destination3 = nameString & ":"
            Case 4
                My.Settings.UDP4 = addressString
                My.Settings.UDP4Port = portString
                My.Settings.UDP4Enabled = True
                My.Settings.Destination4 = nameString & ":"
            Case 5
                My.Settings.UDP5 = addressString
                My.Settings.UDP5Port = portString
                My.Settings.UDP5Enabled = True
                My.Settings.Destination5 = nameString & ":"
            Case 6
                My.Settings.UDP6 = addressString
                My.Settings.UDP6Port = portString
                My.Settings.UDP6Enabled = True
                My.Settings.Destination6 = nameString & ":"
            Case 7
                My.Settings.UDP7 = addressString
                My.Settings.UDP7Port = portString
                My.Settings.UDP7Enabled = True
                My.Settings.Destination7 = nameString & ":"
            Case 8
                My.Settings.UDP8 = addressString
                My.Settings.UDP8Port = portString
                My.Settings.UDP8Enabled = True
                My.Settings.Destination8 = nameString & ":"
            Case Else
                'not valid
        End Select
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub btnConnectTCP_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Connect()
    End Sub
    Sub ShowMessage(textString As String)

    End Sub
    Sub ClearMessage()

    End Sub
    Sub Connect()
        If My.Settings.UDP8.Trim <> "" And My.Settings.UDP8Port > 0 Then
            Try
                ' The TcpClient is a subclass of Socket, providing higher level 
                ' functionality like streaming.
                '            client = New TcpClient("192.168.0.6", 10540)
                Console.WriteLine("Connecting to " & My.Settings.UDP8 & " Port " & My.Settings.UDP8Port.ToString)
                ShowMessage("Connecting to Main Server...")
                client = New TcpClient(My.Settings.UDP8, My.Settings.UDP8Port)
                ' Start an asynchronous read invoking DoRead to avoid lagging the user
                ' interface.
                client.GetStream.BeginRead(readBuffer, 0, READ_BUFFER_SIZE, AddressOf DoRead, Nothing)

                ' Make sure the window is showing before popping up connection dialog.
                'Me.Show()
                lablConnected.BackColor = Color.Lime
                lablConnected.ForeColor = Color.Black
                lablConnected.Text = "OK"
                lablConnected.Visible = True
                btnDisconnect.Enabled = True
                btnConnect.Enabled = False
                bConnectedToServer = True
            Catch Ex As Exception
                'UnhandledExceptionHandler()
                lablConnected.BackColor = Color.Red
                lablConnected.ForeColor = Color.White
                lablConnected.Text = "ERROR"
                btnDisconnect.Enabled = False
                btnConnect.Enabled = True
                bConnectedToServer = False
            End Try
            ClearMessage()
            If bConnectedToServer = True Then
                SendData("CONNECT|" & My.Computer.Name & "-TimingServer" & "|Network|")
            End If
        End If
    End Sub
    Sub Disconnect()
        Try
            client.Close()
            LablConnected.Visible = False
            btnDisconnect.Enabled = False
            btnConnect.Enabled = True
            bConnectedToServer = False
            'Logger.debug("enabled")
        Catch Ex As Exception
            'ShowAction(Ex.ToString)
        End Try
    End Sub
    Public Sub SendData(ByVal data As String)
        If bConnectedToServer = True Then
            Try
                Dim writer As New IO.StreamWriter(client.GetStream)
                writer.Write(data & vbCr)
                writer.Flush()
            Catch ex As Exception
            End Try
            'ShowAction(data)
        End If
    End Sub

    Private Sub btnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click
        SendData("DISCONNECT|Goodbye")
        Disconnect()
    End Sub
    Private Sub DoRead(ByVal ar As IAsyncResult)
        Dim BytesRead As Integer
        Dim strMessage As String
        'Dim dataArray() As String
        Dim inc As Integer
        Static strTemp As String
        Dim strData() As String

        Try
            ' Finish asynchronous read into readBuffer and return number of bytes read.
            BytesRead = client.GetStream.EndRead(ar)
            If BytesRead < 1 Then
                ' If no bytes were read server has closed.  Disable input window.
                Exit Sub
            End If

            strMessage = Encoding.Default.GetString(readBuffer, 0, BytesRead)
            If Microsoft.VisualBasic.Right(strMessage, 2) = vbCrLf Then
                strTemp += Microsoft.VisualBasic.Left(strMessage, Len(strMessage) - 2)    'remove CRLF
                If InStr(strTemp, vbCrLf) > 0 Then
                    strData = strTemp.Split(vbCrLf)
                    For inc = 0 To UBound(strData)
                        ProcessCommands(strData(inc).Replace(vbLf, "").Replace(vbCr, "")) 'tidy, should just be lf left after split
                    Next
                Else
                    ProcessCommands(strTemp)
                End If

                strTemp = ""    'clear for next time
            Else
                strTemp += strMessage   'add for future
            End If

            ' Start a new asynchronous read into readBuffer.
            client.GetStream.BeginRead(readBuffer, 0, READ_BUFFER_SIZE, AddressOf DoRead, Nothing)
        Catch e As Exception
        End Try
    End Sub

    Private Sub timerCheckConnections_Tick(sender As Object, e As EventArgs) Handles timerCheckConnections.Tick
        If DateDiff(DateInterval.Minute, dtLastData, Now) > 1 Then
            If bConnectedToServer = True Then
                Disconnect()
                Connect()
            End If
        End If
        If My.Settings.UDP7Enabled Then
            If bConnectedToServer = False Then
                Connect()
            End If
        End If

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged, RadioButton4.CheckedChanged
        ResizeForm()
    End Sub
    Sub ResizeForm()
        If RadioButton3.Checked Or RadioButton4.Checked Then
            Me.Height = 532
        Else
            Me.Height = 462
        End If
    End Sub
End Class
