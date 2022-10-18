Imports Escuela.Contracts.Services
Imports Escuela.BusinessCore.DataAccess
Namespace DomainObjects

    Public Class CarreraDomainObject
        Implements ICarrera

        Public Function getAll() As System.Data.DataTable Implements ICarrera.getAll
            Dim dao As CarreraDAO = New CarreraDAO
            Return dao.consultar()
        End Function
    End Class
End Namespace