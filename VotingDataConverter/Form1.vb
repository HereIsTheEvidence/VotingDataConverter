Imports System.IO
Imports System.Text
Public Class Form1
    Dim m_headerFilenameIn As String = ""
    Dim m_DataFilenameIn As String = ""
    Dim m_SingleFilenameIn As String = ""
    Dim m_columnNames() As String
    Dim m_rowColumnData() As String
    Dim m_recordsFound As Int64
    Dim m_cbs As New Dictionary(Of String, CheckBox)
    Dim m_Stop As Boolean = False
    Dim m_DataIsCSV As Boolean = False
    Dim m_HasHeader As Boolean
    Private Sub btnDataIn_Click(sender As Object, e As EventArgs) Handles btnDataIn.Click
        txtDataFile.Text = ""
        m_DataFilenameIn = ""
        lblWorking.Visible = False
        lblLinesDone.Visible = False
        lblSkippedLines.Visible = False
        Panel1.Visible = False
        lblWorking.Visible = False
        lblLinesDone.Visible = False
        txtSingleFile.Text = ""
        m_SingleFilenameIn = ""
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            m_DataFilenameIn = OpenFileDialog1.FileName.ToLower.Trim
        End If
        Dim line As String
        ' Create new StreamReader instance with Using block.
        Try
            Using reader As StreamReader = New StreamReader(m_DataFilenameIn)
                line = reader.ReadLine.Trim
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            m_DataFilenameIn = ""
            Exit Sub
        End Try
        m_DataIsCSV = False
        Dim fields As String()
        fields = line.Split(vbTab)
        If fields.Length = 1 Then
            fields = line.Split(",")
            m_DataIsCSV = True
            If fields.Length = 1 Then
                MsgBox("This file is not a valid data file. The first line of the file must have more than one column.",, "Invalid Data File")
                m_DataFilenameIn = ""
                Exit Sub
            End If
        End If
        txtDataFile.Text = m_DataFilenameIn
        If m_headerFilenameIn <> "" Then
            CreateCheckboxes()
        End If
    End Sub
    Private Sub btnHeaderIn_Click(sender As Object, e As EventArgs) Handles btnHeaderIn.Click
        txtHeaderFile.Text = ""
        m_headerFilenameIn = ""
        lblWorking.Visible = False
        lblLinesDone.Visible = False
        lblSkippedLines.Visible = False
        Panel1.Visible = False
        lblWorking.Visible = False
        lblLinesDone.Visible = False
        txtSingleFile.Text = ""
        m_SingleFilenameIn = ""
        Erase m_columnNames
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            m_headerFilenameIn = OpenFileDialog1.FileName.ToLower.Trim
        End If
        Dim line As String
        ' Create new StreamReader instance with Using block.
        Try
            Using reader As StreamReader = New StreamReader(m_headerFilenameIn)
                line = reader.ReadLine.Trim
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            m_headerFilenameIn = ""
            Exit Sub
        End Try
        m_columnNames = line.Split(vbTab)
        If m_columnNames.Length = 1 Then
            m_columnNames = line.Split(",")
            If m_columnNames.Length = 1 Then
                MsgBox("This file is not a valid header file. The first line of the file must have the headers.",, "Invalid File Data")
                Erase m_columnNames
                txtHeaderFile.Text = ""
                m_headerFilenameIn = ""
                Exit Sub
            End If
        End If
        txtHeaderFile.Text = m_headerFilenameIn
        If m_DataFilenameIn <> "" Then
            CreateCheckboxes()
        End If
    End Sub
    Private Sub CreateCheckboxes()
        'remove and delete all the checkboxes
        For i = m_cbs.Count - 1 To 0 Step -1
            Dim cb As CheckBox = m_cbs(i)
            m_cbs.Remove(i)
            ColumnsPanel.Controls.Remove(cb)
        Next
        Panel1.Visible = True
        For i As Integer = 0 To m_columnNames.Length - 1
            Dim cb As New CheckBox
            ColumnsPanel.Controls.Add(cb)
            cb.Height = 17
            cb.Width = 205
            cb.Left = (i Mod 5) * 218 + 9
            cb.Top = (i \ 5) * 19 + 9
            cb.Text = m_columnNames(i)
            cb.Tag = i
            Dim fnt As Font
            fnt = cb.Font
            cb.Font = New Font(fnt.Name, 7)
            m_cbs(i) = cb
        Next
        If m_columnNames.Length > 149 Then
            btnUncheck71to150.Visible = True
            btnUncheck31to70.Visible = True
        Else
            btnUncheck71to150.Visible = False
            btnUncheck31to70.Visible = False
        End If
    End Sub
    Private Sub btnSingleDataFile_Click(sender As Object, e As EventArgs) Handles btnSingleDataFile.Click
        txtSingleFile.Text = ""
        m_SingleFilenameIn = ""
        lblWorking.Visible = False
        lblLinesDone.Visible = False
        lblSkippedLines.Visible = False
        Panel1.Visible = False
        lblWorking.Visible = False
        lblLinesDone.Visible = False
        txtHeaderFile.Text = ""
        m_headerFilenameIn = ""
        txtDataFile.Text = ""
        m_DataFilenameIn = ""
        Erase m_columnNames
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            m_SingleFilenameIn = OpenFileDialog1.FileName.ToLower
        End If
        Dim line As String
        ' Create new StreamReader instance with Using block.
        Try
            Using reader As StreamReader = New StreamReader(m_SingleFilenameIn)
                line = reader.ReadLine.Trim
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            m_SingleFilenameIn = ""
            Exit Sub
        End Try
        m_DataIsCSV = False
        m_columnNames = line.Split(vbTab)
        If m_columnNames.Length = 1 Then
            m_DataIsCSV = True
            m_columnNames = line.Split(",")
            If m_columnNames.Length = 1 Then
                MsgBox("This file is not a valid file. The first line of the file must have more than one.",, "Invalid File Data")
                Erase m_columnNames
                m_SingleFilenameIn = ""
                Exit Sub
            End If
        End If
        txtSingleFile.Text = m_SingleFilenameIn
        CreateCheckboxes()
    End Sub
    Private Sub btnCheckAll_Click(sender As Object, e As EventArgs) Handles btnCheckAll.Click
        For i = 0 To m_columnNames.Length - 1
            m_cbs(i).Checked = True
        Next
    End Sub
    Private Sub btnUncheckAll_Click(sender As Object, e As EventArgs) Handles btnUncheckAll.Click
        For i = 0 To m_columnNames.Length - 1
            m_cbs(i).Checked = False
        Next
    End Sub
    Private Sub btnUncheck71to150_Click(sender As Object, e As EventArgs) Handles btnUncheck71to150.Click
        For i = 70 To 149
            m_cbs(i).Checked = False
        Next
    End Sub
    Private Sub btnUncheck31to70_Click(sender As Object, e As EventArgs) Handles btnUncheck31to70.Click
        For i = 30 To 69
            m_cbs(i).Checked = False
        Next
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If TabControl1.SelectedIndex = 0 Then
            If cbFileHasHeader.Checked Then
                m_HasHeader = True
            Else
                m_HasHeader = False
            End If
        Else
            m_HasHeader = True
        End If
        Dim columnsToSave As New ArrayList
        For n = 0 To m_columnNames.Length - 1
            If m_cbs(n).Checked Then
                columnsToSave.Add(n)
            End If
        Next
        If columnsToSave.Count = 0 Then
            MsgBox("You must select atleast one column below.",, "Not columns selected")
            Exit Sub
        End If
        Dim strHeader As String = ""
        Dim CntLinesInFile As Int64
        Dim fileCount As Int16 = 0
        m_Stop = False
        Dim skippedLines As Int64
        Dim filenameOut As String = ""
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*"
        saveFileDialog1.FilterIndex = 0
        saveFileDialog1.RestoreDirectory = True
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            lblWorking.Visible = True
            lblLinesDone.Visible = True
            lblSkippedLines.Visible = True
            btnStop.Visible = True
            filenameOut = saveFileDialog1.FileName
            lblWorking.Text = "Saving file"
            lblLinesDone.Text = "Rows saved " & 0
            Dim cnt As Int64 = 0
            Dim cntWritten As Int64 = 0
            Dim lineCnt As Int64 = -1
            Dim filteredIDsCnt As Long = 0
            Dim writer As New System.IO.StreamWriter(filenameOut)
            Dim StrBuilder As New StringBuilder()
            Dim fileIn As String
            If TabControl1.SelectedTab.TabIndex = 0 Then
                fileIn = m_SingleFilenameIn
            Else
                fileIn = m_DataFilenameIn
            End If
            'Save a CSV file
            Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(fileIn)
                MyReader.TextFieldType = FileIO.FieldType.Delimited
                If m_DataIsCSV Then
                    MyReader.SetDelimiters(",")
                Else
                    MyReader.SetDelimiters(vbTab)
                End If
                For n = 0 To columnsToSave.Count - 1
                    strHeader = m_columnNames(columnsToSave(n))
                    If strHeader.StartsWith("""") Then
                        StrBuilder.Append(strHeader & ",")
                    Else
                        StrBuilder.Append("""" & strHeader & """,")
                    End If
                Next
                strHeader = StrBuilder.ToString
                strHeader = strHeader.Substring(0, strHeader.Length - 1)
                If TabControl1.SelectedIndex = 1 Then
                    writer.WriteLine(strHeader)
                End If
                Dim str As String = ""
                While Not MyReader.EndOfData
                    Try
                        StrBuilder.Clear()
                        m_rowColumnData = MyReader.ReadFields()
                        If lineCnt = -1 Then
                            If m_rowColumnData.Length <> m_columnNames.Length Then
                                MsgBox("The Header File does not match the Data file." & vbCrLf & "The Header file has " & m_columnNames.Length & " columns and the data has " & m_rowColumnData.Length & " Columns.",, "Files do not match")
                                writer.Close()
                                MyReader.Close()
                                Exit Sub
                            End If
                        End If
                        Dim strToAdd As String
                        For n = 0 To columnsToSave.Count - 1
                            strToAdd = m_rowColumnData(columnsToSave(n))
                            If strToAdd.StartsWith("""") Then
                                StrBuilder.Append(strToAdd & ",")
                            Else
                                StrBuilder.Append("""" & strToAdd & """,")
                            End If
                        Next
                        str = StrBuilder.ToString
                        writer.WriteLine(str.Substring(0, str.Length - 1))
                    Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                        'MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
                        lblSkippedLines.Visible = True
                        skippedLines += 1
                        lblSkippedLines.Text = skippedLines & " Lines skipped due to a formatting issue"
                    End Try
                    If m_Stop Then
                        MyReader.Close()
                        writer.Close()
                        lblWorking.Text = "Stopped"
                        m_Stop = False
                        Exit Sub
                    End If
                    cnt += 1
                    CntLinesInFile += 1
                    lineCnt += 1
                    If cnt = 10000 Then
                        cnt = 0
                        lblLinesDone.Text = lineCnt & " lines tested"
                        Application.DoEvents()
                    End If
                    If CntLinesInFile = 1000000 Then
                        If cbMakeExcel.Checked Then
                            writer.Close()
                            fileCount += 1
                            Dim s As String = filenameOut.Substring(0, filenameOut.Length - 3)
                            writer = New System.IO.StreamWriter(s & "(" & fileCount & ").csv")
                            If m_HasHeader Then
                                writer.WriteLine(strHeader)
                            End If
                            CntLinesInFile = 0
                        End If
                    End If
                End While
                writer.Close()
            End Using
            lblWorking.Text = "Finished Saving"
            lblLinesDone.Text = lineCnt & " lines saved"
            btnStop.Visible = False
            Application.DoEvents()
        End If
    End Sub
    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        m_Stop = True
        btnStop.Visible = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
