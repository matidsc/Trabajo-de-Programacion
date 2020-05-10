
Public Module Principal

    Private dtEmpleados As New DataTable

    Public Function getTiposEmpleados() As DataTable

        ' Creo la tabla fuera del Try 
        ' para poder devolverlo en el return de la Funcion
        Dim dt As New DataTable

        Try
            ' Agrego las columnas al Datatable
            ' donde voy a guardar los dato necesarios
            dt.Columns.Add("id")
            dt.Columns.Add("tipo")

            'Fila es la variable que agregara filas(rows) a mi datatable
            Dim fila As DataRow = dt.NewRow()

            fila = dt.NewRow()
            fila("id") = 0
            fila("tipo") = "Seleccione tipo de Empleado"
            dt.Rows.Add(fila)

            fila = dt.NewRow()
            fila("id") = 1
            fila("tipo") = "Administrativo"
            dt.Rows.Add(fila)

            fila = dt.NewRow()
            fila("id") = 2
            fila("tipo") = "Operario"
            dt.Rows.Add(fila)

            fila = dt.NewRow()
            fila("id") = 3
            fila("tipo") = "Gerente"
            dt.Rows.Add(fila)

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message)
        End Try

        Return dt

    End Function
End Module
