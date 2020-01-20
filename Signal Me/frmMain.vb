Imports System.Threading
Imports System.IO
Imports Utilities.DAL
Imports Utilities.Network
Imports System.Net
Imports System.Net.Http
Imports System.Text.RegularExpressions

Public Class frmMain

#Region "Common Delegates"
    Delegate Sub SetObjectEnableDisable_Delegate(ByVal [obj] As Object, ByVal [value] As Boolean)
    Public Sub SetObjectEnableDisable_ThreadSafe(ByVal [obj] As Object, ByVal [value] As Boolean)
        ' InvokeRequired required compares the thread ID of the calling thread to the thread ID of the creating thread.  
        ' If these threads are different, it returns true.  
        If [obj].InvokeRequired Then
            Dim MyDelegate As New SetObjectEnableDisable_Delegate(AddressOf SetObjectEnableDisable_ThreadSafe)
            Me.Invoke(MyDelegate, New Object() {[obj], [value]})
        Else
            [obj].Enabled = [value]
        End If
    End Sub

    Delegate Sub SetObjectVisible_Delegate(ByVal [obj] As Object, ByVal [value] As Boolean)
    Public Sub SetObjectVisible_ThreadSafe(ByVal [obj] As Object, ByVal [value] As Boolean)
        ' InvokeRequired required compares the thread ID of the calling thread to the thread ID of the creating thread.  
        ' If these threads are different, it returns true.  
        If [obj].InvokeRequired Then
            Dim MyDelegate As New SetObjectVisible_Delegate(AddressOf SetObjectVisible_ThreadSafe)
            Me.Invoke(MyDelegate, New Object() {[obj], [value]})
        Else
            [obj].Visible = [value]
        End If
    End Sub

    Delegate Sub SetLabelText_Delegate(ByVal [label] As Label, ByVal [text] As String)
    Public Sub SetLabelText_ThreadSafe(ByVal [label] As Label, ByVal [text] As String)
        ' InvokeRequired required compares the thread ID of the calling thread to the thread ID of the creating thread.  
        ' If these threads are different, it returns true.  
        If [label].InvokeRequired Then
            Dim MyDelegate As New SetLabelText_Delegate(AddressOf SetLabelText_ThreadSafe)
            Me.Invoke(MyDelegate, New Object() {[label], [text]})
        Else
            [label].Text = [text]
        End If
    End Sub

    Delegate Function GetLabelText_Delegate(ByVal [label] As Label) As String
    Public Function GetLabelText_ThreadSafe(ByVal [label] As Label) As String
        ' InvokeRequired required compares the thread ID of the calling thread to the thread ID of the creating thread.  
        ' If these threads are different, it returns true.  
        If [label].InvokeRequired Then
            Dim MyDelegate As New GetLabelText_Delegate(AddressOf GetLabelText_ThreadSafe)
            Return Me.Invoke(MyDelegate, New Object() {[label]})
        Else
            Return [label].Text
        End If
    End Function

    Delegate Sub SetLabelTag_Delegate(ByVal [label] As Label, ByVal [tag] As String)
    Public Sub SetLabelTag_ThreadSafe(ByVal [label] As Label, ByVal [tag] As String)
        ' InvokeRequired required compares the thread ID of the calling thread to the thread ID of the creating thread.  
        ' If these threads are different, it returns true.  
        If [label].InvokeRequired Then
            Dim MyDelegate As New SetLabelTag_Delegate(AddressOf SetLabelTag_ThreadSafe)
            Me.Invoke(MyDelegate, New Object() {[label], [tag]})
        Else
            [label].Tag = [tag]
        End If
    End Sub

    Delegate Function GetLabelTag_Delegate(ByVal [label] As Label) As String
    Public Function GetLabelTag_ThreadSafe(ByVal [label] As Label) As String
        ' InvokeRequired required compares the thread ID of the calling thread to the thread ID of the creating thread.  
        ' If these threads are different, it returns true.  
        If [label].InvokeRequired Then
            Dim MyDelegate As New GetLabelTag_Delegate(AddressOf GetLabelTag_ThreadSafe)
            Return Me.Invoke(MyDelegate, New Object() {[label]})
        Else
            Return [label].Tag
        End If
    End Function
    Delegate Sub SetToolStripLabel_Delegate(ByVal [toolStrip] As StatusStrip, ByVal [label] As ToolStripStatusLabel, ByVal [text] As String)
    Public Sub SetToolStripLabel_ThreadSafe(ByVal [toolStrip] As StatusStrip, ByVal [label] As ToolStripStatusLabel, ByVal [text] As String)
        ' InvokeRequired required compares the thread ID of the calling thread to the thread ID of the creating thread.  
        ' If these threads are different, it returns true.  
        If [toolStrip].InvokeRequired Then
            Dim MyDelegate As New SetToolStripLabel_Delegate(AddressOf SetToolStripLabel_ThreadSafe)
            Me.Invoke(MyDelegate, New Object() {[toolStrip], [label], [text]})
        Else
            [label].Text = [text]
        End If
    End Sub

    Delegate Function GetToolStripLabel_Delegate(ByVal [toolStrip] As StatusStrip, ByVal [label] As ToolStripLabel) As String
    Public Function GetToolStripLabel_ThreadSafe(ByVal [toolStrip] As StatusStrip, ByVal [label] As ToolStripLabel) As String
        ' InvokeRequired required compares the thread ID of the calling thread to the thread ID of the creating thread.  
        ' If these threads are different, it returns true.  
        If [toolStrip].InvokeRequired Then
            Dim MyDelegate As New GetToolStripLabel_Delegate(AddressOf GetToolStripLabel_ThreadSafe)
            Return Me.Invoke(MyDelegate, New Object() {[toolStrip], [label]})
        Else
            Return [label].Text
        End If
    End Function

    Delegate Function GetDateTimePickerValue_Delegate(ByVal [dateTimePicker] As DateTimePicker) As Date
    Public Function GetDateTimePickerValue_ThreadSafe(ByVal [dateTimePicker] As DateTimePicker) As Date
        ' InvokeRequired required compares the thread ID of the calling thread to the thread ID of the creating thread.  
        ' If these threads are different, it returns true.  
        If [dateTimePicker].InvokeRequired Then
            Dim MyDelegate As New GetDateTimePickerValue_Delegate(AddressOf GetDateTimePickerValue_ThreadSafe)
            Return Me.Invoke(MyDelegate, New DateTimePicker() {[dateTimePicker]})
        Else
            Return [dateTimePicker].Value
        End If
    End Function

    Delegate Function GetNumericUpDownValue_Delegate(ByVal [numericUpDown] As NumericUpDown) As Integer
    Public Function GetNumericUpDownValue_ThreadSafe(ByVal [numericUpDown] As NumericUpDown) As Integer
        ' InvokeRequired required compares the thread ID of the calling thread to the thread ID of the creating thread.  
        ' If these threads are different, it returns true.  
        If [numericUpDown].InvokeRequired Then
            Dim MyDelegate As New GetNumericUpDownValue_Delegate(AddressOf GetNumericUpDownValue_ThreadSafe)
            Return Me.Invoke(MyDelegate, New NumericUpDown() {[numericUpDown]})
        Else
            Return [numericUpDown].Value
        End If
    End Function

    Delegate Function GetComboBoxIndex_Delegate(ByVal [combobox] As ComboBox) As Integer
    Public Function GetComboBoxIndex_ThreadSafe(ByVal [combobox] As ComboBox) As Integer
        ' InvokeRequired required compares the thread ID of the calling thread to the thread ID of the creating thread.  
        ' If these threads are different, it returns true.  
        If [combobox].InvokeRequired Then
            Dim MyDelegate As New GetComboBoxIndex_Delegate(AddressOf GetComboBoxIndex_ThreadSafe)
            Return Me.Invoke(MyDelegate, New Object() {[combobox]})
        Else
            Return [combobox].SelectedIndex
        End If
    End Function

    Delegate Function GetComboBoxItem_Delegate(ByVal [ComboBox] As ComboBox) As String
    Public Function GetComboBoxItem_ThreadSafe(ByVal [ComboBox] As ComboBox) As String
        ' InvokeRequired required compares the thread ID of the calling thread to the thread ID of the creating thread.  
        ' If these threads are different, it returns true.  
        If [ComboBox].InvokeRequired Then
            Dim MyDelegate As New GetComboBoxItem_Delegate(AddressOf GetComboBoxItem_ThreadSafe)
            Return Me.Invoke(MyDelegate, New Object() {[ComboBox]})
        Else
            Return [ComboBox].SelectedItem.ToString
        End If
    End Function

    Delegate Function GetTextBoxText_Delegate(ByVal [textBox] As TextBox) As String
    Public Function GetTextBoxText_ThreadSafe(ByVal [textBox] As TextBox) As String
        ' InvokeRequired required compares the thread ID of the calling thread to the thread ID of the creating thread.  
        ' If these threads are different, it returns true.  
        If [textBox].InvokeRequired Then
            Dim MyDelegate As New GetTextBoxText_Delegate(AddressOf GetTextBoxText_ThreadSafe)
            Return Me.Invoke(MyDelegate, New Object() {[textBox]})
        Else
            Return [textBox].Text
        End If
    End Function

    Delegate Function GetCheckBoxChecked_Delegate(ByVal [checkBox] As CheckBox) As Boolean
    Public Function GetCheckBoxChecked_ThreadSafe(ByVal [checkBox] As CheckBox) As Boolean
        ' InvokeRequired required compares the thread ID of the calling thread to the thread ID of the creating thread.  
        ' If these threads are different, it returns true.  
        If [checkBox].InvokeRequired Then
            Dim MyDelegate As New GetCheckBoxChecked_Delegate(AddressOf GetCheckBoxChecked_ThreadSafe)
            Return Me.Invoke(MyDelegate, New Object() {[checkBox]})
        Else
            Return [checkBox].Checked
        End If
    End Function

    Delegate Function GetRadioButtonChecked_Delegate(ByVal [radioButton] As RadioButton) As Boolean
    Public Function GetRadioButtonChecked_ThreadSafe(ByVal [radioButton] As RadioButton) As Boolean
        ' InvokeRequired required compares the thread ID of the calling thread to the thread ID of the creating thread.  
        ' If these threads are different, it returns true.  
        If [radioButton].InvokeRequired Then
            Dim MyDelegate As New GetRadioButtonChecked_Delegate(AddressOf GetRadioButtonChecked_ThreadSafe)
            Return Me.Invoke(MyDelegate, New Object() {[radioButton]})
        Else
            Return [radioButton].Checked
        End If
    End Function

    Delegate Sub SetDatagridBindDatatable_Delegate(ByVal [datagrid] As DataGridView, ByVal [table] As DataTable)
    Public Sub SetDatagridBindDatatable_ThreadSafe(ByVal [datagrid] As DataGridView, ByVal [table] As DataTable)
        ' InvokeRequired required compares the thread ID of the calling thread to the thread ID of the creating thread.  
        ' If these threads are different, it returns true.  
        If [datagrid].InvokeRequired Then
            Dim MyDelegate As New SetDatagridBindDatatable_Delegate(AddressOf SetDatagridBindDatatable_ThreadSafe)
            Me.Invoke(MyDelegate, New Object() {[datagrid], [table]})
        Else
            [datagrid].DataSource = [table]
            [datagrid].Refresh()
        End If
    End Sub
