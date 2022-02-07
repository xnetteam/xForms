Partial Class frmDeleteClient
    Dim Owner As ReadyMySQL.Client

    Sub New(Client As ReadyMySQL.Client)
        InitializeComponent()
        Owner = Client
    End Sub

End Class