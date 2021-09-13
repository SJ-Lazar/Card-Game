
Imports System.Configuration
Imports CardGameRepository

Public Class frmViewAllCards

    Dim connectionString = ConfigurationManager.ConnectionStrings("CardGameConnnectionString").ConnectionString.ToString()


    Private Sub frmViewAllCards_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetAllCardsList()

    End Sub

    Private Sub GetAllCardsList()
        Dim repository = New CardRepository(connectionString)
        dgvCardsList.DataSource = repository.ReadCardList()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        GetAllCardsList()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        frmCreateCard.Show()
    End Sub
End Class