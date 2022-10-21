Imports Escuela.Contracts.DataTransferObjects
Imports System.ComponentModel
Imports Escuela.Contracts.DisplayObjects

Namespace Services
    Public Interface IAlumno
        Function getList() As BindingList(Of alumnodisplayobject)
        Sub getByMatricula(ByVal dto As AlumnoDTO)
        Sub save(ByVal dto As AlumnoDTO)
        Sub update(ByVal dto As AlumnoDTO)
        Sub delete(ByVal id As Integer)
    End Interface
End Namespace

