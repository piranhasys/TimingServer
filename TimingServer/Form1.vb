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
    Public RemoteIpEndPoint As New IPEndPoint(IPAddress.Any, 0)
    Private Shared thdUdp As Thread
    Private Loading As Boolean = True

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If UDPConnectedIncoming Then
            thdUdp.Abort()
            udpClientIncoming.Close()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loading = True
        Me.Text = "Piranha Timing Server v." & Application.ProductVersion
        Setup()
        SetupOutput()
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
            Broadcast()
        End If
    End Sub
    Sub Setup()

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
    Sub Broadcast()
        If OutgoingString <> lastOutput Then
            ShowOutgoing()
            lastOutput = OutgoingString
            Try
                bteSendData = Encoding.ASCII.GetBytes(OutgoingString)
                If UDPConnected1 Then
                    udpClient1.Send(bteSendData, bteSendData.Length)
                End If
                If UDPConnected2 Then
                    udpClient2.Send(bteSendData, bteSendData.Length)
                End If
                If UDPConnected3 Then
                    udpClient3.Send(bteSendData, bteSendData.Length)
                End If
                If UDPConnected4 Then
                    udpClient4.Send(bteSendData, bteSendData.Length)
                End If

            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try

        End If
    End Sub

    Private Sub btnTestClock_Click(sender As Object, e As EventArgs) Handles btnTestClockTimer.Click
        TimerClock.Stop()
        TimerTimer.Stop()
        startTicks = Now.Ticks
        TimerTimer.Start()
    End Sub

    Private Sub TimerClock_Tick(sender As Object, e As EventArgs) Handles TimerClock.Tick
        If My.Settings.SourceTestClock Then
            elapsedTime = Date.Now
            OutgoingString = My.Settings.LocationCode & "|" & elapsedTime.ToString(My.Settings.TestClockFormat)
            Broadcast()
        End If
    End Sub

    Private Sub btnTestTimer_Click(sender As Object, e As EventArgs) Handles btnTestTimer.Click
        TimerClock.Stop()
        TimerTimer.Stop()

        TimerClock.Start()
    End Sub

    Private Sub TimerTimer_Tick(sender As Object, e As EventArgs) Handles TimerTimer.Tick
        If My.Settings.SourceTestTimer Then
            currentTicks = Now.Ticks - startTicks
            elapsedTime = New Date(currentTicks)
            OutgoingString = My.Settings.LocationCode & "|" & elapsedTime.ToString(My.Settings.TestTimerFormat)
            Broadcast()
        End If
    End Sub

    Private Sub btnBroadcastUDP_Click(sender As Object, e As EventArgs) Handles btnBroadcastUDP.Click
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
        TimerClock.Enabled = My.Settings.SourceTestClock
    End Sub

    Private Sub btnTimerStart_Click(sender As Object, e As EventArgs) Handles btnTimerStart.Click
        startTicks = Now.Ticks
        TimerTimer.Start()
    End Sub

    Private Sub btnTimerReset_Click(sender As Object, e As EventArgs) Handles btnTimerReset.Click
        TimerTimer.Stop()
        If My.Settings.SourceTestTimer Then
            currentTicks = 0
            elapsedTime = New Date(currentTicks)
            OutgoingString = My.Settings.LocationCode & "|" & elapsedTime.ToString(My.Settings.TestTimerFormat)
            Broadcast()
        End If
    End Sub
End Class
