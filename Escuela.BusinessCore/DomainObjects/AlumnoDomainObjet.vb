Imports Escuela.Contracts.Services
Imports Escuela.Contracts.DataTransferObjects
Imports Escuela.BusinessCore.DataAccess
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

        Public Function getAll() As DataTable Implements IAlumno.getAll
            Dim dao As AlumnoDAO = New AlumnoDAO
            Return dao.consultar()
        End Function

        Public Sub delete(ByVal id As Integer) Implements IAlumno.delete
            Dim dao As AlumnoDAO = New AlumnoDAO
            dao.eliminar(id)
        End Sub

        Public Sub update(ByVal dto As AlumnoDTO) Implements IAlumno.update
            Dim dao As AlumnoDAO = New AlumnoDAO
            dao.actualizar(dto)
        End Sub
        Public Sub addMateria1(ByVal dto As AlumnoDTO) Implements IAlumno.addMateria
            Dim dao As AlumnoDAO = New AlumnoDAO
            dao.addMateria(dto)
        End Sub
    End Class

End Namespace