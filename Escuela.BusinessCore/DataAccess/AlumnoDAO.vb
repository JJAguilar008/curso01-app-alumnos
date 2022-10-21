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
        

        Public Sub guardar(ByVal alumno As AlumnoDTO)

            addParameter(AlumnoEnum.matricula.ToString, alumno.Matricula)
            addParameter(AlumnoEnum.nombre.ToString, alumno.Nombre)
            addParameter(AlumnoEnum.apellidos.ToString, alumno.Apellidos)
            addParameter(AlumnoEnum.carrera.ToString, alumno.Carrera)
            Execute(SP_INSERT)

        End Sub

        Public Sub buscar(ByVal alumno As AlumnoDTO)

            addParameter(AlumnoEnum.matricula.ToString, alumno.Matricula)

            'addOutputParameter(AlumnoEnum.nombre.ToString, "", 50)
            'addOutputParameter(AlumnoEnum.apellidos.ToString, "", 100)
            'addOutputParameter(AlumnoEnum.carrera.ToString, 0)
            'Execute(SP_GETBYMATRICULA)

            Dim dt As DataTable = New DataTable
            dt = ExecuteResultSet(SP_GETBYMATRICULA)

            If dt.Rows.Count = 0 Then
                alumno.IsNew = True
            Else
                alumno.IsNew = False
                alumno.Nombre = CStr(dt.Rows(0)(AlumnoEnum.nombre.ToString))
                alumno.Apellidos = CStr(dt.Rows(0)(AlumnoEnum.apellidos.ToString))
                alumno.Carrera = CInt(dt.Rows(0)(AlumnoEnum.idcarrera.ToString))
            End If

            'alumno.IsNew = IIf(getParameter(AlumnoEnum.nombre.ToString) Is DBNull.Value, True, False)
            'alumno.Nombre = IIf(getParameter(AlumnoEnum.nombre.ToString) Is DBNull.Value, "", getParameter(AlumnoEnum.nombre.ToString))
            'alumno.Apellidos = IIf(getParameter(AlumnoEnum.apellidos.ToString) Is DBNull.Value, "", getParameter(AlumnoEnum.apellidos.ToString))
            'alumno.Carrera = IIf(getParameter(AlumnoEnum.carrera.ToString) Is DBNull.Value, 1, getParameter(AlumnoEnum.carrera.ToString))


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

        Public Function getList() As BindingList(Of AlumnoDisplayObject)

            Dim dt As DataTable
            dt = ExecuteResultSet(SP_GETLIST)
            Return AlumnoCreateList(dt)

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

    End Class
End Namespace