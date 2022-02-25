Partial Class frmInputString
    Sub Vizuelno()
        btnOtkazi.Image = My.Resources.Resources.cancel16
        btnVnesi.Image = My.Resources.Resources.ok16

    End Sub

    Private Sub btnOtkazi_Click(sender As Object, e As EventArgs) Handles btnOtkazi.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnVnesi_Click(sender As Object, e As EventArgs) Handles btnVnesi.Click
        DialogResult = Windows.Forms.DialogResult.Yes
    End Sub

    Private Sub txt_KeyDown(sender As Object, e As KeyEventArgs) Handles txt.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                e.SuppressKeyPress = True
                btnVnesi_Click(sender, New EventArgs)
            Case Keys.Escape
                e.SuppressKeyPress = True
                btnOtkazi_Click(sender, New EventArgs)
        End Select
    End Sub

    Private Sub frmInputString_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Vizuelno()
    End Sub
End Class