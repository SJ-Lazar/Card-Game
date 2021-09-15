Imports System.Configuration
Imports CardGameDataModels
Imports CardGameRepository

Public Class frmCreateCard

    Dim _connectionString = ConfigurationManager.ConnectionStrings("CardGameConnnectionString").ConnectionString.ToString()

    Private Sub btnChooseImage_Click(sender As Object, e As EventArgs) Handles btnChooseImage.Click
        If ofdImage.ShowDialog = DialogResult.OK Then
            txtImageName.Text = ofdImage.FileName
            pbImage.ImageLocation = txtImageName.Text
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim repository = New CardRepository(_connectionString)
        Dim model = New CardModel(txtName.Text.ToString, 1)
        Dim IsSuccess = repository.Create(model)
    End Sub
End Class