Namespace DataAccess

    Public Class CarreraDAO
        Inherits DataBase

        Private Const SP_GETLIST = "spCarreraGetList"

        Public Function consultar() As DataTable

            Return ExecuteResultSet(SP_GETLIST)

        End Function

    End Class

End Namespace