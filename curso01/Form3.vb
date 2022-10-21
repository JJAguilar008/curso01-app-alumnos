Imports Escuela.Contracts.DataTransferObjects
Imports Escuela.Contracts.Services
Imports Escuela.BusinessCore.DomainObjects
Imports Escuela.Contracts
Imports System.ComponentModel
Imports Escuela.Contracts.DisplayObjects

Public Class Form3

    Dim listaMateria As BindingList(Of AlumnoMateriaDTO)          'LISTA DE MATERIAS PARA MOSTRAR EN LA TABLA
    Dim listaMateriaUpdate As BindingList(Of AlumnoMateriaDTO)              'LISTA DE MATERIAS PARA CONSERVAR PARA MANDAR A LA BD

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim servicio As IMateria = New MateriaDomainObject()

        cbMateria.DataSource = servicio.getAll()

        cbMateria.ValueMember = "idmateria"
        cbMateria.DisplayMember = "nombre"
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click

        listaMateriaUpdate = New BindingList(Of AlumnoMateriaDTO)           'CADA QUE SE CONSULTE UN ALUMNO SE REINICIA LA LISTA DE MATERIAS QUE SE AGREGAGRAN

        Dim objAlumno As AlumnoDTO = New AlumnoDTO                          'SE CREA UN OBJETO DE TIPO ALUMNO PARA AGREGAR DATOS
        objAlumno.Matricula = CInt(txtMatricula.Text)                       'SE LA MATRICULA DEL ALUMNO A BUSCAR

        Dim servicio As IAlumno = New AlumnoDomainObjet                     'SE CREA UN SERVICIO
        servicio.getByMatricula(objAlumno)                                  'SE MANDA LLAMAR EL METODO PARA OBTENER LOS DATOS DEL ALUMNO 
        lblNombre.Text = objAlumno.Nombre & " " & objAlumno.Apellidos

        Dim servicio2 As IAlumnoMateria = New AlumnoMateriaDomainObject     'SE CREA UN SEGUNDO SERVICIO DEL ALUMNO ASI CONSERVAMOS LOS DATOS ANTERIORES
        listaMateria = servicio2.getMateriaByMatricula(objAlumno.Matricula) 'SE MANDA LLAMAR EL METODO PARA OBTENER LAS MATERIAS DEL ALUMNO Y SE GUARDAN EN LA LISTA DE MATERIAS
        dgvMaterias.DataSource = listaMateria                               'SE PASAN LAS MATERIAS AL DATA SOURCE DEL DATA GRID VIEW
        dgvMaterias.Columns("matricula").Visible = False                    'OCULTA UNA COLUMNA DEL DATA GRID VIEW
        'dgvMaterias.Columns("isNew").Visible = False

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        Dim objAlumnoMateria As AlumnoMateriaDTO = New AlumnoMateriaDTO                     'SE CREA OBJETO DE TIPO ALUMNODYSPLAYOBJECT

        objAlumnoMateria.Matricula = txtMatricula.Text                                      'SE AGREGAN LOS DATOS AL OBJETO
        objAlumnoMateria.IdMateria = cbMateria.SelectedValue                                '
        objAlumnoMateria.Materia = cbMateria.Text                                           '
        objAlumnoMateria.IsNew = True

        Dim display As AlumnoMateriaDTO = New AlumnoMateriaDTO

        display.Matricula = txtMatricula.Text
        display.IdMateria = cbMateria.SelectedValue
        display.Materia = cbMateria.Text
        display.IsNew = True

        listaMateriaUpdate.Add(objAlumnoMateria)                                            'SE AGREGA EL OBJETO A LA LISTA QUE SIRVE PARA AGREGAR MATERIAS
        listaMateria.Add(display)                                                           'TAMBIEN SE AGREGA EL OBJETO A LA LISTA DEL COMPONENTE DATAGRIDVIEW
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Dim dto As IAlumnoMateria = New AlumnoMateriaDomainObject           'SE CREA EL SERVICIO

        'Try
        '    dto.AddListaMateria(listaMateriaUpdate)                         'SE MANDA LLAMAR EL METODO PARA AGREGAR MATERIAS Y SE PARA EL ITEM DE LA LISTA
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try

        

    End Sub
End Class