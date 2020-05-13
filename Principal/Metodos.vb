Imports Acceso_a_Datos

Public Class Metodos

    Private mov As Boolean
    Private movX, movY As Double
    Public Function getEmp() As DataTable
        Dim dt As DataTable
        Dim datos As New Consultas()
        dt = datos.mostrar_empleados

        Return dt
    End Function

    'Public Function agregar(cedula As Integer, nombre As String, segundo_nombre As String, apellido As String, segundo_apellido As String, sueldo As Integer) As Boolean
    '    Return datos.agregar_registro(cedula, nombre, segundo_nombre, apellido, segundo_apellido, sueldo)
    'End Function

    Public Function getTipoEmp() As DataTable


        Dim dt As New DataTable

        Try

            dt.Columns.Add("id")
            dt.Columns.Add("tipo")

            Dim row As DataRow = dt.NewRow()

            row = dt.NewRow()
            row("id") = 0
            row("tipo") = "Seleccione tipo de Empleado"
            dt.Rows.Add(row)

            row = dt.NewRow()
            row("id") = 1
            row("tipo") = "Administrativo"
            dt.Rows.Add(row)

            row = dt.NewRow()
            row("id") = 2
            row("tipo") = "Operario"
            dt.Rows.Add(row)

            row = dt.NewRow()
            row("id") = 3
            row("tipo") = "Gerente"
            dt.Rows.Add(row)

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message)
        End Try

        Return dt

    End Function


End Class
