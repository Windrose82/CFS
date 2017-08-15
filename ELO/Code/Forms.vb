Module Forms
    Public Sub OpenForm(frm As Form, panel As Panel)
        panel.Controls.Clear()
        frm.TopLevel = False
        frm.Dock = DockStyle.Fill
        panel.Controls.Add(frm)
        frm.Show()
        frm.Focus()
    End Sub
End Module
