Imports Escuela.Contracts.DataTransferObjects
Imports Escuela.Contracts.Enums
Imports System.ComponentModel
Imports Escuela.Contracts.DisplayObjects
Imports Escuela.Contracts

Namespace DataAccess
    Public Class AlumnoDAO
        Inherits DataBase

        Private Const SP_INSERT = "spAlumnoInsert"
        Private Const SP_GETBYMATRICULA = "spAlumnoGetByMatricula"
        Private Const SP_GETLIST = "spAlumnoGetList"
        Private Const SP_UPDATE = "spAlumnoUpdate"
        Private Const SP_DELETE = "spAlumnoDelete"
        Private Const SP_INSERTMATERIA = "spAlumnomateriaInsert"
        Private Const SP_GETMATERIASBYMATRICULA = "spGetMateriasByMatricula"

        Public Sub guardar(ByVal alumno As AlumnoDTO)

            addParameter(AlumnoEnum.matricula.ToString, alumno.Matricula)
            addParameter(AlumnoEnum.nombre.ToString, alumno.Nombre)
            addParameter(AlumnoEnum.apellidos.ToString, alumno.Apellidos)
            addParameter(AlumnoEnum.carrera.ToString, alumno.Carrera)
            Execute(SP_INSERT)

        End Sub

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

        Public Sub addMateria(ByVal alumnoMateriaDo As AlumnoMateriaDisplayObject)

            addParameter(AlumnoEnum.matricula.ToString, alumnoMateriaDo.Matricula)
            addParameter(AlumnoEnum.idmateria.ToString, alumnoMateriaDo.IdMateria)
            Execute(SP_INSERTMATERIA)

        End Sub

        Public Function getList() As BindingList(Of AlumnoDisplayObject)

            Dim dt As DataTable
            dt = ExecuteResultSet(SP_GETLIST)
            Return AlumnoCreateList(dt)

        End Function

        Public Function getMateriasByMatricula(ByVal id As Integer) As BindingList(Of AlumnoMateriaDisplayObject)

            Dim dt As DataTable = New DataTable()
            addParameter(AlumnoEnum.matricula.ToString, id)
            dt = ExecuteResultSet(SP_GETMATERIASBYMATRICULA)
            Return MateriaCreateList(dt)

        End Function

        Private Function AlumnoCreateList(ByVal dt As DataTable) As BindingList(Of AlumnoDisplayObject)
            Dim lista As New BindingList(Of AlumnoDisplayObject)
            For Each dr As DataRow In dt.Rows
                Dim alumnoDO As New AlumnoDisplayObject

                alumnoDO.Matricula = CInt(dr(AlumnoEnum.matricula.ToString))
                alumnoDO.Nombre = dr(AlumnoEnum.nombre.ToString)
                alumnoDO.Apellidos = dr(AlumnoEnum.apellidos.ToString)
                alumnoDO.IdCarrera = IIf(dr(AlumnoEnum.idcarrera.ToString) Is DBNull.Value, 0, dr(AlumnoEnum.idcarrera.ToString))
                alumnoDO.Carrera = IIf(dr(AlumnoEnum.carrera.ToString) Is DBNull.Value, "", dr(AlumnoEnum.carrera.ToString))
                lista.Add(alumnoDO)
            Next
            Return lista
        End Function

        Private Function MateriaCreateList(ByVal dt As DataTable) As BindingList(Of AlumnoMateriaDisplayObject)

            Dim listaMaterias As New BindingList(Of AlumnoMateriaDisplayObject)

            For Each dr As DataRow In dt.Rows
                Dim materiaDO As New AlumnoMateriaDisplayObject

                materiaDO.Matricula = CInt(dr(AlumnoEnum.matricula.ToString))
                materiaDO.IdMateria = CInt(dr(AlumnoEnum.idmateria.ToString))
                materiaDO.Materia = dr(AlumnoEnum.materia.ToString)
                listaMaterias.Add(materiaDO)
            Next
            Return listaMaterias
        End Function

    End Class
End Namespace