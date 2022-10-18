Imports Escuela.Contracts.DataTransferObjects
Imports Escuela.Contracts.Enums
Namespace DataAccess
    Public Class AlumnoDAO
        Inherits DataBase

        Private Const SP_INSERT = "spAlumnoInsert"
        Private Const SP_GETBYMATRICULA = "spAlumnoGetByMatricula"
        Private Const SP_GETLIST = "spAlumnoGetList"
        Private Const SP_UPDATE = "spAlumnoUpdate"
        Private Const SP_DELETE = "spAlumnoDelete"
        Private Const SP_INSERTMATERIA = "spAlumnomateriaInsert"

        Public Sub guardar(ByVal alumno As AlumnoDTO)

            addParameter(AlumnoEnum.matricula.ToString, alumno.Matricula)
            addParameter(AlumnoEnum.nombre.ToString, alumno.Nombre)
            addParameter(AlumnoEnum.apellidos.ToString, alumno.Apellidos)
            addParameter(AlumnoEnum.carrera.ToString, alumno.Carrera)
            Execute(SP_INSERT)

        End Sub

        Public Function consultar() As DataTable

            Return ExecuteResultSet(SP_GETLIST)

        End Function

        Public Sub buscar(ByVal alumno As AlumnoDTO)

            addParameter(AlumnoEnum.matricula.ToString, alumno.Matricula)

            addOutputParameter(AlumnoEnum.nombre.ToString, "", 50)
            addOutputParameter(AlumnoEnum.apellidos.ToString, "", 100)
            addOutputParameter(AlumnoEnum.carrera.ToString, 0)
            Execute(SP_GETBYMATRICULA)

            alumno.Nombre = getParameter(AlumnoEnum.nombre.ToString)
            alumno.Apellidos = getParameter(AlumnoEnum.apellidos.ToString)

            alumno.Carrera = IIf(getParameter(AlumnoEnum.carrera.ToString) Is DBNull.Value, 1, getParameter(AlumnoEnum.carrera.ToString))

        End Sub

        Public Sub actualizar(ByVal alumno As AlumnoDTO)

            addParameter(AlumnoEnum.matricula.ToString, alumno.Matricula)
            addParameter(AlumnoEnum.nombre.ToString, alumno.Nombre)
            addParameter(AlumnoEnum.apellidos.ToString, alumno.Apellidos)
            addParameter(AlumnoEnum.carrera.ToString, alumno.Carrera)

            Execute(SP_UPDATE)

        End Sub

        Public Sub eliminar(ByVal id As Integer)

            addParameter(AlumnoEnum.matricula.ToString, id)
            Execute(SP_DELETE)

        End Sub

        Public Sub addMateria(ByVal alumno As AlumnoDTO)

            addParameter(AlumnoEnum.matricula.ToString, alumno.Matricula)
            addParameter(AlumnoEnum.idmateria.ToString, alumno.Idmateria)
            Execute(SP_INSERTMATERIA)

        End Sub

    End Class
End Namespace