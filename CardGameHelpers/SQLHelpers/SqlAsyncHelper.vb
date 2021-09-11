Imports System.Data.SqlClient

Public Class SqlAsyncHelper
    'Public Async Function ExecuteQueryAsync(connectionString As String, sqlQuery As String,
    '                            Optional parameters As List(Of SqlParameter) = Nothing,
    '                            Optional isStoredProcedure As Boolean = False) As Task

    '    Dim dataTable As New DataTable
    '    Using sqlConnetion As New SqlConnection(connectionString)

    '        IsConnectionOpenAsync(sqlConnetion)

    '        Using sqlCommand As New SqlCommand(sqlQuery, sqlConnetion)

    '            IsAStoredProcedure(isStoredProcedure, sqlCommand)
    '            AddsqlCommandParameter(parameters, sqlCommand)

    '            Using sqlDataReader = Await sqlCommand.ExecuteReaderAsync(CommandBehavior.CloseConnection)
    '                While Await sqlDataReader.ReadAsync()
    '                    For i = 0 To sqlDataReader.FieldCount
    '                        response.Result.Add(sqlDataReader.GetFieldValueAsync(Of T)(i))
    '                    Next
    '                End While

    '            End Using
    '            Return response
    '        End Using
    '    End Using
    '    Return response
    'End Function

    Private Shared Sub IsConnectionOpenAsync(sqlConnetion As SqlConnection)
        If sqlConnetion.State = ConnectionState.Open Then
            sqlConnetion.Close()
            sqlConnetion.OpenAsync()
        End If
    End Sub
    Private Shared Sub AddsqlCommandParameter(parameters As List(Of SqlParameter), sqlCommand As SqlCommand)
        If IsNothing(parameters) = False Then
            For Each paramter In parameters
                sqlCommand.Parameters.Add(paramter)
            Next
        End If
    End Sub

    Private Shared Sub IsAStoredProcedure(isStoredProcedure As Boolean, sqlCommand As SqlCommand)
        If isStoredProcedure = True Then
            sqlCommand.CommandType = CommandType.StoredProcedure
        End If
    End Sub

End Class
