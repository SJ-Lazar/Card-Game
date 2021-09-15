Public Interface IGenericCrud(Of T)
    Function Create(model As T) As Boolean
    Function Update(id As Integer, model As T) As Boolean
    Function Delete(Id As Integer) As Boolean
    Function Read() As DataTable
End Interface