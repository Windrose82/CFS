Imports System.IO
Imports System.Text
Imports System.Diagnostics
Imports System.Linq
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports LiteDB
Imports LiteDB.BsonDocument
Imports LiteDB.BsonValue

Public Class frm_Übersicht
    Private Sub frm_Übersicht_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Table_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Table.CellEndEdit
        Dim titleText As String = Table.Columns(3).HeaderText
        Debug.Print(e.ColumnIndex)
        If Table.CurrentCell.ColumnIndex = 3 Then
            Table.Columns(3).Width = 55
        End If
        If Table.Item(5, e.RowIndex).Value IsNot Nothing Then
            Dim doc As New BsonDocument
            Dim Datum As Date
            If Table.Item(4, e.RowIndex).Value IsNot Nothing And IsDate(Table.Item(4, e.RowIndex).Value) = True Then
                Datum = CDate(Table.Item(4, e.RowIndex).Value)
            ElseIf Table.Item(4, e.RowIndex).Value IsNot Nothing And IsDate(Table.Item(4, e.RowIndex).Value) = False Then
                MsgBox("Das Datum existiert nicht!!!")
                Datum = Now.Date
                Table.Item(4, e.RowIndex).Value = Now.Date
            Else
                Datum = Now.Date
                Table.Item(4, e.RowIndex).Value = Now.Date
            End If
            doc = ReadData("dokumente", Table.Item(5, e.RowIndex).Value)
            doc.Set("Status", New BsonValue(CType(Table.Item(0, e.RowIndex).Value, Boolean)).AsBoolean)
            doc.Set("Bezeichnung", New BsonValue(Table.Item(1, e.RowIndex).Value))
            doc.Set("Kontakt", New BsonValue(Table.Item(2, e.RowIndex).Value))
            doc.Set("Ablage", New BsonValue(Table.Item(3, e.RowIndex).Value))
            doc.Set("Datum", New BsonValue(Datum).AsDateTime)
            UpdateData(doc, "dokumente")
            If Table.CurrentCell.ColumnIndex = 3 Then
                ordner.DD.Clear()

                For Each Document As BsonDocument In ReadAll("Ablage")
                    Dim Min = CType(Document.Item("Min").ToString, Integer)
                    Dim Max = CType(Document.Item("Max").ToString, Integer)
                    Dim Ablage = Document.Item("Ablage").ToString
                    For i = Min To Max
                        ordner.DD.Add(Ablage & "-" & String.Format("{0:00}", i))
                    Next
                Next
                For Each Document As BsonDocument In ReadAll("dokumente")
                    Dim Ablage = Document.Item("Ablage").ToString
                    ordner.DD.Remove(Ablage)


                Next
            End If

        End If

        If e.ColumnIndex = 0 Or e.ColumnIndex = 4 Then

            '    If frm_Main.btn_Übersicht.ImageIndex = 0 Then
            '        Reload("Status", False, "EQ")
            '    ElseIf frm_Main.btn_Heute.ImageIndex = 0 Then
            '        Reload("Datum", DateAdd(DateInterval.Hour, 23, Now.Date), "LTE")
            '    ElseIf frm_Main.btn_Demnaechst.ImageIndex = 0 Then
            '        Reload("Datum", DateAdd(DateInterval.Hour, 23, Now.Date), "GT")
            '    ElseIf frm_Main.btn_Ablage.ImageIndex = 0 Then
            '        Reload("Status", True, "EQ")
            '    End If
        End If
    End Sub

    Public Sub Reload(col As String, filter As String, art As String)
        Table.Rows.Clear()
        For Each Document As BsonDocument In ReadFilter("dokumente", col, filter, art)
            If Document.Item("Bezeichnung").ToString = "(null)" Then
                Document.Item("Bezeichnung") = ""
            End If
            If Document.Item("Kontakt").ToString = "(null)" Then
                Document.Item("Kontakt") = ""
            End If
            If Document.Item("Ablage").ToString = "(null)" Then
                Document.Item("Ablage") = ""
            End If
            If Document.Item("Datum").ToString = "(null)" Then
                Document.Item("Datum") = ""
            End If
            Dim Datum As Date = Document.Item("Datum").ToString
            Table.Rows.Add(
                Document.Item("Status").ToString,
                Document.Item("Bezeichnung").ToString,
                Document.Item("Kontakt").ToString,
                Document.Item("Ablage").ToString,
                Datum,
                Document.Item("_id").ToString
            )
        Next
        Dim anhang As IEnumerable(Of LiteFileInfo)
        For Each reihe As DataGridViewRow In Table.Rows
            anhang = LoadDocuments(reihe.Cells(5).Value)
            If anhang.Count <> 0 Then
                reihe.Cells(6).Value = My.Resources.attachment_icon
            Else
                reihe.Cells(6).Value = My.Resources.no_attachment_icon
            End If
        Next
        Table.ClearSelection()
    End Sub

    Private Sub Table_DragEnter(sender As Object, e As DragEventArgs) Handles Table.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
            '  erlaube das reinziehen von Outlook Elementen direkt
        ElseIf e.Data.GetDataPresent("FileGroupDescriptor") Then
            e.Effect = DragDropEffects.Copy
        Else
            '  nix erlauben
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub Table_DragDrop(sender As Object, e As DragEventArgs) Handles Table.DragDrop
        Dim theFiles() As String = CType(e.Data.GetData("FileDrop", True), String())
        Dim LocalMousePosition As Point
        LocalMousePosition = Me.Table.PointToClient(Cursor.Position)
        Dim x As Integer = LocalMousePosition.X
        Dim y As Integer = LocalMousePosition.Y
        Dim hitTestInfo As DataGridView.HitTestInfo
        hitTestInfo = Table.HitTest(x, y)
        If hitTestInfo.Type = DataGridViewHitTestType.Cell Then
            Try
                If e.Data.GetDataPresent(DataFormats.FileDrop) Then
                    For Each theFile As String In theFiles
                        WriteDocument(theFile, Table.Rows.Item(hitTestInfo.RowIndex).Cells(5).Value)
                    Next
                ElseIf e.Data.GetDataPresent("FileGroupDescriptor") Then
                    ' We have a embedded file. First lets try to get the file name out of memory
                    Dim theStream As Stream = CType(e.Data.GetData("FileGroupDescriptor"), Stream)
                    Dim fileGroupDescriptor(512) As Byte
                    theStream.Read(fileGroupDescriptor, 0, 512)
                    Dim fileName As System.Text.StringBuilder = New System.Text.StringBuilder("")
                    Dim i As Integer = 76
                    While Not (fileGroupDescriptor(i) = 0)
                        fileName.Append(Convert.ToChar(fileGroupDescriptor(i)))
                        System.Math.Min(System.Threading.Interlocked.Increment(i), i - 1)
                    End While
                    theStream.Close()
                    ' We should have the file name or if its a email the subject line. Create our temp file based on the temp path and this info
                    Dim myTempFile As String = Path.GetTempPath & fileName.ToString
                    ' Look to see if this is a email message. If so save that temporarily and get the temp file.
                    If InStr(myTempFile, ".msg") > 0 Then
                        Dim objOL As New Microsoft.Office.Interop.Outlook.Application
                        Dim objMI As Microsoft.Office.Interop.Outlook.MailItem
                        If objOL.ActiveExplorer.Selection.Count > 1 Then
                        End If
                        For Each objMI In objOL.ActiveExplorer.Selection()
                            objMI.SaveAs(myTempFile)
                            WriteDocument(myTempFile, Table.Rows.Item(hitTestInfo.RowIndex).Cells(5).Value)
                            My.Computer.FileSystem.DeleteFile(myTempFile)
                            Exit For
                        Next
                        objOL = Nothing
                        objMI = Nothing

                    End If
                    ' Make sure we have a actual file and also if we do make sure we erase it when done
                Else
                    Throw New System.Exception("An exception has occurred.")
                End If

            Catch ex As Exception
            End Try
            Table.Rows(hitTestInfo.RowIndex).Selected = True
            LoadFiles(hitTestInfo.RowIndex)
        Else
            Table.Rows.Add("False")
            Dim project As BsonDocument = New BsonDocument From {
                            {"Status", False},
                            {"Bezeichnung", ""},
                            {"Kontakt", ""},
                            {"Ablage", ""},
                            {"Datum", ""}
                        }
            WriteData(project, "dokumente")
            Table.ClearSelection()
            Table.CurrentCell = Table.Rows.Item(Table.Rows.Count - 1).Cells(1)
            Table.CurrentRow.Cells(5).Value = ReadDataLast("dokumente").ToString
            frm_Main.Files.Clear()
            Try
                If e.Data.GetDataPresent(DataFormats.FileDrop) Then
                    For Each theFile As String In theFiles
                        WriteDocument(theFile, Table.Rows.Item(Table.CurrentRow.Index).Cells(5).Value)
                    Next
                ElseIf e.Data.GetDataPresent("FileGroupDescriptor") Then
                    ' We have a embedded file. First lets try to get the file name out of memory
                    Dim theStream As Stream = CType(e.Data.GetData("FileGroupDescriptor"), Stream)
                    Dim fileGroupDescriptor(512) As Byte
                    theStream.Read(fileGroupDescriptor, 0, 512)
                    Dim fileName As System.Text.StringBuilder = New System.Text.StringBuilder("")
                    Dim i As Integer = 76
                    While Not (fileGroupDescriptor(i) = 0)
                        fileName.Append(Convert.ToChar(fileGroupDescriptor(i)))
                        System.Math.Min(System.Threading.Interlocked.Increment(i), i - 1)
                    End While
                    theStream.Close()
                    ' We should have the file name or if its a email the subject line. Create our temp file based on the temp path and this info
                    Dim myTempFile As String = Path.GetTempPath & fileName.ToString
                    ' Look to see if this is a email message. If so save that temporarily and get the temp file.
                    If InStr(myTempFile, ".msg") > 0 Then
                        Dim objOL As New Microsoft.Office.Interop.Outlook.Application
                        Dim objMI As Microsoft.Office.Interop.Outlook.MailItem
                        If objOL.ActiveExplorer.Selection.Count > 1 Then
                        End If
                        For Each objMI In objOL.ActiveExplorer.Selection()
                            objMI.SaveAs(myTempFile)
                            WriteDocument(myTempFile, Table.Rows.Item(Table.CurrentRow.Index).Cells(5).Value)
                            My.Computer.FileSystem.DeleteFile(myTempFile)
                            Exit For
                        Next
                        objOL = Nothing
                        objMI = Nothing

                    End If
                    ' Make sure we have a actual file and also if we do make sure we erase it when done
                Else
                    Throw New System.Exception("An exception has occurred.")
                End If
                Table.BeginEdit(True)
            Catch ex As Exception
            End Try
            LoadFiles(Table.CurrentRow.Index)
        End If
        Dim anhang As IEnumerable(Of LiteFileInfo)
        For Each reihe As DataGridViewRow In Table.Rows
            anhang = LoadDocuments(reihe.Cells(5).Value)
            If anhang.Count <> 0 Then
                reihe.Cells(6).Value = My.Resources.attachment_icon
            Else
                reihe.Cells(6).Value = My.Resources.no_attachment_icon
            End If
        Next
    End Sub

    Private Sub Table_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Table.RowEnter
        LoadFiles(e.RowIndex)
    End Sub

    Private Sub LoadFiles(e As Integer)
        frm_Main.Files.Clear()
        If Table.CurrentRow IsNot Nothing Then
            For Each File As LiteFileInfo In LoadDocuments(Table.Rows(e).Cells(5).Value)
                Dim newItem As New ListViewItem
                newItem.Text = File.Filename
                newItem.Tag = File.Id
                If File.Filename.Substring(File.Filename.Length - 3, 3) = "pdf" Then
                    newItem.ImageIndex = 0
                ElseIf File.Filename.Substring(File.Filename.Length - 3, 3) = "msg" Then
                    newItem.ImageIndex = 1
                ElseIf File.Filename.Substring(File.Filename.Length - 3, 3) = "txt" Then
                    newItem.ImageIndex = 2
                ElseIf File.Filename.Substring(File.Filename.Length - 3, 3) = "doc" Or File.Filename.Substring(File.Filename.Length - 4, 4) = "docx" Then
                    newItem.ImageIndex = 3
                ElseIf File.Filename.Substring(File.Filename.Length - 3, 3) = "xls" Or File.Filename.Substring(File.Filename.Length - 4, 4) = "xlsx" Then
                    newItem.ImageIndex = 4
                Else
                    newItem.ImageIndex = 5
                End If
                frm_Main.Files.Items.Add(newItem)
            Next
        End If
    End Sub

    Private Sub Table_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles Table.EditingControlShowing
        Dim titleText As String = Table.Columns(3).HeaderText
        If Table.CurrentCell.ColumnIndex = 3 Then
            Table.Columns(3).Width = 100
        End If
        If titleText.Equals("Ablage") Then

            Dim autoText As TextBox = TryCast(e.Control, TextBox)
            If autoText IsNot Nothing Then
                autoText.AutoCompleteMode = AutoCompleteMode.Suggest
                autoText.AutoCompleteSource = AutoCompleteSource.CustomSource
                Dim DataCollection As New AutoCompleteStringCollection()
                addItems(DataCollection)
                autoText.AutoCompleteCustomSource = DataCollection
            End If
        End If
    End Sub

    Public Sub addItems(ByVal col As AutoCompleteStringCollection)
        For Each doc In ordner.DD
            col.Add(doc)
        Next
    End Sub

    Private Sub Table_CellPainting(ByVal sender As System.Object,
            ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) _
            Handles Table.CellPainting
        If e.RowIndex = -1 AndAlso e.ColumnIndex = Table.Columns.Count - 1 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All And Not DataGridViewPaintParts.ContentForeground)
            e.Graphics.DrawImage(My.Resources.attachment_icon_16, e.CellBounds)
            e.Handled = True
        ElseIf e.RowIndex = -1 AndAlso e.ColumnIndex = Table.Columns.Count - 5 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All And Not DataGridViewPaintParts.ContentForeground)
            e.Graphics.DrawImage(My.Resources.Windows_Messenger_icon, e.CellBounds)
            e.Handled = True
        ElseIf e.RowIndex = -1 AndAlso e.ColumnIndex = Table.Columns.Count - 4 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All And Not DataGridViewPaintParts.ContentForeground)
            e.Graphics.DrawImage(My.Resources.folder_close_icon, e.CellBounds)
            e.Handled = True
        ElseIf e.RowIndex = -1 AndAlso e.ColumnIndex = Table.Columns.Count - 3 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All And Not DataGridViewPaintParts.ContentForeground)
            e.Graphics.DrawImage(My.Resources.calendar_icon, e.CellBounds)
            e.Handled = True
        End If

    End Sub
End Class