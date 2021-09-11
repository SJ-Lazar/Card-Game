
Imports System.Configuration
Imports CardGameHelpers

Public Class frmViewAllCards

    Dim connectionString = ConfigurationManager.ConnectionStrings("CardGameConnnectionString").ConnectionString.ToString()


    Private Sub frmViewAllCards_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetAllCardsList()
    End Sub

    Private Sub GetAllCardsList()
        Dim sqlhelper = New SqlHelper()
        Dim cardList = sqlhelper.ExecuteQuery(connectionString, "SELECT * FROM dbo.Card")
        If IsNothing(cardList) Then
            MsgBox("Card List is Empty")
        Else
            dgvCardsList.DataSource = cardList
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        GetAllCardsList()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        frmCreateCard.Show()
    End Sub
End Class