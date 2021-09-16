Imports System.Configuration
Imports CardGameDataModels
Imports CardGameRepository

Public Class frmCreateCard

    Dim _connectionString = ConfigurationManager.ConnectionStrings("CardGameConnnectionString").ConnectionString.ToString()

    Private Sub btnChooseImage_Click(sender As Object, e As EventArgs) Handles btnChooseImage.Click
        If ofdImage.ShowDialog = DialogResult.OK Then
            txtImagePath.Text = ofdImage.FileName
            pbImage.ImageLocation = txtImagePath.Text
            txtImageName.Text = txtImagePath.Text.Substring(txtImagePath.Text.LastIndexOf("\") + 1).ToString()
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim repository = New CardRepository(_connectionString)
        Dim model = New MonsterCardModel(txtName.Text.ToString,
                                         txtImagePath.Text.ToString(),
                                         txtImageName.Text.ToString(),
                                         txtDescription.Text.ToString(),
                                         CInt(nudAttack.Value),
                                         CInt(nudDefense.Value)
                                         )
        Dim IsSuccess = repository.Create(model)
        If IsSuccess Then
            Me.Close()
            frmViewAllCards.Show()
        End If
    End Sub
End Class