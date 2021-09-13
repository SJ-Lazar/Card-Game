
Public Module ConvertDataTable

    Public Function ToList(Of TResultType)(dataTable As DataTable) As List(Of TResultType)
        Dim data = New List(Of TResultType)
        For Each row In dataTable.Rows
            Dim item = GetItem(Of TResultType)(row)
            data.Add(item)
        Next
        Return data
    End Function

    Private Function GetItem(Of TResultType)(dataRow As DataRow) As TResultType
        Dim temp As Type = GetType(TResultType)
        Dim obj = Activator.CreateInstance(GetType(TResultType))
        For Each dataColumn In dataRow.Table.Columns
            For Each prop In temp.GetProperties()
                If prop.Name = dataColumn.ColumnName Then
                    prop.SetValue(obj, dataRow(dataColumn.ColumnName), Nothing)
                Else
                    Continue For
                End If
            Next
        Next
        Return obj
    End Function
End Module
