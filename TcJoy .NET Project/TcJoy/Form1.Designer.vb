<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPage_LiveStatus = New System.Windows.Forms.TabPage()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Button_RightJoystick = New System.Windows.Forms.CheckBox()
        Me.Button_LeftJoystick = New System.Windows.Forms.CheckBox()
        Me.ProgressBar_RightShoulderAnalog = New TcJoyV2.MyVerticalProgessBar()
        Me.ProgressBar_LeftShoulderAnalog = New TcJoyV2.MyVerticalProgessBar()
        Me.ProgressBar_LeftStickYMinus = New TcJoyV2.MyVerticalProgessBarMinus()
        Me.ProgressBar_RightStickYMinus = New TcJoyV2.MyVerticalProgessBarMinus()
        Me.ProgressBar_RightStickYPlus = New TcJoyV2.MyVerticalProgessBar()
        Me.ProgressBar_LeftStickYPlus = New TcJoyV2.MyVerticalProgessBar()
        Me.Label_LeftShoulderVal = New System.Windows.Forms.Label()
        Me.Label_RightShoulderVal = New System.Windows.Forms.Label()
        Me.Label_RightStickYNeg = New System.Windows.Forms.Label()
        Me.Label_RightStickYPos = New System.Windows.Forms.Label()
        Me.Label_LeftStickYPos = New System.Windows.Forms.Label()
        Me.Label_LeftStickYNeg = New System.Windows.Forms.Label()
        Me.Label_RightStickXPos = New System.Windows.Forms.Label()
        Me.Label_RightStickXNeg = New System.Windows.Forms.Label()
        Me.Label_LeftStickXPos = New System.Windows.Forms.Label()
        Me.Label_LeftStickXNeg = New System.Windows.Forms.Label()
        Me.Button_RightShoulder = New System.Windows.Forms.CheckBox()
        Me.Button_LeftShoulder = New System.Windows.Forms.CheckBox()
        Me.Button_DPadLeft = New System.Windows.Forms.CheckBox()
        Me.Button_DPadRight = New System.Windows.Forms.CheckBox()
        Me.Button_DPadDown = New System.Windows.Forms.CheckBox()
        Me.Button_DPadUp = New System.Windows.Forms.CheckBox()
        Me.Button_Back = New System.Windows.Forms.CheckBox()
        Me.Button_Start = New System.Windows.Forms.CheckBox()
        Me.CheckBox_XButton = New System.Windows.Forms.CheckBox()
        Me.CheckBox_BButton = New System.Windows.Forms.CheckBox()
        Me.CheckBox_AButton = New System.Windows.Forms.CheckBox()
        Me.CheckBox_YButton = New System.Windows.Forms.CheckBox()
        Me.ProgressBar_RightStickXMinus = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar_RightStickXPlus = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar_LeftStickXMinus = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar_LeftStickXPlus = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar_Controller0Battery = New System.Windows.Forms.ProgressBar()
        Me.Label_Battery = New System.Windows.Forms.Label()
        Me.Label_Controller_Connection = New System.Windows.Forms.Label()
        Me.TextBox_ADSDataRateAchieved = New System.Windows.Forms.TextBox()
        Me.TextBox_ADSConnectionStatus2 = New System.Windows.Forms.TextBox()
        Me.TabPage_Connection = New System.Windows.Forms.TabPage()
        Me.GroupBox_Controller = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Textbox_TcJoyUpdateRate = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox_ShoulderDeadzone = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox_AnalogDeadzone = New System.Windows.Forms.TextBox()
        Me.GroupBox_PLC = New System.Windows.Forms.GroupBox()
        Me.TextBox_PLCVariables = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Button_ResetSettings = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox_ADSWatchdogDeadDuration = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox_ADSWatchdog = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button_ADSDisconnect = New System.Windows.Forms.Button()
        Me.TextBox_TcJoyPath = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox_ADSRate = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox_ADSNetID = New System.Windows.Forms.TextBox()
        Me.TextBox_AdditionalInformation = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_ADSPort = New System.Windows.Forms.TextBox()
        Me.TextBox_ADSConnectionStatus = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button_ADSConnect = New System.Windows.Forms.Button()
        Me.CheckBox_AutoConnectOnOpen = New System.Windows.Forms.CheckBox()
        Me.TabPage_Help = New System.Windows.Forms.TabPage()
        Me.RichTextBox_Help = New System.Windows.Forms.RichTextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl.SuspendLayout()
        Me.TabPage_LiveStatus.SuspendLayout()
        Me.TabPage_Connection.SuspendLayout()
        Me.GroupBox_Controller.SuspendLayout()
        Me.GroupBox_PLC.SuspendLayout()
        Me.TabPage_Help.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPage_LiveStatus)
        Me.TabControl.Controls.Add(Me.TabPage_Connection)
        Me.TabControl.Controls.Add(Me.TabPage_Help)
        Me.TabControl.Location = New System.Drawing.Point(3, 2)
        Me.TabControl.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(684, 589)
        Me.TabControl.TabIndex = 0
        '
        'TabPage_LiveStatus
        '
        Me.TabPage_LiveStatus.BackColor = System.Drawing.Color.White
        Me.TabPage_LiveStatus.BackgroundImage = CType(resources.GetObject("TabPage_LiveStatus.BackgroundImage"), System.Drawing.Image)
        Me.TabPage_LiveStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TabPage_LiveStatus.Controls.Add(Me.Label19)
        Me.TabPage_LiveStatus.Controls.Add(Me.Button_RightJoystick)
        Me.TabPage_LiveStatus.Controls.Add(Me.Button_LeftJoystick)
        Me.TabPage_LiveStatus.Controls.Add(Me.ProgressBar_RightShoulderAnalog)
        Me.TabPage_LiveStatus.Controls.Add(Me.ProgressBar_LeftShoulderAnalog)
        Me.TabPage_LiveStatus.Controls.Add(Me.ProgressBar_LeftStickYMinus)
        Me.TabPage_LiveStatus.Controls.Add(Me.ProgressBar_RightStickYMinus)
        Me.TabPage_LiveStatus.Controls.Add(Me.ProgressBar_RightStickYPlus)
        Me.TabPage_LiveStatus.Controls.Add(Me.ProgressBar_LeftStickYPlus)
        Me.TabPage_LiveStatus.Controls.Add(Me.Label_LeftShoulderVal)
        Me.TabPage_LiveStatus.Controls.Add(Me.Label_RightShoulderVal)
        Me.TabPage_LiveStatus.Controls.Add(Me.Label_RightStickYNeg)
        Me.TabPage_LiveStatus.Controls.Add(Me.Label_RightStickYPos)
        Me.TabPage_LiveStatus.Controls.Add(Me.Label_LeftStickYPos)
        Me.TabPage_LiveStatus.Controls.Add(Me.Label_LeftStickYNeg)
        Me.TabPage_LiveStatus.Controls.Add(Me.Label_RightStickXPos)
        Me.TabPage_LiveStatus.Controls.Add(Me.Label_RightStickXNeg)
        Me.TabPage_LiveStatus.Controls.Add(Me.Label_LeftStickXPos)
        Me.TabPage_LiveStatus.Controls.Add(Me.Label_LeftStickXNeg)
        Me.TabPage_LiveStatus.Controls.Add(Me.Button_RightShoulder)
        Me.TabPage_LiveStatus.Controls.Add(Me.Button_LeftShoulder)
        Me.TabPage_LiveStatus.Controls.Add(Me.Button_DPadLeft)
        Me.TabPage_LiveStatus.Controls.Add(Me.Button_DPadRight)
        Me.TabPage_LiveStatus.Controls.Add(Me.Button_DPadDown)
        Me.TabPage_LiveStatus.Controls.Add(Me.Button_DPadUp)
        Me.TabPage_LiveStatus.Controls.Add(Me.Button_Back)
        Me.TabPage_LiveStatus.Controls.Add(Me.Button_Start)
        Me.TabPage_LiveStatus.Controls.Add(Me.CheckBox_XButton)
        Me.TabPage_LiveStatus.Controls.Add(Me.CheckBox_BButton)
        Me.TabPage_LiveStatus.Controls.Add(Me.CheckBox_AButton)
        Me.TabPage_LiveStatus.Controls.Add(Me.CheckBox_YButton)
        Me.TabPage_LiveStatus.Controls.Add(Me.ProgressBar_RightStickXMinus)
        Me.TabPage_LiveStatus.Controls.Add(Me.ProgressBar_RightStickXPlus)
        Me.TabPage_LiveStatus.Controls.Add(Me.ProgressBar_LeftStickXMinus)
        Me.TabPage_LiveStatus.Controls.Add(Me.ProgressBar_LeftStickXPlus)
        Me.TabPage_LiveStatus.Controls.Add(Me.ProgressBar_Controller0Battery)
        Me.TabPage_LiveStatus.Controls.Add(Me.Label_Battery)
        Me.TabPage_LiveStatus.Controls.Add(Me.Label_Controller_Connection)
        Me.TabPage_LiveStatus.Controls.Add(Me.TextBox_ADSDataRateAchieved)
        Me.TabPage_LiveStatus.Controls.Add(Me.TextBox_ADSConnectionStatus2)
        Me.TabPage_LiveStatus.Cursor = System.Windows.Forms.Cursors.Default
        Me.TabPage_LiveStatus.ForeColor = System.Drawing.Color.Black
        Me.TabPage_LiveStatus.Location = New System.Drawing.Point(4, 25)
        Me.TabPage_LiveStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage_LiveStatus.Name = "TabPage_LiveStatus"
        Me.TabPage_LiveStatus.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage_LiveStatus.Size = New System.Drawing.Size(676, 560)
        Me.TabPage_LiveStatus.TabIndex = 0
        Me.TabPage_LiveStatus.Text = "Live Status"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Location = New System.Drawing.Point(189, 435)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(163, 17)
        Me.Label19.TabIndex = 61
        Me.Label19.Text = "ADS Connection Status: "
        '
        'Button_RightJoystick
        '
        Me.Button_RightJoystick.AutoSize = True
        Me.Button_RightJoystick.BackColor = System.Drawing.Color.Transparent
        Me.Button_RightJoystick.Enabled = False
        Me.Button_RightJoystick.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_RightJoystick.ForeColor = System.Drawing.Color.Black
        Me.Button_RightJoystick.Location = New System.Drawing.Point(413, 262)
        Me.Button_RightJoystick.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_RightJoystick.Name = "Button_RightJoystick"
        Me.Button_RightJoystick.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button_RightJoystick.Size = New System.Drawing.Size(15, 14)
        Me.Button_RightJoystick.TabIndex = 60
        Me.Button_RightJoystick.UseVisualStyleBackColor = False
        Me.Button_RightJoystick.Visible = False
        '
        'Button_LeftJoystick
        '
        Me.Button_LeftJoystick.AutoSize = True
        Me.Button_LeftJoystick.BackColor = System.Drawing.Color.Transparent
        Me.Button_LeftJoystick.Enabled = False
        Me.Button_LeftJoystick.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_LeftJoystick.ForeColor = System.Drawing.Color.Black
        Me.Button_LeftJoystick.Location = New System.Drawing.Point(167, 170)
        Me.Button_LeftJoystick.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_LeftJoystick.Name = "Button_LeftJoystick"
        Me.Button_LeftJoystick.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button_LeftJoystick.Size = New System.Drawing.Size(15, 14)
        Me.Button_LeftJoystick.TabIndex = 59
        Me.Button_LeftJoystick.UseVisualStyleBackColor = False
        Me.Button_LeftJoystick.Visible = False
        '
        'ProgressBar_RightShoulderAnalog
        '
        Me.ProgressBar_RightShoulderAnalog.Location = New System.Drawing.Point(548, 12)
        Me.ProgressBar_RightShoulderAnalog.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar_RightShoulderAnalog.Maximum = 255
        Me.ProgressBar_RightShoulderAnalog.Name = "ProgressBar_RightShoulderAnalog"
        Me.ProgressBar_RightShoulderAnalog.Size = New System.Drawing.Size(13, 55)
        Me.ProgressBar_RightShoulderAnalog.TabIndex = 58
        '
        'ProgressBar_LeftShoulderAnalog
        '
        Me.ProgressBar_LeftShoulderAnalog.Location = New System.Drawing.Point(114, 12)
        Me.ProgressBar_LeftShoulderAnalog.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar_LeftShoulderAnalog.Maximum = 255
        Me.ProgressBar_LeftShoulderAnalog.Name = "ProgressBar_LeftShoulderAnalog"
        Me.ProgressBar_LeftShoulderAnalog.Size = New System.Drawing.Size(13, 55)
        Me.ProgressBar_LeftShoulderAnalog.TabIndex = 57
        '
        'ProgressBar_LeftStickYMinus
        '
        Me.ProgressBar_LeftStickYMinus.BackColor = System.Drawing.SystemColors.Control
        Me.ProgressBar_LeftStickYMinus.Location = New System.Drawing.Point(168, 186)
        Me.ProgressBar_LeftStickYMinus.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar_LeftStickYMinus.Maximum = 32768
        Me.ProgressBar_LeftStickYMinus.Name = "ProgressBar_LeftStickYMinus"
        Me.ProgressBar_LeftStickYMinus.Size = New System.Drawing.Size(12, 45)
        Me.ProgressBar_LeftStickYMinus.TabIndex = 56
        '
        'ProgressBar_RightStickYMinus
        '
        Me.ProgressBar_RightStickYMinus.BackColor = System.Drawing.SystemColors.Control
        Me.ProgressBar_RightStickYMinus.Location = New System.Drawing.Point(415, 281)
        Me.ProgressBar_RightStickYMinus.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar_RightStickYMinus.Maximum = 32768
        Me.ProgressBar_RightStickYMinus.Name = "ProgressBar_RightStickYMinus"
        Me.ProgressBar_RightStickYMinus.RightToLeftLayout = True
        Me.ProgressBar_RightStickYMinus.Size = New System.Drawing.Size(12, 45)
        Me.ProgressBar_RightStickYMinus.TabIndex = 55
        '
        'ProgressBar_RightStickYPlus
        '
        Me.ProgressBar_RightStickYPlus.Location = New System.Drawing.Point(415, 215)
        Me.ProgressBar_RightStickYPlus.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar_RightStickYPlus.Maximum = 32768
        Me.ProgressBar_RightStickYPlus.Name = "ProgressBar_RightStickYPlus"
        Me.ProgressBar_RightStickYPlus.Size = New System.Drawing.Size(12, 45)
        Me.ProgressBar_RightStickYPlus.TabIndex = 54
        '
        'ProgressBar_LeftStickYPlus
        '
        Me.ProgressBar_LeftStickYPlus.BackColor = System.Drawing.SystemColors.Control
        Me.ProgressBar_LeftStickYPlus.Location = New System.Drawing.Point(168, 122)
        Me.ProgressBar_LeftStickYPlus.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar_LeftStickYPlus.Maximum = 32768
        Me.ProgressBar_LeftStickYPlus.Name = "ProgressBar_LeftStickYPlus"
        Me.ProgressBar_LeftStickYPlus.Size = New System.Drawing.Size(12, 45)
        Me.ProgressBar_LeftStickYPlus.TabIndex = 51
        '
        'Label_LeftShoulderVal
        '
        Me.Label_LeftShoulderVal.AutoSize = True
        Me.Label_LeftShoulderVal.Location = New System.Drawing.Point(81, 33)
        Me.Label_LeftShoulderVal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_LeftShoulderVal.Name = "Label_LeftShoulderVal"
        Me.Label_LeftShoulderVal.Size = New System.Drawing.Size(25, 17)
        Me.Label_LeftShoulderVal.TabIndex = 49
        Me.Label_LeftShoulderVal.Text = "LT"
        '
        'Label_RightShoulderVal
        '
        Me.Label_RightShoulderVal.AutoSize = True
        Me.Label_RightShoulderVal.Location = New System.Drawing.Point(569, 29)
        Me.Label_RightShoulderVal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_RightShoulderVal.Name = "Label_RightShoulderVal"
        Me.Label_RightShoulderVal.Size = New System.Drawing.Size(27, 17)
        Me.Label_RightShoulderVal.TabIndex = 48
        Me.Label_RightShoulderVal.Text = "RT"
        '
        'Label_RightStickYNeg
        '
        Me.Label_RightStickYNeg.AutoSize = True
        Me.Label_RightStickYNeg.BackColor = System.Drawing.Color.Transparent
        Me.Label_RightStickYNeg.Location = New System.Drawing.Point(399, 333)
        Me.Label_RightStickYNeg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_RightStickYNeg.Name = "Label_RightStickYNeg"
        Me.Label_RightStickYNeg.Size = New System.Drawing.Size(0, 17)
        Me.Label_RightStickYNeg.TabIndex = 43
        '
        'Label_RightStickYPos
        '
        Me.Label_RightStickYPos.AutoSize = True
        Me.Label_RightStickYPos.BackColor = System.Drawing.Color.Transparent
        Me.Label_RightStickYPos.Location = New System.Drawing.Point(399, 195)
        Me.Label_RightStickYPos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_RightStickYPos.Name = "Label_RightStickYPos"
        Me.Label_RightStickYPos.Size = New System.Drawing.Size(0, 17)
        Me.Label_RightStickYPos.TabIndex = 42
        '
        'Label_LeftStickYPos
        '
        Me.Label_LeftStickYPos.AutoSize = True
        Me.Label_LeftStickYPos.BackColor = System.Drawing.Color.Transparent
        Me.Label_LeftStickYPos.Location = New System.Drawing.Point(155, 100)
        Me.Label_LeftStickYPos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_LeftStickYPos.Name = "Label_LeftStickYPos"
        Me.Label_LeftStickYPos.Size = New System.Drawing.Size(0, 17)
        Me.Label_LeftStickYPos.TabIndex = 41
        '
        'Label_LeftStickYNeg
        '
        Me.Label_LeftStickYNeg.AutoSize = True
        Me.Label_LeftStickYNeg.BackColor = System.Drawing.Color.Transparent
        Me.Label_LeftStickYNeg.Location = New System.Drawing.Point(155, 233)
        Me.Label_LeftStickYNeg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_LeftStickYNeg.Name = "Label_LeftStickYNeg"
        Me.Label_LeftStickYNeg.Size = New System.Drawing.Size(0, 17)
        Me.Label_LeftStickYNeg.TabIndex = 40
        '
        'Label_RightStickXPos
        '
        Me.Label_RightStickXPos.AutoSize = True
        Me.Label_RightStickXPos.BackColor = System.Drawing.Color.Transparent
        Me.Label_RightStickXPos.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label_RightStickXPos.ForeColor = System.Drawing.Color.Black
        Me.Label_RightStickXPos.Location = New System.Drawing.Point(461, 280)
        Me.Label_RightStickXPos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_RightStickXPos.Name = "Label_RightStickXPos"
        Me.Label_RightStickXPos.Size = New System.Drawing.Size(0, 17)
        Me.Label_RightStickXPos.TabIndex = 39
        '
        'Label_RightStickXNeg
        '
        Me.Label_RightStickXNeg.AutoSize = True
        Me.Label_RightStickXNeg.BackColor = System.Drawing.Color.Transparent
        Me.Label_RightStickXNeg.Location = New System.Drawing.Point(341, 281)
        Me.Label_RightStickXNeg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_RightStickXNeg.Name = "Label_RightStickXNeg"
        Me.Label_RightStickXNeg.Size = New System.Drawing.Size(0, 17)
        Me.Label_RightStickXNeg.TabIndex = 38
        '
        'Label_LeftStickXPos
        '
        Me.Label_LeftStickXPos.AutoSize = True
        Me.Label_LeftStickXPos.BackColor = System.Drawing.Color.Transparent
        Me.Label_LeftStickXPos.Location = New System.Drawing.Point(202, 187)
        Me.Label_LeftStickXPos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_LeftStickXPos.Name = "Label_LeftStickXPos"
        Me.Label_LeftStickXPos.Size = New System.Drawing.Size(0, 17)
        Me.Label_LeftStickXPos.TabIndex = 37
        '
        'Label_LeftStickXNeg
        '
        Me.Label_LeftStickXNeg.AutoSize = True
        Me.Label_LeftStickXNeg.BackColor = System.Drawing.Color.Transparent
        Me.Label_LeftStickXNeg.Location = New System.Drawing.Point(104, 188)
        Me.Label_LeftStickXNeg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_LeftStickXNeg.Name = "Label_LeftStickXNeg"
        Me.Label_LeftStickXNeg.Size = New System.Drawing.Size(0, 17)
        Me.Label_LeftStickXNeg.TabIndex = 36
        '
        'Button_RightShoulder
        '
        Me.Button_RightShoulder.Appearance = System.Windows.Forms.Appearance.Button
        Me.Button_RightShoulder.AutoSize = True
        Me.Button_RightShoulder.BackColor = System.Drawing.Color.Transparent
        Me.Button_RightShoulder.Enabled = False
        Me.Button_RightShoulder.ForeColor = System.Drawing.Color.Black
        Me.Button_RightShoulder.Location = New System.Drawing.Point(477, 40)
        Me.Button_RightShoulder.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_RightShoulder.Name = "Button_RightShoulder"
        Me.Button_RightShoulder.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button_RightShoulder.Size = New System.Drawing.Size(37, 27)
        Me.Button_RightShoulder.TabIndex = 33
        Me.Button_RightShoulder.Text = "RB"
        Me.Button_RightShoulder.UseVisualStyleBackColor = False
        Me.Button_RightShoulder.Visible = False
        '
        'Button_LeftShoulder
        '
        Me.Button_LeftShoulder.Appearance = System.Windows.Forms.Appearance.Button
        Me.Button_LeftShoulder.AutoSize = True
        Me.Button_LeftShoulder.BackColor = System.Drawing.Color.Transparent
        Me.Button_LeftShoulder.Enabled = False
        Me.Button_LeftShoulder.ForeColor = System.Drawing.Color.Black
        Me.Button_LeftShoulder.Location = New System.Drawing.Point(164, 40)
        Me.Button_LeftShoulder.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_LeftShoulder.Name = "Button_LeftShoulder"
        Me.Button_LeftShoulder.Size = New System.Drawing.Size(35, 27)
        Me.Button_LeftShoulder.TabIndex = 32
        Me.Button_LeftShoulder.Text = "LB"
        Me.Button_LeftShoulder.UseVisualStyleBackColor = False
        Me.Button_LeftShoulder.Visible = False
        '
        'Button_DPadLeft
        '
        Me.Button_DPadLeft.Appearance = System.Windows.Forms.Appearance.Button
        Me.Button_DPadLeft.AutoSize = True
        Me.Button_DPadLeft.BackColor = System.Drawing.Color.Transparent
        Me.Button_DPadLeft.Enabled = False
        Me.Button_DPadLeft.ForeColor = System.Drawing.Color.Black
        Me.Button_DPadLeft.Location = New System.Drawing.Point(197, 261)
        Me.Button_DPadLeft.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_DPadLeft.Name = "Button_DPadLeft"
        Me.Button_DPadLeft.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button_DPadLeft.Size = New System.Drawing.Size(26, 27)
        Me.Button_DPadLeft.TabIndex = 31
        Me.Button_DPadLeft.Text = "L"
        Me.Button_DPadLeft.UseVisualStyleBackColor = False
        Me.Button_DPadLeft.Visible = False
        '
        'Button_DPadRight
        '
        Me.Button_DPadRight.Appearance = System.Windows.Forms.Appearance.Button
        Me.Button_DPadRight.AutoSize = True
        Me.Button_DPadRight.BackColor = System.Drawing.Color.Transparent
        Me.Button_DPadRight.Enabled = False
        Me.Button_DPadRight.ForeColor = System.Drawing.Color.Black
        Me.Button_DPadRight.Location = New System.Drawing.Point(277, 261)
        Me.Button_DPadRight.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_DPadRight.Name = "Button_DPadRight"
        Me.Button_DPadRight.Size = New System.Drawing.Size(28, 27)
        Me.Button_DPadRight.TabIndex = 30
        Me.Button_DPadRight.Text = "R"
        Me.Button_DPadRight.UseVisualStyleBackColor = False
        Me.Button_DPadRight.Visible = False
        '
        'Button_DPadDown
        '
        Me.Button_DPadDown.Appearance = System.Windows.Forms.Appearance.Button
        Me.Button_DPadDown.AutoSize = True
        Me.Button_DPadDown.BackColor = System.Drawing.Color.Transparent
        Me.Button_DPadDown.Enabled = False
        Me.Button_DPadDown.ForeColor = System.Drawing.Color.Black
        Me.Button_DPadDown.Location = New System.Drawing.Point(235, 303)
        Me.Button_DPadDown.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_DPadDown.Name = "Button_DPadDown"
        Me.Button_DPadDown.Size = New System.Drawing.Size(28, 27)
        Me.Button_DPadDown.TabIndex = 29
        Me.Button_DPadDown.Text = "D"
        Me.Button_DPadDown.UseVisualStyleBackColor = False
        Me.Button_DPadDown.Visible = False
        '
        'Button_DPadUp
        '
        Me.Button_DPadUp.Appearance = System.Windows.Forms.Appearance.Button
        Me.Button_DPadUp.AutoSize = True
        Me.Button_DPadUp.BackColor = System.Drawing.Color.Transparent
        Me.Button_DPadUp.Enabled = False
        Me.Button_DPadUp.ForeColor = System.Drawing.Color.Black
        Me.Button_DPadUp.Location = New System.Drawing.Point(235, 223)
        Me.Button_DPadUp.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_DPadUp.Name = "Button_DPadUp"
        Me.Button_DPadUp.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button_DPadUp.Size = New System.Drawing.Size(28, 27)
        Me.Button_DPadUp.TabIndex = 28
        Me.Button_DPadUp.Text = "U"
        Me.Button_DPadUp.UseVisualStyleBackColor = False
        Me.Button_DPadUp.Visible = False
        '
        'Button_Back
        '
        Me.Button_Back.Appearance = System.Windows.Forms.Appearance.Button
        Me.Button_Back.AutoSize = True
        Me.Button_Back.BackColor = System.Drawing.Color.Transparent
        Me.Button_Back.Enabled = False
        Me.Button_Back.ForeColor = System.Drawing.Color.Black
        Me.Button_Back.Location = New System.Drawing.Point(261, 162)
        Me.Button_Back.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_Back.Name = "Button_Back"
        Me.Button_Back.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button_Back.Size = New System.Drawing.Size(49, 27)
        Me.Button_Back.TabIndex = 27
        Me.Button_Back.Text = "Back"
        Me.Button_Back.UseVisualStyleBackColor = False
        Me.Button_Back.Visible = False
        '
        'Button_Start
        '
        Me.Button_Start.Appearance = System.Windows.Forms.Appearance.Button
        Me.Button_Start.AutoSize = True
        Me.Button_Start.BackColor = System.Drawing.Color.Transparent
        Me.Button_Start.Enabled = False
        Me.Button_Start.ForeColor = System.Drawing.Color.Black
        Me.Button_Start.Location = New System.Drawing.Point(360, 162)
        Me.Button_Start.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_Start.Name = "Button_Start"
        Me.Button_Start.Size = New System.Drawing.Size(48, 27)
        Me.Button_Start.TabIndex = 26
        Me.Button_Start.Text = "Start"
        Me.Button_Start.UseVisualStyleBackColor = False
        Me.Button_Start.Visible = False
        '
        'CheckBox_XButton
        '
        Me.CheckBox_XButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox_XButton.AutoSize = True
        Me.CheckBox_XButton.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox_XButton.Enabled = False
        Me.CheckBox_XButton.ForeColor = System.Drawing.Color.Black
        Me.CheckBox_XButton.Location = New System.Drawing.Point(443, 165)
        Me.CheckBox_XButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox_XButton.Name = "CheckBox_XButton"
        Me.CheckBox_XButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox_XButton.Size = New System.Drawing.Size(27, 27)
        Me.CheckBox_XButton.TabIndex = 25
        Me.CheckBox_XButton.Text = "X"
        Me.CheckBox_XButton.UseVisualStyleBackColor = False
        Me.CheckBox_XButton.Visible = False
        '
        'CheckBox_BButton
        '
        Me.CheckBox_BButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox_BButton.AutoSize = True
        Me.CheckBox_BButton.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox_BButton.Enabled = False
        Me.CheckBox_BButton.ForeColor = System.Drawing.Color.Black
        Me.CheckBox_BButton.Location = New System.Drawing.Point(528, 167)
        Me.CheckBox_BButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox_BButton.Name = "CheckBox_BButton"
        Me.CheckBox_BButton.Size = New System.Drawing.Size(27, 27)
        Me.CheckBox_BButton.TabIndex = 24
        Me.CheckBox_BButton.Text = "B"
        Me.CheckBox_BButton.ThreeState = True
        Me.CheckBox_BButton.UseVisualStyleBackColor = False
        Me.CheckBox_BButton.Visible = False
        '
        'CheckBox_AButton
        '
        Me.CheckBox_AButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox_AButton.AutoSize = True
        Me.CheckBox_AButton.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox_AButton.Enabled = False
        Me.CheckBox_AButton.ForeColor = System.Drawing.Color.Black
        Me.CheckBox_AButton.Location = New System.Drawing.Point(485, 203)
        Me.CheckBox_AButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox_AButton.Name = "CheckBox_AButton"
        Me.CheckBox_AButton.Size = New System.Drawing.Size(27, 27)
        Me.CheckBox_AButton.TabIndex = 23
        Me.CheckBox_AButton.Text = "A"
        Me.CheckBox_AButton.UseVisualStyleBackColor = False
        Me.CheckBox_AButton.Visible = False
        '
        'CheckBox_YButton
        '
        Me.CheckBox_YButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox_YButton.AutoSize = True
        Me.CheckBox_YButton.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox_YButton.Enabled = False
        Me.CheckBox_YButton.ForeColor = System.Drawing.Color.Black
        Me.CheckBox_YButton.Location = New System.Drawing.Point(485, 126)
        Me.CheckBox_YButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox_YButton.Name = "CheckBox_YButton"
        Me.CheckBox_YButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox_YButton.Size = New System.Drawing.Size(27, 27)
        Me.CheckBox_YButton.TabIndex = 22
        Me.CheckBox_YButton.Text = "Y"
        Me.CheckBox_YButton.UseVisualStyleBackColor = False
        Me.CheckBox_YButton.Visible = False
        '
        'ProgressBar_RightStickXMinus
        '
        Me.ProgressBar_RightStickXMinus.Location = New System.Drawing.Point(363, 262)
        Me.ProgressBar_RightStickXMinus.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar_RightStickXMinus.MarqueeAnimationSpeed = 0
        Me.ProgressBar_RightStickXMinus.Maximum = 32768
        Me.ProgressBar_RightStickXMinus.Name = "ProgressBar_RightStickXMinus"
        Me.ProgressBar_RightStickXMinus.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ProgressBar_RightStickXMinus.RightToLeftLayout = True
        Me.ProgressBar_RightStickXMinus.Size = New System.Drawing.Size(45, 12)
        Me.ProgressBar_RightStickXMinus.TabIndex = 21
        '
        'ProgressBar_RightStickXPlus
        '
        Me.ProgressBar_RightStickXPlus.Location = New System.Drawing.Point(433, 262)
        Me.ProgressBar_RightStickXPlus.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar_RightStickXPlus.MarqueeAnimationSpeed = 0
        Me.ProgressBar_RightStickXPlus.Maximum = 32768
        Me.ProgressBar_RightStickXPlus.Name = "ProgressBar_RightStickXPlus"
        Me.ProgressBar_RightStickXPlus.Size = New System.Drawing.Size(45, 12)
        Me.ProgressBar_RightStickXPlus.TabIndex = 20
        '
        'ProgressBar_LeftStickXMinus
        '
        Me.ProgressBar_LeftStickXMinus.Location = New System.Drawing.Point(118, 170)
        Me.ProgressBar_LeftStickXMinus.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar_LeftStickXMinus.MarqueeAnimationSpeed = 0
        Me.ProgressBar_LeftStickXMinus.Maximum = 32768
        Me.ProgressBar_LeftStickXMinus.Name = "ProgressBar_LeftStickXMinus"
        Me.ProgressBar_LeftStickXMinus.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ProgressBar_LeftStickXMinus.RightToLeftLayout = True
        Me.ProgressBar_LeftStickXMinus.Size = New System.Drawing.Size(45, 12)
        Me.ProgressBar_LeftStickXMinus.TabIndex = 19
        '
        'ProgressBar_LeftStickXPlus
        '
        Me.ProgressBar_LeftStickXPlus.Location = New System.Drawing.Point(185, 170)
        Me.ProgressBar_LeftStickXPlus.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar_LeftStickXPlus.MarqueeAnimationSpeed = 0
        Me.ProgressBar_LeftStickXPlus.Maximum = 32768
        Me.ProgressBar_LeftStickXPlus.Name = "ProgressBar_LeftStickXPlus"
        Me.ProgressBar_LeftStickXPlus.Size = New System.Drawing.Size(45, 12)
        Me.ProgressBar_LeftStickXPlus.TabIndex = 18
        '
        'ProgressBar_Controller0Battery
        '
        Me.ProgressBar_Controller0Battery.Location = New System.Drawing.Point(242, 409)
        Me.ProgressBar_Controller0Battery.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar_Controller0Battery.MarqueeAnimationSpeed = 1
        Me.ProgressBar_Controller0Battery.Name = "ProgressBar_Controller0Battery"
        Me.ProgressBar_Controller0Battery.Size = New System.Drawing.Size(237, 17)
        Me.ProgressBar_Controller0Battery.TabIndex = 17
        '
        'Label_Battery
        '
        Me.Label_Battery.AutoSize = True
        Me.Label_Battery.BackColor = System.Drawing.Color.Transparent
        Me.Label_Battery.Location = New System.Drawing.Point(189, 409)
        Me.Label_Battery.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_Battery.Name = "Label_Battery"
        Me.Label_Battery.Size = New System.Drawing.Size(57, 17)
        Me.Label_Battery.TabIndex = 16
        Me.Label_Battery.Text = "Battery:"
        '
        'Label_Controller_Connection
        '
        Me.Label_Controller_Connection.BackColor = System.Drawing.Color.Transparent
        Me.Label_Controller_Connection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label_Controller_Connection.Location = New System.Drawing.Point(192, 382)
        Me.Label_Controller_Connection.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_Controller_Connection.Name = "Label_Controller_Connection"
        Me.Label_Controller_Connection.Size = New System.Drawing.Size(287, 23)
        Me.Label_Controller_Connection.TabIndex = 15
        Me.Label_Controller_Connection.Text = "Controller Connection"
        Me.Label_Controller_Connection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox_ADSDataRateAchieved
        '
        Me.TextBox_ADSDataRateAchieved.Enabled = False
        Me.TextBox_ADSDataRateAchieved.Location = New System.Drawing.Point(242, 12)
        Me.TextBox_ADSDataRateAchieved.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_ADSDataRateAchieved.Name = "TextBox_ADSDataRateAchieved"
        Me.TextBox_ADSDataRateAchieved.Size = New System.Drawing.Size(186, 22)
        Me.TextBox_ADSDataRateAchieved.TabIndex = 11
        Me.TextBox_ADSDataRateAchieved.TabStop = False
        Me.TextBox_ADSDataRateAchieved.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_ADSConnectionStatus2
        '
        Me.TextBox_ADSConnectionStatus2.Enabled = False
        Me.TextBox_ADSConnectionStatus2.Location = New System.Drawing.Point(192, 456)
        Me.TextBox_ADSConnectionStatus2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_ADSConnectionStatus2.Name = "TextBox_ADSConnectionStatus2"
        Me.TextBox_ADSConnectionStatus2.Size = New System.Drawing.Size(287, 22)
        Me.TextBox_ADSConnectionStatus2.TabIndex = 9
        Me.TextBox_ADSConnectionStatus2.TabStop = False
        Me.TextBox_ADSConnectionStatus2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabPage_Connection
        '
        Me.TabPage_Connection.Controls.Add(Me.GroupBox_Controller)
        Me.TabPage_Connection.Controls.Add(Me.GroupBox_PLC)
        Me.TabPage_Connection.Location = New System.Drawing.Point(4, 25)
        Me.TabPage_Connection.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage_Connection.Name = "TabPage_Connection"
        Me.TabPage_Connection.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage_Connection.Size = New System.Drawing.Size(676, 560)
        Me.TabPage_Connection.TabIndex = 1
        Me.TabPage_Connection.Text = "Connection"
        Me.TabPage_Connection.UseVisualStyleBackColor = True
        '
        'GroupBox_Controller
        '
        Me.GroupBox_Controller.Controls.Add(Me.Label5)
        Me.GroupBox_Controller.Controls.Add(Me.Label6)
        Me.GroupBox_Controller.Controls.Add(Me.Textbox_TcJoyUpdateRate)
        Me.GroupBox_Controller.Controls.Add(Me.Label16)
        Me.GroupBox_Controller.Controls.Add(Me.Label17)
        Me.GroupBox_Controller.Controls.Add(Me.TextBox_ShoulderDeadzone)
        Me.GroupBox_Controller.Controls.Add(Me.Label15)
        Me.GroupBox_Controller.Controls.Add(Me.Label14)
        Me.GroupBox_Controller.Controls.Add(Me.TextBox_AnalogDeadzone)
        Me.GroupBox_Controller.Location = New System.Drawing.Point(8, 337)
        Me.GroupBox_Controller.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox_Controller.Name = "GroupBox_Controller"
        Me.GroupBox_Controller.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox_Controller.Size = New System.Drawing.Size(658, 140)
        Me.GroupBox_Controller.TabIndex = 11
        Me.GroupBox_Controller.TabStop = False
        Me.GroupBox_Controller.Text = "Game Controller"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(302, 32)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 17)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "ms (Standard: 200 ms)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Location = New System.Drawing.Point(35, 32)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 17)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "TcJoy Update Rate"
        '
        'Textbox_TcJoyUpdateRate
        '
        Me.Textbox_TcJoyUpdateRate.AllowDrop = True
        Me.Textbox_TcJoyUpdateRate.Location = New System.Drawing.Point(231, 27)
        Me.Textbox_TcJoyUpdateRate.Margin = New System.Windows.Forms.Padding(4)
        Me.Textbox_TcJoyUpdateRate.Multiline = True
        Me.Textbox_TcJoyUpdateRate.Name = "Textbox_TcJoyUpdateRate"
        Me.Textbox_TcJoyUpdateRate.Size = New System.Drawing.Size(63, 22)
        Me.Textbox_TcJoyUpdateRate.TabIndex = 25
        Me.Textbox_TcJoyUpdateRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.Textbox_TcJoyUpdateRate, resources.GetString("Textbox_TcJoyUpdateRate.ToolTip"))
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(302, 96)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(117, 17)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "counts (255 max)"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(35, 96)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(188, 17)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "Analog Shoulder Dead Zone"
        '
        'TextBox_ShoulderDeadzone
        '
        Me.TextBox_ShoulderDeadzone.AllowDrop = True
        Me.TextBox_ShoulderDeadzone.Location = New System.Drawing.Point(231, 91)
        Me.TextBox_ShoulderDeadzone.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_ShoulderDeadzone.Name = "TextBox_ShoulderDeadzone"
        Me.TextBox_ShoulderDeadzone.Size = New System.Drawing.Size(63, 22)
        Me.TextBox_ShoulderDeadzone.TabIndex = 7
        Me.TextBox_ShoulderDeadzone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.TextBox_ShoulderDeadzone, "The Analog Shoulder Triggers of the Controller are usually showing Zero when ther" & _
        "e's no input. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If that's not the case you may set an Analog Shoulder Trigger De" & _
        "ad Zone here." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(302, 64)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(133, 17)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "counts (32767 max)"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(35, 64)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(161, 17)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Analog Stick Dead Zone"
        '
        'TextBox_AnalogDeadzone
        '
        Me.TextBox_AnalogDeadzone.AllowDrop = True
        Me.TextBox_AnalogDeadzone.Location = New System.Drawing.Point(231, 59)
        Me.TextBox_AnalogDeadzone.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_AnalogDeadzone.Name = "TextBox_AnalogDeadzone"
        Me.TextBox_AnalogDeadzone.Size = New System.Drawing.Size(63, 22)
        Me.TextBox_AnalogDeadzone.TabIndex = 6
        Me.TextBox_AnalogDeadzone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.TextBox_AnalogDeadzone, resources.GetString("TextBox_AnalogDeadzone.ToolTip"))
        '
        'GroupBox_PLC
        '
        Me.GroupBox_PLC.Controls.Add(Me.TextBox_PLCVariables)
        Me.GroupBox_PLC.Controls.Add(Me.Label18)
        Me.GroupBox_PLC.Controls.Add(Me.Button_ResetSettings)
        Me.GroupBox_PLC.Controls.Add(Me.Label12)
        Me.GroupBox_PLC.Controls.Add(Me.TextBox_ADSWatchdogDeadDuration)
        Me.GroupBox_PLC.Controls.Add(Me.Label13)
        Me.GroupBox_PLC.Controls.Add(Me.Label10)
        Me.GroupBox_PLC.Controls.Add(Me.TextBox_ADSWatchdog)
        Me.GroupBox_PLC.Controls.Add(Me.Label11)
        Me.GroupBox_PLC.Controls.Add(Me.Button_ADSDisconnect)
        Me.GroupBox_PLC.Controls.Add(Me.TextBox_TcJoyPath)
        Me.GroupBox_PLC.Controls.Add(Me.Label9)
        Me.GroupBox_PLC.Controls.Add(Me.Label8)
        Me.GroupBox_PLC.Controls.Add(Me.TextBox_ADSRate)
        Me.GroupBox_PLC.Controls.Add(Me.Label7)
        Me.GroupBox_PLC.Controls.Add(Me.TextBox_ADSNetID)
        Me.GroupBox_PLC.Controls.Add(Me.TextBox_AdditionalInformation)
        Me.GroupBox_PLC.Controls.Add(Me.Label1)
        Me.GroupBox_PLC.Controls.Add(Me.Label4)
        Me.GroupBox_PLC.Controls.Add(Me.TextBox_ADSPort)
        Me.GroupBox_PLC.Controls.Add(Me.TextBox_ADSConnectionStatus)
        Me.GroupBox_PLC.Controls.Add(Me.Label2)
        Me.GroupBox_PLC.Controls.Add(Me.Label3)
        Me.GroupBox_PLC.Controls.Add(Me.Button_ADSConnect)
        Me.GroupBox_PLC.Controls.Add(Me.CheckBox_AutoConnectOnOpen)
        Me.GroupBox_PLC.Location = New System.Drawing.Point(8, 7)
        Me.GroupBox_PLC.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox_PLC.Name = "GroupBox_PLC"
        Me.GroupBox_PLC.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox_PLC.Size = New System.Drawing.Size(658, 322)
        Me.GroupBox_PLC.TabIndex = 10
        Me.GroupBox_PLC.TabStop = False
        Me.GroupBox_PLC.Text = "PLC"
        '
        'TextBox_PLCVariables
        '
        Me.TextBox_PLCVariables.Enabled = False
        Me.TextBox_PLCVariables.Location = New System.Drawing.Point(195, 283)
        Me.TextBox_PLCVariables.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_PLCVariables.Name = "TextBox_PLCVariables"
        Me.TextBox_PLCVariables.ReadOnly = True
        Me.TextBox_PLCVariables.Size = New System.Drawing.Size(448, 22)
        Me.TextBox_PLCVariables.TabIndex = 29
        Me.TextBox_PLCVariables.TabStop = False
        Me.TextBox_PLCVariables.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(29, 283)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(101, 17)
        Me.Label18.TabIndex = 28
        Me.Label18.Text = "PLC Variables:"
        '
        'Button_ResetSettings
        '
        Me.Button_ResetSettings.Location = New System.Drawing.Point(439, 126)
        Me.Button_ResetSettings.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_ResetSettings.Name = "Button_ResetSettings"
        Me.Button_ResetSettings.Size = New System.Drawing.Size(184, 28)
        Me.Button_ResetSettings.TabIndex = 22
        Me.Button_ResetSettings.Text = "Reset Settings"
        Me.Button_ResetSettings.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(265, 158)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(26, 17)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "ms"
        '
        'TextBox_ADSWatchdogDeadDuration
        '
        Me.TextBox_ADSWatchdogDeadDuration.AllowDrop = True
        Me.TextBox_ADSWatchdogDeadDuration.Location = New System.Drawing.Point(195, 154)
        Me.TextBox_ADSWatchdogDeadDuration.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_ADSWatchdogDeadDuration.Name = "TextBox_ADSWatchdogDeadDuration"
        Me.TextBox_ADSWatchdogDeadDuration.Size = New System.Drawing.Size(63, 22)
        Me.TextBox_ADSWatchdogDeadDuration.TabIndex = 4
        Me.TextBox_ADSWatchdogDeadDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.TextBox_ADSWatchdogDeadDuration, resources.GetString("TextBox_ADSWatchdogDeadDuration.ToolTip"))
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(29, 158)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(163, 17)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "ADS WD Dead Duration:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(265, 126)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 17)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "ms"
        '
        'TextBox_ADSWatchdog
        '
        Me.TextBox_ADSWatchdog.AllowDrop = True
        Me.TextBox_ADSWatchdog.Location = New System.Drawing.Point(195, 123)
        Me.TextBox_ADSWatchdog.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_ADSWatchdog.Name = "TextBox_ADSWatchdog"
        Me.TextBox_ADSWatchdog.Size = New System.Drawing.Size(63, 22)
        Me.TextBox_ADSWatchdog.TabIndex = 3
        Me.TextBox_ADSWatchdog.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.TextBox_ADSWatchdog, resources.GetString("TextBox_ADSWatchdog.ToolTip"))
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(29, 126)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 17)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "ADS Watchdog:"
        '
        'Button_ADSDisconnect
        '
        Me.Button_ADSDisconnect.Location = New System.Drawing.Point(439, 90)
        Me.Button_ADSDisconnect.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_ADSDisconnect.Name = "Button_ADSDisconnect"
        Me.Button_ADSDisconnect.Size = New System.Drawing.Size(184, 28)
        Me.Button_ADSDisconnect.TabIndex = 10
        Me.Button_ADSDisconnect.Text = "Disconnect"
        Me.Button_ADSDisconnect.UseVisualStyleBackColor = True
        '
        'TextBox_TcJoyPath
        '
        Me.TextBox_TcJoyPath.AllowDrop = True
        Me.TextBox_TcJoyPath.Location = New System.Drawing.Point(195, 185)
        Me.TextBox_TcJoyPath.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_TcJoyPath.Name = "TextBox_TcJoyPath"
        Me.TextBox_TcJoyPath.Size = New System.Drawing.Size(448, 22)
        Me.TextBox_TcJoyPath.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.TextBox_TcJoyPath, resources.GetString("TextBox_TcJoyPath.ToolTip"))
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(29, 188)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 17)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "FB_TcJoy Instance:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(265, 98)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 17)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "ms"
        '
        'TextBox_ADSRate
        '
        Me.TextBox_ADSRate.AllowDrop = True
        Me.TextBox_ADSRate.Location = New System.Drawing.Point(195, 92)
        Me.TextBox_ADSRate.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_ADSRate.Name = "TextBox_ADSRate"
        Me.TextBox_ADSRate.Size = New System.Drawing.Size(63, 22)
        Me.TextBox_ADSRate.TabIndex = 2
        Me.TextBox_ADSRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.TextBox_ADSRate, resources.GetString("TextBox_ADSRate.ToolTip"))
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 96)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "ADS Rate:"
        '
        'TextBox_ADSNetID
        '
        Me.TextBox_ADSNetID.AllowDrop = True
        Me.TextBox_ADSNetID.Location = New System.Drawing.Point(195, 26)
        Me.TextBox_ADSNetID.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_ADSNetID.Name = "TextBox_ADSNetID"
        Me.TextBox_ADSNetID.Size = New System.Drawing.Size(184, 22)
        Me.TextBox_ADSNetID.TabIndex = 0
        Me.TextBox_ADSNetID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.TextBox_ADSNetID, resources.GetString("TextBox_ADSNetID.ToolTip"))
        '
        'TextBox_AdditionalInformation
        '
        Me.TextBox_AdditionalInformation.Enabled = False
        Me.TextBox_AdditionalInformation.Location = New System.Drawing.Point(195, 248)
        Me.TextBox_AdditionalInformation.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_AdditionalInformation.Name = "TextBox_AdditionalInformation"
        Me.TextBox_AdditionalInformation.ReadOnly = True
        Me.TextBox_AdditionalInformation.Size = New System.Drawing.Size(448, 22)
        Me.TextBox_AdditionalInformation.TabIndex = 9
        Me.TextBox_AdditionalInformation.TabStop = False
        Me.TextBox_AdditionalInformation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "AMS Net ID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 249)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Additional Information:"
        '
        'TextBox_ADSPort
        '
        Me.TextBox_ADSPort.AllowDrop = True
        Me.TextBox_ADSPort.Location = New System.Drawing.Point(195, 60)
        Me.TextBox_ADSPort.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_ADSPort.Name = "TextBox_ADSPort"
        Me.TextBox_ADSPort.Size = New System.Drawing.Size(63, 22)
        Me.TextBox_ADSPort.TabIndex = 1
        Me.TextBox_ADSPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.TextBox_ADSPort, resources.GetString("TextBox_ADSPort.ToolTip"))
        '
        'TextBox_ADSConnectionStatus
        '
        Me.TextBox_ADSConnectionStatus.Enabled = False
        Me.TextBox_ADSConnectionStatus.Location = New System.Drawing.Point(195, 218)
        Me.TextBox_ADSConnectionStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_ADSConnectionStatus.Name = "TextBox_ADSConnectionStatus"
        Me.TextBox_ADSConnectionStatus.ReadOnly = True
        Me.TextBox_ADSConnectionStatus.Size = New System.Drawing.Size(448, 22)
        Me.TextBox_ADSConnectionStatus.TabIndex = 7
        Me.TextBox_ADSConnectionStatus.TabStop = False
        Me.TextBox_ADSConnectionStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 62)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ADS Port:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 218)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ADS Connection Status: "
        '
        'Button_ADSConnect
        '
        Me.Button_ADSConnect.Location = New System.Drawing.Point(439, 54)
        Me.Button_ADSConnect.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_ADSConnect.Name = "Button_ADSConnect"
        Me.Button_ADSConnect.Size = New System.Drawing.Size(184, 28)
        Me.Button_ADSConnect.TabIndex = 9
        Me.Button_ADSConnect.Text = "Connect"
        Me.Button_ADSConnect.UseVisualStyleBackColor = True
        '
        'CheckBox_AutoConnectOnOpen
        '
        Me.CheckBox_AutoConnectOnOpen.AutoSize = True
        Me.CheckBox_AutoConnectOnOpen.Location = New System.Drawing.Point(439, 26)
        Me.CheckBox_AutoConnectOnOpen.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox_AutoConnectOnOpen.Name = "CheckBox_AutoConnectOnOpen"
        Me.CheckBox_AutoConnectOnOpen.Size = New System.Drawing.Size(172, 21)
        Me.CheckBox_AutoConnectOnOpen.TabIndex = 8
        Me.CheckBox_AutoConnectOnOpen.Text = "Auto Connect On Start"
        Me.CheckBox_AutoConnectOnOpen.UseVisualStyleBackColor = True
        '
        'TabPage_Help
        '
        Me.TabPage_Help.Controls.Add(Me.RichTextBox_Help)
        Me.TabPage_Help.Location = New System.Drawing.Point(4, 25)
        Me.TabPage_Help.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage_Help.Name = "TabPage_Help"
        Me.TabPage_Help.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage_Help.Size = New System.Drawing.Size(676, 560)
        Me.TabPage_Help.TabIndex = 2
        Me.TabPage_Help.Text = "Help"
        Me.TabPage_Help.UseVisualStyleBackColor = True
        '
        'RichTextBox_Help
        '
        Me.RichTextBox_Help.Location = New System.Drawing.Point(8, 7)
        Me.RichTextBox_Help.Margin = New System.Windows.Forms.Padding(4)
        Me.RichTextBox_Help.Name = "RichTextBox_Help"
        Me.RichTextBox_Help.Size = New System.Drawing.Size(656, 412)
        Me.RichTextBox_Help.TabIndex = 0
        Me.RichTextBox_Help.Text = resources.GetString("RichTextBox_Help.Text")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(691, 541)
        Me.Controls.Add(Me.TabControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "TcJoy V2"
        Me.TabControl.ResumeLayout(False)
        Me.TabPage_LiveStatus.ResumeLayout(False)
        Me.TabPage_LiveStatus.PerformLayout()
        Me.TabPage_Connection.ResumeLayout(False)
        Me.GroupBox_Controller.ResumeLayout(False)
        Me.GroupBox_Controller.PerformLayout()
        Me.GroupBox_PLC.ResumeLayout(False)
        Me.GroupBox_PLC.PerformLayout()
        Me.TabPage_Help.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabPage_LiveStatus As TabPage
    Friend WithEvents TabPage_Connection As TabPage
    Friend WithEvents TabPage_Help As TabPage
    Friend WithEvents Button_ADSConnect As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_ADSPort As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_ADSNetID As TextBox
    Friend WithEvents CheckBox_AutoConnectOnOpen As CheckBox
    Friend WithEvents TextBox_AdditionalInformation As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox_ADSConnectionStatus As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_ADSConnectionStatus2 As TextBox
    Friend WithEvents GroupBox_PLC As GroupBox
    Friend WithEvents GroupBox_Controller As GroupBox
    Friend WithEvents TextBox_ADSDataRateAchieved As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox_ADSRate As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox_TcJoyPath As TextBox
    Friend WithEvents Button_ADSDisconnect As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox_ADSWatchdog As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox_ADSWatchdogDeadDuration As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label_Controller_Connection As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox_AnalogDeadzone As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBox_ShoulderDeadzone As TextBox
    Friend WithEvents ProgressBar_Controller0Battery As ProgressBar
    Friend WithEvents Label_Battery As Label
    Friend WithEvents ProgressBar_LeftStickXMinus As ProgressBar
    Friend WithEvents ProgressBar_LeftStickXPlus As ProgressBar
    Friend WithEvents ProgressBar_RightStickXMinus As ProgressBar
    Friend WithEvents ProgressBar_RightStickXPlus As ProgressBar
    Friend WithEvents CheckBox_XButton As CheckBox
    Friend WithEvents CheckBox_BButton As CheckBox
    Friend WithEvents CheckBox_AButton As CheckBox
    Friend WithEvents CheckBox_YButton As CheckBox
    Friend WithEvents Button_Back As CheckBox
    Friend WithEvents Button_Start As CheckBox
    Friend WithEvents Button_RightShoulder As CheckBox
    Friend WithEvents Button_LeftShoulder As CheckBox
    Friend WithEvents Button_DPadLeft As CheckBox
    Friend WithEvents Button_DPadRight As CheckBox
    Friend WithEvents Button_DPadDown As CheckBox
    Friend WithEvents Button_DPadUp As CheckBox
    Friend WithEvents RichTextBox_Help As RichTextBox
    Friend WithEvents Label_RightStickXPos As Label
    Friend WithEvents Label_RightStickXNeg As Label
    Friend WithEvents Label_LeftStickXPos As Label
    Friend WithEvents Label_LeftStickXNeg As Label
    Friend WithEvents Label_RightStickYNeg As Label
    Friend WithEvents Label_RightStickYPos As Label
    Friend WithEvents Label_LeftStickYPos As Label
    Friend WithEvents Label_LeftStickYNeg As Label
    Friend WithEvents Label_LeftShoulderVal As Label
    Friend WithEvents Label_RightShoulderVal As Label
    Friend WithEvents ProgressBar_LeftStickYPlus As MyVerticalProgessBar
    Friend WithEvents ProgressBar_RightStickYPlus As MyVerticalProgessBar
    Friend WithEvents ProgressBar_LeftStickYMinus As MyVerticalProgessBarMinus
    Friend WithEvents ProgressBar_RightStickYMinus As MyVerticalProgessBarMinus
    Friend WithEvents ProgressBar_RightShoulderAnalog As MyVerticalProgessBar
    Friend WithEvents ProgressBar_LeftShoulderAnalog As MyVerticalProgessBar
    Friend WithEvents Button_LeftJoystick As System.Windows.Forms.CheckBox
    Friend WithEvents Button_RightJoystick As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Textbox_TcJoyUpdateRate As System.Windows.Forms.TextBox
    Friend WithEvents Button_ResetSettings As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TextBox_PLCVariables As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
