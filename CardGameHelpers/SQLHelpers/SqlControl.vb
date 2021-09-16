Imports System.Data.SqlClient

Public Class SqlControl
    Implements ISqlControl

    Private _dbConnection As New SqlConnection("Data Source=DESKTOP-6322EIK\SQLEXPRESS;Initial Catalog=CardGame;Integrated Security=True;")
    Private _dbCommand As New SqlCommand

    'Database Data
    Public DbAdapter As SqlDataAdapter
    Public DbDataTable As DataTable

    'Query Parameters 
    Public Params As New List(Of SqlParameter)

    'Query Stats
    Public RecordCount As Integer
    Public Exception As String

    Public Sub New()
    End Sub
    Public Sub New(connectionString As String)
        _dbConnection = New SqlConnection(connectionString)
    End Sub

    Public Sub ExecuteQuery(query As String) Implements ISqlControl.ExecuteQuery
        'Reset Stats 
        ResetStats()

        Try

            OpenConnectionAnCreateCommand(query)
            ConfigureParams()
            ExecuteCommnadAndfillDataSet()
        Catch ex As Exception
            CaptureExceptionErrors(ex)
        Finally
            CloseConection()
        End Try
    End Sub
    Public Sub ExecuteNonQuery(query As String, Optional isStoredProcedure As Boolean = False)
        'Reset Stats 
        ResetStats()

        Try
            OpenConnectionAnCreateCommand(query)
            If isStoredProcedure = True Then
                _dbCommand.CommandType = CommandType.StoredProcedure
            End If
            ConfigureParams()
            ExecuteCommnad()
        Catch ex As Exception
            CaptureExceptionErrors(ex)
        Finally
            CloseConection()
        End Try
    End Sub
    Private Sub ExecuteCommnad()
        RecordCount = _dbCommand.ExecuteNonQuery
    End Sub
    Public Sub AddParam(name As String, value As Object) Implements ISqlControl.AddParam
        Dim newParam As New SqlParameter(name, value)
        Params.Add(newParam)
    End Sub
    Public Function HasException(Optional report As Boolean = False) As Boolean Implements ISqlControl.HasException
        If String.IsNullOrEmpty(Exception) Then Return False
        If report = True Then MsgBox(Exception, MsgBoxStyle.Critical, "Exception")
        Return True
    End Function
    Private Sub ResetStats()
        RecordCount = 0
        Exception = ""
    End Sub
    Private Sub OpenConnectionAnCreateCommand(query As String)
        _dbConnection.Open()
        _dbCommand = New SqlCommand(query, _dbConnection)
    End Sub
    Private Sub ConfigureParams()
        Params.ForEach(Sub(p) _dbCommand.Parameters.Add(p))
        Params.Clear()
    End Sub
    Private Sub ConfigureParamsWithValue()
        Params.ForEach(Sub(p) _dbCommand.Parameters.AddWithValue(p.ParameterName, p.Value))

    End Sub
    Private Sub ExecuteCommnadAndfillDataSet()
        DbDataTable = New DataTable
        DbAdapter = New SqlDataAdapter(_dbCommand)
        RecordCount = DbAdapter.Fill(DbDataTable)
    End Sub
    Private Sub CloseConection()
        If _dbConnection.State = ConnectionState.Open Then _dbConnection.Close()
    End Sub
    Private Sub CaptureExceptionErrors(ex As Exception)
        Exception = $"ExecuteQuery Error: {ex.Message}"
    End Sub
End Class
