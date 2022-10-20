Public Class AlumnoMateriaDisplayObject

    Private _matricula As Integer
    Private _idmateria As Integer
    Private _materia As String

    Public Property Matricula() As Integer
        Get
            Return _matricula
        End Get
        Set(ByVal value As Integer)
            _matricula = value
        End Set
    End Property

    Public Property IdMateria() As Integer
        Get
            Return _idmateria
        End Get
        Set(ByVal value As Integer)
            _idmateria = value
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
