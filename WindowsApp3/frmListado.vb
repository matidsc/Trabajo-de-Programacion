Imports Logica

Public Class frmListado
    Dim dt As DataTable

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim met As New Metodos

        dt = met.getEmp()
        dgvEmp.DataSource = dt
        Console.WriteLine()


    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        frmAddList.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub dgvEmp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dgvEmp.KeyPress
        e.Handled = False
    End Sub
    Private Sub dgvEmp_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmp.CellDoubleClick
        frmDelMod.ced = (sender.CurrentRow.Cells(0).Value)
        frmDelMod.Visible = True

        Me.Close()

    End Sub

    Private Sub txtCed_TextChanged(sender As Object, e As EventArgs) Handles txtCed.TextChanged

        Dim dv As New DataView(dt)
        dv.RowFilter = String.Format("convert(cedula, 'System.String') Like '%{0}%' ", txtCed.Text)

        If dv.Count > 0 Then
            Label9.Visible = False
            dgvEmp.DataSource = dv
        Else
            dgvEmp.DataSource = dv
            Label9.Visible = True

        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel1.Visible = False
        Panel2.Location = New Point(188, 83)
    End Sub
End Class