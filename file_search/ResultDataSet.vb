Public Class ResultDataSet : Implements IDisposable
    Public search_text As String
    Public result As DataTable

    Public Sub New(ByVal str As String, ByVal re As DataTable)
        Me.search_text = str
        Me.result = re
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        ' Dispose of unmanaged resources.
        result.Dispose()
        ' Suppress finalization.
        GC.SuppressFinalize(Me)
    End Sub

End Class
