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
    Private udpClient1 As New UdpClient()
    Private udpClient2 As New UdpClient()
    Private udpClient3 As New UdpClient()
    Private udpClient4 As New UdpClient()
    'Private GroupEP1 As IPEndPoint
    'Private GroupEP2 As IPEndPoint
    'Private GroupEP3 As IPEndPoint
    'Private GroupEP4 As IPEndPoint
    'Private SendUdp1 As New UdpClient()
    'Private SendUdp2 As New UdpClient()
    'Private SendUdp3 As New UdpClient()
    'Private SendUdp4 As New UdpClient()
    'Private GroupIP1 As IPAddress
    'Private GroupIP2 As IPAddress
    'Private GroupIP3 As IPAddress
    'Private GroupIP4 As IPAddress
    Dim bteSendData() As Byte
    Private UDPConnected1 As Boolean = False
    Private UDPConnected2 As Boolean = False
    Private UDPConnected3 As Boolean = False
    Private UDPConnected4 As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Piranha Timing Server v." & Application.ProductVersion
        Setup()
    End Sub

    Sub Setup()
       
        If My.Settings.UDP1Enabled Then
            Try
                udpClient1.Connect(My.Settings.UDP1, My.Settings.UDP1Port)
                UDPConnected1 = True
                lablError1.Visible = False
            Catch ex As Exception
                UDPConnected1 = False
                lablError1.Visible = True
            End Try
        End If
        If My.Settings.UDP2Enabled Then
            Try
                udpClient2.Connect(My.Settings.UDP2, My.Settings.UDP2Port)
                UDPConnected2 = True
                lablError2.Visible = False
            Catch ex As Exception
                UDPConnected2 = False
                lablError2.Visible = True
            End Try
        End If
        If My.Settings.UDP3Enabled Then
            Try
                udpClient3.Connect(My.Settings.UDP3, My.Settings.UDP3Port)
                UDPConnected3 = True
                lablError3.Visible = False
            Catch ex As Exception
                UDPConnected3 = False
                lablError3.Visible = True
            End Try
        End If
        If My.Settings.UDP4Enabled Then
            Try
                udpClient4.Connect(My.Settings.UDP4, My.Settings.UDP4Port)
                UDPConnected4 = True
                lablError4.Visible = False
            Catch ex As Exception
                UDPConnected4 = False
                lablError4.Visible = True
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
    Sub Broadcast()
        If OutgoingString <> lastOutput Then
            ShowOutgoing()
            lastOutput = OutgoingString
            Try
                bteSendData = Encoding.Unicode.GetBytes(OutgoingString)
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
        elapsedTime = Date.Now
        OutgoingString = My.Settings.LocationCode & "|" & elapsedTime.ToString(My.Settings.TestClockFormat)
        Broadcast()
    End Sub

    Private Sub btnTestTimer_Click(sender As Object, e As EventArgs) Handles btnTestTimer.Click
        TimerClock.Stop()
        TimerTimer.Stop()

        TimerClock.Start()
    End Sub

    Private Sub TimerTimer_Tick(sender As Object, e As EventArgs) Handles TimerTimer.Tick
        currentTicks = Now.Ticks - startTicks
        elapsedTime = New Date(currentTicks)
        OutgoingString = My.Settings.LocationCode & "|" & elapsedTime.ToString(My.Settings.TestTimerFormat)
        Broadcast()
    End Sub
End Class
