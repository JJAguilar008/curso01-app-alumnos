Imports Escuela.Contracts.DataTransferObjects
Imports Escuela.Contracts.Services
Imports Escuela.BusinessCore.DomainObjects


Public Class Form1
    Dim alumno As AlumnoDTO = New AlumnoDTO     'SE CREA OBJETO ALUMNO PARA MANTENER LOS DATOS

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        'Dim objAlumno As AlumnoDTO = New AlumnoDTO
        alumno.Matricula = txtMatricula.Text                'TOMA TODOS LOS VALORES DE LAS CAJAS DE TEXTO PARA INSERTAR
        alumno.Nombre = txtNombre.Text
        alumno.Apellidos = txtApellido.Text
        alumno.Carrera = cbCarrera.SelectedValue

        Dim servicio As IAlumno = New AlumnoDomainObjet     'SE CREA EL SERVICIO PARA ACTUALIZAR
        servicio.save(alumno)                               'SE LLAMA EL METODO SAVE DEL SERVICIO Y SE MANDA EL OBJETO ALUMNO

        btnEliminar.Enabled = False                         'SE DESACTIVAN LOS COMPONENTES DEL FORM PARA DESPUES PODER HACER CAMBIOS
        txtNombre.Enabled = False
        txtApellido.Enabled = False
        cbCarrera.Enabled = False
        btnAgregar.Enabled = False
        txtMatricula.Enabled = True

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
        dgvAlumnos.DataSource = servicio.getList()
        dgvAlumnos.Columns("idcarrera").Visible = False

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click


        alumno.Matricula = CInt(txtMatricula.Text)
        Dim servicio As IAlumno = New AlumnoDomainObjet
        servicio.getByMatricula(alumno)


        If alumno.IsNew Then
            MessageBox.Show("La matricula no existe")
        Else
            txtNombre.Text = alumno.Nombre
            txtApellido.Text = alumno.Apellidos
            cbCarrera.SelectedValue = alumno.Carrera
        End If


        'txtNombre.Text = alumno.Nombre
        'txtApellido.Text = alumno.Apellidos
        'cbCarrera.SelectedValue = alumno.Carrera

        btnEliminar.Enabled = True                      'AQUI SE HABILITAN LOS COMPONENTES DEL FORM
        txtNombre.Enabled = True
        txtApellido.Enabled = True
        cbCarrera.Enabled = True
        btnAgregar.Enabled = True
        txtMatricula.Enabled = False

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

        btnActualizar.Enabled = False               'AL INICIAR EL FORM SE DESHABILITAN TODOS LOS COMPONENTES
        btnEliminar.Enabled = False
        txtNombre.Enabled = False
        txtApellido.Enabled = False
        cbCarrera.Enabled = False
        btnAgregar.Enabled = False

    End Sub
End Class
