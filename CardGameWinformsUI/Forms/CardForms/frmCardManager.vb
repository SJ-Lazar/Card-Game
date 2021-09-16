Public Class frmCardManager
    Private Sub btnShowCard_Click(sender As Object, e As EventArgs) Handles btnShowCard.Click
        Dim frmCard = New frmCard()
        frmCard.txtCardName.Text = "Battle Fox"
        frmCard.pbCardImage.Image = Image.FromFile("C:\Users\Lenovo\Pictures\Card Game\battleFox.png")
        frmCard.txtCardDescription.Text = "Smart Fox"
        frmCard.txtAttack.Text = CStr(2000)
        frmCard.ShowDialog()
    End Sub
End Class