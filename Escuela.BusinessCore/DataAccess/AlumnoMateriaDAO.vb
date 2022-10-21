Imports System.ComponentModel
Imports Escuela.Contracts
Imports Escuela.Contracts.Enums
Imports Escuela.Contracts.DataTransferObjects
Imports Escuela.Contracts.DisplayObjects

Namespace DataAccess

    Public Class AlumnoMateriaDAO
        Inherits DataBase
        Private Const SP_INSERTMATERIA = "spAlumnomateriaInsert"
        Private Const SP_GETMATERIASBYMATRICULA = "spGetMateriasByMatricula"

        Public Function getMateriasByMatricula(ByVal id As Integer) As BindingList(Of AlumnoMateriaDTO)

            Dim dt As DataTable = New DataTable()
            addParameter(AlumnoEnum.matricula.ToString, id)
            dt = ExecuteResultSet(SP_GETMATERIASBYMATRICULA)
            Return MateriaCreateList(dt)

        End Function

        Public Sub addMateria(ByVal alumnoMateriaDo As AlumnoMateriaDTO)

            addParameter(AlumnoEnum.matricula.ToString, alumnoMateriaDo.Matricula)
            addParameter(MateriaEnum.idmateria.ToString, alumnoMateriaDo.IdMateria)
            Execute(SP_INSERTMATERIA)

        End Sub

        Private Function MateriaCreateList(ByVal dt As DataTable) As BindingList(Of AlumnoMateriaDTO)

            Dim listaMaterias As New BindingList(Of AlumnoMateriaDTO)

            For Each dr As DataRow In dt.Rows
                Dim materiaDO As New AlumnoMateriaDTO

                materiaDO.Matricula = CInt(dr(AlumnoEnum.matricula.ToString))
                materiaDO.IdMateria = CInt(dr(MateriaEnum.idmateria.ToString))
                materiaDO.Materia = dr(MateriaEnum.materia.ToString)
                materiaDO.IsNew = False
                listaMaterias.Add(materiaDO)
            Next
            Return listaMaterias
        End Function
    End Class

End Namespace
