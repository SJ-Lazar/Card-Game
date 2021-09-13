Imports System.Data.SqlClient

Public Class SqlAsyncHelper
    Public Function ExecuteQueryAsync(connectionString As String, sqlQuery As String,
                                Optional parameters As List(Of SqlParameter) = Nothing,
                                Optional isStoredProcedure As Boolean = False) As SqlCommand


        'Using sqlConnetion As New SqlConnection(connectionString)

        Dim sqlConnection As New SqlConnection(connectionString)
        IsConnectionOpenAsync(sqlConnection)

        'Using sqlCommand As New SqlCommand(sqlQuery, sqlConnetion)
        Dim sqlCommand As New SqlCommand(sqlQuery, sqlConnection)
        IsAStoredProcedure(isStoredProcedure, sqlCommand)
        AddsqlCommandParameter(parameters, sqlCommand)
                Return sqlCommand

        'End Using
        'End Using
        Return Nothing
    End Function

    Private Sub IsConnectionOpenAsync(sqlConnetion As SqlConnection)
        If sqlConnetion.State = ConnectionState.Open Then
            sqlConnetion.Close()
        End If
        sqlConnetion.OpenAsync()
    End Sub
    Private Sub AddsqlCommandParameter(parameters As List(Of SqlParameter), sqlCommand As SqlCommand)
        If IsNothing(parameters) = False Then
            For Each paramter In parameters
                sqlCommand.Parameters.Add(paramter)
            Next
        End If
    End Sub
    Private Sub IsAStoredProcedure(isStoredProcedure As Boolean, sqlCommand As SqlCommand)
        If isStoredProcedure = True Then
            sqlCommand.CommandType = CommandType.StoredProcedure
        End If
    End Sub

End Class
