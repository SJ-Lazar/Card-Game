Imports System.Data.SqlClient

Public Class SqlHelper


    Public Function ExecuteNonQueryAasync(connectionString As String, sqlQuery As String,
                                 Optional parameters As List(Of SqlParameter) = Nothing,
                                 Optional isStoredProcedure As Boolean = False) As Boolean

        Using sqlConnetion As New SqlConnection(connectionString)

            IsConnectionOpen(sqlConnetion)

            Using sqlCommand As New SqlCommand(sqlQuery, sqlConnetion)
                IsAStoredProcedure(isStoredProcedure, sqlCommand)
                AddsqlCommandParameter(parameters, sqlCommand)
                sqlCommand.ExecuteNonQuery()
                Return True
            End Using

        End Using
        Return False
    End Function
    Public Function ExecuteQuery(connectionString As String, sqlQuery As String,
                                 Optional parameters As List(Of SqlParameter) = Nothing,
                                 Optional isStoredProcedure As Boolean = False) As DataTable
        Dim dataTable As New DataTable
        Using sqlConnetion As New SqlConnection(connectionString)

            IsConnectionOpen(sqlConnetion)

            Using sqlCommand As New SqlCommand(sqlQuery, sqlConnetion)

                IsAStoredProcedure(isStoredProcedure, sqlCommand)
                AddsqlCommandParameter(parameters, sqlCommand)

                Dim sqlDataAdapter As New SqlDataAdapter(sqlCommand)
                sqlDataAdapter.Fill(dataTable)
                Return dataTable
            End Using

        End Using
        Return dataTable
    End Function

    Public Function ExecuteNonQuery(connectionString As String, sqlQuery As String,
                                 Optional parameters As List(Of SqlParameter) = Nothing,
                                 Optional isStoredProcedure As Boolean = False) As Boolean

        Using sqlConnetion As New SqlConnection(connectionString)

            IsConnectionOpen(sqlConnetion)

            Using sqlCommand As New SqlCommand(sqlQuery, sqlConnetion)
                IsAStoredProcedure(isStoredProcedure, sqlCommand)
                AddsqlCommandParameter(parameters, sqlCommand)
                sqlCommand.ExecuteNonQuery()
                Return True
            End Using

        End Using
        Return False
    End Function

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

    Private Shared Sub IsConnectionOpen(sqlConnetion As SqlConnection)
        If sqlConnetion.State = ConnectionState.Open Then
            sqlConnetion.Close()
            sqlConnetion.Open()
        End If
    End Sub


End Class
