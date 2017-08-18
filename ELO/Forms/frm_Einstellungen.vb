Imports System.IO
Imports System.Text
Imports System.Diagnostics
Imports System.Linq
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports LiteDB
Imports LiteDB.BsonDocument
Imports LiteDB.BsonValue

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
End Class