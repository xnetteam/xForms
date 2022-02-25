Partial Class frmAdminZone
    Private Sub frmAdminZone_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click, MyBase.Click, Label3.Click, Label2.Click, Label1.Click
        Close()
    End Sub
End Class