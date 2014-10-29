
Public Class SearchMenu
    Private item As String
    Private value As Integer

    Public Sub New(ByVal it As String, ByVal va As Integer)
        Me.item = it
        Me.value = va
    End Sub

    Public ReadOnly Property itemmem As String
        Get
            Return Me.item
        End Get
    End Property

    Public ReadOnly Property valuemem As Integer
        Get
            Return Me.value
        End Get
    End Property
End Class