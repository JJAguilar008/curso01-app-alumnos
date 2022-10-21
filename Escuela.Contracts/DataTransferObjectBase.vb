Public Class DataTransferObjectBase
    Private _isNew As Boolean = True

    Public Property IsNew() As Boolean
        Get
            Return _isNew
        End Get
        Set(ByVal value As Boolean)
            _isNew = value
        End Set
    End Property

End Class
