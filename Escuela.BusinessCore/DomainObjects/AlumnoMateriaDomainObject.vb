Imports Escuela.BusinessCore.DataAccess
Imports Escuela.Contracts.DisplayObjects
Imports Escuela.Contracts.DataTransferObjects
Imports Escuela.Contracts
Imports Escuela.BusinessCore.DomainObjects.BusinessRule

Namespace DomainObjects

    Public Class AlumnoMateriaDomainObject
        Implements IAlumnoMateria

        Public Function GetMateriaByMatricula(ByVal id As String) As System.ComponentModel.BindingList(Of AlumnoMateriaDTO) Implements IAlumnoMateria.GetMateriaByMatricula
            Dim dao As AlumnoMateriaDAO = New AlumnoMateriaDAO
            Return dao.getMateriasByMatricula(id)
        End Function

        Public Sub AddMateria(ByVal alumnoMateriaDO As AlumnoMateriaDTO) Implements IAlumnoMateria.AddMateria
            Dim dao As AlumnoMateriaDAO = New AlumnoMateriaDAO
            dao.addMateria(alumnoMateriaDO)
        End Sub


        Public Sub AddListaMateria(ByVal lista As System.ComponentModel.BindingList(Of Contracts.DataTransferObjects.AlumnoMateriaDTO)) Implements Contracts.IAlumnoMateria.AddListaMateria

            'LimiteCreditosBusinessRule.ValidaCreditos(lista)

            For Each dto As AlumnoMateriaDTO In lista

                If dto.IsNew Then
                    AddMateria(dto)
                End If

            Next

        End Sub
    End Class
End Namespace

