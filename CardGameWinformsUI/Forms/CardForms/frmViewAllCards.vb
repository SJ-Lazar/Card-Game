
Imports System.Configuration
Imports CardGameRepository

Public Class frmViewAllCards

    Dim connectionString = ConfigurationManager.ConnectionStrings("CardGameConnnectionString").ConnectionString.ToString()


    Private Sub frmViewAllCards_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvCardsList.ColumnCount = 3
        dgvCardsList.Columns(0).Name = "Id"
        dgvCardsList.Columns(1).Name = "Name"
        dgvCardsList.Columns(2).Name = "ImageId"
        GetAllCardsList()

    End Sub

    Private Sub GetAllCardsList()
        Dim repository = New CardRepository(connectionString)
        dgvCardsList.Rows.Add(repository.ReadCardList())
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        GetAllCardsList()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        frmCreateCard.Show()
    End Sub
End Class