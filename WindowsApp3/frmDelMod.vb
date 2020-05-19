Imports Logica

Public Class frmDelMod

    Property ced As String

    Private Sub frmDelMod_load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label4.Text += ced

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        Dim yn = MsgBox("Eliminar a: " & ced & "?", vbYesNo)

        If yn = vbYes Then
            Dim met As New Metodos
            met.getCedula(ced)
            met.eliminarEmp()
            MsgBox("Empleado eliminado")
            If met.hasEmp Then
                Me.Close()
                frmListado.Visible = True
            Else
                Me.Close()
                frmAddList.Visible = True

            End If
        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        frmModificar.Visible = True
        frmModificar.darCedula(ced)
        Me.Close()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

        frmListado.Visible = True
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.WindowState = WindowState.Minimized

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()

    End Sub

End Class