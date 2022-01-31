Partial Class frmInitFile

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        lblInfo.Visible = False
        txtFileName.Text = txtFileName.Text.Trim
        txtPCName.Text = txtPCName.Text.Trim
        If txtFileName.Text = "" Then
            lblInfo.Text = "Filename not valid"
            lblInfo.Visible = True
            txtFileName.Focus()
            Exit Sub
        End If
        If txtPCName.Text = "" Then
            lblInfo.Text = "PC name not valid"
            lblInfo.Visible = True
            txtPCName.Focus()
            Exit Sub
        End If
        Cursor = Cursors.WaitCursor
        Dim x As New ReadyMySQL.Database
        x.Create_New_Init_File(txtFileName.Text, txtDirectory.Text, txtPCName.Text)
        DialogResult = DialogResult.Yes
        Cursor = Cursors.Default
    End Sub

    Private Sub txtPCName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPCName.KeyDown, txtFileName.KeyDown, txtDirectory.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                e.SuppressKeyPress = True
                DialogResult = DialogResult.Cancel
            Case Keys.Enter
                e.SuppressKeyPress = True
                SelectNextControl(sender, True, True, True, True)
        End Select
    End Sub

    Private Sub frmInitFile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDirectory.Text = Application.StartupPath & "\data\connections\"
    End Sub

    Private Sub txtDirectory_DoubleClick(sender As Object, e As EventArgs) Handles txtDirectory.DoubleClick
        dlgFolder.ShowDialog()
        If dlgFolder.SelectedPath <> "" Then
            txtDirectory.Text = dlgFolder.SelectedPath
        End If
    End Sub

End Class