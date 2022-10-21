Imports Escuela.Contracts.DataTransferObjects
Imports System.ComponentModel
Imports Escuela.Contracts.DisplayObjects

Public Interface IAlumnoMateria

    Function GetMateriaByMatricula(ByVal matricula As String) As BindingList(Of AlumnoMateriaDTO)
    Sub AddMateria(ByVal dto As AlumnoMateriaDTO)
    Sub AddListaMateria(ByVal lista As BindingList(Of AlumnoMateriaDTO))

End Interface
