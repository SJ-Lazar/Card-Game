
Imports System.Configuration
Imports CardGameRepository

Public Class frmViewAllCards

    Dim connectionString = ConfigurationManager.ConnectionStrings("CardGameConnnectionString").ConnectionString.ToString()


    Private Sub frmViewAllCards_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetAllCardsList()

    End Sub

    Private Async Sub GetAllCardsList()
        Dim repository = New CardRepository(connectionString)
        'dgvCardsList.DataSource = repository.ReadCardList()
        dgvCardsList.ColumnCount = 3
        dgvCardsList.Columns(0).Name = "Id"
        dgvCardsList.Columns(1).Name = "Name"
        dgvCardsList.Columns(2).Name = "ImageId"
        Dim list = Await repository.ReadCardList()
        For Each item In list
            dgvCardsList.Rows.Add(item.Id, item.Name, item.ImageId)
        Next
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        GetAllCardsList()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        frmCreateCard.Show()
    End Sub
End Class