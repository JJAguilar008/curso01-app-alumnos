Imports System.Data.SqlClient
Public Class DataBase

    Private cnx As SqlConnection
    Private comando As SqlCommand

    Sub New() 'CONSTRUCTOR
        'REALIZA LA CONECCION CON LA BASE DE DATOS
        cnx = New SqlConnection()
        cnx.ConnectionString = "Data Source=LAPTOP-VDL3A52S;Initial Catalog=curso01;Integrated Security=true;"
        cnx.Open()
        'CREA UN COMANDO DESDE EL MOMENTO QUE SE CONSTRUYE LA CLASE
        comando = New SqlCommand()
        comando.Connection = cnx

    End Sub

    Public Sub addParameter(ByVal nombre As String, ByVal valor As Object)
        'INSERTA LOS PARAMETROS PARA LOS SP
        Dim parametro As SqlParameter = New SqlParameter
        parametro.ParameterName = nombre
        parametro.Value = valor
        comando.Parameters.Add(parametro)
    End Sub

    Public Sub addOutputParameter(ByVal nombre As String, ByVal valor As Object, Optional ByVal size As Integer = 0)
        'AGREGA LOS PARAMETROS DE SALIDA
        Dim parametro As SqlParameter = New SqlParameter
        parametro.ParameterName = nombre
        parametro.Value = valor
        parametro.Direction = ParameterDirection.Output
        If size > 0 Then
            parametro.Size = size
        End If
        comando.Parameters.Add(parametro)
    End Sub

    Public Sub Execute(ByVal sp As String)
        'EJECUTA EL COMANDO EN LA BASE DE DATOS
        comando.CommandText = sp
        comando.CommandType = CommandType.StoredProcedure
        comando.ExecuteNonQuery()
    End Sub

    Public Function ExecuteResultSet(ByVal sp As String) As DataTable
        'EJECUTA COMANDO PARA OBTENER UNA LISTA DE DATOS
        comando.CommandText = sp
        comando.CommandType = CommandType.StoredProcedure
        Dim ds As DataSet = New DataSet
        Dim adaptador As SqlDataAdapter = New SqlDataAdapter
        adaptador.SelectCommand = comando
        adaptador.Fill(ds, "tabla")
        Return ds.Tables("tabla")
    End Function

    Public Function getParameter(ByVal nombre As String) As Object
        'SIRVE PARA OBTENER LOS DATOS QUE SE QUEDAN EN LOS PARAMETROS DE SALIDA
        Return comando.Parameters(nombre).Value
    End Function
End Class
