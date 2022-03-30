Imports ReadyMySQL

Partial Class frmSelectArticle
    Dim Owner As Company

    Sub New(Company As Company)
        InitializeComponent()
        Owner = Company
    End Sub

    Private Sub frmSelectArticle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Owner.Articles.AssociateDataGridView(tblArticles, ArticlesSourceType.WordPress)
    End Sub

    Private Sub txtFilter_TextChanged(sender As Object, e As EventArgs) Handles txtFilter.TextChanged
        Owner.Articles.Filter(txtFilter.Text)
    End Sub

    Private Sub txtFilter_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFilter.KeyDown
        On Error Resume Next
        Select Case e.KeyCode
            Case Keys.Down
                e.SuppressKeyPress = True
                tblArticles.CurrentCell = tblArticles(1, tblArticles.CurrentRow.Index + 1)
            Case Keys.Up
                e.SuppressKeyPress = True
                tblArticles.CurrentCell = tblArticles(1, tblArticles.CurrentRow.Index - 1)
            Case Keys.Enter
                e.SuppressKeyPress = True
                btnSelect_Click(sender, e)
            Case Keys.Escape
                e.SuppressKeyPress = True
                If txtFilter.Text <> "" Then txtFilter.Text = "" Else DialogResult = DialogResult.Cancel
            Case Keys.Insert
                'Dim fr As New frmNewArticle(conn)
                'fr.ShowDialog(Me)
                'If fr.DialogResult = DialogResult.Yes Then
                '    conn.Articles.AssociateDataGridView(tblArticles, ArticlesSourceType.XNet)
                '    txtSearch.Text = fr.txtProduct.Text
                'End If
        End Select
    End Sub

    Private Sub tblArticles_KeyDown(sender As Object, e As KeyEventArgs) Handles tblArticles.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                e.SuppressKeyPress = True
                txtFilter.Focus()
            Case Keys.Enter
                e.SuppressKeyPress = True
                btnSelect_Click(sender, New EventArgs)
        End Select
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        If tblArticles.RowCount > 0 Then DialogResult = DialogResult.Yes
    End Sub
End Class