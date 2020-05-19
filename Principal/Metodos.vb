Imports Acceso_a_Datos

Public Class Metodos

    Private cedula As String

    Public Function darCed(ByRef cedula As String, ByRef priNom As String, ByRef segundo_nombre As String, ByRef primer_apellido As String, ByRef segundo_apellido As String, ByRef sueldo As String, ByRef incentivo As String, ByRef cantHoras As String, ByRef precioHora As String, ByRef nivel As String) As String

        Dim consultas = New Consultas()
        Dim readerEmpleado As ArrayList = consultas.tomarEmpleado(cedula)
        Dim readerTrabajoDeEmpleado As ArrayList = consultas.buscar_empleados_en_tablas(cedula)


        cedula = readerEmpleado.Item(0)
        priNom = readerEmpleado.Item(1)
        segundo_nombre = readerEmpleado.Item(2)
        primer_apellido = readerEmpleado.Item(3)
        segundo_apellido = readerEmpleado.Item(4)
        sueldo = readerEmpleado.Item(5)

        Select Case readerTrabajoDeEmpleado.Item(0)

            Case "Administrativo"

                incentivo = readerTrabajoDeEmpleado.Item(1)
                Return "Administrativo"

            Case "Operario"

                cantHoras = readerTrabajoDeEmpleado.Item(1)
                precioHora = readerTrabajoDeEmpleado.Item(2)
                Return "Operario"


            Case "Gerente"

                nivel = readerTrabajoDeEmpleado.Item(1)
                Return "Gerente"
        End Select

    End Function

    Public Function hasEmp() As Boolean
        Dim consultas As New Consultas

        If consultas.hasEmp() = 1 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Sub getCedula(ced As String)

        Me.cedula = ced 'obtiene la cedula que clickea el usuario del dataGridView

    End Sub

    Public Function getEmp() As DataTable

        Dim dt As DataTable
        Dim datos As New Consultas()
        dt = datos.mostrar_empleados
        Return dt

    End Function

    Public Sub eliminarEmp()

        Dim tipo As String
        Dim consultas As New Consultas
        Dim readerTrabajoDeEmpleado As Object
        readerTrabajoDeEmpleado = consultas.buscar_empleados_en_tablas(Me.cedula)

        tipo = readerTrabajoDeEmpleado(0)

        consultas.eliminar_registro(cedula, tipo)

    End Sub

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
