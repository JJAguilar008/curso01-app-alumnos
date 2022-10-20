Namespace DataAccess

    Public Class MateriaDAO
        Inherits DataBase

        Private Const SP_GETLIST = "spMateriaGetList"

        Public Function consultar() As DataTable

            Return ExecuteResultSet(SP_GETLIST)

        End Function

    End Class

End Namespace
