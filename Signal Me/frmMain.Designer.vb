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
        Me.rdbWithoutAPI = New System.Windows.Forms.RadioButton()
        Me.rdbWithAPI = New System.Windows.Forms.RadioButton()
        Me.rdbFromFile = New System.Windows.Forms.RadioButton()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.opnFile = New System.Windows.Forms.OpenFileDialog()
        Me.pnlFileBrowse = New System.Windows.Forms.Panel()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvMain = New System.Windows.Forms.DataGridView()
        Me.grpMode.SuspendLayout()
        Me.pnlFileBrowse.SuspendLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpMode
        '
        Me.grpMode.Controls.Add(Me.pnlFileBrowse)
        Me.grpMode.Controls.Add(Me.rdbFromFile)
        Me.grpMode.Controls.Add(Me.rdbWithoutAPI)
        Me.grpMode.Controls.Add(Me.rdbWithAPI)
        Me.grpMode.Location = New System.Drawing.Point(3, 2)
        Me.grpMode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpMode.Name = "grpMode"
        Me.grpMode.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpMode.Size = New System.Drawing.Size(642, 63)
        Me.grpMode.TabIndex = 28
        Me.grpMode.TabStop = False
        Me.grpMode.Text = "Mode"
        '
        'rdbWithoutAPI
        '
        Me.rdbWithoutAPI.AutoSize = True
        Me.rdbWithoutAPI.Location = New System.Drawing.Point(93, 24)
        Me.rdbWithoutAPI.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdbWithoutAPI.Name = "rdbWithoutAPI"
        Me.rdbWithoutAPI.Size = New System.Drawing.Size(102, 21)
        Me.rdbWithoutAPI.TabIndex = 1
        Me.rdbWithoutAPI.Text = "Without API"
        Me.rdbWithoutAPI.UseVisualStyleBackColor = True
        '
        'rdbWithAPI
        '
        Me.rdbWithAPI.AutoSize = True
        Me.rdbWithAPI.Location = New System.Drawing.Point(5, 24)
        Me.rdbWithAPI.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdbWithAPI.Name = "rdbWithAPI"
        Me.rdbWithAPI.Size = New System.Drawing.Size(82, 21)
        Me.rdbWithAPI.TabIndex = 0
        Me.rdbWithAPI.Text = "With API"
        Me.rdbWithAPI.UseVisualStyleBackColor = True
        '
        'rdbFromFile
        '
        Me.rdbFromFile.AutoSize = True
        Me.rdbFromFile.Checked = True
        Me.rdbFromFile.Location = New System.Drawing.Point(201, 24)
        Me.rdbFromFile.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdbFromFile.Name = "rdbFromFile"
        Me.rdbFromFile.Size = New System.Drawing.Size(87, 21)
        Me.rdbFromFile.TabIndex = 2
        Me.rdbFromFile.Text = "From File"
        Me.rdbFromFile.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStop.Location = New System.Drawing.Point(813, 16)
        Me.btnStop.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(139, 39)
        Me.btnStop.TabIndex = 30
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStart.Location = New System.Drawing.Point(661, 17)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(145, 39)
        Me.btnStart.TabIndex = 29
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lblProgress
        '
        Me.lblProgress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProgress.Location = New System.Drawing.Point(0, 581)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(960, 44)
        Me.lblProgress.TabIndex = 31
        Me.lblProgress.Text = "Progress Status"
        '
        'opnFile
        '
        '
        'pnlFileBrowse
        '
        Me.pnlFileBrowse.Controls.Add(Me.btnBrowse)
        Me.pnlFileBrowse.Controls.Add(Me.txtFilePath)
        Me.pnlFileBrowse.Controls.Add(Me.Label1)
        Me.pnlFileBrowse.Location = New System.Drawing.Point(304, 10)
        Me.pnlFileBrowse.Name = "pnlFileBrowse"
        Me.pnlFileBrowse.Size = New System.Drawing.Size(332, 48)
        Me.pnlFileBrowse.TabIndex = 3
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(297, 13)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(33, 23)
        Me.btnBrowse.TabIndex = 39
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtFilePath
        '
        Me.txtFilePath.Location = New System.Drawing.Point(69, 13)
        Me.txtFilePath.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(221, 22)
        Me.txtFilePath.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 17)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "File Path:"
        '
        'dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.AllowUserToDeleteRows = False
        Me.dgvMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMain.Location = New System.Drawing.Point(3, 71)
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.ReadOnly = True
        Me.dgvMain.RowHeadersVisible = False
        Me.dgvMain.RowTemplate.Height = 24
        Me.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMain.Size = New System.Drawing.Size(957, 497)
        Me.dgvMain.TabIndex = 32
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 629)
        Me.Controls.Add(Me.dgvMain)
        Me.Controls.Add(Me.lblProgress)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.grpMode)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Signal Me"
        Me.grpMode.ResumeLayout(False)
        Me.grpMode.PerformLayout()
        Me.pnlFileBrowse.ResumeLayout(False)
        Me.pnlFileBrowse.PerformLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvMain As DataGridView
End Class
