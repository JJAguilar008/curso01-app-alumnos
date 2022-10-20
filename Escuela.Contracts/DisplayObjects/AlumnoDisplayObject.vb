Namespace DisplayObjects
    Public Class AlumnoDisplayObject
        Private _matricula As Integer
        Private _nombre As String
        Private _apellidos As String
        Private _idcarrera As Integer
        Private _carrera As String
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

        Public Property IdCarrera() As Integer
            Get
                Return _idcarrera
            End Get
            Set(ByVal value As Integer)
                _idcarrera = value
            End Set
        End Property

        Public Property Carrera() As String
            Get
                Return _carrera
            End Get
            Set(ByVal value As String)
                _carrera = value
            End Set
        End Property
    End Class
End Namespace
