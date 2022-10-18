Namespace DataTransferObjects

    Public Class AlumnoDTO

        Private _matricula As Integer
        Private _nombre As String
        Private _apellidos As String
        Private _carrera As Integer
        Private _idmateria As Integer

        Public Property Matricula() As Integer
            Get
                Return _matricula
            End Get
            Set(ByVal value As Integer)
                _matricula = value
            End Set
        End Property

        Public Property Nombre() As String
            Get
                Return _nombre
            End Get
            Set(ByVal value As String)
                _nombre = value
            End Set
        End Property

        Public Property Apellidos() As String
            Get
                Return _apellidos
            End Get
            Set(ByVal value As String)
                _apellidos = value
            End Set
        End Property

        Public Property Carrera() As Integer
            Get
                Return _carrera
            End Get
            Set(ByVal value As Integer)
                _carrera = value
            End Set
        End Property

        Public Property Idmateria() As Integer
            Get
                Return _idmateria
            End Get
            Set(ByVal value As Integer)
                _idmateria = value
            End Set
        End Property
    End Class

End Namespace