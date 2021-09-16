Public Class frmCard



    Private Sub txtCardName_TextChanged(sender As Object, e As EventArgs) Handles txtCardName.TextChanged

    End Sub

    Private Sub frmCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If String.IsNullOrWhiteSpace(txtAttack.Text.ToString) Then
            txtAttack.Visible = False
            txtDefense.Visible = False
        End If
    End Sub
End Class