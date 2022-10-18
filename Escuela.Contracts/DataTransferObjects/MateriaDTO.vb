Namespace DataTransferObjects

    Public Class MateriaDTO

        Private _idMateria As Integer
        Private _materia As String

        Public Property IdMateria() As Integer
            Get
                Return _idMateria
            End Get
            Set(ByVal value As Integer)
                _idMateria = value
            End Set
        End Property

        Public Property Materia() As String
            Get
                Return _materia
            End Get
            Set(ByVal value As String)
                _materia = value
            End Set
        End Property
    End Class

End Namespace