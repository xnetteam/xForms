Partial Class frmFirstCompany
    Dim ActiveCompany As ReadyMySQL.Company

    Sub New(Company As ReadyMySQL.Company)
        InitializeComponent()
        ActiveCompany = Company
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Cursor = Cursors.WaitCursor
        ActiveCompany.CreateFirstCompany(txtShortName.Text, txtFullName.Text)
        Cursor = Cursors.Default
        DialogResult = DialogResult.Yes
    End Sub

    Private Sub txtFullName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtShortName.KeyDown, txtFullName.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                e.SuppressKeyPress = True
                DialogResult = DialogResult.Cancel
            Case Keys.Enter
                e.SuppressKeyPress = True
                SelectNextControl(sender, True, True, True, True)
        End Select
    End Sub
End Class