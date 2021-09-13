﻿
Imports CardGameDataModels
Imports CardGameHelpers
Imports GeneralExtensions

Public Interface ICardRepository
    Function CreateCard(cardModel As CardModel) As SqlResponseModel
    Function UpdateCard(cardModel As CardModel) As SqlResponseModel
    Function DeleteCard(Id As Integer) As SqlResponseModel
    Function ReadCardList() As List(Of CardModel)
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

    Public Function ReadCardList() As List(Of CardModel) Implements ICardRepository.ReadCardList
        Dim sqlHelper = New SqlHelper()
        Dim dt = sqlHelper.ExecuteQuery(_connectionString, "SELECT * FROM dbo.Card")
        Dim listOfCards = ConvertDataTable.ToList(Of CardModel)(dt)
        Return listOfCards
    End Function

    Public Function ReadCard() As CardModel Implements ICardRepository.ReadCard
        Throw New NotImplementedException()
    End Function
End Class
