Imports Logica

Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim met As New Metodos
        Dim dt As New DataTable
        dt = met.getEmp()
        dgvEmp.DataSource = dt

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        Form2.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub dgvEmp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dgvEmp.KeyPress
        e.Handled = False
    End Sub
    Private Sub dgvEmp_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmp.CellDoubleClick
        Form5.Visible = True
        Form5.darCedula(sender.CurrentRow.Cells(0).Value)
        Me.Close()

    End Sub
End Class