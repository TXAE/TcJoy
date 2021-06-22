Imports TwinCAT.Ads
Imports J2i.Net.XInputWrapper
Imports System.ComponentModel

'
' TcJoy, by Evan Jensen of Jensen Mecharonics, LLC. 2018 
'
' See the github page for more information: https://github.com/evanmj/TcJoy
'
' TODO: Any todos in code
' TODO: Fix help tab, add help text/btns on plc settings
' TODO: Add donate link and possibly 'nag' screen
' TODO: Make howto video
' 
'
' MIT License

' Copyright(c) 2018 Evan Jensen of Jensen Mecharonics, LLC.connection with the

' Permission Is hereby granted, free Of charge, to any person obtaining a copy
' of this software And associated documentation files (the "Software"), to deal
' in the Software without restriction, including without limitation the rights
' to use, copy, modify, merge, publish, distribute, sublicense, And/Or sell
' copies of the Software, And to permit persons to whom the Software Is
' furnished to do so, subject to the following conditions:

' The above copyright notice And this permission notice shall be included In all
' copies Or substantial portions of the Software.

' THE SOFTWARE Is PROVIDED "AS IS", WITHOUT WARRANTY Of ANY KIND, EXPRESS Or
' IMPLIED, INCLUDING BUT Not LIMITED To THE WARRANTIES Of MERCHANTABILITY,
' FITNESS FOR A PARTICULAR PURPOSE And NONINFRINGEMENT. IN NO EVENT SHALL THE
' AUTHORS Or COPYRIGHT HOLDERS BE LIABLE For ANY CLAIM, DAMAGES Or OTHER
' LIABILITY, WHETHER In AN ACTION Of CONTRACT, TORT Or OTHERWISE, ARISING FROM,
' OUT OF Or IN CONNECTION WITH THE SOFTWARE Or THE USE Or OTHER DEALINGS IN THE
' SOFTWARE.
'

