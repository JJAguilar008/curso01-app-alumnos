Imports Escuela.Contracts.DataTransferObjects
Imports Escuela.Contracts.Services
Imports Escuela.BusinessCore.DomainObjects


Public Class Form1

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        Dim objAlumno As AlumnoDTO = New AlumnoDTO
        objAlumno.Matricula = txtMatricula.Text
        objAlumno.Nombre = txtNombre.Text
        objAlumno.Apellidos = txtApellido.Text
        objAlumno.Carrera = cbCarrera.SelectedValue

        Dim servicio As IAlumno = New AlumnoDomainObjet
        servicio.Save(objAlumno)

    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click

        Dim objAlumno As AlumnoDTO = New AlumnoDTO
        objAlumno.Matricula = txtMatricula.Text
        objAlumno.Nombre = txtNombre.Text
        objAlumno.Apellidos = txtApellido.Text
        objAlumno.Carrera = cbCarrera.SelectedValue

        Dim servicio As IAlumno = New AlumnoDomainObjet
        servicio.update(objAlumno)

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Dim servicio As IAlumno = New AlumnoDomainObjet
        servicio.delete(CInt(txtMatricula.Text))

    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click

        Dim servicio As IAlumno = New AlumnoDomainObjet
        dgvAlumnos.DataSource = servicio.getAll()

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        Dim objAlumno As AlumnoDTO = New AlumnoDTO
        objAlumno.Matricula = CInt(txtMatricula.Text)

        Dim servicio As IAlumno = New AlumnoDomainObjet
        servicio.getByMatricula(objAlumno)

        txtNombre.Text = objAlumno.Nombre
        txtApellido.Text = objAlumno.Apellidos
        cbCarrera.SelectedValue = objAlumno.Carrera

    End Sub

    Private Sub dgvAlumnos_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvAlumnos.SelectionChanged

        If dgvAlumnos.SelectedRows.Count = 1 Then
            txtMatricula.Text = dgvAlumnos.SelectedRows(0).Cells("matricula").Value
            txtNombre.Text = dgvAlumnos.SelectedRows(0).Cells("nombre").Value
            txtApellido.Text = dgvAlumnos.SelectedRows(0).Cells("apellidos").Value
            cbCarrera.SelectedValue = dgvAlumnos.SelectedRows(0).Cells("idcarrera").Value
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim servicio As ICarrera = New CarreraDomainObject()

        cbCarrera.DataSource = servicio.getAll()

        cbCarrera.ValueMember = "idcarrera"
        cbCarrera.DisplayMember = "nombre"
    End Sub
End Class
