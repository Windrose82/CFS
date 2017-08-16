Imports System.IO
Imports System.Text
Imports System.Diagnostics
Imports System.Linq
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports LiteDB
Imports LiteDB.BsonDocument
Imports LiteDB.BsonValue
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop

Public Class frm_Main
    'Dynamische Verarbeitung von Button-Befehlen
    Private Sub Übersicht_Click(sender As Object, e As EventArgs) Handles btn_Übersicht.Click
        Button_Activate(sender)
        Forms.OpenForm(frm_Übersicht, MainPanel)
        frm_Übersicht.Reload("Status", False, "EQ")
    End Sub

    Private Sub btn_Heute_Click(sender As Object, e As EventArgs) Handles btn_Heute.Click
        Button_Activate(sender)
        Forms.OpenForm(frm_Übersicht, MainPanel)
        frm_Übersicht.Reload("Datum", DateAdd(DateInterval.Hour, 23, Now.Date), "LTE")
    End Sub

    Private Sub btn_Demnaechst_Click(sender As Object, e As EventArgs) Handles btn_Demnaechst.Click
        Button_Activate(sender)
        Forms.OpenForm(frm_Übersicht, MainPanel)
        frm_Übersicht.Reload("Datum", DateAdd(DateInterval.Hour, 23, Now.Date), "GT")
    End Sub

    Private Sub btn_Ablage_Click(sender As Object, e As EventArgs) Handles btn_Ablage.Click
        Button_Activate(sender)
        Forms.OpenForm(frm_Übersicht, MainPanel)
        frm_Übersicht.Reload("Status", True, "EQ")
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        btn_Übersicht.ImageIndex = 1
        btn_Heute.ImageIndex = 1
        btn_Demnaechst.ImageIndex = 1
        btn_Ablage.ImageIndex = 1
        Forms.OpenForm(frm_Übersicht, MainPanel)
        frm_Übersicht.Reload("Bezeichnung", tb_search.Text, "CT")
    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        If btn_Add.ImageIndex = 0 Then
            frm_Übersicht.Table.Rows.Add("False")
            Dim project As BsonDocument = New BsonDocument From {
                            {"Status", False},
                            {"Bezeichnung", ""},
                            {"Kontakt", ""},
                            {"Ablage", ""},
                            {"Datum", ""}
                        }
            WriteData(project, "dokumente")
            frm_Übersicht.Table.ClearSelection()
            frm_Übersicht.Table.CurrentCell = frm_Übersicht.Table.Rows.Item(frm_Übersicht.Table.Rows.Count - 1).Cells(1)
            frm_Übersicht.Table.CurrentRow.Cells(5).Value = ReadDataLast("dokumente").ToString
            frm_Übersicht.Table.BeginEdit(True)
            Files.Clear()
        ElseIf btn_Add.ImageIndex = 2 Then
            My.Settings.Datenbank = frm_Einstellungen.tb_Datenbank.Text
            For Each row In frm_Einstellungen.grd_Ablage.Rows
                If row.cells(3).value Is Nothing And row.index + 1 <> frm_Einstellungen.grd_Ablage.Rows.Count Then
                    Dim project As BsonDocument = New BsonDocument From {
                                        {"Ablage", row.Cells(0).Value.ToString},
                                        {"Min", row.Cells(1).Value.ToString},
                                        {"Max", row.Cells(2).Value.ToString}
                                    }
                    WriteData(project, "ablage")
                    row.Cells(3).Value = ReadDataLast("ablage").ToString
                ElseIf row.cells(3).value IsNot Nothing And row.index + 1 <> frm_Einstellungen.grd_Ablage.Rows.Count Then
                    Dim doc As New BsonDocument
                    doc = ReadData("ablage", row.Cells(3).Value)
                    doc.Set("Ablage", New BsonValue(row.cells(0).Value))
                    doc.Set("Min", New BsonValue(row.cells(1).Value))
                    doc.Set("Max", New BsonValue(row.cells(2).Value))
                    UpdateData(doc, "ablage")
                End If
            Next
            btn_Add.ImageIndex = 0
            btn_Del.ImageIndex = 1
            frm_Einstellungen.Close()
            Button_Activate(btn_Heute)
            OpenForm(frm_Übersicht, MainPanel)
            frm_Übersicht.Reload("Datum", DateAdd(DateInterval.Hour, 23, Now.Date), "LTE")
        End If
    End Sub

    Private Sub btn_Del_Click(sender As Object, e As EventArgs) Handles btn_Del.Click
        If btn_Del.ImageIndex = 1 Then
            Try
                Dim doc As New BsonDocument
                doc = ReadData("dokumente", frm_Übersicht.Table.CurrentRow.Cells(5).Value)
                deleteData(doc, "dokumente")
                Dim id As String = frm_Übersicht.Table.CurrentRow.Cells(5).Value

                frm_Übersicht.Table.Rows.RemoveAt(frm_Übersicht.Table.CurrentRow.Index)

                Files.Clear()
                Dim ids As New List(Of String)
                For Each File As LiteFileInfo In LoadDocuments(id)
                    ids.Add(File.Id)
                Next
                For Each File In ids
                    DeleteDocument(File)
                Next
            Catch ex As Exception
            End Try
        ElseIf btn_Del.ImageIndex = 3 Then
            btn_Add.ImageIndex = 0
            btn_Del.ImageIndex = 1
            frm_Einstellungen.Close()
            Button_Activate(btn_Heute)
            OpenForm(frm_Übersicht, MainPanel)
            frm_Übersicht.Reload("Datum", DateAdd(DateInterval.Hour, 23, Now.Date), "LTE")
        End If
    End Sub

    Private Sub Button_Activate(Button As Object)
        btn_Übersicht.ImageIndex = 1
        btn_Heute.ImageIndex = 1
        btn_Demnaechst.ImageIndex = 1
        btn_Ablage.ImageIndex = 1
        Button.ImageIndex = 0
    End Sub

    'Laden des Hauptformulars, füllen des Tree-Elements und Aktion bei Click auf Tree-Element
    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button_Activate(btn_Heute)
        OpenForm(frm_Übersicht, MainPanel)
        frm_Übersicht.Reload("Datum", DateAdd(DateInterval.Hour, 23, Now.Date), "LTE")
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

    End Sub

    Private Sub Files_DoubleClick(sender As Object, e As EventArgs) Handles Files.DoubleClick

        System.Diagnostics.Process.Start(ReadDocument(Files.SelectedItems(0).Tag))
    End Sub

    Private Sub EinstellungenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EinstellungenToolStripMenuItem.Click, EinstellungenToolStripMenuItem1.Click, OptionenToolStripMenuItem.Click
        btn_Add.ImageIndex = 2
        btn_Del.ImageIndex = 3
        OpenForm(frm_Einstellungen, MainPanel)
    End Sub

    Private Sub tb_search_Click(sender As Object, e As EventArgs) Handles tb_search.Click
        tb_search.SelectAll()
    End Sub

    Private Sub ExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcelToolStripMenuItem.Click, ExcelToolStripMenuItem1.Click, ExcelToolStripMenuItem2.Click
        Dim xls_Appl As Excel.Application ' Excel Anwendung 
        Dim xls_Mappe As Excel.Workbook ' Excel Arbeitsmappe 
        Dim xls_Blatt As Excel.Worksheet ' Excel Blatt (Tabelle) 
        Dim Anzahlzeilen As Integer
        xls_Appl = New Excel.Application() ' Excel Instanz bilden         xls_Appl.Visible = True
        xls_Mappe = xls_Appl.Workbooks.Add()
        xls_Blatt = xls_Mappe.ActiveSheet
        'hier muß der Name des zu exportierenden DataGridViews rein 
        With frm_Übersicht.Table
            For Spalte As Integer = 0 To .Columns.Count - 2
                xls_Blatt.Cells(1, Spalte + 1).Value = .Columns(Spalte).HeaderText
                xls_Blatt.Cells(1, Spalte + 1).Font.Bold = True
            Next
            Anzahlzeilen = .Rows.Count

            For Zeile As Integer = 0 To Anzahlzeilen - 1
                For Spalte As Integer = 0 To .Columns.Count - 2
                    xls_Blatt.Cells(Zeile + 2, Spalte + 1).Value() _
                        = .Rows(Zeile).Cells(Spalte).Value()
                Next
            Next
            xls_Appl.Visible = True
        End With
    End Sub

    Private Sub Files_KeyDown(sender As Object, e As KeyEventArgs) Handles Files.KeyDown
        If e.KeyValue = 46 And Files.SelectedItems.Count <> 0 Then
            DeleteDocument(Files.SelectedItems.Item(0).Tag)
            Files.SelectedItems.Item(0).Remove()
            Dim anhang As IEnumerable(Of LiteFileInfo)
            For Each reihe As DataGridViewRow In frm_Übersicht.Table.Rows
                anhang = LoadDocuments(reihe.Cells(5).Value)
                If anhang.Count <> 0 Then
                    reihe.Cells(6).Value = My.Resources.attachment_icon
                Else
                    reihe.Cells(6).Value = My.Resources.no_attachment_icon
                End If
            Next
        End If
    End Sub

    Private Sub BeendenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem1.Click, BeendenToolStripMenuItem2.Click
        Me.Close()
    End Sub
End Class
Public Class ordner
    Public Shared DD As New List(Of String)
    Public Shared DM As New List(Of String)
End Class