﻿Public Class CardModel
    Public Property Id As Integer
    Public Property Name As String
    Public Property ImageId As Integer
    Public Property CardId
End Class
Public Class MonsterCardModel
    Inherits CardModel
    Public Property Description As String
    Public Property Attack As Integer
    Public Property Defense As Integer

End Class
Public Class SpellCardModel
    Inherits CardModel
    Public Property SpellEffect
End Class