Imports System.Data.SqlClient
Imports CardGameDataModels

Public Class SqlAsyncHelper
    Public Async Function ExecuteQueryAsync(connectionString As String, sqlQuery As String,
                                Optional parameters As List(Of SqlParameter) = Nothing,
                                Optional isStoredProcedure As Boolean = False) As Task(Of List(Of CardModel))

        Dim list = New List(Of CardModel)
        Using sqlConnetion As New SqlConnection(connectionString)
            Await sqlConnetion.OpenAsync
            Try
                Using sqlCommand As New SqlCommand(sqlQuery, sqlConnetion)
                    IsAStoredProcedure(isStoredProcedure, sqlCommand)
                    AddsqlCommandParameter(parameters, sqlCommand)

                    Using dr = Await sqlCommand.ExecuteReaderAsync()
                        While Await dr.ReadAsync()
                            list.Add(New CardModel(id:=dr.GetFieldValue(Of Integer)(0),
                                                   name:=dr.GetFieldValue(Of String)(1),
                                                   imageId:=dr.GetFieldValue(Of Integer)(2)))
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
        Return list
    End Function
    Private Async Sub IsConnectionOpenAsync(sqlConnetion As SqlConnection)
        If sqlConnetion.State = ConnectionState.Closed Then
            Await sqlConnetion.OpenAsync()
        End If
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
