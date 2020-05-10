Imports Logica

Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombos()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub CargarCombos()

        ' La propiedad DataSource del ComboBox permite pasarle como
        ' parametro un DataTable
        cbo_tipo.DataSource = getTiposEmpleados()
        cbo_tipo.ValueMember = "id"
        cbo_tipo.DisplayMember = "tipo"

        ' Parate en el indice 0 del contenido
        cbo_tipo.SelectedIndex = 0

    End Sub
    Private Sub cboTipoEmpleado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_tipo.SelectedIndexChanged

        If cbo_tipo.ValueMember <> "" Then

            Dim tipo As Integer = cbo_tipo.SelectedValue

            Select Case tipo
                Case 0
                    lblPrecioHora.Visible = False
                    lblCantHoras.Visible = False
                    txt_cant_horas.Visible = False
                    pnlCantHoras.Visible = False
                    txt_precio_hora.Visible = False
                    pnlPrecioHora.Visible = False

                    txt_incentivo.Visible = False
                    pnlAdmin.Visible = False
                    lblAdmin.Visible = False

                    lblGerente.Visible = False
                    txt_gerente.Visible = False
                    pnlGerente.Visible = False

                Case 1
                    ' Muestro Administrativos

                    txt_incentivo.Visible = True
                    pnlAdmin.Visible = True
                    lblAdmin.Visible = True

                    ' Escondo Campos de Operarios

                    lblPrecioHora.Visible = False
                    lblCantHoras.Visible = False
                    txt_cant_horas.Visible = False
                    pnlCantHoras.Visible = False
                    txt_precio_hora.Visible = False
                    pnlPrecioHora.Visible = False

                    ' Escondo Campos de Gerentes

                    lblGerente.Visible = False
                    txt_gerente.Visible = False
                    pnlGerente.Visible = False
                    txt_incentivo.Focus()

                Case 2

                    ' Muestro Campos de Operarios
                    lblPrecioHora.Visible = True
                    lblCantHoras.Visible = True
                    txt_cant_horas.Visible = True
                    pnlCantHoras.Visible = True
                    txt_precio_hora.Visible = True
                    pnlPrecioHora.Visible = True
                    ' Escondo Admiistrativos
                    txt_incentivo.Visible = False
                    pnlAdmin.Visible = False
                    lblAdmin.Visible = False

                    ' Escondo Campos de Gerentes
                    lblGerente.Visible = False
                    txt_gerente.Visible = False
                    pnlGerente.Visible = False
                    txt_cant_horas.Focus()

                Case 3

                    ' Muestro Campos de Gerentes
                    lblGerente.Visible = True
                    txt_gerente.Visible = True
                    pnlGerente.Visible = True

                    ' Escondo Admiistrativos
                    txt_incentivo.Visible = False
                    pnlAdmin.Visible = False
                    lblAdmin.Visible = False

                    ' Escondo Campos de Operarios
                    lblPrecioHora.Visible = False
                    lblCantHoras.Visible = False
                    txt_cant_horas.Visible = False
                    pnlCantHoras.Visible = False
                    txt_precio_hora.Visible = False
                    pnlPrecioHora.Visible = False
                    txt_gerente.Focus()

            End Select

        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        Me.Close()
        Form2.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub txtPrecioHora_TextChanged(sender As Object, e As EventArgs) Handles txt_precio_hora.TextChanged

    End Sub

    Private Sub txtGerente_TextChanged(sender As Object, e As EventArgs) Handles txt_gerente.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        Dim log As New Verificiaciones
        Dim guardar As Boolean = False

        Try

            If log.verificar_cedula(txt_cedula.Text) = False Or log.verificar_digito(txt_cedula.Text) = False Then

                MsgBox("Cédula incorrecta o vacía")
                Exit Try

            End If

            If log.verificar_string(txt_primer_nombre.Text) = False Then

                MsgBox("Nombre incorrecto o vacío")
                Exit Try

            End If

            If log.verificar_string(txt_primer_apellido.Text) = False Then

                MsgBox("Apellido incorrecto o vacío")
                Exit Try

            End If

            If log.verificar_string(txt_segundo_apellido.Text) = False Then

                MsgBox("Segundo apellido incorrecto o vacío")
                Exit Try

            End If

            If txt_segundo_nombre.Text <> "" And txt_segundo_nombre.Text.Length < 3 Then

                MsgBox("Segundo nombre incorrecto")
                Exit Try

            End If

            If log.verificar_int(txt_sueldo.Text) = False Then

                MsgBox("Sueldo incorrecto o vacío")
                Exit Try

            End If

            If cbo_tipo.SelectedValue = 0 Then

                MsgBox("Debe seleccionar una categoría")
                Exit Try

            End If


            Select Case cbo_tipo.SelectedValue

                Case 1
                    If log.verificar_int(txt_incentivo.Text) = False Then

                        MsgBox("Incentivo incorrecto o vacío")
                        Exit Try

                    Else
                        guardar = True
                    End If

                Case 2
                    If log.verificar_int(txt_cant_horas.Text) = False Or log.verificar_int(txt_precio_hora.Text) = False Then

                        MsgBox("Debe llenar los campos de operario")
                        Exit Try

                    Else
                        guardar = True
                    End If

                Case 3
                    If log.verificar_int(txt_gerente.Text) = False Then
                        MsgBox("Nivel del gerente incorrecto o vacío")
                        Exit Try
                    Else
                        guardar = True
                    End If

            End Select

            If guardar = True Then
                agregar_empleado()
            End If

        Catch ex As Exception
            MsgBox("Error al ingresar empleado " & ex.Message)
        End Try

    End Sub

    Private Sub agregar_empleado()

        Select Case cbo_tipo.SelectedValue

            Case 1

                Dim adm As New Administrativo

                adm._cedula = txt_cedula.Text
                adm._primer_nombre = txt_primer_nombre.Text
                adm._segundo_nombre = txt_segundo_nombre.Text
                adm._primer_apellido = txt_primer_apellido.Text
                adm._segundo_apellido = txt_segundo_apellido.Text
                adm._sueldo = Integer.Parse(txt_sueldo.Text)
                adm._incentivo = Double.Parse(txt_incentivo.Text)
                adm.Sueldo()

                If adm.agregar() Then
                    MsgBox("Empleado ingresado con éxito")
                End If

            Case 2

                Dim ope As New Operario

                ope._cedula = txt_cedula.Text
                ope._primer_nombre = txt_primer_nombre.Text
                ope._segundo_nombre = txt_segundo_nombre.Text
                ope._primer_apellido = txt_primer_apellido.Text
                ope._segundo_apellido = txt_segundo_apellido.Text
                ope._sueldo = Integer.Parse(txt_sueldo.Text)
                ope._cant_horas = Double.Parse(txt_cant_horas.Text)
                ope._precio_hora = Double.Parse(txt_precio_hora.Text)
                ope.Sueldo()

                If ope.agregar() Then
                    MsgBox("Empleado ingresado con éxito")
                End If

            Case 3

                Dim ger As New Gerente

                ger._cedula = txt_cedula.Text
                ger._primer_nombre = txt_primer_nombre.Text
                ger._segundo_nombre = txt_segundo_nombre.Text
                ger._primer_apellido = txt_primer_apellido.Text
                ger._segundo_apellido = txt_segundo_apellido.Text
                ger._sueldo = Integer.Parse(txt_sueldo.Text)
                ger._nivel = Byte.Parse(txt_gerente.Text)
                ger.Sueldo()

                If ger.agregar() Then
                    MsgBox("Empleado ingresado con éxito")
                End If

        End Select
    End Sub

End Class