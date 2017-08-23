Imports System.IO
Imports System.Text
Imports System.Diagnostics
Imports System.Linq
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports LiteDB
Imports LiteDB.BsonDocument
Imports LiteDB.BsonValue
Imports Microsoft.Office.Interop

Public Class frm_Einstellungen
    Private Sub frm_Einstellungen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_Datenbank.Text = My.Settings.Datenbank
        Email.Text = My.Settings.EMail
        tb_nr.Text = My.Settings.Aufgaben
        tb_ordner.Text = My.Settings.Ordner
        For Each Document As BsonDocument In ReadAll("ablage")
            grd_Ablage.Rows.Add(
                Document.Item("Ablage").ToString,
                Document.Item("Min").ToString,
                Document.Item("Max").ToString,
                Document.Item("_id").ToString
            )
        Next
    End Sub

    Private Sub btn_file_Click(sender As Object, e As EventArgs) Handles btn_file.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            tb_Datenbank.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub tb_Datenbank_TextChanged(sender As Object, e As EventArgs) Handles tb_Datenbank.TextChanged
        For Each reihe As DataGridViewRow In grd_Ablage.Rows
            reihe.Cells.Item(3).Value = Nothing
        Next
    End Sub

    Private Sub grd_Ablage_KeyDown(sender As Object, e As KeyEventArgs) Handles grd_Ablage.KeyDown
        If e.KeyValue = 46 And grd_Ablage.CurrentRow.Cells(3).Value IsNot Nothing Then

            Dim doc As New BsonDocument
            doc = ReadData("ablage", grd_Ablage.CurrentRow.Cells(3).Value)
            deleteData(doc, "ablage")
            Dim id As String = grd_Ablage.CurrentRow.Cells(3).Value

            grd_Ablage.Rows.RemoveAt(grd_Ablage.CurrentRow.Index)
        Else
            grd_Ablage.Rows.RemoveAt(grd_Ablage.CurrentRow.Index)

        End If
    End Sub

    Private Sub ord_Outlook_Click(sender As Object, e As EventArgs) Handles ord_Outlook.Click
        Dim myolApp As Outlook.Application
        Dim myNamespace As Outlook.NameSpace
        Dim myFolder As Outlook.MAPIFolder

        ' Outlook initialisieren
        myolApp = CreateObject("Outlook.Application")

        ' Namespace initialisieren
        myNamespace = myolApp.GetNamespace("MAPI")

        ' Folder per Ordnerauswahl setzen
        myFolder = myNamespace.PickFolder

        tb_ordner.Text = myFolder.Name
        ' Öffnet Outlook und zeigt den Inhalt des ausgewählten Ordners an


    End Sub
End Class