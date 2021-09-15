
Imports System.Configuration
Imports CardGameRepository

Public Class frmViewAllCards

    Dim connectionString = ConfigurationManager.ConnectionStrings("CardGameConnnectionString").ConnectionString.ToString()

    Private Sub frmViewAllCards_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetAllCards()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        GetAllCards()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        frmCreateCard.ShowDialog()
    End Sub

    Private Sub GetAllCards()
        Dim repository = New CardRepository(connectionString)
        dgvCardsList.DataSource = repository.Read()
    End Sub
End Class