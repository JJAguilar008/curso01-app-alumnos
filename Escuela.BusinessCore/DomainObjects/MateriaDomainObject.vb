Imports Escuela.Contracts.Services
Imports Escuela.BusinessCore.DataAccess
Namespace DomainObjects

    Public Class MateriaDomainObject
        Implements IMateria

        Public Function getAll() As System.Data.DataTable Implements IMateria.getAll
            Dim dao As MateriaDAO = New MateriaDAO
            Return dao.consultar()
        End Function
    End Class

End Namespace


