Imports ReadyMySQL

Public Class Articles
    Dim Owner As Company

    Sub New(Company As Company)
        Owner = Company

    End Sub

    Public Function SelectArticle(Source As ArticlesSourceType, Optional HideForm As Form = Nothing) As Article
        Select Case Source
            Case ArticlesSourceType.XNet

            Case ArticlesSourceType.WordPress
                Dim Art As Article = New Article(Owner)
                Dim fr As New frmSelectArticle(Owner)
                If Not IsNothing(HideForm) Then HideForm.Hide()
                fr.ShowDialog()
                If fr.DialogResult = DialogResult.Yes Then
                    Art = Owner.Articles.FromID(fr.tblArticles("id", fr.tblArticles.CurrentRow.Index).Value)
                End If
                fr = Nothing
                If Not IsNothing(HideForm) Then HideForm.Show()
                If Not IsNothing(Art) Then Return Art
        End Select
        Return Nothing
    End Function
End Class
