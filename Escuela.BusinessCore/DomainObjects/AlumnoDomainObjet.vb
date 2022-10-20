Imports Escuela.Contracts.Services
Imports Escuela.Contracts.DataTransferObjects
Imports Escuela.BusinessCore.DataAccess
Imports System.ComponentModel
Imports Escuela.Contracts.DisplayObjects

Namespace DomainObjects

    Public Class AlumnoDomainObjet
        Implements IAlumno

        Public Sub getByMatricula(ByVal dto As AlumnoDTO) Implements IAlumno.getByMatricula
            Dim dao As AlumnoDAO = New AlumnoDAO
            dao.buscar(dto)
        End Sub

        Public Sub save(ByVal dto As AlumnoDTO) Implements IAlumno.save
            Dim dao As AlumnoDAO = New AlumnoDAO
            dao.guardar(dto)
        End Sub

        Public Function getList() As BindingList(Of AlumnoDisplayObject) Implements IAlumno.getList
            Dim dao As AlumnoDAO = New AlumnoDAO
            Return dao.getList()
        End Function

        Public Sub delete(ByVal id As Integer) Implements IAlumno.delete
            Dim dao As AlumnoDAO = New AlumnoDAO
            dao.eliminar(id)
        End Sub

        Public Sub update(ByVal dto As AlumnoDTO) Implements IAlumno.update
            Dim dao As AlumnoDAO = New AlumnoDAO
            dao.actualizar(dto)
        End Sub

        Public Function getMateriaByMatricula(ByVal id As String) As System.ComponentModel.BindingList(Of Contracts.AlumnoMateriaDisplayObject) Implements Contracts.Services.IAlumno.getMateriaByMatricula
            Dim dao As AlumnoDAO = New AlumnoDAO
            Return dao.getMateriasByMatricula(id)
        End Function

        Public Sub addMateria(ByVal alumnoMateriaDO As Contracts.AlumnoMateriaDisplayObject) Implements Contracts.Services.IAlumno.addMateria
            Dim dao As AlumnoDAO = New AlumnoDAO
            dao.addMateria(alumnoMateriaDO)
        End Sub
    End Class

End Namespace