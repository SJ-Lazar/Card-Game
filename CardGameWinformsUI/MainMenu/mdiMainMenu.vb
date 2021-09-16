Imports System.Windows.Forms

Public Class mdiMainMenu

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub btnManageCards_Click(sender As Object, e As EventArgs) Handles btnManageCards.Click
        frmViewAllCards.Show()
    End Sub

    Private Sub btnManagePlayers_Click(sender As Object, e As EventArgs) Handles btnManagePlayers.Click
        frmViewAllPlayers.Show()
    End Sub

    Private Sub btnCardManager_Click(sender As Object, e As EventArgs) Handles btnCardManager.Click
        frmCardManager.Show()
    End Sub

    Private Sub mdiMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
