Public Class Files

    Public Sub Create_Init_File(Optional ShowModal As Boolean = False, Optional ShowInTaskbar As Boolean = True, Optional HideForm As Form = Nothing, Optional SugestedFilename As String = "", Optional SugestedDirectory As String = "")
        Dim fr As New frmInitFile
        fr.txtFileName.Text = SugestedFilename
        fr.ShowInTaskbar = ShowInTaskbar
        If Not IsNothing(HideForm) Then HideForm.Hide()
        If SugestedDirectory <> "" Then fr.txtDirectory.Text = SugestedDirectory
        If ShowModal Then
            fr.ShowDialog()
        Else
            fr.Show()
        End If
        If Not IsNothing(HideForm) Then HideForm.Show()
        fr = Nothing
    End Sub

    Public Sub Create_Connection_File(Optional ShowModal As Boolean = False, Optional ShowInTaskbar As Boolean = True, Optional HideForm As Form = Nothing)
        Dim fr As New frmConnectionFile
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
