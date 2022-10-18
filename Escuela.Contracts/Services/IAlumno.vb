Imports Escuela.Contracts.DataTransferObjects
Namespace Services
    Public Interface IAlumno
        Function getAll() As DataTable
        Sub getByMatricula(ByVal dto As AlumnoDTO)
        Sub save(ByVal dto As AlumnoDTO)
        Sub update(ByVal dto As AlumnoDTO)
        Sub delete(ByVal id As Integer)
        Sub addMateria(ByVal dto As AlumnoDTO)
    End Interface
End Namespace

