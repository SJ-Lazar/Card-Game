Public Interface ISqlControl
    Sub AddParam(name As String, value As Object)
    Sub ExecuteQuery(query As String)
    Function HasException(Optional report As Boolean = False) As Boolean
End Interface
