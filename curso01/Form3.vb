Imports Escuela.Contracts.DataTransferObjects
Imports Escuela.Contracts.Services
Imports Escuela.BusinessCore.DomainObjects

Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim servicio As IMateria = New MateriaDomainObject()

        cbMateria.DataSource = servicio.getAll()

        cbMateria.ValueMember = "idmateria"
        cbMateria.DisplayMember = "nombre"
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click

        Dim objAlumno As AlumnoDTO = New AlumnoDTO
        objAlumno.Matricula = CInt(txtMatricula.Text)

        Dim servicio As IAlumno = New AlumnoDomainObjet
        servicio.getByMatricula(objAlumno)

        lblNombre.Text = objAlumno.Nombre & " " & objAlumno.Apellidos

        Dim servicio2 As IMateria = New MateriaDomainObject
        dgvMaterias.DataSource = servicio2.getMateriaByMatricula(objAlumno.Matricula)

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        Dim objAlumno As AlumnoDTO = New AlumnoDTO
        objAlumno.Matricula = CInt(txtMatricula.Text)
        objAlumno.Idmateria = cbMateria.SelectedValue

        Dim servicio As IAlumno = New AlumnoDomainObjet
        servicio.addMateria(objAlumno)

        Dim servicio2 As IMateria = New MateriaDomainObject
        dgvMaterias.DataSource = servicio2.getMateriaByMatricula(objAlumno.Matricula)
    End Sub
End Class