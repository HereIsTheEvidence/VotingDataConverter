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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtDataFile = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnDataIn = New System.Windows.Forms.Button()
        Me.btnHeaderIn = New System.Windows.Forms.Button()
        Me.txtHeaderFile = New System.Windows.Forms.TextBox()
        Me.btnSingleDataFile = New System.Windows.Forms.Button()
        Me.txtSingleFile = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabSingle = New System.Windows.Forms.TabPage()
        Me.TabSeparate = New System.Windows.Forms.TabPage()
        Me.cbMakeExcel = New System.Windows.Forms.CheckBox()
        Me.btnUncheck71to150 = New System.Windows.Forms.Button()
        Me.btnUncheckAll = New System.Windows.Forms.Button()
        Me.btnCheckAll = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ColumnsPanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.lblSkippedLines = New System.Windows.Forms.Label()
        Me.lblWorking = New System.Windows.Forms.Label()
        Me.lblLinesDone = New System.Windows.Forms.Label()
        Me.btnUncheck31to70 = New System.Windows.Forms.Button()
        Me.cbFileHasHeader = New System.Windows.Forms.CheckBox()
        Me.TabControl1.SuspendLayout()
        Me.TabSingle.SuspendLayout()
        Me.TabSeparate.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(12, 28)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(129, 23)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save Reformatted File"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtDataFile
        '
        Me.txtDataFile.Location = New System.Drawing.Point(141, 29)
        Me.txtDataFile.Name = "txtDataFile"
        Me.txtDataFile.Size = New System.Drawing.Size(492, 20)
        Me.txtDataFile.TabIndex = 1
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnDataIn
        '
        Me.btnDataIn.Location = New System.Drawing.Point(5, 30)
        Me.btnDataIn.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDataIn.Name = "btnDataIn"
        Me.btnDataIn.Size = New System.Drawing.Size(131, 19)
        Me.btnDataIn.TabIndex = 2
        Me.btnDataIn.Text = "Data File"
        Me.btnDataIn.UseVisualStyleBackColor = True
        '
        'btnHeaderIn
        '
        Me.btnHeaderIn.Location = New System.Drawing.Point(5, 5)
        Me.btnHeaderIn.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHeaderIn.Name = "btnHeaderIn"
        Me.btnHeaderIn.Size = New System.Drawing.Size(131, 19)
        Me.btnHeaderIn.TabIndex = 4
        Me.btnHeaderIn.Text = "Header File"
        Me.btnHeaderIn.UseVisualStyleBackColor = True
        '
        'txtHeaderFile
        '
        Me.txtHeaderFile.Location = New System.Drawing.Point(141, 4)
        Me.txtHeaderFile.Name = "txtHeaderFile"
        Me.txtHeaderFile.Size = New System.Drawing.Size(492, 20)
        Me.txtHeaderFile.TabIndex = 3
        '
        'btnSingleDataFile
        '
        Me.btnSingleDataFile.Location = New System.Drawing.Point(4, 9)
        Me.btnSingleDataFile.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSingleDataFile.Name = "btnSingleDataFile"
        Me.btnSingleDataFile.Size = New System.Drawing.Size(131, 19)
        Me.btnSingleDataFile.TabIndex = 7
        Me.btnSingleDataFile.Text = "Data File"
        Me.btnSingleDataFile.UseVisualStyleBackColor = True
        '
        'txtSingleFile
        '
        Me.txtSingleFile.Location = New System.Drawing.Point(140, 8)
        Me.txtSingleFile.Name = "txtSingleFile"
        Me.txtSingleFile.Size = New System.Drawing.Size(492, 20)
        Me.txtSingleFile.TabIndex = 6
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabSingle)
        Me.TabControl1.Controls.Add(Me.TabSeparate)
        Me.TabControl1.Location = New System.Drawing.Point(2, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(716, 85)
        Me.TabControl1.TabIndex = 8
        '
        'TabSingle
        '
        Me.TabSingle.Controls.Add(Me.cbFileHasHeader)
        Me.TabSingle.Controls.Add(Me.txtSingleFile)
        Me.TabSingle.Controls.Add(Me.btnSingleDataFile)
        Me.TabSingle.Location = New System.Drawing.Point(4, 22)
        Me.TabSingle.Name = "TabSingle"
        Me.TabSingle.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSingle.Size = New System.Drawing.Size(708, 59)
        Me.TabSingle.TabIndex = 0
        Me.TabSingle.Text = "Single File"
        Me.TabSingle.UseVisualStyleBackColor = True
        '
        'TabSeparate
        '
        Me.TabSeparate.Controls.Add(Me.btnHeaderIn)
        Me.TabSeparate.Controls.Add(Me.txtDataFile)
        Me.TabSeparate.Controls.Add(Me.btnDataIn)
        Me.TabSeparate.Controls.Add(Me.txtHeaderFile)
        Me.TabSeparate.Location = New System.Drawing.Point(4, 22)
        Me.TabSeparate.Name = "TabSeparate"
        Me.TabSeparate.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSeparate.Size = New System.Drawing.Size(708, 59)
        Me.TabSeparate.TabIndex = 1
        Me.TabSeparate.Text = "Separate Header File"
        Me.TabSeparate.UseVisualStyleBackColor = True
        '
        'cbMakeExcel
        '
        Me.cbMakeExcel.AutoSize = True
        Me.cbMakeExcel.Location = New System.Drawing.Point(12, 6)
        Me.cbMakeExcel.Name = "cbMakeExcel"
        Me.cbMakeExcel.Size = New System.Drawing.Size(259, 17)
        Me.cbMakeExcel.TabIndex = 9
        Me.cbMakeExcel.Text = "Make Excel Friendly (1,000,000 rows max per file)"
        Me.cbMakeExcel.UseVisualStyleBackColor = True
        '
        'btnUncheck71to150
        '
        Me.btnUncheck71to150.Location = New System.Drawing.Point(525, 76)
        Me.btnUncheck71to150.Name = "btnUncheck71to150"
        Me.btnUncheck71to150.Size = New System.Drawing.Size(167, 23)
        Me.btnUncheck71to150.TabIndex = 10
        Me.btnUncheck71to150.Text = "Uncheck Columns 71-150"
        Me.btnUncheck71to150.UseVisualStyleBackColor = True
        '
        'btnUncheckAll
        '
        Me.btnUncheckAll.Location = New System.Drawing.Point(179, 76)
        Me.btnUncheckAll.Name = "btnUncheckAll"
        Me.btnUncheckAll.Size = New System.Drawing.Size(167, 23)
        Me.btnUncheckAll.TabIndex = 11
        Me.btnUncheckAll.Text = "Uncheck All"
        Me.btnUncheckAll.UseVisualStyleBackColor = True
        '
        'btnCheckAll
        '
        Me.btnCheckAll.Location = New System.Drawing.Point(6, 76)
        Me.btnCheckAll.Name = "btnCheckAll"
        Me.btnCheckAll.Size = New System.Drawing.Size(167, 23)
        Me.btnCheckAll.TabIndex = 12
        Me.btnCheckAll.Text = "Check All"
        Me.btnCheckAll.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(348, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Check the columns below that you want included in the Reformatted file."
        '
        'ColumnsPanel
        '
        Me.ColumnsPanel.AutoScroll = True
        Me.ColumnsPanel.Location = New System.Drawing.Point(7, 105)
        Me.ColumnsPanel.Name = "ColumnsPanel"
        Me.ColumnsPanel.Size = New System.Drawing.Size(1124, 467)
        Me.ColumnsPanel.TabIndex = 14
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnStop)
        Me.Panel1.Controls.Add(Me.btnUncheck31to70)
        Me.Panel1.Controls.Add(Me.ColumnsPanel)
        Me.Panel1.Controls.Add(Me.btnUncheck71to150)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnCheckAll)
        Me.Panel1.Controls.Add(Me.cbMakeExcel)
        Me.Panel1.Controls.Add(Me.btnUncheckAll)
        Me.Panel1.Location = New System.Drawing.Point(2, 89)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1138, 578)
        Me.Panel1.TabIndex = 15
        Me.Panel1.Visible = False
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(148, 28)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(170, 23)
        Me.btnStop.TabIndex = 26
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        Me.btnStop.Visible = False
        '
        'lblSkippedLines
        '
        Me.lblSkippedLines.AutoSize = True
        Me.lblSkippedLines.Location = New System.Drawing.Point(855, 105)
        Me.lblSkippedLines.Name = "lblSkippedLines"
        Me.lblSkippedLines.Size = New System.Drawing.Size(70, 13)
        Me.lblSkippedLines.TabIndex = 25
        Me.lblSkippedLines.Text = "Skipped lines"
        Me.lblSkippedLines.Visible = False
        '
        'lblWorking
        '
        Me.lblWorking.AutoSize = True
        Me.lblWorking.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWorking.Location = New System.Drawing.Point(838, 54)
        Me.lblWorking.Name = "lblWorking"
        Me.lblWorking.Size = New System.Drawing.Size(149, 24)
        Me.lblWorking.TabIndex = 23
        Me.lblWorking.Text = "Saving the File"
        Me.lblWorking.Visible = False
        '
        'lblLinesDone
        '
        Me.lblLinesDone.AutoSize = True
        Me.lblLinesDone.Location = New System.Drawing.Point(855, 85)
        Me.lblLinesDone.Name = "lblLinesDone"
        Me.lblLinesDone.Size = New System.Drawing.Size(69, 13)
        Me.lblLinesDone.TabIndex = 24
        Me.lblLinesDone.Text = "0 lines tested"
        Me.lblLinesDone.Visible = False
        '
        'btnUncheck31to70
        '
        Me.btnUncheck31to70.Location = New System.Drawing.Point(352, 76)
        Me.btnUncheck31to70.Name = "btnUncheck31to70"
        Me.btnUncheck31to70.Size = New System.Drawing.Size(167, 23)
        Me.btnUncheck31to70.TabIndex = 15
        Me.btnUncheck31to70.Text = "Uncheck Columns 31-70"
        Me.btnUncheck31to70.UseVisualStyleBackColor = True
        '
        'cbFileHasHeader
        '
        Me.cbFileHasHeader.AutoSize = True
        Me.cbFileHasHeader.Checked = True
        Me.cbFileHasHeader.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbFileHasHeader.Location = New System.Drawing.Point(8, 33)
        Me.cbFileHasHeader.Name = "cbFileHasHeader"
        Me.cbFileHasHeader.Size = New System.Drawing.Size(128, 17)
        Me.cbFileHasHeader.TabIndex = 27
        Me.cbFileHasHeader.Text = "File has a Header line"
        Me.cbFileHasHeader.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1139, 666)
        Me.Controls.Add(Me.lblLinesDone)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lblSkippedLines)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblWorking)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Voting Data Converter"
        Me.TabControl1.ResumeLayout(False)
        Me.TabSingle.ResumeLayout(False)
        Me.TabSingle.PerformLayout()
        Me.TabSeparate.ResumeLayout(False)
        Me.TabSeparate.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSave As Button
    Friend WithEvents txtDataFile As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnDataIn As Button
    Friend WithEvents btnHeaderIn As Button
    Friend WithEvents txtHeaderFile As TextBox
    Friend WithEvents btnSingleDataFile As Button
    Friend WithEvents txtSingleFile As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabSingle As TabPage
    Friend WithEvents TabSeparate As TabPage
    Friend WithEvents cbMakeExcel As CheckBox
    Friend WithEvents btnUncheck71to150 As Button
    Friend WithEvents btnUncheckAll As Button
    Friend WithEvents btnCheckAll As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ColumnsPanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnUncheck31to70 As Button
    Friend WithEvents lblSkippedLines As Label
    Friend WithEvents lblWorking As Label
    Friend WithEvents lblLinesDone As Label
    Friend WithEvents btnStop As Button
    Friend WithEvents cbFileHasHeader As CheckBox
End Class
