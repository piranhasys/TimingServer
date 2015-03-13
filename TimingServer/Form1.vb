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
    Dim bteSendData() As Byte
    Private UDPConnected1 As Boolean = False
    Private UDPConnected2 As Boolean = False
    Private UDPConnected3 As Boolean = False
    Private UDPConnected4 As Boolean = False
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

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loading = True
        Me.Text = "Piranha Timing Server v." & Application.ProductVersion
        Setup()
        SetupOutput()
        ShowRunningStatus()
        TimerHeartbeat.Start()
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

    Private Sub SocketM_ClientData(ByVal message As String) Handles SerialOmega.DataArrival
        ProcessOmegaClock(message)
    End Sub
    Sub ProcessOmegaClock(ByVal thisData As String)
        'can arrive 10 per second
        'should already be filtered by Serial class
        'logger.Debug(thisData)
        Dim sendClock As Boolean = False
        If thisData.StartsWith("D") Then
            If thisData.Length > 18 Then
                Dim extractedTime As String = thisData.Substring(1, 5)
                'omega use only 1 leading zero for minutes eg ' 0:44'

                If (extractedTime.Substring(0, 1) = " ") Then
                    extractedTime = extractedTime.Replace(" ", "0")
                End If

                Dim extractedStatus As String = thisData.Substring(18, 1)
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
                        'not sure of status when counting down - 2, 3 don't seem to appear
                        Case "0", "2"
                            If ClockRunning Then
                                '## change of status
                            End If
                            ClockRunning = False
                        Case "1", "3"
                            If Not (ClockRunning) Then
                                '## change of status
                            End If
                            ClockRunning = True
                    End Select
                    ShowRunningStatus()
                    If My.Settings.SourceCOM Then
                        OutgoingString = "TS|" & My.Settings.LocationCode & "|" & currentOmegaTime & "|" & currentOmegaStatus & "|"
                        lastTX = Now
                        Broadcast(True)
                    End If

                End If
            End If
        End If
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

    Sub CloseConnections()
        If SerialOmega.Connected Then
            SerialOmega.Disconnect()
        End If
        If UDPConnectedIncoming Then
            udpClientIncoming.Close()
        End If
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
        lablCOMError.Visible = False
        lablCOMOK.Visible = False
        lablUDPIncomingError.Visible = False
        lablUDPIncomingOK.Visible = False
        lablError1.Visible = False
        lablOK1.Visible = False
        lablError2.Visible = False
        lablOK2.Visible = False
        lablError3.Visible = False
        lablOK3.Visible = False
        lablError4.Visible = False
        lablOK4.Visible = False
    End Sub
    Sub Setup()
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
        If My.Settings.UDP1Enabled Then
            Try
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
                If UDPConnected1 Then
                    udpClient1.Send(bteSendData, bteSendData.Length)
                    Console.WriteLine("Sent to UDP1: " & OutgoingString)
                End If
                If UDPConnected2 Then
                    udpClient2.Send(bteSendData, bteSendData.Length)
                    Console.WriteLine("Sent to UDP2: " & OutgoingString)
                End If
                If UDPConnected3 Then
                    udpClient3.Send(bteSendData, bteSendData.Length)
                    Console.WriteLine("Sent to UDP3: " & OutgoingString)
                End If
                If UDPConnected4 Then
                    udpClient4.Send(bteSendData, bteSendData.Length)
                    Console.WriteLine("Sent to UDP4: " & OutgoingString)
                End If
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
            OutgoingString = "TS|" & My.Settings.LocationCode & "|" & elapsedTime.ToString(My.Settings.TestTimerFormat) & "|1|"
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
            OutgoingString = "TS|" & My.Settings.LocationCode & "|" & elapsedTime.ToString(My.Settings.TestTimerFormat) & "|0|"
            Broadcast(True)
        End If

    End Sub
    Private Sub btnTimerReset_Click(sender As Object, e As EventArgs) Handles btnTimerReset.Click
        TimerTimer.Stop()
        If My.Settings.SourceTestTimer Then
            currentTicks = 0
            elapsedTime = New Date(currentTicks)
            OutgoingString = "TS|" & My.Settings.LocationCode & "|" & elapsedTime.ToString(My.Settings.TestTimerFormat) & "|0|"
            Broadcast(True)
        End If
    End Sub

    Private Sub TimerOmega_Tick(sender As Object, e As EventArgs) Handles TimerOmega.Tick
        Me.lablOmega.Visible = False 'constant flow of data keeps visible
        Me.lablRunning.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ProcessOmegaClock("D 0:00 00000000000000000000000000000000000")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ProcessOmegaClock("D 0:19 00000000000100000000000000000000000")
    End Sub

    Private Sub TimerHeartbeat_Tick(sender As Object, e As EventArgs) Handles TimerHeartbeat.Tick
        If DateDiff(DateInterval.Second, lastBroadcastTimestamp, Now) > 9 Then
            OutgoingString = "TS|" & My.Settings.LocationCode & "|HBT " & Now.ToLongTimeString & "|-1|"
            Broadcast(False)
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        CloseConnections()
        Setup()
    End Sub
End Class
