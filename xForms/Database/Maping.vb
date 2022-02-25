Imports ReadyMySQL

Partial Class frmMapping
    Dim Owner As Company
    Dim M4 As New ReadyMySQL.Database

    Sub New(Company As Company)
        InitializeComponent()
        Owner = Company
    End Sub

    Private Sub frmMapping_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbShema.SelectedIndex = 0
    End Sub

    Private Sub btnAnalize_Click(sender As Object, e As EventArgs) Handles btnAnalize.Click
        bgAnalize.RunWorkerAsync()
    End Sub

    Dim ListForAnalize As New List(Of DataTable)
    Private Sub bgAnalize_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgAnalize.DoWork
        Dim _ListForAnalize As New List(Of DataTable)
        Select Case cmbShema.SelectedIndex
            Case 0
                _ListForAnalize = M4.ListaCompany_Common
            Case 1
                _ListForAnalize = M4.ListaCompany_Coffee
        End Select
        bgAnalize.ReportProgress(1, _ListForAnalize)

        Dim dtBaseTables As DataTable = Owner.GetDatatables()
        bgAnalize.ReportProgress(2, dtBaseTables)
    End Sub

    Private Sub bgAnalize_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bgAnalize.ProgressChanged
        Select Case e.ProgressPercentage
            Case 1
                ListForAnalize = e.UserState
                Dim dtTables As New DataTable
                dtTables.Columns.Add("number", GetType(Integer))
                dtTables.Columns.Add("origin", GetType(String))
                dtTables.Columns.Add("origin_status", GetType(String))
                dtTables.Columns.Add("custom", GetType(String))
                dtTables.Columns.Add("custom_status", GetType(String))
                For Each t As DataTable In ListForAnalize
                    dtTables.Rows.Add(dtTables.Rows.Count + 1, t.TableName, "pending check")
                Next
                tblTables.DataSource = dtTables
            Case 2
                Dim dtBaseTables As DataTable = e.UserState
                For i = 0 To tblTables.RowCount - 1
                    For Each r As DataRow In dtBaseTables.Rows
                        If r(0).ToString.ToLower = tblTables("origin", i).Value Then

                        End If
                    Next
                Next
        End Select
    End Sub

End Class