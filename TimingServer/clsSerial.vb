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
       
        Dim thisMessage As String = serialPort.ReadExisting
        Dim stx As String = Chr(1) & Chr(20)
        Dim etx As String = Chr(4)
        Console.WriteLine("Raw: " & thisMessage.Replace(vbLf, "[LF]").Replace(vbCr, "[CR]").Replace(vbCrLf, "[CRLF]").Replace(Chr(1), "[1]").Replace(Chr(2), "[2]").Replace(Chr(3), "[3]").Replace(Chr(4), "[4]").Replace(Chr(20), "[20]").Replace(Chr(8), "[8]"))
        If thisMessage.Contains(etx) Then
            tempMessage += thisMessage
            '  Console.WriteLine(tempMessage.Replace(vbLf, "[LF]").Replace(vbCr, "[CR]").Replace(vbCrLf, "[CRLF]"))
            extractMessages(tempMessage)    'may be part message following EOT - keep
            If tempMessage.EndsWith(etx) Then
                'OK
                tempMessage = "" 'clear for next time
            Else
                'find last ETX, keep rest
                Dim lastETX As Integer = tempMessage.LastIndexOf(etx)
                'abcdefgh|jklmno
                'len=15 lastetx=8 start at 9 take 6
                tempMessage = tempMessage.Substring(lastETX + 1, tempMessage.Length - (lastETX + 1))
                '  Console.WriteLine("######################################## " + tempMessage)
            End If
        Else
            'unfinished packet
            tempMessage += thisMessage   'add for future
        End If

    End Sub
    Private Sub extractMessages(ByVal thisBatch As String)

        Dim stx As String = Chr(1) & Chr(20)
        Dim etx As String = Chr(4)
        Dim convertedBatch As String = thisBatch.Replace(etx, "|")
        Dim messages() As String
        messages = convertedBatch.Split("|")
        For inc = 0 To UBound(messages)
            Dim tidiedData As String = messages(inc).Replace(stx, "").Replace(Chr(8), " ").Replace(Chr(2), " ").Replace(Chr(20), " ").Replace(Chr(3), " ")
            If tidiedData.Length > 4 Then
                RaiseEvent DataArrival(tidiedData)
                'If tidiedData.StartsWith("R") Then
                '    'clock
                'End If
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
