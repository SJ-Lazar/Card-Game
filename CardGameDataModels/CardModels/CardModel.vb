Public Class CardModel
    Public Sub New(id As Integer, name As String, imageId As Integer)
        Me.Id = id
        Me.Name = name
        Me.ImageId = imageId
    End Sub

    Public Property Id As Integer
    Public Property Name As String
    Public Property ImageId As Integer



End Class
'Public Class MonsterCardModel
'    Inherits CardModel
'    Public Property Description As String
'    Public Property Attack As Integer
'    Public Property Defense As Integer

'End Class
'Public Class SpellCardModel
'    Inherits CardModel
'    Public Property SpellEffect
'End Class