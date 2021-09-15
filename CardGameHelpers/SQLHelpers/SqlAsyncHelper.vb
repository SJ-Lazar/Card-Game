Imports System.Data.SqlClient

Public Class SqlAsyncHelper
    Public Async Function ExecuteQueryAsync(connectionString As String, sqlQuery As String,
                                Optional parameters As List(Of SqlParameter) = Nothing,
                                Optional isStoredProcedure As Boolean = False) As Task(Of SqlDataReader)


        Using sqlConnetion As New SqlConnection(connectionString)
            'Await OpenSqlConnectionIfClosedAsync(sqlConnetion)
            If sqlConnetion.State = ConnectionState.Closed Then Await sqlConnetion.OpenAsync

            Try
                Using sqlCommand As New SqlCommand(sqlQuery, sqlConnetion)
                    IsAStoredProcedure(isStoredProcedure, sqlCommand)
                    AddsqlCommandParameter(parameters, sqlCommand)

                    Dim dataRaeder = Await sqlCommand.ExecuteReaderAsync
                    Return dataRaeder
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
        Return Nothing
    End Function

    Private Async Function OpenSqlConnectionIfClosedAsync(sqlConnetion As SqlConnection) As Task
        If sqlConnetion.State = ConnectionState.Closed Then Await sqlConnetion.OpenAsync
    End Function
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
