
Imports System.Data.SqlClient
Imports CardGameDataModels
Imports CardGameHelpers



Public Class CardRepository
    Implements IGenericCrud(Of MonsterCardModel)

    Private ReadOnly _connectionString As String
    Private ReadOnly _sqlhelper As SqlHelper
    Public Sub New(connectionString As String)
        _connectionString = connectionString
        _sqlhelper = New SqlHelper()
    End Sub

    Public Function Create(model As MonsterCardModel) As Boolean Implements IGenericCrud(Of MonsterCardModel).Create
        Try
            Dim IsSuccess = _sqlhelper.ExecuteNonQuery(_connectionString, "spCreateMonsterCard", True, AddParameters(model))
            If IsSuccess Then MsgBox("Success")
            Return IsSuccess
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Private Function AddParameters(model As MonsterCardModel) As List(Of SqlParameter)
        Dim list = New List(Of SqlParameter)
        list.Add(New SqlParameter(parameterName:="@Name", value:=model.Name.ToString()))
        list.Add(New SqlParameter(parameterName:="@ImagePath", value:=model.ImagePath.ToString()))
        list.Add(New SqlParameter(parameterName:="@ImageName", value:=model.ImageName.ToString()))
        list.Add(New SqlParameter(parameterName:="@Description", value:=model.Description.ToString()))
        list.Add(New SqlParameter(parameterName:="@Attack", value:=CInt(model.Attack)))
        list.Add(New SqlParameter(parameterName:="@Defense", value:=CInt(model.Defense)))
        Return list
    End Function

    Public Function Update(id As Integer, model As MonsterCardModel) As Boolean Implements IGenericCrud(Of MonsterCardModel).Update
        Throw New NotImplementedException()
    End Function

    Public Function Delete(Id As Integer) As Boolean Implements IGenericCrud(Of MonsterCardModel).Delete
        Throw New NotImplementedException()
    End Function

    Public Function Read() As DataTable Implements IGenericCrud(Of MonsterCardModel).Read
        Return _sqlhelper.ExecuteQuery(_connectionString, "spGetAllCards", True)
    End Function
End Class
