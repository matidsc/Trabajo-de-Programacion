Imports Acceso_a_Datos
Imports Logica

Public Class Form5


    Private cedula As String
    Public Sub darCedula(cedula As String)
        Dim consultas = New Consultas()
        Dim readerEmpleado = consultas.tomarEmpleado(cedula)
        Dim readerTrabajoDeEmpleado As Object
        readerTrabajoDeEmpleado = consultas.buscar_empleados_en_tablas(cedula)
        Me.cedula = readerEmpleado.GetString(0)
        txtPrimerNombre.Text = readerEmpleado.GetString(1)
        txtSegundoNombre.Text = readerEmpleado.GetString(2)
        txtPrimerApellido.Text = readerEmpleado.GetString(3)
        txtSegundoApellido.Text = readerEmpleado.GetString(4)
        txtSueldo.Text = readerEmpleado.GetString(5)
        Select Case readerTrabajoDeEmpleado(0)
            Case "Administrativo"
                txtIncentivo.Visible = True
                pnlAdmin.Visible = True
                lblAdmin.Visible = True

                lblPrecioHora.Visible = False
                lblCantHoras.Visible = False
                txtCantHoras.Visible = False
                pnlCantHoras.Visible = False
                txtPrecioHora.Visible = False
                pnlPrecioHora.Visible = False

                lblGerente.Visible = False
                txtGerente.Visible = False
                pnlGerente.Visible = False
                txtIncentivo.Focus()

                cboTipo.SelectedIndex = 1
                txtIncentivo.Text = readerTrabajoDeEmpleado(1)(1)

            Case "Operario"
                lblPrecioHora.Visible = True
                lblCantHoras.Visible = True
                txtCantHoras.Visible = True
                pnlCantHoras.Visible = True
                txtPrecioHora.Visible = True
                pnlPrecioHora.Visible = True

                txtIncentivo.Visible = False
                pnlAdmin.Visible = False
                lblAdmin.Visible = False

                lblGerente.Visible = False
                txtGerente.Visible = False
                pnlGerente.Visible = False
                txtCantHoras.Focus()

                cboTipo.SelectedIndex = 2
                txtCantHoras.Text = readerTrabajoDeEmpleado(1)(1)
                txtPrecioHora.Text = readerTrabajoDeEmpleado(1)(2)


            Case "Gerente"

                lblGerente.Visible = True
                txtGerente.Visible = True
                pnlGerente.Visible = True

                txtIncentivo.Visible = False
                pnlAdmin.Visible = False
                lblAdmin.Visible = False

                lblPrecioHora.Visible = False
                lblCantHoras.Visible = False
                txtCantHoras.Visible = False
                pnlCantHoras.Visible = False
                txtPrecioHora.Visible = False
                pnlPrecioHora.Visible = False
                txtGerente.Focus()

                cboTipo.SelectedIndex = 3
                txtGerente.Text = readerTrabajoDeEmpleado(1)(1)
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        Form4.Visible = True
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombos()
    End Sub
    Private Sub CargarCombos()
        Dim met As New Metodos

        cboTipo.DataSource = met.getTipoEmp()
        cboTipo.ValueMember = "id"
        cboTipo.DisplayMember = "tipo"


        cboTipo.SelectedIndex = 0

    End Sub

    Private Sub cboTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipo.SelectedIndexChanged
        If cboTipo.ValueMember <> "" Then

            Dim tipo As Integer = cboTipo.SelectedValue

            Select Case tipo
                Case 0
                    lblPrecioHora.Visible = False
                    lblCantHoras.Visible = False
                    txtCantHoras.Visible = False
                    pnlCantHoras.Visible = False
                    txtPrecioHora.Visible = False
                    pnlPrecioHora.Visible = False

                    txtIncentivo.Visible = False
                    pnlAdmin.Visible = False
                    lblAdmin.Visible = False

                    lblGerente.Visible = False
                    txtGerente.Visible = False
                    pnlGerente.Visible = False

                Case 1


                    txtIncentivo.Visible = True
                    pnlAdmin.Visible = True
                    lblAdmin.Visible = True


                    lblPrecioHora.Visible = False
                    lblCantHoras.Visible = False
                    txtCantHoras.Visible = False
                    pnlCantHoras.Visible = False
                    txtPrecioHora.Visible = False
                    pnlPrecioHora.Visible = False



                    lblGerente.Visible = False
                    txtGerente.Visible = False
                    pnlGerente.Visible = False
                    txtIncentivo.Focus()

                Case 2

                    lblPrecioHora.Visible = True
                    lblCantHoras.Visible = True
                    txtCantHoras.Visible = True
                    pnlCantHoras.Visible = True
                    txtPrecioHora.Visible = True
                    pnlPrecioHora.Visible = True

                    txtIncentivo.Visible = False
                    pnlAdmin.Visible = False
                    lblAdmin.Visible = False


                    lblGerente.Visible = False
                    txtGerente.Visible = False
                    pnlGerente.Visible = False
                    txtCantHoras.Focus()

                Case 3


                    lblGerente.Visible = True
                    txtGerente.Visible = True
                    pnlGerente.Visible = True


                    txtIncentivo.Visible = False
                    pnlAdmin.Visible = False
                    lblAdmin.Visible = False


                    lblPrecioHora.Visible = False
                    lblCantHoras.Visible = False
                    txtCantHoras.Visible = False
                    pnlCantHoras.Visible = False
                    txtPrecioHora.Visible = False
                    pnlPrecioHora.Visible = False
                    txtGerente.Focus()

            End Select

        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim log As New Verificiaciones
        Dim guardar As Boolean = False

        Try
            If log.verificar_string(txtPrimerNombre.Text) = False Then

                MsgBox("Nombre incorrecto o vacío")
                Exit Try

            End If

            If log.verificar_string(txtPrimerApellido.Text) = False Then

                MsgBox("Apellido incorrecto o vacío")
                Exit Try

            End If

            If log.verificar_string(txtSegundoApellido.Text) = False Then

                MsgBox("Segundo apellido incorrecto o vacío")
                Exit Try

            End If

            If txtSegundoNombre.Text <> "" And txtSegundoNombre.Text.Length < 3 Then

                MsgBox("Segundo nombre incorrecto")
                Exit Try

            End If

            If log.verificar_int(txtSueldo.Text) = False Then

                MsgBox("Sueldo incorrecto o vacío")
                Exit Try

            End If

            If cboTipo.SelectedValue = 0 Then

                MsgBox("Debe seleccionar una categoría")
                Exit Try

            End If


            Select Case cboTipo.SelectedValue

                Case 1
                    If log.verificar_int(txtIncentivo.Text) = False Then

                        MsgBox("Incentivo incorrecto o vacío")
                        Exit Try

                    Else
                        guardar = True
                    End If

                Case 2
                    If log.verificar_int(txtCantHoras.Text) = False Or log.verificar_int(txtPrecioHora.Text) = False Then

                        MsgBox("Debe llenar los campos de operario")
                        Exit Try

                    Else
                        guardar = True
                    End If

                Case 3
                    If log.verificar_int(txtGerente.Text) = False Then
                        MsgBox("Nivel del gerente incorrecto o vacío")
                        Exit Try
                    Else
                        guardar = True
                    End If

            End Select

            If guardar = True Then
                modificar_empleado()
            End If

        Catch ex As Exception
            MsgBox("Error al ingresar empleado " & ex.Message)
        End Try
    End Sub
    Private Sub modificar_empleado()

        Select Case cboTipo.SelectedValue

            Case 1

                Dim adm As New Administrativo

                adm._cedula = Me.cedula
                adm._primer_nombre = txtPrimerNombre.Text.ToUpper
                adm._segundo_nombre = txtSegundoNombre.Text.ToUpper
                adm._primer_apellido = txtPrimerApellido.Text.ToUpper
                adm._segundo_apellido = txtSegundoApellido.Text.ToUpper
                adm._sueldo = Integer.Parse(txtSueldo.Text)
                adm._incentivo = Double.Parse(txtIncentivo.Text)
                adm.Sueldo()

                If adm.modificar() Then
                    MsgBox("Empleado modificado con éxito")
                End If

            Case 2

                Dim ope As New Operario

                ope._cedula = Me.cedula
                ope._primer_nombre = txtPrimerNombre.Text.ToUpper
                ope._segundo_nombre = txtSegundoNombre.Text.ToUpper
                ope._primer_apellido = txtPrimerApellido.Text.ToUpper
                ope._segundo_apellido = txtSegundoApellido.Text.ToUpper
                ope._sueldo = Integer.Parse(txtSueldo.Text)
                ope._cant_horas = Double.Parse(txtCantHoras.Text)
                ope._precio_hora = Double.Parse(txtPrecioHora.Text)
                ope.Sueldo()

                If ope.modificar() Then
                    MsgBox("Empleado modificado con éxito")
                End If

            Case 3

                Dim ger As New Gerente

                ger._cedula = Me.cedula
                ger._primer_nombre = txtPrimerNombre.Text.ToUpper
                ger._segundo_nombre = txtSegundoNombre.Text.ToUpper
                ger._primer_apellido = txtPrimerApellido.Text.ToUpper
                ger._segundo_apellido = txtSegundoApellido.Text.ToUpper
                ger._sueldo = Integer.Parse(txtSueldo.Text)
                ger._nivel = Byte.Parse(txtGerente.Text)
                ger.Sueldo()

                If ger.agregar() Then
                    MsgBox("Empleado modificado con éxito")
                End If

        End Select
    End Sub

End Class