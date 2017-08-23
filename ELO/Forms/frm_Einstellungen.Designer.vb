<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Einstellungen
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Einstellungen))
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.tb_Datenbank = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_file = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Email = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_nr = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_ordner = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.grd_Ablage = New System.Windows.Forms.DataGridView()
        Me.Ablage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Minimum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Maximum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ord_Outlook = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.grd_Ablage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "save-diskette-floppy-disk-icon.png")
        Me.ImageList2.Images.SetKeyName(1, "Actions-process-stop-icon.png")
        Me.ImageList2.Images.SetKeyName(2, "Filesystem-folder-blue-icon.png")
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(816, 402)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(808, 376)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Grundeinstellungen"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.tb_Datenbank, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_file, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Email, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.tb_nr, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.tb_ordner, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.ord_Outlook, 2, 3)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 6
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(802, 370)
        Me.TableLayoutPanel3.TabIndex = 4
        '
        'tb_Datenbank
        '
        Me.tb_Datenbank.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb_Datenbank.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Datenbank.Location = New System.Drawing.Point(194, 4)
        Me.tb_Datenbank.Margin = New System.Windows.Forms.Padding(3, 4, 3, 3)
        Me.tb_Datenbank.Name = "tb_Datenbank"
        Me.tb_Datenbank.Size = New System.Drawing.Size(567, 22)
        Me.tb_Datenbank.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Datenbankordner"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_file
        '
        Me.btn_file.BackColor = System.Drawing.Color.Transparent
        Me.btn_file.FlatAppearance.BorderSize = 0
        Me.btn_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_file.ImageIndex = 2
        Me.btn_file.ImageList = Me.ImageList2
        Me.btn_file.Location = New System.Drawing.Point(767, 3)
        Me.btn_file.Name = "btn_file"
        Me.btn_file.Size = New System.Drawing.Size(31, 23)
        Me.btn_file.TabIndex = 2
        Me.btn_file.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 30)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Email Adresse"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Email
        '
        Me.Email.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email.Location = New System.Drawing.Point(194, 34)
        Me.Email.Margin = New System.Windows.Forms.Padding(3, 4, 3, 3)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(567, 22)
        Me.Email.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(185, 30)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nummernkreis Aufgaben"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tb_nr
        '
        Me.tb_nr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb_nr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_nr.Location = New System.Drawing.Point(194, 64)
        Me.tb_nr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 3)
        Me.tb_nr.Name = "tb_nr"
        Me.tb_nr.Size = New System.Drawing.Size(567, 22)
        Me.tb_nr.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(185, 30)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Outlook Ordner"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tb_ordner
        '
        Me.tb_ordner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb_ordner.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_ordner.Location = New System.Drawing.Point(194, 94)
        Me.tb_ordner.Margin = New System.Windows.Forms.Padding(3, 4, 3, 3)
        Me.tb_ordner.Name = "tb_ordner"
        Me.tb_ordner.Size = New System.Drawing.Size(567, 22)
        Me.tb_ordner.TabIndex = 8
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.grd_Ablage)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(808, 376)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ordner"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'grd_Ablage
        '
        Me.grd_Ablage.AllowUserToDeleteRows = False
        Me.grd_Ablage.BackgroundColor = System.Drawing.SystemColors.Window
        Me.grd_Ablage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_Ablage.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ablage, Me.Minimum, Me.Maximum, Me.ID})
        Me.grd_Ablage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grd_Ablage.Location = New System.Drawing.Point(3, 3)
        Me.grd_Ablage.Name = "grd_Ablage"
        Me.grd_Ablage.RowHeadersVisible = False
        Me.grd_Ablage.Size = New System.Drawing.Size(802, 370)
        Me.grd_Ablage.TabIndex = 0
        '
        'Ablage
        '
        Me.Ablage.HeaderText = "Ablage"
        Me.Ablage.Name = "Ablage"
        '
        'Minimum
        '
        Me.Minimum.HeaderText = "Min"
        Me.Minimum.Name = "Minimum"
        '
        'Maximum
        '
        Me.Maximum.HeaderText = "Max"
        Me.Maximum.Name = "Maximum"
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Visible = False
        '
        'ord_Outlook
        '
        Me.ord_Outlook.BackColor = System.Drawing.Color.Transparent
        Me.ord_Outlook.FlatAppearance.BorderSize = 0
        Me.ord_Outlook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ord_Outlook.ImageIndex = 2
        Me.ord_Outlook.ImageList = Me.ImageList2
        Me.ord_Outlook.Location = New System.Drawing.Point(767, 93)
        Me.ord_Outlook.Name = "ord_Outlook"
        Me.ord_Outlook.Size = New System.Drawing.Size(31, 23)
        Me.ord_Outlook.TabIndex = 9
        Me.ord_Outlook.UseVisualStyleBackColor = False
        '
        'frm_Einstellungen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(816, 402)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Einstellungen"
        Me.Text = "frm_Einstellungen"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.grd_Ablage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageList2 As ImageList
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents tb_Datenbank As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents grd_Ablage As DataGridView
    Friend WithEvents Ablage As DataGridViewTextBoxColumn
    Friend WithEvents Minimum As DataGridViewTextBoxColumn
    Friend WithEvents Maximum As DataGridViewTextBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents btn_file As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Label2 As Label
    Friend WithEvents Email As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_nr As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_ordner As TextBox
    Friend WithEvents ord_Outlook As Button
End Class
