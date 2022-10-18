Imports Escuela.Contracts.Enums

Namespace DataAccess

    Public Class MateriaDAO

        Inherits DataBase

        Private Const SP_GETLIST = "spMateriaGetList"
        Private Const SP_GETMATERIASBYMATRICULA = "spGetMateriasByMatricula"

        Public Function consultar() As DataTable

            Return ExecuteResultSet(SP_GETLIST)

        End Function

        Public Function getMateriasByMatricula(ByVal id As Integer) As DataTable

            addParameter(AlumnoEnum.matricula.ToString, id)
            Return ExecuteResultSet(SP_GETMATERIASBYMATRICULA)

        End Function

    End Class

End Namespace
