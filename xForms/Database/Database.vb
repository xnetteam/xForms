Public Class Database

    Public Sub InsertFirstCompany(Company As ReadyMySQL.Company, Optional ShowModal As Boolean = False, Optional ShowInTaskbar As Boolean = True, Optional HideForm As Form = Nothing, Optional SugestedShortName As String = "", Optional SugestedFullName As String = "")
        Dim fr As New frmFirstCompany(Company)
        fr.txtShortName.Text = SugestedShortName
        fr.txtFullName.Text = SugestedFullName
        fr.ShowInTaskbar = ShowInTaskbar
        If Not IsNothing(HideForm) Then HideForm.Hide()
        If ShowModal Then
            fr.ShowDialog()
        Else
            fr.Show()
        End If
        If Not IsNothing(HideForm) Then HideForm.Show()
        fr = Nothing
    End Sub

    Public Sub InsertFirstAdmin(Company As ReadyMySQL.Company, Optional ShowModal As Boolean = False, Optional ShowInTaskbar As Boolean = True, Optional HideForm As Form = Nothing)
        Dim fr As New frmFirstAdmin(Company)
        fr.ShowInTaskbar = ShowInTaskbar
        If Not IsNothing(HideForm) Then HideForm.Hide()
        If ShowModal Then
            fr.ShowDialog()
        Else
            fr.Show()
        End If
        If Not IsNothing(HideForm) Then HideForm.Show()
        fr = Nothing
    End Sub


End Class