Public Class Form1

    Public BgTaskData As TaskData                       ' Data for background task that runs actual ADS comms.

    Public WithEvents Timer_TcJoyUpdate As New Timer    ' Timer that updates the TcJoy GUI (default: 100ms)
    Public WithEvents Timer_SendDataToPLC As New Timer  ' Timer that sends ADS data to the PLC.

    Public HeartBeatState As Boolean                    ' Toggle helper for heartbeat.

    Public MyController As XboxController

    Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadSettings()

        MyController = XboxController.RetrieveController(0)

        If My.Settings.bAutoConnectADS Then
            Button_ADSConnect_Click(Me, e)
        End If

        'Start Health Check (GUI Update)
        Timer_TcJoyUpdate.Start()

    End Sub

    Private Sub LoadSettings()

        If Not My.Computer.Keyboard.ShiftKeyDown Then
            Me.Location = My.Settings.WindowLoc ' Restore window position from saved file.
        Else
            Me.Location = My.Computer.Screen.Bounds.Location  ' Optional factory reset if holding shift on startup
        End If

        TabControl.SelectedTab = TabPage_Connection

        Button_ADSDisconnect.Enabled = False
        TextBox_AdditionalInformation.Enabled = False
        TextBox_ADSConnectionStatus.Enabled = False
        TextBox_ADSConnectionStatus2.Enabled = False

        If TextBox_ADSNetID.Text = "" Then
            Button_ResetSettings_Click(Me, System.EventArgs.Empty)
        End If

        CheckBox_AutoConnectOnOpen.Checked = My.Settings.bAutoConnectADS
        TextBox_ADSNetID.Text = My.Settings.sPLC_NETID
        TextBox_ADSPort.Text = My.Settings.sPLC_PORT
        TextBox_TcJoyPath.Text = My.Settings.sTcJoyPath
        TextBox_ADSRate.Text = My.Settings.sADSRate
        TextBox_ADSWatchdog.Text = My.Settings.sADSWatchdog
        TextBox_ADSWatchdogDeadDuration.Text = My.Settings.sADSWatchdogDeadDuration
        Textbox_TcJoyUpdateRate.Text = My.Settings.sTcJoyUpdateRate
        TextBox_AnalogDeadzone.Text = My.Settings.sAnalogDeadZone
        TextBox_ShoulderDeadzone.Text = My.Settings.sShoulderDeadZone

        ' Create dummy TaskData instance so we don't get NullException when we're not connected yet
        BgTaskData = New TaskData(My.Settings.sADSRate,
                                  My.Settings.sADSWatchdog,
                                  My.Settings.sADSWatchdogDeadDuration,
                                  AmsNetId.Parse("192.168.1.10.1.1"),
                                  My.Settings.sPLC_PORT)
    End Sub

    Private Sub Timer_SendDataToPLC_Tick(sender As Object, e As EventArgs) Handles Timer_SendDataToPLC.Tick
        MyController.UpdateState()
        'If MyController.IsConnected Then
        HeartBeatState = Not HeartBeatState ' Invert heartbeat before send.
        Try
            ' Controller Data to the PLC. (From the PLC happens in the PLC_Polling.vb File)
            For Each Tag As DataTag In BgTaskData.TagList
                Select Case Tag.TagName
                    ' Buttons/Bools
                    Case TextBox_TcJoyPath.Text + ".in_boControllerConnected"
                        Tag.Value = MyController.IsConnected
                    Case TextBox_TcJoyPath.Text + ".out_boStart_Button"
                        Tag.Value = MyController.IsStartPressed
                    Case TextBox_TcJoyPath.Text + ".out_boBack_Button"
                        Tag.Value = MyController.IsBackPressed
                    Case TextBox_TcJoyPath.Text + ".out_boA_Button"
                        Tag.Value = MyController.IsAPressed
                    Case TextBox_TcJoyPath.Text + ".out_boB_Button"
                        Tag.Value = MyController.IsBPressed
                    Case TextBox_TcJoyPath.Text + ".out_boX_Button"
                        Tag.Value = MyController.IsXPressed
                    Case TextBox_TcJoyPath.Text + ".out_boY_Button"
                        Tag.Value = MyController.IsYPressed
                    Case TextBox_TcJoyPath.Text + ".out_boLeftShoulder_Button"
                        Tag.Value = MyController.IsLeftShoulderPressed
                    Case TextBox_TcJoyPath.Text + ".out_boRightShoulder_Button"
                        Tag.Value = MyController.IsRightShoulderPressed
                    Case TextBox_TcJoyPath.Text + ".out_boLeftStick_Button"
                        Tag.Value = MyController.IsLeftStickPressed
                    Case TextBox_TcJoyPath.Text + ".out_boRightStick_Button"
                        Tag.Value = MyController.IsRightStickPressed
                    Case TextBox_TcJoyPath.Text + ".out_boDPad_Up_Button"
                        Tag.Value = MyController.IsDPadUpPressed
                    Case TextBox_TcJoyPath.Text + ".out_boDPad_Left_Button"
                        Tag.Value = MyController.IsDPadLeftPressed
                    Case TextBox_TcJoyPath.Text + ".out_boDPad_Right_Button"
                        Tag.Value = MyController.IsDPadRightPressed
                    Case TextBox_TcJoyPath.Text + ".out_boDPad_Down_Button"
                        Tag.Value = MyController.IsDPadDownPressed

                        ' Analog Triggers should be handled as USINTs/Byte as their range from the Xbox Controller is exactly 0 to 255
                    Case TextBox_TcJoyPath.Text + ".out_usiLeftTrigger_Axis"
                        Tag.Value = MyController.LeftTrigger.ToString
                    Case TextBox_TcJoyPath.Text + ".out_usiRightTrigger_Axis"
                        Tag.Value = MyController.RightTrigger.ToString


                        ' Sticks. Want to send as Integers, but does not work to a TwinCAT 2 PLC
                        ' TODO: Beckhoff TwinCAT 2 Problem? No Problems with Integers in TC3
                    Case TextBox_TcJoyPath.Text + ".out_sLeftStick_X_Axis"
                        Tag.Value = MyController.LeftThumbStick.X.ToString
                    Case TextBox_TcJoyPath.Text + ".out_sLeftStick_Y_Axis"
                        Tag.Value = MyController.LeftThumbStick.Y.ToString
                    Case TextBox_TcJoyPath.Text + ".out_sRightStick_X_Axis"
                        Tag.Value = MyController.RightThumbStick.X.ToString
                    Case TextBox_TcJoyPath.Text + ".out_sRightStick_Y_Axis"
                        Tag.Value = MyController.RightThumbStick.Y.ToString

                        'Why? We don't need the battery info to be sent to the PLC?!
                        'Case TextBox_TcJoyPath.Text + ".sBatteryInfo"
                        '    MyController.UpdateBatteryState()
                        '    Select Case MyController.BatteryInformationGamepad.BatteryLevel
                        '        Case BatteryLevel.BATTERY_LEVEL_EMPTY
                        '            Tag.Value = "0"
                        '        Case BatteryLevel.BATTERY_LEVEL_LOW
                        '            Tag.Value = "25"
                        '        Case BatteryLevel.BATTERY_LEVEL_MEDIUM
                        '            Tag.Value = "50"
                        '        Case BatteryLevel.BATTERY_LEVEL_FULL
                        '            Tag.Value = "100"
                        '        Case Else
                        '            Tag.Value = "unkn"
                        '    End Select

                    Case TextBox_TcJoyPath.Text + ".in_boHeartBeatToggle"
                        Tag.Value = HeartBeatState

                        ' TODO: Doesn't need to be sent every tick
                    Case TextBox_TcJoyPath.Text + ".in_sADSWatchdogMS"
                        Tag.Value = "T#" + TextBox_ADSWatchdog.Text + "ms"
                    Case TextBox_TcJoyPath.Text + ".in_sADSWatchdogDeadDurationMS"
                        Tag.Value = "T#" + TextBox_ADSWatchdogDeadDuration.Text + "ms"
                End Select
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message + " Disconnecting from PLC.")
            Button_ADSDisconnect_Click(Me, e)
        End Try
        ' Fire off dude that goes and applies the changes to the code.
        PLC_IO_Polling.StartWorker()
        'End If
    End Sub

    ''' <summary>
    ''' TcJoy Update Timer... Updates the GUI with values from PLC Connection, the controller, etc.  
    ''' Runs with Timer_HealthCheck.Interval (could be set slower than default: 100ms to preserve resources)
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Ticks every 'Timer_TcJoyUpdate.Interval' Milliseconds </remarks>
    Private Sub Timer_TcJoyUpdate_Tick(sender As Object, e As EventArgs) Handles Timer_TcJoyUpdate.Tick
        'Update PLC information only when we're communicating with the PLC
        If Timer_SendDataToPLC.Enabled Then
            ' Do Reads at slow speed, we don't need really any of this for actual functionality, but it is nice for status.
            Dim symbol As ITcAdsSymbol
            Dim debug = False
            'Dim VibrateLenght As New TimeSpan(0, 0, 0, 0, 0)
            'Dim VibrateIntensity As Integer
            For Each tag As DataTag In BgTaskData.TagList
                If tag.IsRead Then
                    Try
                        ' Get data type and other information from PLC variable
                        symbol = BgTaskData.ADS_Connection.AdsClient.ReadSymbolInfo(tag.TagName)

                        ' Read Value of isRead PLC variable in tag.Value of our BgTaskData.Taglist
                        tag.Value = BgTaskData.ADS_Connection.AdsClient.ReadSymbol(symbol)

                        If debug Then Console.WriteLine(tag.TagName + " value = " + tag.Value.ToString)
                        BgTaskData.IsConnected = BgTaskData.ADS_Connection.AdsClient.IsConnected
                    Catch ex As Exception
                        Button_ADSDisconnect_Click(Me, e)
                        If ex.Message = "Ads-Error 0x745 : Timeout has elapsed. (Ads-Error 0x745 : Timeout has elapsed.)" Then
                            TextBox_AdditionalInformation.Text = "TcJoy lost connection to the PLC!"
                            TextBox_AdditionalInformation.BackColor = Color.OrangeRed
                            MessageBox.Show("TcJoy lost connection to the PLC! Exception Message: " + ex.Message)
                            Exit Sub
                        Else
                            TextBox_AdditionalInformation.BackColor = Color.Orange
                            TextBox_AdditionalInformation.Text = ex.Message
                            TextBox_PLCVariables.BackColor = Color.Orange
                            TextBox_PLCVariables.Text = "Could not read from: " + tag.TagName
                            MessageBox.Show("Could not read from: " + tag.TagName + vbNewLine +
                                            "Most likely cause: A Variable from the TcJoy TagList (see PLC_Polling.vb file) " +
                                            "does not exist on the PLC TcJoy Function Block." + vbNewLine + "Exception Message: " + ex.Message)
                            Exit Sub
                        End If
                    End Try

                    ' Do stuff with our new found tag reads... 
                    Select Case tag.TagName

                        Case TextBox_TcJoyPath.Text + ".boIsActive"
                            If tag.Value Then
                                TextBox_PLCVariables.BackColor = Color.LawnGreen
                                TextBox_PLCVariables.Text = "boIsActive = true"
                            Else
                                TextBox_PLCVariables.BackColor = Color.Orange
                                TextBox_PLCVariables.Text = "boIsActive = false"
                                TextBox_ADSDataRateAchieved.Text = "boIsActive = false"
                                Exit Sub
                            End If

                        Case TextBox_TcJoyPath.Text + ".boWatchdogFailureActive"
                            If tag.Value Then
                                TextBox_PLCVariables.BackColor = Color.OrangeRed
                                TextBox_PLCVariables.Text = "Watchdog Failure"
                            End If

                        Case TextBox_TcJoyPath.Text + ".boControlerInputsMustBeReleased"
                            If tag.Value Then
                                TextBox_PLCVariables.BackColor = Color.Orange
                                TextBox_PLCVariables.Text = "Release Controller Inputs"
                            End If

                        Case TextBox_TcJoyPath.Text + ".tonUpdateRate.ET"
                            ' Fill out latency status bar graphs with achieved rate.
                            TextBox_ADSDataRateAchieved.Text = "Latency: " + tag.Value.ToString

                            'Case TextBox_TcJoyPath.Text + ".sVibrateLength"
                            '    If tag.Value > 0 Then
                            '        VibrateLenght = New TimeSpan(0, 0, 0, 0, tag.Value)
                            '    End If

                            'Case TextBox_TcJoyPath.Text + ".sVibrateIntensity"
                            '    If Not tag.Value Is Nothing Then
                            '        VibrateIntensity = tag.Value
                            '    End If
                    End Select
                    'MyController.Vibrate(0, VibrateIntensity, VibrateLenght)
                End If
            Next
            ' Update Controller State with this Timer when we're not connected to PLC so User can see Controller Inputs when looking at Live Status Tab
        ElseIf TabControl.SelectedTab Is TabPage_LiveStatus Then
            MyController.UpdateState()
        End If

        If TabControl.SelectedTab Is TabPage_LiveStatus Then
            ' Update controller readout display
            If MyController.IsConnected Then
                Label_Controller_Connection.Text = "      Controller 0 Connected     "
                Label_Controller_Connection.BackColor = Color.LawnGreen

                If MyController.LeftThumbStick.X >= 0 Then
                    UpdateProgressBar(ProgressBar_LeftStickXPlus, Math.Abs(MyController.LeftThumbStick.X))
                    UpdateProgressBar(ProgressBar_LeftStickXMinus, 0)
                    Label_LeftStickXPos.Text = MyController.LeftThumbStick.X.ToString
                    Label_LeftStickXNeg.Text = ""
                Else
                    UpdateProgressBar(ProgressBar_LeftStickXPlus, 0)
                    UpdateProgressBar(ProgressBar_LeftStickXMinus, Math.Abs(MyController.LeftThumbStick.X))
                    Label_LeftStickXPos.Text = ""
                    Label_LeftStickXNeg.Text = MyController.LeftThumbStick.X.ToString
                End If
                If MyController.LeftThumbStick.Y >= 0 Then
                    UpdateProgressBar(ProgressBar_LeftStickYPlus, Math.Abs(MyController.LeftThumbStick.Y))
                    UpdateProgressBar(ProgressBar_LeftStickYMinus, 0)
                    Label_LeftStickYPos.Text = MyController.LeftThumbStick.Y.ToString
                    Label_LeftStickYNeg.Text = ""
                Else
                    UpdateProgressBar(ProgressBar_LeftStickYPlus, 0)
                    UpdateProgressBar(ProgressBar_LeftStickYMinus, Math.Abs(MyController.LeftThumbStick.Y))
                    Label_LeftStickYPos.Text = ""
                    Label_LeftStickYNeg.Text = MyController.LeftThumbStick.Y.ToString
                End If

                ' Color thumbstick sliders
                If Math.Abs(MyController.LeftThumbStick.X) < CInt(TextBox_AnalogDeadzone.Text) Then ' Turn Red
                    SendMessage(ProgressBar_LeftStickXPlus.Handle, 1040, 2, 0)
                    SendMessage(ProgressBar_LeftStickXMinus.Handle, 1040, 2, 0)
                    Label_LeftStickXPos.ForeColor = Color.DarkRed
                    Label_LeftStickXNeg.ForeColor = Color.DarkRed
                Else ' Turn Green
                    SendMessage(ProgressBar_LeftStickXPlus.Handle, 1040, 1, 0)
                    SendMessage(ProgressBar_LeftStickXMinus.Handle, 1040, 1, 0)
                    Label_LeftStickXPos.ForeColor = Color.DarkGreen
                    Label_LeftStickXNeg.ForeColor = Color.DarkGreen
                End If
                If Math.Abs(MyController.LeftThumbStick.Y) < CInt(TextBox_AnalogDeadzone.Text) Then ' Turn Red
                    SendMessage(ProgressBar_LeftStickYPlus.Handle, 1040, 2, 0)
                    SendMessage(ProgressBar_LeftStickYMinus.Handle, 1040, 2, 0)
                    Label_LeftStickYPos.ForeColor = Color.DarkRed
                    Label_LeftStickYNeg.ForeColor = Color.DarkRed
                Else ' Turn Green
                    SendMessage(ProgressBar_LeftStickYPlus.Handle, 1040, 1, 0)
                    SendMessage(ProgressBar_LeftStickYMinus.Handle, 1040, 1, 0)
                    Label_LeftStickYPos.ForeColor = Color.DarkGreen
                    Label_LeftStickYNeg.ForeColor = Color.DarkGreen
                End If

                If MyController.RightThumbStick.X >= 0 Then
                    UpdateProgressBar(ProgressBar_RightStickXPlus, Math.Abs(MyController.RightThumbStick.X))
                    UpdateProgressBar(ProgressBar_RightStickXMinus, 0)
                    Label_RightStickXPos.Text = MyController.RightThumbStick.X.ToString
                    Label_RightStickXNeg.Text = ""
                Else
                    UpdateProgressBar(ProgressBar_RightStickXPlus, 0)
                    UpdateProgressBar(ProgressBar_RightStickXMinus, Math.Abs(MyController.RightThumbStick.X))
                    Label_RightStickXPos.Text = ""
                    Label_RightStickXNeg.Text = MyController.RightThumbStick.X.ToString
                End If

                If MyController.RightThumbStick.Y >= 0 Then
                    UpdateProgressBar(ProgressBar_RightStickYPlus, Math.Abs(MyController.RightThumbStick.Y))
                    UpdateProgressBar(ProgressBar_RightStickYMinus, 0)
                    Label_RightStickYPos.Text = MyController.RightThumbStick.Y.ToString
                    Label_RightStickYNeg.Text = ""
                Else
                    UpdateProgressBar(ProgressBar_RightStickYPlus, 0)
                    UpdateProgressBar(ProgressBar_RightStickYMinus, Math.Abs(MyController.RightThumbStick.Y))
                    Label_RightStickYPos.Text = ""
                    Label_RightStickYNeg.Text = MyController.RightThumbStick.Y.ToString
                End If

                ' Color thumbstick sliders
                If Math.Abs(MyController.RightThumbStick.X) < CInt(TextBox_AnalogDeadzone.Text) Then ' Turn Red
                    SendMessage(ProgressBar_RightStickXPlus.Handle, 1040, 2, 0)
                    SendMessage(ProgressBar_RightStickXMinus.Handle, 1040, 2, 0)
                    Label_RightStickXPos.ForeColor = Color.DarkRed
                    Label_RightStickXNeg.ForeColor = Color.DarkRed
                Else ' Turn Green
                    SendMessage(ProgressBar_RightStickXPlus.Handle, 1040, 1, 0)
                    SendMessage(ProgressBar_RightStickXMinus.Handle, 1040, 1, 0)
                    Label_RightStickXPos.ForeColor = Color.DarkGreen
                    Label_RightStickXNeg.ForeColor = Color.DarkGreen
                End If
                If Math.Abs(MyController.RightThumbStick.Y) < CInt(TextBox_AnalogDeadzone.Text) Then ' Turn Red
                    SendMessage(ProgressBar_RightStickYPlus.Handle, 1040, 2, 0)
                    SendMessage(ProgressBar_RightStickYMinus.Handle, 1040, 2, 0)
                    Label_RightStickYPos.ForeColor = Color.DarkRed
                    Label_RightStickYNeg.ForeColor = Color.DarkRed
                Else ' Turn Green
                    SendMessage(ProgressBar_RightStickYPlus.Handle, 1040, 1, 0)
                    SendMessage(ProgressBar_RightStickYMinus.Handle, 1040, 1, 0)
                    Label_RightStickYPos.ForeColor = Color.DarkGreen
                    Label_RightStickYNeg.ForeColor = Color.DarkGreen
                End If

                ' Motor vibrations/rumble test
                If MyController.IsAPressed Then
                    Dim VibrateSpan As New TimeSpan(0, 0, 0, 0, 100)
                    MyController.Vibrate(0, 0.1, VibrateSpan)
                End If

                ' Show Button presses
                CheckBox_AButton.Visible = MyController.IsAPressed
                CheckBox_BButton.Visible = MyController.IsBPressed
                CheckBox_XButton.Visible = MyController.IsXPressed
                CheckBox_YButton.Visible = MyController.IsYPressed

                Button_LeftJoystick.Visible = MyController.IsLeftStickPressed
                Button_RightJoystick.Visible = MyController.IsRightStickPressed

                Button_DPadDown.Visible = MyController.IsDPadDownPressed
                Button_DPadUp.Visible = MyController.IsDPadUpPressed
                Button_DPadLeft.Visible = MyController.IsDPadLeftPressed
                Button_DPadRight.Visible = MyController.IsDPadRightPressed

                Button_LeftShoulder.Visible = MyController.IsLeftShoulderPressed
                Button_RightShoulder.Visible = MyController.IsRightShoulderPressed

                Button_Back.Visible = MyController.IsBackPressed
                Button_Start.Visible = MyController.IsStartPressed

                UpdateProgressBar(ProgressBar_LeftShoulderAnalog, MyController.LeftTrigger)
                Label_LeftShoulderVal.Text = MyController.LeftTrigger.ToString
                UpdateProgressBar(ProgressBar_RightShoulderAnalog, MyController.RightTrigger)
                Label_RightShoulderVal.Text = MyController.RightTrigger.ToString

                ' Color shoulder trigger sliders
                If MyController.LeftTrigger < CInt(TextBox_ShoulderDeadzone.Text) Then
                    SendMessage(ProgressBar_LeftShoulderAnalog.Handle, 1040, 2, 0) ' Turn Red
                Else
                    SendMessage(ProgressBar_LeftShoulderAnalog.Handle, 1040, 1, 0) ' Turn Green
                End If
                If MyController.RightTrigger < CInt(TextBox_ShoulderDeadzone.Text) Then
                    SendMessage(ProgressBar_RightShoulderAnalog.Handle, 1040, 2, 0) ' Turn Red
                Else
                    SendMessage(ProgressBar_RightShoulderAnalog.Handle, 1040, 1, 0) ' Turn Green
                End If

                Select Case MyController.BatteryInformationGamepad.BatteryLevel

                    Case BatteryLevel.BATTERY_LEVEL_EMPTY
                        ProgressBar_Controller0Battery.Value = 0
                        SendMessage(ProgressBar_Controller0Battery.Handle, 1040, 2, 0) ' Turn Red

                    Case BatteryLevel.BATTERY_LEVEL_LOW
                        ProgressBar_Controller0Battery.Value = 25
                        SendMessage(ProgressBar_Controller0Battery.Handle, 1040, 2, 0) ' Turn Red

                    Case BatteryLevel.BATTERY_LEVEL_MEDIUM
                        ProgressBar_Controller0Battery.Value = 50
                        SendMessage(ProgressBar_Controller0Battery.Handle, 1040, 1, 0) ' Turn Green

                    Case BatteryLevel.BATTERY_LEVEL_FULL
                        ProgressBar_Controller0Battery.Value = 100
                        SendMessage(ProgressBar_Controller0Battery.Handle, 1040, 1, 0) ' Turn Green

                    Case Else
                        Console.WriteLine("Battery: " + "Error: " + MyController.BatteryInformationGamepad.BatteryLevel.ToString)
                        ProgressBar_Controller0Battery.Value = 100
                        SendMessage(ProgressBar_Controller0Battery.Handle, 1040, 2, 0) ' Turn Red

                End Select
            Else
                Label_Controller_Connection.Text = "  Controller 0 NOT CONNECTED!    "
                Label_Controller_Connection.BackColor = Color.Orange
            End If
        End If
    End Sub

    ' Hack a faster response from dumb animated progress bars.
    Public Sub UpdateProgressBar(ByRef Bar As ProgressBar, ByVal value As Integer)
        If value = Bar.Maximum Then
            Bar.Value = value
            Bar.Value = value - 1
            Bar.Value = value
        Else
            Bar.Value = value + 1
            Bar.Value = value
        End If
    End Sub

#Region "Connection Tab"

    Private Sub CheckBox_AutoConnectOnOpen_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_AutoConnectOnOpen.CheckedChanged
        My.Settings.bAutoConnectADS = CheckBox_AutoConnectOnOpen.Checked
        My.Settings.Save()
    End Sub

    Private Sub TextBox_ADSNetID_TextChanged(sender As Object, e As EventArgs) Handles TextBox_ADSNetID.TextChanged
        My.Settings.sPLC_NETID = TextBox_ADSNetID.Text
        My.Settings.Save()
    End Sub

    Private Sub TextBox_ADSPort_TextChanged(sender As Object, e As EventArgs) Handles TextBox_ADSPort.TextChanged
        My.Settings.sPLC_PORT = TextBox_ADSPort.Text
        My.Settings.Save()
    End Sub

    Private Sub Button_ADSConnect_Click(sender As Object, e As EventArgs) Handles Button_ADSConnect.Click
        ' Validate inputs
        Dim NetID As AmsNetId
        Try
            NetID = AmsNetId.Parse(TextBox_ADSNetID.Text) ' Attempt to parse input into an AmsAdress
        Catch ex As Exception
            MessageBox.Show("The attempt to parse your Net ID into an AmsNetId returned the following Exception: " + ex.Message + vbNewLine + " Defaulting to Net ID: 192.168.1.10.1.1")
            TextBox_ADSNetID.Text = "192.168.1.10.1.1"
            NetID = AmsNetId.Parse(TextBox_ADSNetID.Text)
        End Try

        Dim port As Integer
        Try
            port = TextBox_ADSPort.Text
            If port <= 0 Then
                TextBox_ADSPort.Text = 801
                MessageBox.Show("Your Port input is unreasonable. Defaulting to Port 801")
            End If
        Catch ex As Exception
            MessageBox.Show("The attempt to parse your Port into an Integer returned the following Exception: " + ex.Message + vbNewLine + " Defaulting to Port: 801")
            TextBox_ADSPort.Text = 801
            port = 801
        End Try

        Dim rate As Integer
        Try
            rate = TextBox_ADSRate.Text
            If rate <= 0 Then
                TextBox_ADSRate.Text = 100
                MessageBox.Show("Your ADS Rate input is unreasonable. Defaulting to 100ms")
            End If
        Catch ex As Exception
            TextBox_ADSRate.Text = 100
            MessageBox.Show("The attempt to parse your Rate into an Integer returned the following Exception: " + ex.Message + vbNewLine + " Defaulting to 100ms")
        End Try

        Dim ADSWatchdog As Integer
        Try
            If TextBox_ADSWatchdog.Text <= 0 Then
                TextBox_ADSWatchdog.Text = 300
                MessageBox.Show("Your Watchdog input is unreasonable. Defaulting to 300ms")
            End If
        Catch ex As Exception
            MessageBox.Show("The attempt to parse your ADS Watchtog time into an Integer returned the following Exception: " + ex.Message + vbNewLine + " Defaulting to 300ms")
            TextBox_ADSWatchdog.Text = 300
        End Try


        Dim ADSWatchdogDeadDuration As Integer
        Try
            ADSWatchdogDeadDuration = TextBox_ADSWatchdogDeadDuration.Text
            If ADSWatchdogDeadDuration <= 1 Then
                MessageBox.Show("Your Watchdog Dead Duration input is unreasonable. Defaulting to 2000ms")
                TextBox_ADSWatchdogDeadDuration.Text = 2000
            End If
        Catch ex As Exception
            MessageBox.Show("The attempt to parse your ADS Watchdog Dead Duration into an Integer returned the following Exception: " + ex.Message + vbNewLine + " Defaulting to 2000ms")
            TextBox_ADSWatchdogDeadDuration.Text = 2000
        End Try

        ' Build IO List
        BgTaskData = New Form1.TaskData(rate, ADSWatchdog, ADSWatchdogDeadDuration, NetID, port)

        BgTaskData.ADS_Connection = New Ads_Link(NetID, port)
        If BgTaskData.ADS_Connection.AdsClient.IsConnected Then
            ' Check if target PLC is running
            Dim targetState As StateInfo
            targetState = BgTaskData.ADS_Connection.AdsClient.ReadState()
            If Not targetState.AdsState.ToString = "Run" Then
                Button_ADSDisconnect_Click(Me, e)
                TextBox_AdditionalInformation.BackColor = Color.Orange
                TextBox_AdditionalInformation.Text = String.Format("Target PLC state: {0}", targetState.AdsState.ToString)
                TextBox_PLCVariables.BackColor = Color.Orange
                TextBox_PLCVariables.Text = "Please start the PLC program!"
                MessageBox.Show("Please start the PLC program and try to connect again!")
                Exit Sub
            Else
                ' See if we can find the FB on the PLC.
                Dim testtag As ITcAdsSymbol
                testtag = BgTaskData.ADS_Connection.AdsClient.ReadSymbolInfo(TextBox_TcJoyPath.Text + ".tonUpdateRate.ET")
                If testtag Is Nothing Then
                    Button_ADSDisconnect_Click(Me, e)
                    TextBox_AdditionalInformation.Text = "TcJoy instance not found on PLC."
                    TextBox_AdditionalInformation.BackColor = Color.Orange
                    TextBox_TcJoyPath.Focus()
                    MessageBox.Show("TcJoy instance not found on PLC. Make sure you've put in the correct Path to the TcJoy Function Block. Also make sure the Variable sUpdateRateMS exists within the TcJoy Function Block on the PLC.")
                    Exit Sub
                Else
                    'Dim settings As TwinCAT.ISymbolLoaderSettings
                    'Dim test As ITcAdsSymbolBrowser

                    AddVariablesToList(BgTaskData)
                    TextBox_ADSNetID.Enabled = False
                    TextBox_ADSPort.Enabled = False
                    TextBox_ADSRate.Enabled = False
                    TextBox_ADSWatchdog.Enabled = False
                    TextBox_ADSWatchdogDeadDuration.Enabled = False
                    TextBox_TcJoyPath.Enabled = False
                    Button_ADSDisconnect.Enabled = True
                    Button_ADSConnect.Enabled = False
                    Button_ResetSettings.Enabled = False
                    TextBox_ADSConnectionStatus.BackColor = Color.LawnGreen
                    TextBox_ADSConnectionStatus.Text = "Connected."
                    TextBox_AdditionalInformation.BackColor = Color.LightGray
                    TextBox_AdditionalInformation.Text = ""
                    TextBox_PLCVariables.BackColor = Color.LightGray
                    TextBox_PLCVariables.Text = ""

                    ' Copy ADS Connection Status textbox from 'Connection' Tab to the second ADS Connection Status textbox on the 'Live Status' Tab 
                    TextBox_ADSConnectionStatus2.BackColor = TextBox_ADSConnectionStatus.BackColor
                    TextBox_ADSConnectionStatus2.Text = TextBox_ADSConnectionStatus.Text

                    ' Change to Live Status Tab when Connection is established succesfully
                    TabControl.SelectedTab = TabPage_LiveStatus

                    ' Start sending data using this timer's tick function.
                    Timer_SendDataToPLC.Interval = CInt(TextBox_ADSRate.Text)
                    Timer_SendDataToPLC.Start()
                End If
            End If
        End If
    End Sub

    Public Sub Button_ADSDisconnect_Click(sender As Object, e As EventArgs) Handles Button_ADSDisconnect.Click
        Timer_SendDataToPLC.Stop()

        ' Kill ads object if it still exists
        If Not BgTaskData.ADS_Connection Is Nothing Then
            BgTaskData.ADS_Connection.AdsClient.Dispose()
            BgTaskData.ADS_Connection = Nothing
        End If

        TextBox_ADSNetID.Enabled = True
        TextBox_ADSPort.Enabled = True
        TextBox_ADSRate.Enabled = True
        TextBox_ADSWatchdog.Enabled = True
        TextBox_ADSWatchdogDeadDuration.Enabled = True
        TextBox_TcJoyPath.Enabled = True
        Button_ADSConnect.Enabled = True
        Button_ADSDisconnect.Enabled = False
        Button_ResetSettings.Enabled = True
        TextBox_ADSConnectionStatus.Text = "Disconnected."
        TextBox_ADSConnectionStatus.BackColor = Color.OrangeRed
        TextBox_AdditionalInformation.Text = "Disconnect Button used."
        TextBox_AdditionalInformation.BackColor = Color.LightGray
        TextBox_PLCVariables.Text = ""
        TextBox_PLCVariables.BackColor = Color.LightGray

        ' Copy ADS Connection Status textbox from 'Connection' Tab to the second ADS Connection Status textbox on the 'Live Status' Tab 
        TextBox_ADSConnectionStatus2.BackColor = TextBox_ADSConnectionStatus.BackColor
        TextBox_ADSConnectionStatus2.Text = TextBox_ADSConnectionStatus.Text

        ' Change to Connection Tab when disconnected from PLC        
        TabControl.SelectedTab = TabPage_Connection
    End Sub

    Private Sub Button_ResetSettings_Click(sender As Object, e As EventArgs) Handles Button_ResetSettings.Click
        CheckBox_AutoConnectOnOpen.Checked = False
        TextBox_ADSNetID.Text = "0.0.0.0.0.0"
        TextBox_ADSPort.Text = 851
        TextBox_TcJoyPath.Text = "Global_Variables.TcJoy"
        TextBox_ADSRate.Text = 100
        TextBox_ADSWatchdog.Text = 400
        TextBox_ADSWatchdogDeadDuration.Text = 2000
        Textbox_TcJoyUpdateRate.Text = 200
        TextBox_AnalogDeadzone.Text = 8000 ' counts of 32767
        TextBox_ShoulderDeadzone.Text = 0  ' counts of 255
        Textbox_TcJoyUpdateRate.Text = 200
    End Sub

    Private Sub TextBox_TcJoyPath_TextChanged(sender As Object, e As EventArgs) Handles TextBox_TcJoyPath.TextChanged
        My.Settings.sTcJoyPath = TextBox_TcJoyPath.Text
        My.Settings.Save()
    End Sub

    Private Sub TextBox_ADSRate_TextChanged(sender As Object, e As EventArgs) Handles TextBox_ADSRate.TextChanged
        My.Settings.sADSRate = TextBox_ADSRate.Text
        My.Settings.Save()
    End Sub

    Private Sub TextBox_ADSWatchdog_TextChanged(sender As Object, e As EventArgs) Handles TextBox_ADSWatchdog.TextChanged
        My.Settings.sADSWatchdog = TextBox_ADSWatchdog.Text
        My.Settings.Save()
    End Sub

    Private Sub TextBox_ADSWatchdogDeadDuration_TextChanged(sender As Object, e As EventArgs) Handles TextBox_ADSWatchdogDeadDuration.TextChanged
        My.Settings.sADSWatchdogDeadDuration = TextBox_ADSWatchdogDeadDuration.Text
        My.Settings.Save()
    End Sub

    Private Sub Textbox_TcJoyUpdateRate_TextChanged(sender As Object, e As EventArgs) Handles Textbox_TcJoyUpdateRate.TextChanged
        If Textbox_TcJoyUpdateRate.Text <> "" And Textbox_TcJoyUpdateRate.Text > 0 Then
            Try
                Timer_TcJoyUpdate.Interval = Textbox_TcJoyUpdateRate.Text
            Catch ex As Exception
                MessageBox.Show("Didn't understand the value you put in, it must be an integer. Setting a default value of 200ms.")
                Textbox_TcJoyUpdateRate.Text = 200
            End Try
            If Textbox_TcJoyUpdateRate.Text <= 0 Then
                Textbox_TcJoyUpdateRate.Text = 200
            End If
            My.Settings.sTcJoyUpdateRate = Textbox_TcJoyUpdateRate.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub TextBox_AnalogDeadzone_TextChanged(sender As Object, e As EventArgs) Handles TextBox_AnalogDeadzone.TextChanged
        If TextBox_AnalogDeadzone.Text <> "" Then
            Dim value As Integer
            Try
                value = TextBox_AnalogDeadzone.Text
            Catch ex As Exception
                MessageBox.Show("Didn't understand the value you put in, it must be an integer. Setting a default value.")
                TextBox_AnalogDeadzone.Text = 6000
                value = 6000
            End Try
            If value < 0 Then
                TextBox_AnalogDeadzone.Text = 6000
            End If
            My.Settings.sAnalogDeadZone = TextBox_AnalogDeadzone.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub TextBox_ShoulderDeadzone_TextChanged(sender As Object, e As EventArgs) Handles TextBox_ShoulderDeadzone.TextChanged
        If TextBox_ShoulderDeadzone.Text <> "" Then
            Dim value As Integer
            Try
                value = Int32.Parse(TextBox_ShoulderDeadzone.Text)
            Catch ex As Exception
                MessageBox.Show("Didn't understand the value you put in, it must be an integer. Setting a default value.")
                TextBox_ShoulderDeadzone.Text = 0
                value = 0
            End Try
            If value < 0 Then
                TextBox_ShoulderDeadzone.Text = 0
            End If
            My.Settings.sShoulderDeadZone = TextBox_ShoulderDeadzone.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.WindowLoc = Me.Location
        My.Settings.Save()
        Application.Exit()
        End
    End Sub

#End Region

    Public Class TaskData

        Private _TagList As List(Of DataTag)
        Private _UpdateRateMS As Integer
        Private _ADSWatchdogMs As Integer
        Private _ADSWatchdogDeadDurationMS As Integer
        Private _NetID As AmsNetId
        Private _Port As Integer
        Private _IsConnected As Boolean
        Private _ADS_Connection As Ads_Link


        Public Sub New(UpdateRateMs As Integer, ADSWatchdogMs As Integer, ADSWatchdogDeadDurationMS As Integer, NetID As AmsNetId, Port As AmsPort)
            _TagList = New List(Of DataTag)
            _UpdateRateMS = UpdateRateMs
            _ADSWatchdogMs = ADSWatchdogMs
            _ADSWatchdogDeadDurationMS = ADSWatchdogDeadDurationMS
            _NetID = NetID
            _Port = Port
        End Sub

        Property TagList As List(Of DataTag)
            Get
                Return _TagList
            End Get
            Set(value As List(Of DataTag))
                _TagList = value
            End Set
        End Property

        Property UpdateRateMS As Integer
            Get
                Return _UpdateRateMS
            End Get
            Set(value As Integer)
                _UpdateRateMS = value
            End Set
        End Property

        Property ADSWatchdogMs As Integer
            Get
                Return _ADSWatchdogMs
            End Get
            Set(value As Integer)
                _ADSWatchdogMs = value
            End Set
        End Property

        Property ADSWatchdogDeadDurationMS As Integer
            Get
                Return _ADSWatchdogDeadDurationMS
            End Get
            Set(value As Integer)
                _ADSWatchdogDeadDurationMS = value
            End Set
        End Property

        Property NetID As AmsNetId
            Get
                Return _NetID
            End Get
            Set(value As AmsNetId)
                _NetID = value
            End Set
        End Property

        Property Port As Integer
            Get
                Return _Port
            End Get
            Set(value As Integer)
                _Port = value
            End Set
        End Property

        Property IsConnected As Boolean
            Get
                Return _IsConnected
            End Get
            Set(value As Boolean)
                _IsConnected = value
            End Set
        End Property

        Property ADS_Connection As Ads_Link
            Get
                Return _ADS_Connection
            End Get
            Set(value As Ads_Link)
                _ADS_Connection = value
            End Set
        End Property

    End Class

    ''' <summary>
    ''' Data Tag Object that we read/write to or from twincat via ADS
    ''' </summary>
    Public Class DataTag

        Private _TagName As String
        'Private _TagType As Object
        Private _IsRead As Boolean
        Private _IsWritten As Boolean
        Private _value As Object

        Public Sub New(TagName As String, IsRead As Boolean, IsWritten As Boolean)
            _TagName = TagName
            '_TagType = TagType
            _IsRead = IsRead
            _IsWritten = IsWritten
            _value = New Object
            _value = 0 ' Set default value of this object to '0'
        End Sub

        Property TagName As String
            Get
                Return _TagName
            End Get
            Set(value As String)
                _TagName = value
            End Set
        End Property

        'Property TagType As Object
        '    Get
        '        Return _TagType
        '    End Get
        '    Set(value As Object)
        '        _TagType = value
        '    End Set
        'End Property

        Property IsRead As Boolean
            Get
                Return _IsRead
            End Get
            Set(value As Boolean)
                _IsRead = value
            End Set
        End Property

        Property IsWritten As Boolean
            Get
                Return _IsWritten
            End Get
            Set(value As Boolean)
                _IsWritten = value
            End Set
        End Property

        Property Value As Object
            Get
                Return _value
            End Get
            Set(value As Object)
                _value = value
            End Set
        End Property

    End Class

    Private Sub Textbox_TcJoyUpdateRate_Leave(sender As Object, e As EventArgs) Handles Textbox_TcJoyUpdateRate.Leave

    End Sub

End Class