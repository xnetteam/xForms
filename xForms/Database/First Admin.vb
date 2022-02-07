Partial Class frmFirstAdmin
    Dim ActiveCompany As ReadyMySQL.Company

    Sub New(Company As ReadyMySQL.Company)
        InitializeComponent()
        ActiveCompany = Company
    End Sub

    Private Sub frmFirstAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        lblInfo.Visible = False
        txtName.Text = txtName.Text.Trim
        txtSurname.Text = txtSurname.Text.Trim
        txtUsername.Text = txtUsername.Text.Trim
        txtPassword.Text = txtPassword.Text.Trim
        txtConfirm.Text = txtConfirm.Text.Trim
        If txtPassword.Text.Length < 4 Then
            lblInfo.Text = "Password too short"
            lblInfo.Visible = True
            txtPassword.Focus()
            Exit Sub
        End If
        If txtPassword.Text <> txtConfirm.Text Then
            lblInfo.Text = "Password not confirmed"
            lblInfo.Visible = True
            txtConfirm.Focus()
            Exit Sub
        End If
        Try
            ActiveCompany.CreateFirstAdmin(txtName.Text, txtSurname.Text, txtUsername.Text, txtPassword.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        DialogResult = DialogResult.Yes
    End Sub

    Private Sub KD(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown, txtSurname.KeyDown, txtPassword.KeyDown, txtName.KeyDown, txtConfirm.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                e.SuppressKeyPress = True
                SelectNextControl(sender, True, True, True, True)
            Case Keys.Escape
                e.SuppressKeyPress = True
                DialogResult = DialogResult.Cancel
        End Select
    End Sub
End Class