#End Region

#Region "Event Handlers"
    Private Sub OnHeartbeat(message As String)
        SetLabelText_ThreadSafe(lblProgress, message)
    End Sub
    Private Sub OnDocumentDownloadComplete()
        'OnHeartbeat("Document download compelete")
    End Sub
    Private Sub OnDocumentRetryStatus(currentTry As Integer, totalTries As Integer)
        OnHeartbeat(String.Format("Try #{0}/{1}: Connecting...", currentTry, totalTries))
    End Sub
    Public Sub OnWaitingFor(ByVal elapsedSecs As Integer, ByVal totalSecs As Integer, ByVal msg As String)
        OnHeartbeat(String.Format("{0}, waiting {1}/{2} secs", msg, elapsedSecs, totalSecs))
    End Sub
#End Region

#Region "Enum"
    Enum DataType
        EOD = 1
        Intraday
    End Enum
#End Region

    Private canceller As CancellationTokenSource

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        canceller.Cancel()
    End Sub

    Private Sub rdbFromFile_CheckedChanged(sender As Object, e As EventArgs) Handles rdbFromFile.CheckedChanged
        SetObjectVisible_ThreadSafe(pnlFileBrowse, True)
    End Sub

    Private Sub rdbWithoutAPI_CheckedChanged(sender As Object, e As EventArgs) Handles rdbWithoutAPI.CheckedChanged
        SetObjectVisible_ThreadSafe(pnlFileBrowse, False)
    End Sub

    Private Sub rdbWithAPI_CheckedChanged(sender As Object, e As EventArgs) Handles rdbWithAPI.CheckedChanged
        SetObjectVisible_ThreadSafe(pnlFileBrowse, False)
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        opnFile.Filter = "|*.csv"
        opnFile.ShowDialog()
    End Sub

    Private Sub opnFile_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles opnFile.FileOk
        Dim extension As String = Path.GetExtension(opnFile.FileName)
        If extension = ".csv" Then
            txtFilePath.Text = opnFile.FileName
        Else
            MsgBox("File Type not supported. Please Try again.", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetObjectEnableDisable_ThreadSafe(btnStop, False)

        rdbWithAPI.Checked = My.Settings.WithAPI
        rdbWithoutAPI.Checked = My.Settings.WithoutAPI
        rdbFromFile.Checked = My.Settings.FromFile
        txtFilePath.Text = My.Settings.FilePath
    End Sub

    Private Async Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        SetObjectEnableDisable_ThreadSafe(btnStart, False)
        SetObjectEnableDisable_ThreadSafe(btnStop, True)
        SetObjectEnableDisable_ThreadSafe(grpMode, False)

        My.Settings.WithAPI = rdbWithAPI.Checked
        My.Settings.WithoutAPI = rdbWithoutAPI.Checked
        My.Settings.FromFile = rdbFromFile.Checked
        My.Settings.FilePath = txtFilePath.Text
        My.Settings.Save()

        canceller = New CancellationTokenSource
        Await Task.Run(AddressOf StartProcessingAsync).ConfigureAwait(False)
    End Sub

    Private Async Function StartProcessingAsync() As Task
        Try
            Dim workableStockList As List(Of InstrumentDetails) = Nothing
            Dim allStockList As Dictionary(Of String, Date) = Await GetFutureStockList(Now.Date).ConfigureAwait(False)
            Dim cashStockList As Dictionary(Of String, String) = Await GetCashStockList(Now.Date).ConfigureAwait(False)
            If allStockList IsNot Nothing AndAlso allStockList.Count > 0 Then
                Dim ctr As Integer = 0
                For Each runningStock In allStockList
                    ctr += 1
                    OnHeartbeat(String.Format("Getting option stocklist for {0}. #{1}/{2}", runningStock.Key, ctr, allStockList.Count))
                    Dim cashStockName As String = runningStock.Key
                    If runningStock.Key = "BANKNIFTY" Then cashStockName = "NIFTY BANK"
                    If runningStock.Key = "NIFTY" Then cashStockName = "NIFTY 50"
                    If cashStockList.ContainsKey(cashStockName) Then
                        Dim optionStockList As Dictionary(Of String, OptionInstrumentDetails) = Await GetOptionStockList(runningStock.Key, Now.Date, runningStock.Value).ConfigureAwait(False)
                        If optionStockList IsNot Nothing AndAlso optionStockList.Count > 0 Then
                            Dim workingInstrument As InstrumentDetails = New InstrumentDetails With {
                                    .OriginatingInstrument = runningStock.Key,
                                    .CashTradingSymbol = cashStockName,
                                    .CashInstrumentToken = cashStockList(cashStockName),
                                    .OptionInstruments = optionStockList
                                }

                            If workableStockList Is Nothing Then workableStockList = New List(Of InstrumentDetails)
                            workableStockList.Add(workingInstrument)
                        End If
                    End If
                Next
            End If
            If workableStockList IsNot Nothing AndAlso workableStockList.Count > 0 Then
                Dim dt As DataTable = New DataTable
                dt.Columns.Add("Intrument")
                dt.Columns.Add("Close")
                dt.Columns.Add("Sum Of Puts OI")
                dt.Columns.Add("Sum Of Calls OI")
                dt.Columns.Add("PCC")
                dt.Columns.Add("CPC")

                Dim ctr As Integer = 0
                For Each runningStock In workableStockList
                    ctr += 1
                    OnHeartbeat(String.Format("Processing data for {0}. #{1}/{2}", runningStock.OriginatingInstrument, ctr, workableStockList.Count))
                    Dim eodData As Dictionary(Of Date, Payload) = Await GetHistoricalDataAsync(runningStock.CashInstrumentToken, runningStock.CashTradingSymbol, Now.Date, Now.Date.AddDays(-15), DataType.EOD, Nothing)
                    If eodData IsNot Nothing AndAlso eodData.Count > 0 Then
                        runningStock.Open = eodData.LastOrDefault.Value.Open
                        runningStock.Low = eodData.LastOrDefault.Value.Low
                        runningStock.High = eodData.LastOrDefault.Value.High
                        runningStock.Close = eodData.LastOrDefault.Value.Close
                        runningStock.Volume = eodData.LastOrDefault.Value.Volume
                        runningStock.LTP = eodData.LastOrDefault.Value.Close
                        runningStock.PreviousClose = eodData.LastOrDefault.Value.PreviousPayload.Close

                        If runningStock.OptionInstruments IsNot Nothing AndAlso runningStock.OptionInstruments.Count > 0 Then
                            For Each runningOptionInstrument In runningStock.OptionInstruments
                                Dim optionEodData As Dictionary(Of Date, Payload) = Await GetHistoricalDataAsync(runningOptionInstrument.Value.TradingSymbol, runningOptionInstrument.Value.InstrumentToken, Now.Date, Now.Date, DataType.EOD, Nothing)
                                If optionEodData IsNot Nothing AndAlso optionEodData.Count > 0 Then
                                    If runningOptionInstrument.Value.InstrumentType = "PE" Then
                                        If runningStock.PEInstrumentsPayloads Is Nothing Then runningStock.PEInstrumentsPayloads = New Dictionary(Of String, Payload)
                                        runningStock.PEInstrumentsPayloads.Add(runningOptionInstrument.Value.StrikePrice, optionEodData.Values.LastOrDefault)
                                    ElseIf runningOptionInstrument.Value.InstrumentType = "CE" Then
                                        If runningStock.CEInstrumentsPayloads Is Nothing Then runningStock.CEInstrumentsPayloads = New Dictionary(Of String, Payload)
                                        runningStock.CEInstrumentsPayloads.Add(runningOptionInstrument.Value.StrikePrice, optionEodData.Values.LastOrDefault)
                                    End If
                                End If
                            Next
                        End If

                        If runningStock.PEInstrumentsPayloads IsNot Nothing AndAlso runningStock.PEInstrumentsPayloads.Count > 0 Then
                            runningStock.SumOfPutsOI = runningStock.PEInstrumentsPayloads.Sum(Function(x)
                                                                                                  If CDec(x.Key) < runningStock.Close Then
                                                                                                      Return x.Value.OI
                                                                                                  Else
                                                                                                      Return 0
                                                                                                  End If
                                                                                              End Function)
                        End If

                        If runningStock.CEInstrumentsPayloads IsNot Nothing AndAlso runningStock.CEInstrumentsPayloads.Count > 0 Then
                            runningStock.SumOfCallsOI = runningStock.CEInstrumentsPayloads.Sum(Function(x)
                                                                                                   If CDec(x.Key) > runningStock.Close Then
                                                                                                       Return x.Value.OI
                                                                                                   Else
                                                                                                       Return 0
                                                                                                   End If
                                                                                               End Function)
                        End If

                        Dim row As DataRow = dt.NewRow
                        row("Intrument") = runningStock.OriginatingInstrument
                        row("Close") = runningStock.Close
                        row("Sum Of Puts OI") = runningStock.SumOfPutsOI
                        row("Sum Of Calls OI") = runningStock.SumOfCallsOI
                        row("PCC") = runningStock.PCC
                        row("CPC") = runningStock.CPC
                        dt.Rows.Add(row)
                    End If
                Next
            End If
        Catch cex As OperationCanceledException
            MsgBox(cex.Message)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SetObjectEnableDisable_ThreadSafe(btnStart, True)
            SetObjectEnableDisable_ThreadSafe(btnStop, False)
            SetObjectEnableDisable_ThreadSafe(grpMode, True)
            OnHeartbeat("Process Complete")
        End Try
    End Function

#Region "Private Functions"
    Private Async Function GetHistoricalDataAsync(ByVal instrumentToken As String, ByVal tradingSymbol As String, ByVal startDate As Date, ByVal endDate As Date, ByVal typeOfData As DataType, ByVal zerodhaDetails As ZerodhaLogin) As Task(Of Dictionary(Of Date, Payload))
        Dim ret As Dictionary(Of Date, Payload) = Nothing
        Dim AWSZerodhaEODHistoricalURL As String = "https://kitecharts-aws.zerodha.com/api/chart/{0}/day?oi=1&api_key=kitefront&access_token=K&from={1}&to={2}"
        Dim AWSZerodhaIntradayHistoricalURL As String = "https://kitecharts-aws.zerodha.com/api/chart/{0}/minute?oi=1&api_key=kitefront&access_token=K&from={1}&to={2}"
        Dim ZerodhaEODHistoricalURL As String = "https://kite.zerodha.com/oms/instruments/historical/{0}/day?&oi=1&from={1}&to={2}"
        Dim ZerodhaIntradayHistoricalURL As String = "https://kite.zerodha.com/oms/instruments/historical/{0}/minute?oi=1&from={1}&to={2}"
        Dim ZerodhaHistoricalURL As String = Nothing
        Select Case typeOfData
            Case DataType.EOD
                If GetRadioButtonChecked_ThreadSafe(rdbWithAPI) Then
                    ZerodhaHistoricalURL = ZerodhaEODHistoricalURL
                ElseIf GetRadioButtonChecked_ThreadSafe(rdbWithoutAPI) Then
                    ZerodhaHistoricalURL = AWSZerodhaEODHistoricalURL
                End If
            Case DataType.Intraday
                If GetRadioButtonChecked_ThreadSafe(rdbWithAPI) Then
                    ZerodhaHistoricalURL = ZerodhaIntradayHistoricalURL
                ElseIf GetRadioButtonChecked_ThreadSafe(rdbWithoutAPI) Then
                    ZerodhaHistoricalURL = AWSZerodhaIntradayHistoricalURL
                End If
        End Select
        If ZerodhaHistoricalURL IsNot Nothing AndAlso instrumentToken IsNot Nothing AndAlso instrumentToken <> "" Then
            Dim historicalDataURL As String = String.Format(ZerodhaHistoricalURL, instrumentToken, startDate.ToString("yyyy-MM-dd"), endDate.ToString("yyyy-MM-dd"))
            OnHeartbeat(String.Format("Fetching historical Data: {0}", historicalDataURL))
            Dim historicalCandlesJSONDict As Dictionary(Of String, Object) = Nothing

            ServicePointManager.Expect100Continue = False
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
            ServicePointManager.ServerCertificateValidationCallback = Function(s, Ca, CaC, sslPE)
                                                                          Return True
                                                                      End Function

            If GetRadioButtonChecked_ThreadSafe(rdbWithAPI) Then
                Dim proxyToBeUsed As HttpProxy = Nothing
                Using browser As New HttpBrowser(proxyToBeUsed, Net.DecompressionMethods.GZip Or DecompressionMethods.Deflate Or DecompressionMethods.None, New TimeSpan(0, 1, 0), canceller)
                    AddHandler browser.DocumentDownloadComplete, AddressOf OnDocumentDownloadComplete
                    AddHandler browser.Heartbeat, AddressOf OnHeartbeat
                    AddHandler browser.WaitingFor, AddressOf OnWaitingFor
                    AddHandler browser.DocumentRetryStatus, AddressOf OnDocumentRetryStatus

                    Dim headers As New Dictionary(Of String, String)
                    headers.Add("Host", "kite.zerodha.com")
                    headers.Add("Accept", "*/*")
                    headers.Add("Accept-Encoding", "gzip, deflate")
                    headers.Add("Accept-Language", "en-US,en;q=0.9,hi;q=0.8,ko;q=0.7")
                    headers.Add("Authorization", String.Format("enctoken {0}", zerodhaDetails.ENCToken))
                    headers.Add("Referer", "https://kite.zerodha.com/static/build/chart.html?v=2.4.0")
                    headers.Add("sec-fetch-mode", "cors")
                    headers.Add("sec-fetch-site", "same-origin")
                    headers.Add("Connection", "keep-alive")

                    canceller.Token.ThrowIfCancellationRequested()
                    Dim l As Tuple(Of Uri, Object) = Await browser.NonPOSTRequestAsync(historicalDataURL,
                                                                                            HttpMethod.Get,
                                                                                            Nothing,
                                                                                            False,
                                                                                            headers,
                                                                                            True,
                                                                                            "application/json").ConfigureAwait(False)
                    canceller.Token.ThrowIfCancellationRequested()
                    If l IsNot Nothing AndAlso l.Item2 IsNot Nothing Then
                        historicalCandlesJSONDict = l.Item2
                    End If

                    RemoveHandler browser.DocumentDownloadComplete, AddressOf OnDocumentDownloadComplete
                    RemoveHandler browser.Heartbeat, AddressOf OnHeartbeat
                    RemoveHandler browser.WaitingFor, AddressOf OnWaitingFor
                    RemoveHandler browser.DocumentRetryStatus, AddressOf OnDocumentRetryStatus
                End Using
            ElseIf GetRadioButtonChecked_ThreadSafe(rdbWithoutAPI) OrElse GetRadioButtonChecked_ThreadSafe(rdbFromFile) Then
                Dim proxyToBeUsed As HttpProxy = Nothing
                Using browser As New HttpBrowser(proxyToBeUsed, Net.DecompressionMethods.GZip, New TimeSpan(0, 1, 0), canceller)
                    AddHandler browser.DocumentDownloadComplete, AddressOf OnDocumentDownloadComplete
                    AddHandler browser.Heartbeat, AddressOf OnHeartbeat
                    AddHandler browser.WaitingFor, AddressOf OnWaitingFor
                    AddHandler browser.DocumentRetryStatus, AddressOf OnDocumentRetryStatus

                    canceller.Token.ThrowIfCancellationRequested()
                    Dim l As Tuple(Of Uri, Object) = Await browser.NonPOSTRequestAsync(historicalDataURL,
                                                                                        HttpMethod.Get,
                                                                                        Nothing,
                                                                                        True,
                                                                                        Nothing,
                                                                                        True,
                                                                                        "application/json").ConfigureAwait(False)
                    canceller.Token.ThrowIfCancellationRequested()
                    If l IsNot Nothing AndAlso l.Item2 IsNot Nothing Then
                        historicalCandlesJSONDict = l.Item2
                    End If

                    RemoveHandler browser.DocumentDownloadComplete, AddressOf OnDocumentDownloadComplete
                    RemoveHandler browser.Heartbeat, AddressOf OnHeartbeat
                    RemoveHandler browser.WaitingFor, AddressOf OnWaitingFor
                    RemoveHandler browser.DocumentRetryStatus, AddressOf OnDocumentRetryStatus
                End Using
            End If

            If historicalCandlesJSONDict IsNot Nothing AndAlso historicalCandlesJSONDict.Count > 0 AndAlso
                historicalCandlesJSONDict.ContainsKey("data") Then
                Dim historicalCandlesDict As Dictionary(Of String, Object) = historicalCandlesJSONDict("data")
                If historicalCandlesDict.ContainsKey("candles") AndAlso historicalCandlesDict("candles").count > 0 Then
                    Dim historicalCandles As ArrayList = historicalCandlesDict("candles")
                    OnHeartbeat(String.Format("Generating Payload for {0}", tradingSymbol))
                    Dim previousPayload As Payload = Nothing
                    For Each historicalCandle As ArrayList In historicalCandles
                        canceller.Token.ThrowIfCancellationRequested()
                        Dim runningSnapshotTime As Date = Utilities.Time.GetDateTimeTillMinutes(historicalCandle(0))

                        Dim runningPayload As Payload = New Payload
                        With runningPayload
                            .PayloadDate = Utilities.Time.GetDateTimeTillMinutes(historicalCandle(0))
                            .TradingSymbol = tradingSymbol
                            .Open = historicalCandle(1)
                            .High = historicalCandle(2)
                            .Low = historicalCandle(3)
                            .Close = historicalCandle(4)
                            .Volume = historicalCandle(5)
                            .OI = historicalCandle(6)
                            .PreviousPayload = previousPayload
                        End With
                        If ret Is Nothing Then ret = New Dictionary(Of Date, Payload)
                        ret.Add(runningSnapshotTime, runningPayload)
                        previousPayload = runningPayload
                    Next
                End If
            End If
        End If
        Return ret
    End Function

    Public Async Function GetFutureStockList(ByVal tradingDate As Date) As Task(Of Dictionary(Of String, Date))
        Dim ret As Dictionary(Of String, Date) = Nothing

        Using sqlHlpr As New MySQLDBHelper(My.Settings.ServerName, "local_stock", "3306", "rio", "speech123", canceller)
            AddHandler sqlHlpr.Heartbeat, AddressOf OnHeartbeat

            Dim queryString As String = "SELECT `TRADING_SYMBOL`,`EXPIRY` FROM `active_instruments_futures` WHERE `AS_ON_DATE`='{0}' AND `SEGMENT`='NFO-FUT'"
            queryString = String.Format(queryString, tradingDate.ToString("yyyy-MM-dd"))

            Dim dt As DataTable = Await sqlHlpr.RunSelectAsync(queryString).ConfigureAwait(False)
            canceller.Token.ThrowIfCancellationRequested()

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                Dim allStock As Dictionary(Of String, Date) = Nothing
                For i = 0 To dt.Rows.Count - 1
                    If Not IsDBNull(dt.Rows(i).Item(0)) AndAlso Not IsDBNull(dt.Rows(i).Item(1)) Then
                        Dim tradingSymbol As String = dt.Rows(i).Item(0).ToString.ToUpper
                        Dim expiry As Date = Convert.ToDateTime(dt.Rows(i).Item(1))

                        Dim pattern As String = "([0-9][0-9]JAN)|([0-9][0-9]FEB)|([0-9][0-9]MAR)|([0-9][0-9]APR)|([0-9][0-9]MAY)|([0-9][0-9]JUN)|([0-9][0-9]JUL)|([0-9][0-9]AUG)|([0-9][0-9]SEP)|([0-9][0-9]OCT)|([0-9][0-9]NOV)|([0-9][0-9]DEC)"
                        If Regex.Matches(tradingSymbol, pattern).Count <= 1 Then
                            If allStock Is Nothing Then allStock = New Dictionary(Of String, Date)
                            allStock.Add(tradingSymbol, expiry)
                        End If
                    End If
                Next
                If allStock IsNot Nothing AndAlso allStock.Count > 0 Then
                    For Each runningStock In allStock
                        If ret Is Nothing Then ret = New Dictionary(Of String, Date)
                        Dim intrumentName As String = runningStock.Key.Remove(runningStock.Key.Count - 8)
                        If Not ret.ContainsKey(intrumentName) Then
                            Dim allInstrumentDetails As IEnumerable(Of KeyValuePair(Of String, Date)) = allStock.Where(Function(x)
                                                                                                                           Return x.Key.Remove(x.Key.Count - 8) = intrumentName
                                                                                                                       End Function)
                            If allInstrumentDetails IsNot Nothing AndAlso allInstrumentDetails.Count > 0 Then
                                Dim minExpiry As Date = allInstrumentDetails.Min(Function(x)
                                                                                     Return x.Value
                                                                                 End Function)

                                If ret Is Nothing Then ret = New Dictionary(Of String, Date)
                                ret.Add(intrumentName, minExpiry)
                            End If
                        End If
                    Next
                End If
            End If
        End Using
        Return ret
    End Function

    Public Async Function GetCashStockList(ByVal tradingDate As Date) As Task(Of Dictionary(Of String, String))
        Dim ret As Dictionary(Of String, String) = Nothing

        Using sqlHlpr As New MySQLDBHelper(My.Settings.ServerName, "local_stock", "3306", "rio", "speech123", canceller)
            AddHandler sqlHlpr.Heartbeat, AddressOf OnHeartbeat

            Dim queryString As String = "SELECT DISTINCT(`INSTRUMENT_TOKEN`),`TRADING_SYMBOL` FROM `active_instruments_cash` WHERE `AS_ON_DATE`='{0}'"
            queryString = String.Format(queryString, tradingDate.ToString("yyyy-MM-dd"))

            Dim dt As DataTable = Await sqlHlpr.RunSelectAsync(queryString).ConfigureAwait(False)
            canceller.Token.ThrowIfCancellationRequested()

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                For i = 0 To dt.Rows.Count - 1
                    canceller.Token.ThrowIfCancellationRequested()
                    If Not IsDBNull(dt.Rows(i).Item(0)) AndAlso Not IsDBNull(dt.Rows(i).Item(1)) Then
                        If ret Is Nothing Then ret = New Dictionary(Of String, String)
                        ret.Add(dt.Rows(i).Item(1), dt.Rows(i).Item(0))
                    End If
                Next
            End If
        End Using
        Return ret
    End Function

    Public Async Function GetOptionStockList(ByVal instrumentName As String, ByVal tradingDate As Date, ByVal mainInstrumentExpiry As Date) As Task(Of Dictionary(Of String, OptionInstrumentDetails))
        Dim ret As Dictionary(Of String, OptionInstrumentDetails) = Nothing

        Using sqlHlpr As New MySQLDBHelper(My.Settings.ServerName, "local_stock", "3306", "rio", "speech123", canceller)
            'AddHandler sqlHlpr.Heartbeat, AddressOf OnHeartbeat

            Dim queryString As String = "SELECT `INSTRUMENT_TOKEN`,`TRADING_SYMBOL`,`EXPIRY`
                                            FROM `active_instruments_futures`
                                            WHERE `TRADING_SYMBOL` REGEXP '^{0}[0-9][0-9]*'
                                            AND `AS_ON_DATE`='{1}'
                                            AND `SEGMENT`='NFO-OPT'
                                            AND `EXPIRY`=(SELECT MIN(`EXPIRY`)
                                            FROM `active_instruments_futures`
                                            WHERE `TRADING_SYMBOL` REGEXP '^{0}[0-9][0-9]*'
                                            AND `AS_ON_DATE`='{1}')"
            queryString = String.Format(queryString, instrumentName, tradingDate.ToString("yyyy-MM-dd"))

            Dim dt As DataTable = Await sqlHlpr.RunSelectAsync(queryString).ConfigureAwait(False)
            canceller.Token.ThrowIfCancellationRequested()

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                For i = 0 To dt.Rows.Count - 1
                    canceller.Token.ThrowIfCancellationRequested()
                    If Not IsDBNull(dt.Rows(i).Item(0)) AndAlso Not IsDBNull(dt.Rows(i).Item(1)) AndAlso Not IsDBNull(dt.Rows(i).Item(2)) Then
                        Dim tradingSymbol As String = dt.Rows(i).Item(1)
                        Dim expiry As Date = Convert.ToDateTime(dt.Rows(i).Item(2))
                        Dim concatStr As String = Nothing
                        If mainInstrumentExpiry <> Date.MinValue AndAlso mainInstrumentExpiry = expiry Then
                            'Monthly
                            concatStr = expiry.ToString("yyMMM")
                        Else
                            'Weekly
                            If expiry.Month > 9 Then
                                concatStr = String.Format("{0}{1}{2}", expiry.ToString("yy"), Microsoft.VisualBasic.Left(expiry.ToString("MMM"), 1), expiry.ToString("dd"))
                            Else
                                concatStr = expiry.ToString("yyMdd")
                            End If
                        End If
                        Dim prefix As String = String.Format("{0}{1}", instrumentName, concatStr.ToUpper)
                        Dim instrumentType As String = Microsoft.VisualBasic.Right(tradingSymbol, 2)
                        Dim strikePrice As String = Utilities.Strings.GetTextBetween(prefix, instrumentType, tradingSymbol)
                        If IsNumeric(strikePrice) Then
                            Dim optionInstrument As OptionInstrumentDetails = New OptionInstrumentDetails With {
                                        .InstrumentToken = dt.Rows(i).Item(0),
                                        .TradingSymbol = tradingSymbol,
                                        .Expiry = expiry,
                                        .InstrumentType = instrumentType,
                                        .StrikePrice = strikePrice
                                    }

                            If ret Is Nothing Then ret = New Dictionary(Of String, OptionInstrumentDetails)
                            ret.Add(optionInstrument.TradingSymbol, optionInstrument)
                        End If
                    End If
                Next
            End If
        End Using
        Return ret
    End Function
#End Region
End Class
