Imports MySql.Data.MySqlClient

Partial Class frmConnectionFile

    Function TitleOK() As Boolean
        lblInfo.Visible = False
        txtTitle.Text = txtTitle.Text.Trim
        If txtTitle.Text = "" Then
            lblInfo.Text = "Title not valid"
            lblInfo.Visible = True
            txtTitle.Focus()
            Return False
        End If
        Return True
    End Function

    Function PasswordOK() As Boolean
        txtMySQLPassword.Text = txtMySQLPassword.Text.Trim
        txtConfirmPassword.Text = txtConfirmPassword.Text.Trim
        If txtMySQLPassword.Text <> txtConfirmPassword.Text Then
            lblInfo.Text = "Password not confirmed"
            lblInfo.Visible = True
            txtConfirmPassword.Focus()
            txtConfirmPassword.SelectAll()
            Return False
        End If
        Return True
    End Function


    Private Sub txtDatabase_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTitle.KeyDown, txtServerAddress.KeyDown, txtMySQLUsername.KeyDown, txtMySQLPassword.KeyDown, txtDatabase.KeyDown, txtConfirmPassword.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                e.SuppressKeyPress = True
                DialogResult = DialogResult.Cancel
            Case Keys.Enter
                e.SuppressKeyPress = True
                SelectNextControl(sender, True, True, True, True)
        End Select
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        lblInfo.Visible = False
        If TitleOK() AndAlso PasswordOK() Then
            Dim x As New ReadyMySQL.Database
            x.Create_New_Connection_File(txtTitle.Text, txtServerAddress.Text, txtMySQLUsername.Text, txtMySQLPassword.Text, txtDatabase.Text, "")
            DialogResult = DialogResult.Yes
        End If
    End Sub

    Private Sub btnTestConnection_Click(sender As Object, e As EventArgs) Handles btnTestConnection.Click
        txtDatabase.Text = txtDatabase.Text.Trim
        If txtDatabase.Text <> "" Then
            Dim MySQLConnectionString = "server= '" & txtServerAddress.Text & "';user id='" & txtMySQLUsername.Text & "';password='" & txtMySQLPassword.Text & "';database='" & txtDatabase.Text & "';Convert Zero Datetime=True; Connection Timeout = 10;"
            Dim dt As New DataTable
            Dim conn As New MySqlConnection(MySQLConnectionString)
            Dim da = New MySqlDataAdapter("select count(*) from information_schema.tables where table_schema = '" & txtDatabase.Text & "'", conn)
            Try
                da.Fill(dt)
                MsgBox("Connection OK")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        Else
            MsgBox("Please enter valid database name", MsgBoxStyle.Exclamation)
        End If
    End Sub

End Class