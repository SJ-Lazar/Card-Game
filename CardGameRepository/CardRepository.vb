
Imports CardGameDataModels
Imports CardGameHelpers



Public Class CardRepository
    Implements IGenericCrud(Of CardModel)


    Private ReadOnly _connectionString As String

    Public Sub New(connectionString As String)
        _connectionString = connectionString
    End Sub

    Public Function Create(model As CardModel) As Boolean Implements IGenericCrud(Of CardModel).Create
        Dim sql = New SqlControl(_connectionString)
        sql.AddParam("@Name", model.Name.ToString())
        sql.AddParam("@ImageId", CInt(model.ImageId))
        sql.ExecuteQuery("INSERT INTO dbo.Card(Name,ImageId) VALUES(@Name,@ImageId)")
        Dim i = sql.RecordCount
        If i > 0 Then Return True
        MsgBox(sql.HasException)
        Return False
    End Function

    Public Function Update(id As Integer, model As CardModel) As Boolean Implements IGenericCrud(Of CardModel).Update
        Throw New NotImplementedException()
    End Function

    Public Function Delete(Id As Integer) As Boolean Implements IGenericCrud(Of CardModel).Delete
        Throw New NotImplementedException()
    End Function

    Public Function Read() As DataTable Implements IGenericCrud(Of CardModel).Read
        Dim sql = New SqlControl(_connectionString)
        sql.ExecuteQuery("SELECT * FROM dbo.Card")
        Return sql.DbDataTable
    End Function
End Class
