﻿Imports LiteDB
Imports LiteDB.BsonDocument
Imports LiteDB.BsonValue
Imports System
Imports System.IO
Imports System.Text
Imports System.Diagnostics
Imports System.Linq
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports Aspose.Email.Mapi
Imports System.Web

Module Database
    Public Sub WriteData(project As BsonDocument, table As String)
        Dim db As New LiteDatabase(My.Settings.Datenbank & "\Files.db")
        Dim collection = db.GetCollection(Of BsonDocument)(table)
        collection.Insert(project)
        db.BeginTrans()
        db.Dispose()
    End Sub

    Public Sub UpdateData(project As BsonDocument, table As String)
        Dim db As New LiteDatabase(My.Settings.Datenbank & "\Files.db")
        Dim collection = db.GetCollection(Of BsonDocument)(table)
        collection.Update(project)
        db.Dispose()
    End Sub

    Public Sub deleteData(project As BsonDocument, table As String)
        Dim db As New LiteDatabase(My.Settings.Datenbank & "\Files.db")
        Dim collection = db.GetCollection(Of BsonDocument)(table)
        collection.Delete(project.Values(0))
        db.Dispose()
    End Sub

    Public Function ReadData(table As String, item As String)
        Dim db As New LiteDatabase(My.Settings.Datenbank & "\Files.db")
        Return db.GetCollection(table).FindById(New ObjectId(Item))
        db.Dispose()
        End Function

    Public Function ReadDataLast(table As String)
        Dim db As New LiteDatabase(My.Settings.Datenbank & "\Files.db")
        Return db.GetCollection(table).FindById(db.GetCollection(table).Max).Item("_id")
        db.Dispose()
    End Function

    Public Function ReadFilter(table As String, col As String, item As String, art As String)
        Dim db As New LiteDatabase(My.Settings.Datenbank & "\Files.db")
        If art = "EQ" Then
            Return db.GetCollection(table).Find(Query.EQ(col, CType(Item, Boolean)))
        ElseIf art = "LTE" Then
            Return db.GetCollection(table).Find(Query.And(Query.LTE(col, CDate(Item)), Query.EQ("Status", False)))
        ElseIf art = "GT" Then
            Return db.GetCollection(table).Find(Query.And(Query.GT(col, CDate(Item)), Query.EQ("Status", False)))
        ElseIf art = "CT" Then
            If Item <> "" Then
                Dim DateValue As Date
                If Date.TryParse(Item, DateValue) Then
                    Return db.GetCollection(table).Find((Query.EQ("Datum", CDate(Item))))
                Else
                    Return db.GetCollection(table).Find(Query.Or(Query.Or(Query.Contains("Bezeichnung", Item), Query.Contains("Kontakt", Item)), Query.Contains("Ablage", Item)))
                End If
            Else
                Return db.GetCollection(table).FindAll
            End If
        End If
        db.Dispose()
    End Function

    Public Function ReadAll(table As String)
        Dim db As New LiteDatabase(My.Settings.Datenbank & "\Files.db")
        Return db.GetCollection(table).FindAll
        db.Dispose()
    End Function

    Public Sub WriteDocument(document, id)
        Dim db As New LiteDatabase(My.Settings.Datenbank & "\Files.db")
        Dim newId As String
        newId = id & "-" & db.FileStorage.Find(id).Count
        db.FileStorage.Upload(newId, document)
        db.BeginTrans()
        db.Dispose()
        End Sub

    Public Function ReadDocument(index)
        Dim db As New LiteDatabase(My.Settings.Datenbank & "\Files.db")
        Dim document As LiteFileInfo
        Dim mem As New MemoryStream
        document = db.FileStorage.Download(index, mem)
        Dim bytes() As Byte = mem.ToArray
        If Not IO.Directory.Exists(My.Settings.Datenbank & "\Temp") Then
            ' Nein! Jetzt erstellen...
            Try
                IO.Directory.CreateDirectory(My.Settings.Datenbank & "\Temp")
                ' Ordner wurde korrekt erstellt!
            Catch ex As Exception
                ' Ordner wurde nicht erstellt
            End Try
        End If
        File.WriteAllBytes(My.Settings.Datenbank & "\Temp\" & document.Filename, bytes)
        Return (My.Settings.Datenbank & "\Temp\" & document.Filename)
        'If document.Filename.Substring(document.Filename.LastIndexOf(".") + 1, document.Filename.Length - document.Filename.LastIndexOf(".") - 1) = "txt" Then
        '    Dim str As New StreamReader(mem)
        '    mem.Seek(0, System.IO.SeekOrigin.Begin)
        '    Return str.ReadToEnd()
        '    str.Close()
        'ElseIf document.Filename.Substring(document.Filename.LastIndexOf(".") + 1, document.Filename.Length - document.Filename.LastIndexOf(".") - 1) = "msg" Then
        '    Dim bytes() As Byte = mem.ToArray
        '    Dim stream As MemoryStream = New System.IO.MemoryStream(bytes)
        '    stream.Seek(0, System.IO.SeekOrigin.Begin)
        '    mem.Seek(0, IO.SeekOrigin.Begin)
        '    Dim msg As MapiMessage = MapiMessage.FromStream(mem)
        '    Return msg.BodyHtml
        'ElseIf document.Filename.Substring(document.Filename.LastIndexOf(".") + 1, document.Filename.Length - document.Filename.LastIndexOf(".") - 1) = "pdf" Then
        '    Dim bytes() As Byte = mem.ToArray
        '    File.WriteAllBytes("C\Temp\temp.pdf", bytes)
        '    'Anfragen.WebBrowser1.Navigate("C\Temp\temp.pdf")
        'End If
        db.Dispose()
    End Function

    Public Function LoadDocuments(id As String)
        Dim db As New LiteDatabase(My.Settings.Datenbank & "\Files.db")
        Return db.FileStorage.Find(id)
        db.Dispose()
    End Function

    Public Function DeleteDocument(id As String)
        Dim db As New LiteDatabase(My.Settings.Datenbank & "\Files.db")
        Return db.FileStorage.Delete(id)
        db.Dispose()
    End Function

    Public Function Maximum(table As String, col As String)
        Dim db As New LiteDatabase(My.Settings.Datenbank & "\Files.db")
        Dim Item As Integer = 0
        For Each file In db.GetCollection(table).FindAll

            If Item < file.Values(1).AsInt32 Then
                Item = file.Values(1).AsInt32
            End If
        Next
        Return Item
        db.Dispose()
    End Function

End Module
