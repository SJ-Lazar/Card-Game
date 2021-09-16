Public Class MonsterCardModel
    Public Sub New(name As String, imagePath As String, imageName As String, description As String, attack As Integer, defense As Integer)
        Me.Name = name
        Me.ImagePath = imagePath
        Me.ImageName = imageName
        Me.Description = description
        Me.Attack = attack
        Me.Defense = defense
    End Sub

    Public Property Name As String
    Public Property ImagePath As String
    Public Property ImageName As String
    Public Property Description As String
    Public Property Attack As Integer
    Public Property Defense As Integer
End Class
