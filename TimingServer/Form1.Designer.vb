<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lablOutgoing = New System.Windows.Forms.Label()
        Me.lablOmega = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TimerClock = New System.Windows.Forms.Timer(Me.components)
        Me.TimerTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lablError1 = New System.Windows.Forms.Label()
        Me.lablError2 = New System.Windows.Forms.Label()
        Me.lablError3 = New System.Windows.Forms.Label()
        Me.lablError4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lablIncomingUDP = New System.Windows.Forms.Label()
        Me.lablUDPIncomingError = New System.Windows.Forms.Label()
        Me.lablListenAddresses = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lablRunning = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lablUDPIncomingOK = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lablCOMOK = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.lablCOMError = New System.Windows.Forms.Label()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.lablOmegaError = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lablOK4 = New System.Windows.Forms.Label()
        Me.lablOK3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lablOK2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.lablOK1 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnTimerStop = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnTimerReset = New System.Windows.Forms.Button()
        Me.btnTimerStart = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TimerOmega = New System.Windows.Forms.Timer(Me.components)
        Me.TimerHeartbeat = New System.Windows.Forms.Timer(Me.components)
        Me.btnReset = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(18, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Clock Port:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(73, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(16, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "IP Address 1:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(16, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "IP Address 2:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(16, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "IP Address 3:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(16, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 18)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "IP Address 4:"
        '
        'lablOutgoing
        '
        Me.lablOutgoing.BackColor = System.Drawing.Color.Black
        Me.lablOutgoing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablOutgoing.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablOutgoing.ForeColor = System.Drawing.Color.White
        Me.lablOutgoing.Location = New System.Drawing.Point(203, 35)
        Me.lablOutgoing.Name = "lablOutgoing"
        Me.lablOutgoing.Size = New System.Drawing.Size(255, 32)
        Me.lablOutgoing.TabIndex = 18
        Me.lablOutgoing.Text = "ABC|01:02:03.04"
        Me.lablOutgoing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lablOmega
        '
        Me.lablOmega.BackColor = System.Drawing.Color.Black
        Me.lablOmega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablOmega.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablOmega.ForeColor = System.Drawing.Color.White
        Me.lablOmega.Location = New System.Drawing.Point(106, 96)
        Me.lablOmega.Name = "lablOmega"
        Me.lablOmega.Size = New System.Drawing.Size(190, 32)
        Me.lablOmega.TabIndex = 19
        Me.lablOmega.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(28, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 18)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Incoming:"
        '
        'TimerClock
        '
        Me.TimerClock.Interval = 10
        '
        'TimerTimer
        '
        Me.TimerTimer.Interval = 10
        '
        'lablError1
        '
        Me.lablError1.BackColor = System.Drawing.Color.Red
        Me.lablError1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablError1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablError1.ForeColor = System.Drawing.Color.White
        Me.lablError1.Location = New System.Drawing.Point(522, 24)
        Me.lablError1.Name = "lablError1"
        Me.lablError1.Size = New System.Drawing.Size(112, 29)
        Me.lablError1.TabIndex = 29
        Me.lablError1.Text = "ERROR"
        Me.lablError1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lablError1.Visible = False
        '
        'lablError2
        '
        Me.lablError2.BackColor = System.Drawing.Color.Red
        Me.lablError2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablError2.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablError2.ForeColor = System.Drawing.Color.White
        Me.lablError2.Location = New System.Drawing.Point(522, 60)
        Me.lablError2.Name = "lablError2"
        Me.lablError2.Size = New System.Drawing.Size(112, 29)
        Me.lablError2.TabIndex = 30
        Me.lablError2.Text = "ERROR"
        Me.lablError2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lablError2.Visible = False
        '
        'lablError3
        '
        Me.lablError3.BackColor = System.Drawing.Color.Red
        Me.lablError3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablError3.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablError3.ForeColor = System.Drawing.Color.White
        Me.lablError3.Location = New System.Drawing.Point(522, 96)
        Me.lablError3.Name = "lablError3"
        Me.lablError3.Size = New System.Drawing.Size(112, 29)
        Me.lablError3.TabIndex = 31
        Me.lablError3.Text = "ERROR"
        Me.lablError3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lablError3.Visible = False
        '
        'lablError4
        '
        Me.lablError4.BackColor = System.Drawing.Color.Red
        Me.lablError4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablError4.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablError4.ForeColor = System.Drawing.Color.White
        Me.lablError4.Location = New System.Drawing.Point(522, 132)
        Me.lablError4.Name = "lablError4"
        Me.lablError4.Size = New System.Drawing.Size(112, 29)
        Me.lablError4.TabIndex = 32
        Me.lablError4.Text = "ERROR"
        Me.lablError4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lablError4.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(25, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 18)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "UDP Port:"
        '
        'lablIncomingUDP
        '
        Me.lablIncomingUDP.BackColor = System.Drawing.Color.Black
        Me.lablIncomingUDP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablIncomingUDP.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablIncomingUDP.ForeColor = System.Drawing.Color.White
        Me.lablIncomingUDP.Location = New System.Drawing.Point(106, 226)
        Me.lablIncomingUDP.Name = "lablIncomingUDP"
        Me.lablIncomingUDP.Size = New System.Drawing.Size(255, 32)
        Me.lablIncomingUDP.TabIndex = 38
        Me.lablIncomingUDP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lablUDPIncomingError
        '
        Me.lablUDPIncomingError.BackColor = System.Drawing.Color.Red
        Me.lablUDPIncomingError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablUDPIncomingError.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablUDPIncomingError.ForeColor = System.Drawing.Color.White
        Me.lablUDPIncomingError.Location = New System.Drawing.Point(312, 168)
        Me.lablUDPIncomingError.Name = "lablUDPIncomingError"
        Me.lablUDPIncomingError.Size = New System.Drawing.Size(112, 29)
        Me.lablUDPIncomingError.TabIndex = 40
        Me.lablUDPIncomingError.Text = "ERROR"
        Me.lablUDPIncomingError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lablUDPIncomingError.Visible = False
        '
        'lablListenAddresses
        '
        Me.lablListenAddresses.AutoSize = True
        Me.lablListenAddresses.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablListenAddresses.ForeColor = System.Drawing.Color.White
        Me.lablListenAddresses.Location = New System.Drawing.Point(103, 202)
        Me.lablListenAddresses.Name = "lablListenAddresses"
        Me.lablListenAddresses.Size = New System.Drawing.Size(0, 18)
        Me.lablListenAddresses.TabIndex = 41
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lablRunning)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.lablUDPIncomingOK)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lablCOMOK)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lablCOMError)
        Me.GroupBox1.Controls.Add(Me.TextBox13)
        Me.GroupBox1.Controls.Add(Me.lablIncomingUDP)
        Me.GroupBox1.Controls.Add(Me.lablUDPIncomingError)
        Me.GroupBox1.Controls.Add(Me.lablListenAddresses)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CheckBox5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.CheckBox6)
        Me.GroupBox1.Controls.Add(Me.lablOmega)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lablOmegaError)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(446, 273)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Incoming"
        '
        'lablRunning
        '
        Me.lablRunning.BackColor = System.Drawing.Color.LimeGreen
        Me.lablRunning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablRunning.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablRunning.ForeColor = System.Drawing.Color.Black
        Me.lablRunning.Location = New System.Drawing.Point(312, 97)
        Me.lablRunning.Name = "lablRunning"
        Me.lablRunning.Size = New System.Drawing.Size(112, 29)
        Me.lablRunning.TabIndex = 49
        Me.lablRunning.Text = "Running"
        Me.lablRunning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lablRunning.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(16, 202)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 18)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Addresses:"
        '
        'lablUDPIncomingOK
        '
        Me.lablUDPIncomingOK.BackColor = System.Drawing.Color.LimeGreen
        Me.lablUDPIncomingOK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablUDPIncomingOK.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablUDPIncomingOK.ForeColor = System.Drawing.Color.Black
        Me.lablUDPIncomingOK.Location = New System.Drawing.Point(312, 168)
        Me.lablUDPIncomingOK.Name = "lablUDPIncomingOK"
        Me.lablUDPIncomingOK.Size = New System.Drawing.Size(112, 29)
        Me.lablUDPIncomingOK.TabIndex = 46
        Me.lablUDPIncomingOK.Text = "OK"
        Me.lablUDPIncomingOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lablUDPIncomingOK.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(26, 234)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 18)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Incoming:"
        '
        'lablCOMOK
        '
        Me.lablCOMOK.BackColor = System.Drawing.Color.LimeGreen
        Me.lablCOMOK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablCOMOK.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablCOMOK.ForeColor = System.Drawing.Color.Black
        Me.lablCOMOK.Location = New System.Drawing.Point(312, 25)
        Me.lablCOMOK.Name = "lablCOMOK"
        Me.lablCOMOK.Size = New System.Drawing.Size(112, 29)
        Me.lablCOMOK.TabIndex = 45
        Me.lablCOMOK.Text = "OK"
        Me.lablCOMOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lablCOMOK.Visible = False
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.TimingServer.My.MySettings.Default, "LocationCode", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(106, 60)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(89, 29)
        Me.TextBox6.TabIndex = 5
        Me.TextBox6.Text = Global.TimingServer.My.MySettings.Default.LocationCode
        '
        'lablCOMError
        '
        Me.lablCOMError.BackColor = System.Drawing.Color.Red
        Me.lablCOMError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablCOMError.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablCOMError.ForeColor = System.Drawing.Color.White
        Me.lablCOMError.Location = New System.Drawing.Point(312, 24)
        Me.lablCOMError.Name = "lablCOMError"
        Me.lablCOMError.Size = New System.Drawing.Size(112, 29)
        Me.lablCOMError.TabIndex = 42
        Me.lablCOMError.Text = "ERROR"
        Me.lablCOMError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lablCOMError.Visible = False
        '
        'TextBox13
        '
        Me.TextBox13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.TimingServer.My.MySettings.Default, "UDPListenPort", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox13.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox13.Location = New System.Drawing.Point(106, 168)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(89, 29)
        Me.TextBox13.TabIndex = 33
        Me.TextBox13.Text = Global.TimingServer.My.MySettings.Default.UDPListenPort
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.TimingServer.My.MySettings.Default, "IncomingCOMPort", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(106, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(89, 29)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = Global.TimingServer.My.MySettings.Default.IncomingCOMPort
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Checked = Global.TimingServer.My.MySettings.Default.UDPListenEnabled
        Me.CheckBox5.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.TimingServer.My.MySettings.Default, "UDPListenEnabled", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox5.ForeColor = System.Drawing.Color.White
        Me.CheckBox5.Location = New System.Drawing.Point(210, 172)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(85, 22)
        Me.CheckBox5.TabIndex = 34
        Me.CheckBox5.Text = "Enabled"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Checked = Global.TimingServer.My.MySettings.Default.COMPortEnabled
        Me.CheckBox6.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.TimingServer.My.MySettings.Default, "COMPortEnabled", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox6.ForeColor = System.Drawing.Color.White
        Me.CheckBox6.Location = New System.Drawing.Point(210, 29)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(85, 22)
        Me.CheckBox6.TabIndex = 35
        Me.CheckBox6.Text = "Enabled"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'lablOmegaError
        '
        Me.lablOmegaError.BackColor = System.Drawing.Color.Red
        Me.lablOmegaError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablOmegaError.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablOmegaError.ForeColor = System.Drawing.Color.White
        Me.lablOmegaError.Location = New System.Drawing.Point(106, 96)
        Me.lablOmegaError.Name = "lablOmegaError"
        Me.lablOmegaError.Size = New System.Drawing.Size(190, 32)
        Me.lablOmegaError.TabIndex = 48
        Me.lablOmegaError.Text = "NO OMEGA DATA"
        Me.lablOmegaError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lablOK4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lablOK3)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.lablOK2)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.lablOK1)
        Me.GroupBox2.Controls.Add(Me.lablError4)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.lablError3)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.lablError2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lablError1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TextBox12)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TextBox11)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.TextBox10)
        Me.GroupBox2.Controls.Add(Me.CheckBox2)
        Me.GroupBox2.Controls.Add(Me.TextBox9)
        Me.GroupBox2.Controls.Add(Me.CheckBox3)
        Me.GroupBox2.Controls.Add(Me.CheckBox4)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(465, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(655, 176)
        Me.GroupBox2.TabIndex = 43
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Outgoing UDP"
        '
        'lablOK4
        '
        Me.lablOK4.BackColor = System.Drawing.Color.LimeGreen
        Me.lablOK4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablOK4.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablOK4.ForeColor = System.Drawing.Color.Black
        Me.lablOK4.Location = New System.Drawing.Point(522, 132)
        Me.lablOK4.Name = "lablOK4"
        Me.lablOK4.Size = New System.Drawing.Size(112, 29)
        Me.lablOK4.TabIndex = 50
        Me.lablOK4.Text = "OK"
        Me.lablOK4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lablOK4.Visible = False
        '
        'lablOK3
        '
        Me.lablOK3.BackColor = System.Drawing.Color.LimeGreen
        Me.lablOK3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablOK3.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablOK3.ForeColor = System.Drawing.Color.Black
        Me.lablOK3.Location = New System.Drawing.Point(522, 95)
        Me.lablOK3.Name = "lablOK3"
        Me.lablOK3.Size = New System.Drawing.Size(112, 29)
        Me.lablOK3.TabIndex = 49
        Me.lablOK3.Text = "OK"
        Me.lablOK3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lablOK3.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.TimingServer.My.MySettings.Default, "UDP1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(120, 24)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(176, 29)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = Global.TimingServer.My.MySettings.Default.UDP1
        '
        'lablOK2
        '
        Me.lablOK2.BackColor = System.Drawing.Color.LimeGreen
        Me.lablOK2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablOK2.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablOK2.ForeColor = System.Drawing.Color.Black
        Me.lablOK2.Location = New System.Drawing.Point(522, 60)
        Me.lablOK2.Name = "lablOK2"
        Me.lablOK2.Size = New System.Drawing.Size(112, 29)
        Me.lablOK2.TabIndex = 48
        Me.lablOK2.Text = "OK"
        Me.lablOK2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lablOK2.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.TimingServer.My.MySettings.Default, "UDP2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(120, 60)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(176, 29)
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.Text = Global.TimingServer.My.MySettings.Default.UDP2
        '
        'lablOK1
        '
        Me.lablOK1.BackColor = System.Drawing.Color.LimeGreen
        Me.lablOK1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablOK1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablOK1.ForeColor = System.Drawing.Color.Black
        Me.lablOK1.Location = New System.Drawing.Point(522, 24)
        Me.lablOK1.Name = "lablOK1"
        Me.lablOK1.Size = New System.Drawing.Size(112, 29)
        Me.lablOK1.TabIndex = 47
        Me.lablOK1.Text = "OK"
        Me.lablOK1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lablOK1.Visible = False
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.TimingServer.My.MySettings.Default, "UDP3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(120, 96)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(176, 29)
        Me.TextBox4.TabIndex = 3
        Me.TextBox4.Text = Global.TimingServer.My.MySettings.Default.UDP3
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.TimingServer.My.MySettings.Default, "UDP4", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(120, 132)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(176, 29)
        Me.TextBox5.TabIndex = 4
        Me.TextBox5.Text = Global.TimingServer.My.MySettings.Default.UDP4
        '
        'TextBox12
        '
        Me.TextBox12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.TimingServer.My.MySettings.Default, "UDP4Port", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox12.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.Location = New System.Drawing.Point(302, 132)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(89, 29)
        Me.TextBox12.TabIndex = 28
        Me.TextBox12.Text = Global.TimingServer.My.MySettings.Default.UDP4Port
        '
        'TextBox11
        '
        Me.TextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.TimingServer.My.MySettings.Default, "UDP3Port", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox11.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(302, 96)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(89, 29)
        Me.TextBox11.TabIndex = 27
        Me.TextBox11.Text = Global.TimingServer.My.MySettings.Default.UDP3Port
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = Global.TimingServer.My.MySettings.Default.UDP1Enabled
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.TimingServer.My.MySettings.Default, "UDP1Enabled", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(416, 29)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(85, 22)
        Me.CheckBox1.TabIndex = 12
        Me.CheckBox1.Text = "Enabled"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox10
        '
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.TimingServer.My.MySettings.Default, "UDP2Port", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox10.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(302, 60)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(89, 29)
        Me.TextBox10.TabIndex = 26
        Me.TextBox10.Text = Global.TimingServer.My.MySettings.Default.UDP2Port
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = Global.TimingServer.My.MySettings.Default.UDP2Enabled
        Me.CheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.TimingServer.My.MySettings.Default, "UDP2Enabled", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.White
        Me.CheckBox2.Location = New System.Drawing.Point(416, 63)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(85, 22)
        Me.CheckBox2.TabIndex = 13
        Me.CheckBox2.Text = "Enabled"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'TextBox9
        '
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.TimingServer.My.MySettings.Default, "UDP1Port", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox9.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(302, 24)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(89, 29)
        Me.TextBox9.TabIndex = 25
        Me.TextBox9.Text = Global.TimingServer.My.MySettings.Default.UDP1Port
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Checked = Global.TimingServer.My.MySettings.Default.UDP3Enabled
        Me.CheckBox3.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.TimingServer.My.MySettings.Default, "UDP3Enabled", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.ForeColor = System.Drawing.Color.White
        Me.CheckBox3.Location = New System.Drawing.Point(416, 99)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(85, 22)
        Me.CheckBox3.TabIndex = 14
        Me.CheckBox3.Text = "Enabled"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Checked = Global.TimingServer.My.MySettings.Default.UDP4Enabled
        Me.CheckBox4.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.TimingServer.My.MySettings.Default, "UDP4Enabled", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox4.ForeColor = System.Drawing.Color.White
        Me.CheckBox4.Location = New System.Drawing.Point(416, 135)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(85, 22)
        Me.CheckBox4.TabIndex = 15
        Me.CheckBox4.Text = "Enabled"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButton4)
        Me.GroupBox3.Controls.Add(Me.RadioButton3)
        Me.GroupBox3.Controls.Add(Me.RadioButton2)
        Me.GroupBox3.Controls.Add(Me.RadioButton1)
        Me.GroupBox3.Controls.Add(Me.lablOutgoing)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(465, 190)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(655, 95)
        Me.GroupBox3.TabIndex = 44
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Outgoing data"
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Checked = Global.TimingServer.My.MySettings.Default.SourceTestClock
        Me.RadioButton4.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.TimingServer.My.MySettings.Default, "SourceTestClock", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RadioButton4.Location = New System.Drawing.Point(547, 58)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(87, 20)
        Me.RadioButton4.TabIndex = 25
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Test Clock"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Checked = Global.TimingServer.My.MySettings.Default.SourceTestTimer
        Me.RadioButton3.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.TimingServer.My.MySettings.Default, "SourceTestTimer", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RadioButton3.Location = New System.Drawing.Point(547, 28)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(86, 20)
        Me.RadioButton3.TabIndex = 24
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Test Timer"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = Global.TimingServer.My.MySettings.Default.SourceUDP
        Me.RadioButton2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.TimingServer.My.MySettings.Default, "SourceUDP", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RadioButton2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(19, 58)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(60, 22)
        Me.RadioButton2.TabIndex = 23
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "UDP"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = Global.TimingServer.My.MySettings.Default.SourceCOM
        Me.RadioButton1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.TimingServer.My.MySettings.Default, "SourceCOM", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RadioButton1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(19, 28)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(122, 22)
        Me.RadioButton1.TabIndex = 22
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Omega Clock"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnTimerStop)
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.btnTimerReset)
        Me.GroupBox4.Controls.Add(Me.btnTimerStart)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.TextBox8)
        Me.GroupBox4.Controls.Add(Me.TextBox7)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(13, 287)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(446, 153)
        Me.GroupBox4.TabIndex = 45
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Test"
        '
        'btnTimerStop
        '
        Me.btnTimerStop.BackColor = System.Drawing.Color.DarkRed
        Me.btnTimerStop.Enabled = False
        Me.btnTimerStop.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimerStop.ForeColor = System.Drawing.Color.White
        Me.btnTimerStop.Location = New System.Drawing.Point(329, 24)
        Me.btnTimerStop.Name = "btnTimerStop"
        Me.btnTimerStop.Size = New System.Drawing.Size(49, 29)
        Me.btnTimerStop.TabIndex = 48
        Me.btnTimerStop.Text = "Stop"
        Me.btnTimerStop.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Orange
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(224, 103)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 41)
        Me.Button2.TabIndex = 47
        Me.Button2.Text = "Test Omega" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Start"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Orange
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(119, 103)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 41)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "Test Omega" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Stop"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnTimerReset
        '
        Me.btnTimerReset.BackColor = System.Drawing.Color.DarkRed
        Me.btnTimerReset.Enabled = False
        Me.btnTimerReset.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimerReset.ForeColor = System.Drawing.Color.White
        Me.btnTimerReset.Location = New System.Drawing.Point(384, 24)
        Me.btnTimerReset.Name = "btnTimerReset"
        Me.btnTimerReset.Size = New System.Drawing.Size(49, 29)
        Me.btnTimerReset.TabIndex = 40
        Me.btnTimerReset.Text = "Reset"
        Me.btnTimerReset.UseVisualStyleBackColor = False
        '
        'btnTimerStart
        '
        Me.btnTimerStart.BackColor = System.Drawing.Color.DarkGreen
        Me.btnTimerStart.Enabled = False
        Me.btnTimerStart.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimerStart.ForeColor = System.Drawing.Color.White
        Me.btnTimerStart.Location = New System.Drawing.Point(274, 24)
        Me.btnTimerStart.Name = "btnTimerStart"
        Me.btnTimerStart.Size = New System.Drawing.Size(49, 29)
        Me.btnTimerStart.TabIndex = 39
        Me.btnTimerStart.Text = "Start"
        Me.btnTimerStart.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(10, 66)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 18)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "Clock Format:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(11, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 18)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "Timer Format:"
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.TimingServer.My.MySettings.Default, "TestClockFormat", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox8.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(119, 60)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(149, 29)
        Me.TextBox8.TabIndex = 24
        Me.TextBox8.Text = Global.TimingServer.My.MySettings.Default.TestClockFormat
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.TimingServer.My.MySettings.Default, "TestTimerFormat", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(119, 24)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(149, 29)
        Me.TextBox7.TabIndex = 23
        Me.TextBox7.Text = Global.TimingServer.My.MySettings.Default.TestTimerFormat
        '
        'TimerOmega
        '
        Me.TimerOmega.Interval = 1000
        '
        'TimerHeartbeat
        '
        Me.TimerHeartbeat.Interval = 10000
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Orange
        Me.btnReset.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.Black
        Me.btnReset.Location = New System.Drawing.Point(960, 390)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(160, 41)
        Me.btnReset.TabIndex = 48
        Me.btnReset.Text = "Reset Connections"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(1147, 452)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents lablOutgoing As System.Windows.Forms.Label
    Friend WithEvents lablOmega As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TimerClock As System.Windows.Forms.Timer
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TimerTimer As System.Windows.Forms.Timer
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents lablError1 As System.Windows.Forms.Label
    Friend WithEvents lablError2 As System.Windows.Forms.Label
    Friend WithEvents lablError3 As System.Windows.Forms.Label
    Friend WithEvents lablError4 As System.Windows.Forms.Label
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lablIncomingUDP As System.Windows.Forms.Label
    Friend WithEvents lablUDPIncomingError As System.Windows.Forms.Label
    Friend WithEvents lablListenAddresses As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lablUDPIncomingOK As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lablCOMOK As System.Windows.Forms.Label
    Friend WithEvents lablCOMError As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lablOK4 As System.Windows.Forms.Label
    Friend WithEvents lablOK3 As System.Windows.Forms.Label
    Friend WithEvents lablOK2 As System.Windows.Forms.Label
    Friend WithEvents lablOK1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents btnTimerReset As System.Windows.Forms.Button
    Friend WithEvents btnTimerStart As System.Windows.Forms.Button
    Friend WithEvents lablOmegaError As System.Windows.Forms.Label
    Friend WithEvents TimerOmega As System.Windows.Forms.Timer
    Friend WithEvents lablRunning As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TimerHeartbeat As System.Windows.Forms.Timer
    Friend WithEvents btnTimerStop As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button

End Class
