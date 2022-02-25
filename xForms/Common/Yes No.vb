Partial Class frmYesNo
    Public vrakam As DijalogRezultati = DijalogRezultati.Откажано

    Private Sub frmdlgYesNo_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        e.Graphics.DrawRectangle(New Pen(New SolidBrush(Color.FromArgb(140, 140, 140))), 0, 0, Width - 1, Height - 1)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()

    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        vrakam = DijalogRezultati.Да
        Close()

    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        vrakam = DijalogRezultati.Не
        Close()
    End Sub

    Private Sub btnYes_KeyDown(sender As Object, e As KeyEventArgs) Handles btnYes.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                btnNo_Click(sender, New EventArgs)
        End Select
    End Sub

End Class