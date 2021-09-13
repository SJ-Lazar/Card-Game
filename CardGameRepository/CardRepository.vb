

Imports System.Data.SqlClient
Imports CardGameDataModels
Imports CardGameHelpers

Public Interface ICardRepository
    Function CreateCard(cardModel As CardModel) As SqlResponseModel
    Function UpdateCard(cardModel As CardModel) As SqlResponseModel
    Function DeleteCard(Id As Integer) As SqlResponseModel
    Function ReadCardList() As Task(Of List(Of CardModel))
    Function ReadCard() As CardModel
End Interface

Public Class CardRepository
    Implements ICardRepository

    Private ReadOnly _connectionString As String

    Public Sub New(connectionString As String)
        _connectionString = connectionString
    End Sub

    Public Function CreateCard(cardModel As CardModel) As SqlResponseModel Implements ICardRepository.CreateCard
        Throw New NotImplementedException()
    End Function

    Public Function UpdateCard(cardModel As CardModel) As SqlResponseModel Implements ICardRepository.UpdateCard
        Throw New NotImplementedException()
    End Function

    Public Function DeleteCard(Id As Integer) As SqlResponseModel Implements ICardRepository.DeleteCard
        Throw New NotImplementedException()
    End Function

    Public Async Function ReadCardList() As Task(Of List(Of CardModel)) Implements ICardRepository.ReadCardList
        Dim listOfCards = New List(Of CardModel)
        Dim sqlAsyncHelper = New SqlAsyncHelper()
        Dim cmd = sqlAsyncHelper.ExecuteQueryAsync(_connectionString, "SELECT * FROM dbo.Cards")

        Using dr = cmd.ExecuteReaderAsync
            While Await dr.Result.ReadAsync()
                'Dim tempCard As New CardModel()

                listOfCards.Add(New CardModel(If(IsDBNull(Await dr.Result.GetFieldValueAsync(Of Integer)(0)), dr.Result.GetFieldValueAsync(Of Integer)(0), 0),
                                              If(IsDBNull(Await dr.Result.GetFieldValueAsync(Of String)(1)), dr.Result.GetFieldValueAsync(Of String)(1), String.Empty),
                                              If(IsDBNull(Await dr.Result.GetFieldValueAsync(Of Integer)(2)), dr.Result.GetFieldValueAsync(Of Integer)(2), 0)))
            End While
        End Using
        Return listOfCards
    End Function

    Public Function ReadCard() As CardModel Implements ICardRepository.ReadCard
        Throw New NotImplementedException()
    End Function
End Class
