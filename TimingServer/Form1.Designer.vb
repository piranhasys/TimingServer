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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnTestTimer = New System.Windows.Forms.Button()
        Me.btnBroadcast = New System.Windows.Forms.Button()
        Me.lablOutgoing = New System.Windows.Forms.Label()
        Me.lablIncoming = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnTestClockTimer = New System.Windows.Forms.Button()
        Me.TimerClock = New System.Windows.Forms.Timer(Me.components)
        Me.TimerTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lablError1 = New System.Windows.Forms.Label()
        Me.lablError2 = New System.Windows.Forms.Label()
        Me.lablError3 = New System.Windows.Forms.Label()
        Me.lablError4 = New System.Windows.Forms.Label()
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
        Me.Label2.Location = New System.Drawing.Point(76, 65)
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
        Me.Label3.Location = New System.Drawing.Point(245, 30)
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
        Me.Label4.Location = New System.Drawing.Point(245, 65)
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
        Me.Label5.Location = New System.Drawing.Point(245, 100)
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
        Me.Label6.Location = New System.Drawing.Point(245, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 18)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "IP Address 4:"
        '
        'btnTestTimer
        '
        Me.btnTestTimer.BackColor = System.Drawing.Color.DarkGreen
        Me.btnTestTimer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTestTimer.ForeColor = System.Drawing.Color.White
        Me.btnTestTimer.Location = New System.Drawing.Point(349, 307)
        Me.btnTestTimer.Name = "btnTestTimer"
        Me.btnTestTimer.Size = New System.Drawing.Size(140, 42)
        Me.btnTestTimer.TabIndex = 16
        Me.btnTestTimer.Text = "Test Broadcast Clock"
        Me.btnTestTimer.UseVisualStyleBackColor = False
        '
        'btnBroadcast
        '
        Me.btnBroadcast.BackColor = System.Drawing.Color.DarkGreen
        Me.btnBroadcast.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBroadcast.ForeColor = System.Drawing.Color.White
        Me.btnBroadcast.Location = New System.Drawing.Point(58, 270)
        Me.btnBroadcast.Name = "btnBroadcast"
        Me.btnBroadcast.Size = New System.Drawing.Size(140, 42)
        Me.btnBroadcast.TabIndex = 17
        Me.btnBroadcast.Text = "Broadcast Clock"
        Me.btnBroadcast.UseVisualStyleBackColor = False
        '
        'lablOutgoing
        '
        Me.lablOutgoing.BackColor = System.Drawing.Color.Black
        Me.lablOutgoing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablOutgoing.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablOutgoing.ForeColor = System.Drawing.Color.White
        Me.lablOutgoing.Location = New System.Drawing.Point(349, 212)
        Me.lablOutgoing.Name = "lablOutgoing"
        Me.lablOutgoing.Size = New System.Drawing.Size(255, 32)
        Me.lablOutgoing.TabIndex = 18
        Me.lablOutgoing.Text = "ABC|01:02:03.04"
        Me.lablOutgoing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lablIncoming
        '
        Me.lablIncoming.BackColor = System.Drawing.Color.Black
        Me.lablIncoming.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablIncoming.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablIncoming.ForeColor = System.Drawing.Color.White
        Me.lablIncoming.Location = New System.Drawing.Point(21, 212)
        Me.lablIncoming.Name = "lablIncoming"
        Me.lablIncoming.Size = New System.Drawing.Size(255, 32)
        Me.lablIncoming.TabIndex = 19
        Me.lablIncoming.Text = "ABC|01:02:03.04"
        Me.lablIncoming.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(24, 192)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 18)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Incoming:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(352, 192)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 18)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Outgoing:"
        '
        'btnTestClockTimer
        '
        Me.btnTestClockTimer.BackColor = System.Drawing.Color.DarkGreen
        Me.btnTestClockTimer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTestClockTimer.ForeColor = System.Drawing.Color.White
        Me.btnTestClockTimer.Location = New System.Drawing.Point(349, 247)
        Me.btnTestClockTimer.Name = "btnTestClockTimer"
        Me.btnTestClockTimer.Size = New System.Drawing.Size(140, 42)
        Me.btnTestClockTimer.TabIndex = 22
        Me.btnTestClockTimer.Text = "Test Broadcast Timer"
        Me.btnTestClockTimer.UseVisualStyleBackColor = False
        '
        'TimerClock
        '
        Me.TimerClock.Interval = 10
        '
        'TimerTimer
        '
        Me.TimerTimer.Interval = 10
        '
        'TextBox12
        '
        Me.TextBox12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.TimingServer.My.MySettings.Default, "UDP4Port", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox12.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.Location = New System.Drawing.Point(531, 129)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(89, 29)
        Me.TextBox12.TabIndex = 28
        Me.TextBox12.Text = Global.TimingServer.My.MySettings.Default.UDP4Port
        '
        'TextBox11
        '
        Me.TextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.TimingServer.My.MySettings.Default, "UDP3Port", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox11.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(531, 94)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(89, 29)
        Me.TextBox11.TabIndex = 27
        Me.TextBox11.Text = Global.TimingServer.My.MySettings.Default.UDP3Port
        '
        'TextBox10
        '
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.TimingServer.My.MySettings.Default, "UDP2Port", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox10.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(531, 59)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(89, 29)
        Me.TextBox10.TabIndex = 26
        Me.TextBox10.Text = Global.TimingServer.My.MySettings.Default.UDP2Port
        '
        'TextBox9
        '
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.TimingServer.My.MySettings.Default, "UDP1Port", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox9.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(531, 24)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(89, 29)
        Me.TextBox9.TabIndex = 25
        Me.TextBox9.Text = Global.TimingServer.My.MySettings.Default.UDP1Port
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.TimingServer.My.MySettings.Default, "TestClockFormat", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox8.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(495, 312)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(176, 29)
        Me.TextBox8.TabIndex = 24
        Me.TextBox8.Text = Global.TimingServer.My.MySettings.Default.TestClockFormat
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.TimingServer.My.MySettings.Default, "TestTimerFormat", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(495, 252)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(176, 29)
        Me.TextBox7.TabIndex = 23
        Me.TextBox7.Text = Global.TimingServer.My.MySettings.Default.TestTimerFormat
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Checked = Global.TimingServer.My.MySettings.Default.UDP4Enabled
        Me.CheckBox4.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.TimingServer.My.MySettings.Default, "UDP4Enabled", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox4.ForeColor = System.Drawing.Color.White
        Me.CheckBox4.Location = New System.Drawing.Point(645, 132)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(85, 22)
        Me.CheckBox4.TabIndex = 15
        Me.CheckBox4.Text = "Enabled"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Checked = Global.TimingServer.My.MySettings.Default.UDP3Enabled
        Me.CheckBox3.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.TimingServer.My.MySettings.Default, "UDP3Enabled", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.ForeColor = System.Drawing.Color.White
        Me.CheckBox3.Location = New System.Drawing.Point(645, 97)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(85, 22)
        Me.CheckBox3.TabIndex = 14
        Me.CheckBox3.Text = "Enabled"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = Global.TimingServer.My.MySettings.Default.UDP2Enabled
        Me.CheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.TimingServer.My.MySettings.Default, "UDP2Enabled", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.White
        Me.CheckBox2.Location = New System.Drawing.Point(645, 62)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(85, 22)
        Me.CheckBox2.TabIndex = 13
        Me.CheckBox2.Text = "Enabled"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = Global.TimingServer.My.MySettings.Default.UDP1Enabled
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.TimingServer.My.MySettings.Default, "UDP1Enabled", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(645, 29)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(85, 22)
        Me.CheckBox1.TabIndex = 12
        Me.CheckBox1.Text = "Enabled"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.TimingServer.My.MySettings.Default, "LocationCode", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(109, 59)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(89, 29)
        Me.TextBox6.TabIndex = 5
        Me.TextBox6.Text = Global.TimingServer.My.MySettings.Default.LocationCode
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.TimingServer.My.MySettings.Default, "UDP4", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(349, 129)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(176, 29)
        Me.TextBox5.TabIndex = 4
        Me.TextBox5.Text = Global.TimingServer.My.MySettings.Default.UDP4
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.TimingServer.My.MySettings.Default, "UDP3", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(349, 94)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(176, 29)
        Me.TextBox4.TabIndex = 3
        Me.TextBox4.Text = Global.TimingServer.My.MySettings.Default.UDP3
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.TimingServer.My.MySettings.Default, "UDP2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(349, 59)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(176, 29)
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.Text = Global.TimingServer.My.MySettings.Default.UDP2
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.TimingServer.My.MySettings.Default, "UDP1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(349, 24)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(176, 29)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = Global.TimingServer.My.MySettings.Default.UDP1
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.TimingServer.My.MySettings.Default, "IncomingCOMPort", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(109, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(89, 29)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = Global.TimingServer.My.MySettings.Default.IncomingCOMPort
        '
        'lablError1
        '
        Me.lablError1.BackColor = System.Drawing.Color.Red
        Me.lablError1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablError1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablError1.ForeColor = System.Drawing.Color.White
        Me.lablError1.Location = New System.Drawing.Point(751, 24)
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
        Me.lablError2.Location = New System.Drawing.Point(751, 59)
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
        Me.lablError3.Location = New System.Drawing.Point(751, 94)
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
        Me.lablError4.Location = New System.Drawing.Point(751, 129)
        Me.lablError4.Name = "lablError4"
        Me.lablError4.Size = New System.Drawing.Size(112, 29)
        Me.lablError4.TabIndex = 32
        Me.lablError4.Text = "ERROR"
        Me.lablError4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lablError4.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(903, 381)
        Me.Controls.Add(Me.lablError4)
        Me.Controls.Add(Me.lablError3)
        Me.Controls.Add(Me.lablError2)
        Me.Controls.Add(Me.lablError1)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.btnTestClockTimer)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lablIncoming)
        Me.Controls.Add(Me.lablOutgoing)
        Me.Controls.Add(Me.btnBroadcast)
        Me.Controls.Add(Me.btnTestTimer)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents btnTestTimer As System.Windows.Forms.Button
    Friend WithEvents btnBroadcast As System.Windows.Forms.Button
    Friend WithEvents lablOutgoing As System.Windows.Forms.Label
    Friend WithEvents lablIncoming As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnTestClockTimer As System.Windows.Forms.Button
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

End Class
