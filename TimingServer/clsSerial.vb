Imports System.Text
Public Class clsSerial
    Dim WithEvents serialPort As New IO.Ports.SerialPort
    Public BaudRate As Integer = 9600
    Public PortName As String = "COM1"
    Public Parity As IO.Ports.Parity = IO.Ports.Parity.None
    Public DataBits As Integer = 8
    Public StopBits As IO.Ports.StopBits = IO.Ports.StopBits.One
    Public HandShaking As IO.Ports.Handshake = IO.Ports.Handshake.None
    Public Connected As Boolean = False
    Public Shared Event DataArrival(ByVal Data As String)
    Private tempMessage As String = ""

    Public Function Connect() As Boolean
        If serialPort.IsOpen Then
            serialPort.Close()
        End If

        Try
            With serialPort
                .PortName = PortName
                .BaudRate = BaudRate
                .Parity = Parity
                .DataBits = DataBits
                .StopBits = StopBits
                .Handshake = HandShaking
                .Encoding = Encoding.ASCII
                .DtrEnable = True
                .RtsEnable = True
            End With
            serialPort.Open()

            Connected = True
        Catch ex As Exception
            Connected = False
            Return False
        End Try
        Return True
    End Function
    Public Sub Disconnect()
        If serialPort.IsOpen Then
            serialPort.Close()
        End If
        Connected = False
    End Sub
    Private Sub DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles serialPort.DataReceived
        'does not end with etx, checksum follows
        'extract between stx & etx

        Dim thisMessage As String = serialPort.ReadExisting
        Dim stx As String = Chr(2)
        Dim etx As String = Chr(3)
        'Console.WriteLine(thisMessage)
        If thisMessage.Contains(etx) Then
            tempMessage += thisMessage
            extractMessages(tempMessage)
            tempMessage = ""    'clear for next time
        Else
            'unfinished packet
            tempMessage += thisMessage   'add for future
        End If

    End Sub
    Private Sub extractMessages(ByVal thisBatch As String)
        'format <STX>D00:01<ETX>CRC><STX>D00:02<ETX><CRC>
        Dim stx As String = Chr(2)
        Dim etx As String = Chr(3)
        Dim convertedBatch As String = thisBatch.Replace(stx, "|").Replace(etx, "|")
        Dim messages() As String
        messages = convertedBatch.Split("|")
        For inc = 0 To UBound(messages)
            'discard any <CRC> messages

            If messages(inc).Length > 4 Then
                If messages(inc).StartsWith("D") Then
                    'clock
                    RaiseEvent DataArrival(messages(inc))
                End If
            End If

        Next

    End Sub
    Private Sub serialPort_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles serialPort.Disposed
        'MsgBox(e.ToString)
    End Sub

    Private Sub serialPort_ErrorReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialErrorReceivedEventArgs) Handles serialPort.ErrorReceived
        'Console.WriteLine("Error in serial")
    End Sub

    Private Sub serialPort_PinChanged(ByVal sender As Object, ByVal e As System.IO.Ports.SerialPinChangedEventArgs) Handles serialPort.PinChanged
        'Console.WriteLine("Error in serial")
    End Sub

End Class
