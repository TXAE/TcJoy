Imports TwinCAT
Imports TwinCAT.Ads
Imports System.ComponentModel

Module PLC_IO_Polling

    Dim debug = False
    Public WithEvents BackgroundWorker1 As BackgroundWorker

    ''' <summary>
    ''' Start off the background worker, which will configure itself and then run.
    ''' </summary>
    Public Sub StartWorker()

        ' Start worker with relevant data
        BackgroundWorker1 = New BackgroundWorker()
        BackgroundWorker1.WorkerSupportsCancellation = True
        BackgroundWorker1.RunWorkerAsync(Form1.BgTaskData)
        If debug Then Console.WriteLine("BG Worker Started, netID is " + Form1.BgTaskData.NetID.ToString)

    End Sub

    ''' <summary>
    ''' Start up the IO poller for the Twincat ADS data
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object,
                                         ByVal e As System.ComponentModel.DoWorkEventArgs) _
                                         Handles BackgroundWorker1.DoWork

        Dim symbol As ITcAdsSymbol ' working symbol. 
        Dim debug = False

        ' Do writes
        For Each tag As Form1.DataTag In e.Argument.TagList
            If tag.IsWritten Then
                Try
                    If debug Then Console.WriteLine("Writing Tag: " + tag.TagName + " to value: " + tag.Value.ToString)
                    ' Get data type and other information from PLC
                    symbol = e.Argument.ADS_Connection.AdsClient.ReadSymbolInfo(tag.TagName)

                    ' Write value to PLC
                    e.Argument.ADS_Connection.AdsClient.WriteSymbol(symbol, tag.Value)
                    e.Argument.IsConnected = e.Argument.ADS_Connection.AdsClient.IsConnected

                Catch ex As Exception
                    MessageBox.Show(ex.Message + " TagName = " + tag.TagName + " Inner Exception = " + ex.InnerException.Message)
                    Console.WriteLine("Could not get symbol or write tag: " + tag.TagName + " ex: " + ex.Message)
                    e.Argument.IsConnected = False
                    BackgroundWorker1.CancelAsync()
                End Try

            End If
        Next

    End Sub

    Public Sub AddVariablesToList(ByRef BgTaskData As Form1.TaskData)
        Dim fbPath As String
        fbPath = Form1.TextBox_TcJoyPath.Text
        ' Add tags to our data object, ones that we write to TwinCAT (VB TO PLC)
        BgTaskData.TagList.Add(New Form1.DataTag(fbPath + ".in_boHeartBeatToggle", False, True))
        BgTaskData.TagList.Add(New Form1.DataTag(fbPath + ".in_boControllerConnected", False, True))
        BgTaskData.TagList.Add(New Form1.DataTag(fbPath + ".in_sADSWatchdogMS", False, True))
        BgTaskData.TagList.Add(New Form1.DataTag(fbPath + ".in_sADSWatchdogDeadDurationMS", False, True))

        'BgTaskData.TagList.Add(New Form1.DataTag(fbPath + ".in_sBatteryInfo",  False, True))

        BgTaskData.TagList.Add(New Form1.DataTag(fbPath + ".out_boStart_Button", False, True))
        BgTaskData.TagList.Add(New Form1.DataTag(fbPath + ".out_boBack_Button", False, True))

        BgTaskData.TagList.Add(New Form1.DataTag(fbPath + ".out_boA_Button", False, True))
        BgTaskData.TagList.Add(New Form1.DataTag(fbPath + ".out_boB_Button", False, True))
        BgTaskData.TagList.Add(New Form1.DataTag(fbPath + ".out_boX_Button", False, True))
        BgTaskData.TagList.Add(New Form1.DataTag(fbPath + ".out_boY_Button", False, True))

        BgTaskData.TagList.Add(New Form1.DataTag(fbPath + ".out_boLeftShoulder_Button", False, True))
        BgTaskData.TagList.Add(New Form1.DataTag(fbPath + ".out_boRightShoulder_Button", False, True))
        BgTaskData.TagList.Add(New Form1.DataTag(fbPath + ".out_boLeftStick_Button", False, True))
        BgTaskData.TagList.Add(New Form1.DataTag(fbPath + ".out_boRightStick_Button", False, True))

        BgTaskData.TagList.Add(New Form1.DataTag(fbPath + ".out_boDPad_Up_Button", False, True))
        BgTaskData.TagList.Add(New Form1.DataTag(fbPath + ".out_boDPad_Left_Button", False, True))
        BgTaskData.TagList.Add(New Form1.DataTag(fbPath + ".out_boDPad_Right_Button", False, True))
        BgTaskData.TagList.Add(New Form1.DataTag(fbPath + ".out_boDPad_Down_Button", False, True))

        BgTaskData.TagList.Add(New Form1.DataTag(fbPath + ".out_sLeftStick_X_Axis", False, True))
        BgTaskData.TagList.Add(New Form1.DataTag(fbPath + ".out_sLeftStick_Y_Axis", False, True))
        BgTaskData.TagList.Add(New Form1.DataTag(fbPath + ".out_sRightStick_X_Axis", False, True))
        BgTaskData.TagList.Add(New Form1.DataTag(fbPath + ".out_sRightStick_Y_Axis", False, True))

        BgTaskData.TagList.Add(New Form1.DataTag(fbPath + ".out_usiLeftTrigger_Axis", False, True))
        BgTaskData.TagList.Add(New Form1.DataTag(fbPath + ".out_usiRightTrigger_Axis", False, True))

        ' Add tags to our data object, ones that read from TwinCAT From PLC To VB
        BgTaskData.TagList.Add(New Form1.DataTag(fbPath + ".boIsActive", True, False))
        BgTaskData.TagList.Add(New Form1.DataTag(fbPath + ".boWatchdogFailureActive", True, False))
        BgTaskData.TagList.Add(New Form1.DataTag(fbPath + ".boControlerInputs", True, False))

        BgTaskData.TagList.Add(New Form1.DataTag(fbPath + ".tonUpdateRate.ET", True, False))

        'BgTaskData.TagList.Add(New Form1.DataTag(fbPath + ".sVibrateLength",  True, False))
        'BgTaskData.TagList.Add(New Form1.DataTag(fbPath + ".sVibrateIntensity",  True, False))

        'Public Class DataTag

        'Private _TagName As String
        'Private _IsRead As Boolean
        'Private _IsWritten As Boolean
        'Private _value As Object


    End Sub




End Module
