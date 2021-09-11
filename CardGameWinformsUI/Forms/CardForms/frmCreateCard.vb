Public Class frmCreateCard
    Private Sub btnChooseImage_Click(sender As Object, e As EventArgs) Handles btnChooseImage.Click
        If ofdImage.ShowDialog = DialogResult.OK Then
            txtImageName.Text = ofdImage.FileName
            pbImage.ImageLocation = txtImageName.Text
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

    End Sub
End Class