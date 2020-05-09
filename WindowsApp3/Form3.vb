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
        cboTIpoEmpleado.DataSource = getTiposEmpleados()
        cboTIpoEmpleado.ValueMember = "id"
        cboTIpoEmpleado.DisplayMember = "tipo"

        ' Parate en el indice 0 del contenido
        cboTIpoEmpleado.SelectedIndex = 0

    End Sub
    Private Sub cboTipoEmpleado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTIpoEmpleado.SelectedIndexChanged

        If cboTIpoEmpleado.ValueMember <> "" Then

            Dim tipo As Integer = cboTIpoEmpleado.SelectedValue

            Select Case tipo
                Case 0
                    lblPrecioHora.Visible = False
                    lblCantHoras.Visible = False
                    txtCantHoras.Visible = False
                    pnlCantHoras.Visible = False
                    txtPrecioHora.Visible = False
                    pnlPrecioHora.Visible = False

                    txtAdmin.Visible = False
                    pnlAdmin.Visible = False
                    lblAdmin.Visible = False

                    lblGerente.Visible = False
                    txtGerente.Visible = False
                    pnlGerente.Visible = False

                Case 1
                    ' Muestro Administrativos

                    txtAdmin.Visible = True
                    pnlAdmin.Visible = True
                    lblAdmin.Visible = True

                    ' Escondo Campos de Operarios

                    lblPrecioHora.Visible = False
                    lblCantHoras.Visible = False
                    txtCantHoras.Visible = False
                    pnlCantHoras.Visible = False
                    txtPrecioHora.Visible = False
                    pnlPrecioHora.Visible = False

                    ' Escondo Campos de Gerentes

                    lblGerente.Visible = False
                    txtGerente.Visible = False
                    pnlGerente.Visible = False

                Case 2

                    ' Muestro Campos de Operarios
                    lblPrecioHora.Visible = True
                    lblCantHoras.Visible = True
                    txtCantHoras.Visible = True
                    pnlCantHoras.Visible = True
                    txtPrecioHora.Visible = True
                    pnlPrecioHora.Visible = True
                    ' Escondo Admiistrativos
                    txtAdmin.Visible = False
                    pnlAdmin.Visible = False
                    lblAdmin.Visible = False

                    ' Escondo Campos de Gerentes
                    lblGerente.Visible = False
                    txtGerente.Visible = False
                    pnlGerente.Visible = False

                Case 3

                    ' Muestro Campos de Gerentes
                    lblGerente.Visible = True
                    txtGerente.Visible = True
                    pnlGerente.Visible = True

                    ' Escondo Admiistrativos
                    txtAdmin.Visible = False
                    pnlAdmin.Visible = False
                    lblAdmin.Visible = False

                    ' Escondo Campos de Operarios
                    lblPrecioHora.Visible = False
                    lblCantHoras.Visible = False
                    txtCantHoras.Visible = False
                    pnlCantHoras.Visible = False
                    txtPrecioHora.Visible = False
                    pnlPrecioHora.Visible = False

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
End Class