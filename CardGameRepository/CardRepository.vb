
Imports CardGameDataModels
Imports CardGameHelpers



Public Class CardRepository
    Implements IGenericCrud(Of CardModel)

    Private ReadOnly _connectionString As String
    Private ReadOnly _sql As SqlControl

    Public Sub New(connectionString As String)
        _connectionString = connectionString
        _sql = New SqlControl(_connectionString)
    End Sub

    Public Function Create(model As CardModel) As Boolean Implements IGenericCrud(Of CardModel).Create
        AddParameters(model, _sql)
        _sql.ExecuteQuery("INSERT INTO dbo.Card(Name,ImageId) VALUES(@Name,@ImageId)")
        Return HasException(_sql)
    End Function

    Private Shared Function HasException(sql As SqlControl) As Boolean
        If sql.HasException Then
            MsgBox("Failed to preform operation. Try again")
            Return False
        End If
        MsgBox("Success")
        Return True
    End Function

    Private Shared Sub AddParameters(model As CardModel, sql As SqlControl)
        sql.AddParam("@Name", model.Name.ToString())
        sql.AddParam("@ImageId", CInt(model.ImageId))
    End Sub

    Public Function Update(id As Integer, model As CardModel) As Boolean Implements IGenericCrud(Of CardModel).Update
        Throw New NotImplementedException()
    End Function

    Public Function Delete(Id As Integer) As Boolean Implements IGenericCrud(Of CardModel).Delete
        Throw New NotImplementedException()
    End Function

    Public Function Read() As DataTable Implements IGenericCrud(Of CardModel).Read
        _sql.ExecuteQuery("SELECT * FROM dbo.Card")
        Return _sql.DbDataTable
    End Function
End Class
