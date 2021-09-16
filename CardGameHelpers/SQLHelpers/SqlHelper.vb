Imports System.Data.SqlClient

Public Class SqlHelper

    Public Function ExecuteQuery(connectionString As String, sqlQuery As String,
                                  Optional isStoredProcedure As Boolean = False,
                                 Optional parameters As List(Of SqlParameter) = Nothing) As DataTable
        Dim dataTable As New DataTable
        Using sqlConnetion As New SqlConnection(connectionString)

            IsConnectionOpen(sqlConnetion)

            Using sqlCommand As New SqlCommand(sqlQuery, sqlConnetion)

                IsAStoredProcedure(isStoredProcedure, sqlCommand)
                CreateSqlCommandParameters(parameters, sqlCommand)

                Dim sqlDataAdapter As New SqlDataAdapter(sqlCommand)
                sqlDataAdapter.Fill(dataTable)
                Return dataTable
            End Using

        End Using
        Return dataTable
    End Function

    Public Function ExecuteNonQuery(connectionString As String, sqlQuery As String,
                                    Optional isStoredProcedure As Boolean = False,
                                    Optional parameters As List(Of SqlParameter) = Nothing) As Boolean

        Try
            Using sqlConnetion As New SqlConnection(connectionString)

                IsConnectionOpen(sqlConnetion)
                Using sqlCommand As New SqlCommand(sqlQuery, sqlConnetion)
                    IsAStoredProcedure(isStoredProcedure, sqlCommand)
                    CreateSqlCommandParameters(parameters, sqlCommand)
                    Dim result = sqlCommand.ExecuteNonQuery()
                    MsgBox(result.ToString)
                    Return True
                End Using

            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Private Sub CreateSqlCommandParameters(parameters As List(Of SqlParameter), sqlCommand As SqlCommand)
        If IsNothing(parameters) = False Then
            parameters.ForEach(Sub(p) sqlCommand.Parameters.Add(p))
        End If
    End Sub

    Private Sub IsAStoredProcedure(isStoredProcedure As Boolean, sqlCommand As SqlCommand)
        If isStoredProcedure = True Then
            sqlCommand.CommandType = CommandType.StoredProcedure
        End If
    End Sub

    Private Sub IsConnectionOpen(sqlConnetion As SqlConnection)
        If sqlConnetion.State = ConnectionState.Open Then
            sqlConnetion.Close()
        End If
        sqlConnetion.Open()
    End Sub


End Class
