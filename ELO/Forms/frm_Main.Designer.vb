<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BearbeitenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EinstellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnsichtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HilfeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Files = New System.Windows.Forms.ListView()
        Me.ImageList4 = New System.Windows.Forms.ImageList(Me.components)
        Me.Projects = New System.Windows.Forms.TableLayoutPanel()
        Me.Header = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_Del = New System.Windows.Forms.Button()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.Tools = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_Demnaechst = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btn_Ablage = New System.Windows.Forms.Button()
        Me.btn_Übersicht = New System.Windows.Forms.Button()
        Me.btn_Heute = New System.Windows.Forms.Button()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.tb_search = New System.Windows.Forms.TextBox()
        Me.ImageList3 = New System.Windows.Forms.ImageList(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Projects.SuspendLayout()
        Me.Header.SuspendLayout()
        Me.Tools.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.BearbeitenToolStripMenuItem, Me.AnsichtToolStripMenuItem, Me.HilfeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1186, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportToolStripMenuItem, Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExcelToolStripMenuItem})
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.ExportToolStripMenuItem.Text = "Export"
        '
        'ExcelToolStripMenuItem
        '
        Me.ExcelToolStripMenuItem.Name = "ExcelToolStripMenuItem"
        Me.ExcelToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.ExcelToolStripMenuItem.Text = "Excel"
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.BeendenToolStripMenuItem.Text = "Beenden"
        '
        'BearbeitenToolStripMenuItem
        '
        Me.BearbeitenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EinstellungenToolStripMenuItem})
        Me.BearbeitenToolStripMenuItem.Name = "BearbeitenToolStripMenuItem"
        Me.BearbeitenToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.BearbeitenToolStripMenuItem.Text = "Bearbeiten"
        '
        'EinstellungenToolStripMenuItem
        '
        Me.EinstellungenToolStripMenuItem.Name = "EinstellungenToolStripMenuItem"
        Me.EinstellungenToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.EinstellungenToolStripMenuItem.Text = "Einstellungen"
        '
        'AnsichtToolStripMenuItem
        '
        Me.AnsichtToolStripMenuItem.Name = "AnsichtToolStripMenuItem"
        Me.AnsichtToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.AnsichtToolStripMenuItem.Text = "Ansicht"
        '
        'HilfeToolStripMenuItem
        '
        Me.HilfeToolStripMenuItem.Name = "HilfeToolStripMenuItem"
        Me.HilfeToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HilfeToolStripMenuItem.Text = "Hilfe"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Tools, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 24)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1186, 567)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Projects, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 50)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1186, 517)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Files, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(886, 0)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(300, 517)
        Me.TableLayoutPanel3.TabIndex = 4
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(300, 50)
        Me.TableLayoutPanel4.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 50)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Dokumente"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Files
        '
        Me.Files.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Files.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Files.LargeImageList = Me.ImageList4
        Me.Files.Location = New System.Drawing.Point(3, 53)
        Me.Files.MultiSelect = False
        Me.Files.Name = "Files"
        Me.Files.Size = New System.Drawing.Size(294, 461)
        Me.Files.SmallImageList = Me.ImageList4
        Me.Files.TabIndex = 4
        Me.Files.UseCompatibleStateImageBehavior = False
        Me.Files.View = System.Windows.Forms.View.List
        '
        'ImageList4
        '
        Me.ImageList4.ImageStream = CType(resources.GetObject("ImageList4.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList4.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList4.Images.SetKeyName(0, "pdf (1).png")
        Me.ImageList4.Images.SetKeyName(1, "email_open.png")
        Me.ImageList4.Images.SetKeyName(2, "27_edit_text.png")
        Me.ImageList4.Images.SetKeyName(3, "MS-Word-2-icon.png")
        Me.ImageList4.Images.SetKeyName(4, "Excel-icon.png")
        Me.ImageList4.Images.SetKeyName(5, "icon-909830_640.png")
        Me.ImageList4.Images.SetKeyName(6, "Help-Support-icon.png")
        '
        'Projects
        '
        Me.Projects.ColumnCount = 1
        Me.Projects.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Projects.Controls.Add(Me.Header, 0, 0)
        Me.Projects.Controls.Add(Me.MainPanel, 0, 1)
        Me.Projects.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Projects.Location = New System.Drawing.Point(0, 0)
        Me.Projects.Margin = New System.Windows.Forms.Padding(0)
        Me.Projects.Name = "Projects"
        Me.Projects.RowCount = 2
        Me.Projects.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.Projects.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Projects.Size = New System.Drawing.Size(886, 517)
        Me.Projects.TabIndex = 3
        '
        'Header
        '
        Me.Header.ColumnCount = 3
        Me.Header.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.Header.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Header.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.Header.Controls.Add(Me.btn_Add, 0, 0)
        Me.Header.Controls.Add(Me.Label2, 1, 0)
        Me.Header.Controls.Add(Me.btn_Del, 2, 0)
        Me.Header.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Header.Location = New System.Drawing.Point(0, 0)
        Me.Header.Margin = New System.Windows.Forms.Padding(0)
        Me.Header.Name = "Header"
        Me.Header.RowCount = 1
        Me.Header.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Header.Size = New System.Drawing.Size(886, 50)
        Me.Header.TabIndex = 6
        '
        'btn_Add
        '
        Me.btn_Add.BackColor = System.Drawing.SystemColors.Window
        Me.btn_Add.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Add.FlatAppearance.BorderSize = 0
        Me.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Add.ImageIndex = 0
        Me.btn_Add.ImageList = Me.ImageList2
        Me.btn_Add.Location = New System.Drawing.Point(0, 0)
        Me.btn_Add.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(50, 50)
        Me.btn_Add.TabIndex = 5
        Me.btn_Add.UseVisualStyleBackColor = False
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "Add-icon.png")
        Me.ImageList2.Images.SetKeyName(1, "trash-icon.png")
        Me.ImageList2.Images.SetKeyName(2, "save-icon.png")
        Me.ImageList2.Images.SetKeyName(3, "Actions-process-stop-icon.png")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(786, 50)
        Me.Label2.TabIndex = 2
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_Del
        '
        Me.btn_Del.BackColor = System.Drawing.SystemColors.Window
        Me.btn_Del.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Del.FlatAppearance.BorderSize = 0
        Me.btn_Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Del.ImageIndex = 1
        Me.btn_Del.ImageList = Me.ImageList2
        Me.btn_Del.Location = New System.Drawing.Point(836, 0)
        Me.btn_Del.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Del.Name = "btn_Del"
        Me.btn_Del.Size = New System.Drawing.Size(50, 50)
        Me.btn_Del.TabIndex = 4
        Me.btn_Del.UseVisualStyleBackColor = False
        '
        'MainPanel
        '
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(3, 53)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(880, 461)
        Me.MainPanel.TabIndex = 7
        '
        'Tools
        '
        Me.Tools.BackColor = System.Drawing.SystemColors.MenuText
        Me.Tools.ColumnCount = 9
        Me.Tools.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.Tools.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.Tools.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.Tools.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.Tools.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.Tools.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.Tools.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Tools.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.Tools.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.Tools.Controls.Add(Me.btn_Demnaechst, 0, 0)
        Me.Tools.Controls.Add(Me.btn_Ablage, 0, 0)
        Me.Tools.Controls.Add(Me.btn_Übersicht, 0, 0)
        Me.Tools.Controls.Add(Me.btn_Heute, 0, 0)
        Me.Tools.Controls.Add(Me.btn_search, 8, 0)
        Me.Tools.Controls.Add(Me.tb_search, 7, 0)
        Me.Tools.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tools.Location = New System.Drawing.Point(0, 0)
        Me.Tools.Margin = New System.Windows.Forms.Padding(0)
        Me.Tools.Name = "Tools"
        Me.Tools.RowCount = 1
        Me.Tools.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Tools.Size = New System.Drawing.Size(1186, 50)
        Me.Tools.TabIndex = 1
        '
        'btn_Demnaechst
        '
        Me.btn_Demnaechst.BackColor = System.Drawing.SystemColors.MenuText
        Me.btn_Demnaechst.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Demnaechst.FlatAppearance.BorderSize = 0
        Me.btn_Demnaechst.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Demnaechst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Demnaechst.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Demnaechst.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_Demnaechst.ImageIndex = 1
        Me.btn_Demnaechst.ImageList = Me.ImageList1
        Me.btn_Demnaechst.Location = New System.Drawing.Point(203, 3)
        Me.btn_Demnaechst.Name = "btn_Demnaechst"
        Me.btn_Demnaechst.Size = New System.Drawing.Size(94, 44)
        Me.btn_Demnaechst.TabIndex = 3
        Me.btn_Demnaechst.Text = "Demnächst"
        Me.btn_Demnaechst.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btn_Demnaechst.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "blueBar-bk.jpg")
        Me.ImageList1.Images.SetKeyName(1, "blackBar-bk.jpg")
        '
        'btn_Ablage
        '
        Me.btn_Ablage.BackColor = System.Drawing.SystemColors.MenuText
        Me.btn_Ablage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Ablage.FlatAppearance.BorderSize = 0
        Me.btn_Ablage.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Ablage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Ablage.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Ablage.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_Ablage.ImageIndex = 1
        Me.btn_Ablage.ImageList = Me.ImageList1
        Me.btn_Ablage.Location = New System.Drawing.Point(303, 3)
        Me.btn_Ablage.Name = "btn_Ablage"
        Me.btn_Ablage.Size = New System.Drawing.Size(94, 44)
        Me.btn_Ablage.TabIndex = 2
        Me.btn_Ablage.Text = "Ablage"
        Me.btn_Ablage.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btn_Ablage.UseVisualStyleBackColor = False
        '
        'btn_Übersicht
        '
        Me.btn_Übersicht.BackColor = System.Drawing.SystemColors.MenuText
        Me.btn_Übersicht.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Übersicht.FlatAppearance.BorderSize = 0
        Me.btn_Übersicht.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Übersicht.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Übersicht.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Übersicht.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_Übersicht.ImageIndex = 1
        Me.btn_Übersicht.ImageList = Me.ImageList1
        Me.btn_Übersicht.Location = New System.Drawing.Point(3, 3)
        Me.btn_Übersicht.Name = "btn_Übersicht"
        Me.btn_Übersicht.Size = New System.Drawing.Size(94, 44)
        Me.btn_Übersicht.TabIndex = 1
        Me.btn_Übersicht.Text = "Übersicht"
        Me.btn_Übersicht.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btn_Übersicht.UseVisualStyleBackColor = False
        '
        'btn_Heute
        '
        Me.btn_Heute.BackColor = System.Drawing.SystemColors.MenuText
        Me.btn_Heute.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Heute.FlatAppearance.BorderSize = 0
        Me.btn_Heute.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Heute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Heute.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Heute.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_Heute.ImageIndex = 1
        Me.btn_Heute.ImageList = Me.ImageList1
        Me.btn_Heute.Location = New System.Drawing.Point(103, 3)
        Me.btn_Heute.Name = "btn_Heute"
        Me.btn_Heute.Size = New System.Drawing.Size(94, 44)
        Me.btn_Heute.TabIndex = 0
        Me.btn_Heute.Text = "Heute"
        Me.btn_Heute.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btn_Heute.UseVisualStyleBackColor = False
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.SystemColors.MenuText
        Me.btn_search.FlatAppearance.BorderSize = 0
        Me.btn_search.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_search.ImageIndex = 6
        Me.btn_search.ImageList = Me.ImageList4
        Me.btn_search.Location = New System.Drawing.Point(1149, 3)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(34, 44)
        Me.btn_search.TabIndex = 5
        Me.btn_search.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'tb_search
        '
        Me.tb_search.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb_search.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_search.Location = New System.Drawing.Point(999, 12)
        Me.tb_search.Margin = New System.Windows.Forms.Padding(3, 12, 3, 3)
        Me.tb_search.Name = "tb_search"
        Me.tb_search.Size = New System.Drawing.Size(144, 28)
        Me.tb_search.TabIndex = 4
        Me.tb_search.Text = "Suche"
        '
        'ImageList3
        '
        Me.ImageList3.ImageStream = CType(resources.GetObject("ImageList3.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList3.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList3.Images.SetKeyName(0, "folder-close-icon.png")
        Me.ImageList3.Images.SetKeyName(1, "Actions-view-calendar-tasks-icon.png")
        Me.ImageList3.Images.SetKeyName(2, "User-Interface-Checked-Checkbox-icon.png")
        Me.ImageList3.Images.SetKeyName(3, "User-Interface-Unchecked-Checkbox-icon.png")
        Me.ImageList3.Images.SetKeyName(4, "Button-Next-icon.png")
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1186, 591)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_Main"
        Me.Text = "Chaotic Filing System"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.Projects.ResumeLayout(False)
        Me.Header.ResumeLayout(False)
        Me.Header.PerformLayout()
        Me.Tools.ResumeLayout(False)
        Me.Tools.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DateiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BearbeitenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnsichtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HilfeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Tools As TableLayoutPanel
    Friend WithEvents btn_Heute As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents BeendenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EinstellungenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImageList2 As ImageList
    Friend WithEvents ImageList3 As ImageList
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Demnaechst As Button
    Friend WithEvents btn_Ablage As Button
    Friend WithEvents btn_Übersicht As Button
    Friend WithEvents Files As ListView
    Friend WithEvents ImageList4 As ImageList
    Friend WithEvents Projects As TableLayoutPanel
    Friend WithEvents Header As TableLayoutPanel
    Friend WithEvents btn_Add As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_Del As Button
    Friend WithEvents MainPanel As Panel
    Friend WithEvents btn_search As Button
    Friend WithEvents tb_search As TextBox
    Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExcelToolStripMenuItem As ToolStripMenuItem
End Class
