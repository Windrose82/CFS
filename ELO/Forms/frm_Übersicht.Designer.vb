<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Übersicht
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Übersicht))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.Table = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Anhang = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Datum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ablage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ansprechpartner = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bezeichnung = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Abgeschlossen = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.Table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "Add-icon.png")
        Me.ImageList2.Images.SetKeyName(1, "trash-icon.png")
        '
        'Table
        '
        Me.Table.AllowDrop = True
        Me.Table.AllowUserToAddRows = False
        Me.Table.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveBorder
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Table.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Table.BackgroundColor = System.Drawing.SystemColors.Window
        Me.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table.ColumnHeadersVisible = False
        Me.Table.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Abgeschlossen, Me.Bezeichnung, Me.Ansprechpartner, Me.Ablage, Me.Datum, Me.ID, Me.Anhang})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Table.DefaultCellStyle = DataGridViewCellStyle6
        Me.Table.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Table.Location = New System.Drawing.Point(0, 0)
        Me.Table.MultiSelect = False
        Me.Table.Name = "Table"
        Me.Table.RowHeadersVisible = False
        Me.Table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Table.Size = New System.Drawing.Size(930, 431)
        Me.Table.TabIndex = 0
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Anhang"
        Me.DataGridViewImageColumn1.Image = Global.CFS.My.Resources.Resources.attachment_icon
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Anhang
        '
        Me.Anhang.HeaderText = "Anhang"
        Me.Anhang.Image = CType(resources.GetObject("Anhang.Image"), System.Drawing.Image)
        Me.Anhang.Name = "Anhang"
        Me.Anhang.ReadOnly = True
        Me.Anhang.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Anhang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Anhang.Width = 30
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Visible = False
        '
        'Datum
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Format = "d"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Datum.DefaultCellStyle = DataGridViewCellStyle5
        Me.Datum.HeaderText = "Datum"
        Me.Datum.Name = "Datum"
        Me.Datum.ToolTipText = "Datum"
        '
        'Ablage
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Ablage.DefaultCellStyle = DataGridViewCellStyle4
        Me.Ablage.HeaderText = "Ablage"
        Me.Ablage.Name = "Ablage"
        Me.Ablage.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Ablage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Ablage.ToolTipText = "Ablageort"
        Me.Ablage.Width = 55
        '
        'Ansprechpartner
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Ansprechpartner.DefaultCellStyle = DataGridViewCellStyle3
        Me.Ansprechpartner.HeaderText = "Kontakt"
        Me.Ansprechpartner.Name = "Ansprechpartner"
        Me.Ansprechpartner.ToolTipText = "Kontak"
        '
        'Bezeichnung
        '
        Me.Bezeichnung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Bezeichnung.DefaultCellStyle = DataGridViewCellStyle2
        Me.Bezeichnung.HeaderText = "Bezeichnung"
        Me.Bezeichnung.Name = "Bezeichnung"
        Me.Bezeichnung.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Bezeichnung.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Bezeichnung.ToolTipText = "Bezeichnung"
        '
        'Abgeschlossen
        '
        Me.Abgeschlossen.FalseValue = "False"
        Me.Abgeschlossen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Abgeschlossen.HeaderText = ""
        Me.Abgeschlossen.MinimumWidth = 25
        Me.Abgeschlossen.Name = "Abgeschlossen"
        Me.Abgeschlossen.ToolTipText = "Status"
        Me.Abgeschlossen.TrueValue = "True"
        Me.Abgeschlossen.Width = 50
        '
        'frm_Übersicht
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(930, 431)
        Me.Controls.Add(Me.Table)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Übersicht"
        Me.Text = "Übersicht"
        CType(Me.Table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageList2 As ImageList
    Friend WithEvents Table As DataGridView
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents Abgeschlossen As DataGridViewCheckBoxColumn
    Friend WithEvents Bezeichnung As DataGridViewTextBoxColumn
    Friend WithEvents Ansprechpartner As DataGridViewTextBoxColumn
    Friend WithEvents Ablage As DataGridViewTextBoxColumn
    Friend WithEvents Datum As DataGridViewTextBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Anhang As DataGridViewImageColumn
End Class
