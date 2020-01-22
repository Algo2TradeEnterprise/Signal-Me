<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.grpMode = New System.Windows.Forms.GroupBox()
        Me.pnlFileBrowse = New System.Windows.Forms.Panel()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.lblFilePath = New System.Windows.Forms.Label()
        Me.rdbFromFile = New System.Windows.Forms.RadioButton()
        Me.rdbWithoutAPI = New System.Windows.Forms.RadioButton()
        Me.rdbWithAPI = New System.Windows.Forms.RadioButton()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.opnFile = New System.Windows.Forms.OpenFileDialog()
        Me.dtpckrTradingDate = New System.Windows.Forms.DateTimePicker()
        Me.lblFromDate = New System.Windows.Forms.Label()
        Me.sfdgvMain = New Syncfusion.WinForms.DataGrid.SfDataGrid()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.grpMode.SuspendLayout()
        Me.pnlFileBrowse.SuspendLayout()
        CType(Me.sfdgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpMode
        '
        Me.grpMode.Controls.Add(Me.pnlFileBrowse)
        Me.grpMode.Controls.Add(Me.rdbFromFile)
        Me.grpMode.Controls.Add(Me.rdbWithoutAPI)
        Me.grpMode.Controls.Add(Me.rdbWithAPI)
        Me.grpMode.Location = New System.Drawing.Point(2, 2)
        Me.grpMode.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpMode.Name = "grpMode"
        Me.grpMode.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpMode.Size = New System.Drawing.Size(482, 53)
        Me.grpMode.TabIndex = 28
        Me.grpMode.TabStop = False
        Me.grpMode.Text = "Mode"
        '
        'pnlFileBrowse
        '
        Me.pnlFileBrowse.Controls.Add(Me.btnBrowse)
        Me.pnlFileBrowse.Controls.Add(Me.txtFilePath)
        Me.pnlFileBrowse.Controls.Add(Me.lblFilePath)
        Me.pnlFileBrowse.Location = New System.Drawing.Point(228, 8)
        Me.pnlFileBrowse.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlFileBrowse.Name = "pnlFileBrowse"
        Me.pnlFileBrowse.Size = New System.Drawing.Size(249, 39)
        Me.pnlFileBrowse.TabIndex = 3
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(223, 11)
        Me.btnBrowse.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(25, 19)
        Me.btnBrowse.TabIndex = 39
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtFilePath
        '
        Me.txtFilePath.Location = New System.Drawing.Point(52, 11)
        Me.txtFilePath.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(167, 20)
        Me.txtFilePath.TabIndex = 38
        '
        'lblFilePath
        '
        Me.lblFilePath.AutoSize = True
        Me.lblFilePath.Location = New System.Drawing.Point(2, 13)
        Me.lblFilePath.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFilePath.Name = "lblFilePath"
        Me.lblFilePath.Size = New System.Drawing.Size(51, 13)
        Me.lblFilePath.TabIndex = 37
        Me.lblFilePath.Text = "File Path:"
        '
        'rdbFromFile
        '
        Me.rdbFromFile.AutoSize = True
        Me.rdbFromFile.Location = New System.Drawing.Point(151, 20)
        Me.rdbFromFile.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdbFromFile.Name = "rdbFromFile"
        Me.rdbFromFile.Size = New System.Drawing.Size(67, 17)
        Me.rdbFromFile.TabIndex = 2
        Me.rdbFromFile.Text = "From File"
        Me.rdbFromFile.UseVisualStyleBackColor = True
        '
        'rdbWithoutAPI
        '
        Me.rdbWithoutAPI.AutoSize = True
        Me.rdbWithoutAPI.Checked = True
        Me.rdbWithoutAPI.Location = New System.Drawing.Point(70, 20)
        Me.rdbWithoutAPI.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdbWithoutAPI.Name = "rdbWithoutAPI"
        Me.rdbWithoutAPI.Size = New System.Drawing.Size(82, 17)
        Me.rdbWithoutAPI.TabIndex = 1
        Me.rdbWithoutAPI.TabStop = True
        Me.rdbWithoutAPI.Text = "Without API"
        Me.rdbWithoutAPI.UseVisualStyleBackColor = True
        '
        'rdbWithAPI
        '
        Me.rdbWithAPI.AutoSize = True
        Me.rdbWithAPI.Location = New System.Drawing.Point(4, 20)
        Me.rdbWithAPI.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdbWithAPI.Name = "rdbWithAPI"
        Me.rdbWithAPI.Size = New System.Drawing.Size(67, 17)
        Me.rdbWithAPI.TabIndex = 0
        Me.rdbWithAPI.Text = "With API"
        Me.rdbWithAPI.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStop.Location = New System.Drawing.Point(921, 13)
        Me.btnStop.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(104, 32)
        Me.btnStop.TabIndex = 30
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStart.Location = New System.Drawing.Point(807, 14)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(109, 32)
        Me.btnStart.TabIndex = 29
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lblProgress
        '
        Me.lblProgress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProgress.Location = New System.Drawing.Point(0, 472)
        Me.lblProgress.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(1086, 36)
        Me.lblProgress.TabIndex = 31
        Me.lblProgress.Text = "Progress Status"
        '
        'opnFile
        '
        '
        'dtpckrTradingDate
        '
        Me.dtpckrTradingDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpckrTradingDate.Location = New System.Drawing.Point(529, 21)
        Me.dtpckrTradingDate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpckrTradingDate.Name = "dtpckrTradingDate"
        Me.dtpckrTradingDate.Size = New System.Drawing.Size(82, 20)
        Me.dtpckrTradingDate.TabIndex = 34
        '
        'lblFromDate
        '
        Me.lblFromDate.AutoSize = True
        Me.lblFromDate.Location = New System.Drawing.Point(496, 23)
        Me.lblFromDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFromDate.Name = "lblFromDate"
        Me.lblFromDate.Size = New System.Drawing.Size(33, 13)
        Me.lblFromDate.TabIndex = 33
        Me.lblFromDate.Text = "Date:"
        '
        'sfdgvMain
        '
        Me.sfdgvMain.AccessibleName = "Table"
        Me.sfdgvMain.AllowDraggingColumns = True
        Me.sfdgvMain.AllowEditing = False
        Me.sfdgvMain.AllowFiltering = True
        Me.sfdgvMain.AllowResizingColumns = True
        Me.sfdgvMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sfdgvMain.AutoGenerateColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoGenerateColumnsMode.SmartReset
        Me.sfdgvMain.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.AllCells
        Me.sfdgvMain.Location = New System.Drawing.Point(2, 59)
        Me.sfdgvMain.Name = "sfdgvMain"
        Me.sfdgvMain.PasteOption = Syncfusion.WinForms.DataGrid.Enums.PasteOptions.None
        Me.sfdgvMain.Size = New System.Drawing.Size(1023, 410)
        Me.sfdgvMain.TabIndex = 35
        Me.sfdgvMain.Text = "SfDataGrid1"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(632, 24)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(106, 13)
        Me.lblTime.TabIndex = 36
        Me.lblTime.Text = "Last Iteration Time: 0"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 511)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.sfdgvMain)
        Me.Controls.Add(Me.dtpckrTradingDate)
        Me.Controls.Add(Me.lblFromDate)
        Me.Controls.Add(Me.lblProgress)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.grpMode)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Signal Me"
        Me.grpMode.ResumeLayout(False)
        Me.grpMode.PerformLayout()
        Me.pnlFileBrowse.ResumeLayout(False)
        Me.pnlFileBrowse.PerformLayout()
        CType(Me.sfdgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpMode As GroupBox
    Friend WithEvents rdbFromFile As RadioButton
    Friend WithEvents rdbWithoutAPI As RadioButton
    Friend WithEvents rdbWithAPI As RadioButton
    Friend WithEvents btnStop As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents lblProgress As Label
    Friend WithEvents opnFile As OpenFileDialog
    Friend WithEvents pnlFileBrowse As Panel
    Friend WithEvents btnBrowse As Button
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents lblFilePath As Label
    Friend WithEvents dtpckrTradingDate As DateTimePicker
    Friend WithEvents lblFromDate As Label
    Friend WithEvents sfdgvMain As Syncfusion.WinForms.DataGrid.SfDataGrid
    Friend WithEvents lblTime As Label
End Class
