Imports System.Data.Odbc

Public Class Consultas


    Dim conn As New OdbcConnection("dsn=driverODBC;uid=root;pwd=;")


    Overloads Function agregar_registro(cedula As Integer, nombre As String, segundo_nombre As String, apellido As String, segundo_apellido As String, sueldo As Integer, variable As Integer, tabla As String, columna As String) As Boolean

        Dim consulta As String = "INSERT INTO empleado (cedula,pNom,pApe,sNom,sApe,sueldoTotal) VALUES ("
        consulta = consulta & " '" & cedula & "','" & nombre & "','" & apellido & "','" & segundo_nombre & "',"
        consulta = consulta & "'" & segundo_apellido & "','" & sueldo & "')"

        Dim consulta2 As String
        consulta2 = "INSERT INTO " & tabla & " (cedula," & columna & ") VALUES (" & cedula & ", " & variable & ")"

        Dim command As New OdbcCommand(consulta, conn)
        Dim command2 As New OdbcCommand(consulta2, conn)

        Try
            conn.Open()
            command.ExecuteNonQuery()
            command2.ExecuteNonQuery()
            conn.Close()
            Return True

        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        End Try

        Return False
    End Function

    Overloads Function agregar_registro(cedula As Integer, nombre As String, segundo_nombre As String, apellido As String, segundo_apellido As String, sueldo As Integer, cant_horas As Double, precio_hora As Double)

        Dim consulta As String = "INSERT INTO empleado (cedula,pNom,pApe,sNom,sApe,sueldoTotal) VALUES ("
        consulta = consulta & " '" & cedula & "','" & nombre & "','" & apellido & "','" & segundo_nombre & "',"
        consulta = consulta & "'" & segundo_apellido & "','" & sueldo & "')"

        Dim consulta2 As String
        consulta2 = "INSERT INTO operario (cedula, cantHoras, precioHora) VALUES (" & cedula & ", " & cant_horas & "," & precio_hora & ")"

        Dim command As New OdbcCommand(consulta, conn)
        Dim command2 As New OdbcCommand(consulta2, conn)

        Try
            conn.Open()
            command.ExecuteNonQuery()
            command2.ExecuteNonQuery()
            conn.Close()
            Return True

        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        End Try

        Return False
    End Function

    Overloads Function modificar_registro(cedula As Integer, nombre As String, segundo_nombre As String, apellido As String, segundo_apellido As String, sueldo As Integer, variable As Integer, tabla As String, columna As String) As Boolean

        Dim consulta As String = "UPDATE empleado SET "
        consulta = consulta & "pNom='" & nombre & "', sNom ='" & segundo_nombre & "', pApe= '" & apellido & "', sApe= '"
        consulta = consulta & segundo_apellido & "', sueldoTotal = " & sueldo & " where cedula = " & cedula
        Dim consulta2_1 As String = "delete from administrativo where cedula=" & cedula
        Dim consulta2_2 As String = "delete from gerente where cedula=" & cedula
        Dim consulta2_3 As String = "delete from operario where cedula=" & cedula
        Dim consulta3 As String = "INSERT INTO " & tabla & " (cedula," & columna & ") VALUES (" & cedula & ", " & variable & ")"


        Dim command As New OdbcCommand(consulta, conn)
        Dim command2_1 As New OdbcCommand(consulta2_1, conn)
        Dim command2_2 As New OdbcCommand(consulta2_2, conn)
        Dim command2_3 As New OdbcCommand(consulta2_3, conn)
        Dim command3 As New OdbcCommand(consulta3, conn)

        Try
            conn.Open()
            command.ExecuteNonQuery()
            command2_1.ExecuteNonQuery()
            command2_2.ExecuteNonQuery()
            command2_3.ExecuteNonQuery()
            command3.ExecuteNonQuery()
            conn.Close()

            Return True

        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        End Try

        Return False
    End Function

    Overloads Function modificar_registro(cedula As Integer, nombre As String, segundo_nombre As String, apellido As String, segundo_apellido As String, sueldo As Integer, cant_horas As Double, precio_hora As Double)

        Dim consulta As String = "UPDATE empleado SET "
        consulta = consulta & "pNom='" & nombre & "', sNom ='" & segundo_nombre & "', pApe= '" & apellido & "', sApe= '"
        consulta = consulta & segundo_apellido & "', sueldoTotal = " & sueldo & " where cedula = " & cedula
        Dim consulta2_1 As String = "delete from administrativo where cedula=" & cedula
        Dim consulta2_2 As String = "delete from gerente where cedula=" & cedula
        Dim consulta2_3 As String = "delete from operario where cedula=" & cedula
        Dim consulta3 As String = "INSERT INTO operario VALUES (" & cedula & ", " & cant_horas & "," & precio_hora & ")"

        Dim command As New OdbcCommand(consulta, conn)
        Dim command2_1 As New OdbcCommand(consulta2_1, conn)
        Dim command2_2 As New OdbcCommand(consulta2_2, conn)
        Dim command2_3 As New OdbcCommand(consulta2_3, conn)
        Dim command3 As New OdbcCommand(consulta3, conn)
        Try
            conn.Open()
            command.ExecuteNonQuery()
            command2_1.ExecuteNonQuery()
            command2_2.ExecuteNonQuery()
            command2_3.ExecuteNonQuery()
            command3.ExecuteNonQuery()
            conn.Close()
            Return True

        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        End Try

        Return False
    End Function

    Function tomarEmpleado(cedula As String) As ArrayList

        Dim consulta As String = "Select * from empleado where cedula = " & cedula
        Dim arr As New ArrayList
        conn.Close()

        conn.Open()
        Dim reader = New OdbcCommand(consulta, conn).ExecuteReader()


        While reader.Read

            arr.Add(reader.Item(0))
            arr.Add(reader.Item(1))
            arr.Add(reader.Item(2))
            arr.Add(reader.Item(3))
            arr.Add(reader.Item(4))
            arr.Add(reader.Item(5))

            Return arr
            conn.Close()
        End While

    End Function

    Function buscar_empleados_en_tablas(cedula As String) As ArrayList

        Dim consulta1 As String = "Select * from administrativo where cedula = " & cedula
        Dim consulta2 As String = "Select * from gerente where cedula = " & cedula
        Dim consulta3 As String = "Select * from operario where cedula = " & cedula
        Dim arr As New ArrayList

        conn.Close()

        Try
            conn.Open()
            Dim reader1 = New OdbcCommand(consulta1, conn).ExecuteReader()
            Dim reader2 = New OdbcCommand(consulta2, conn).ExecuteReader()
            Dim reader3 = New OdbcCommand(consulta3, conn).ExecuteReader()

            If reader1.HasRows Then
                arr.Add("Administrativo")
                arr.Add(reader1.Item(1))
                Return arr
            ElseIf reader2.HasRows Then
                arr.Add("Gerente")
                arr.Add(reader2.Item(1))
                Return arr
            ElseIf reader3.HasRows Then
                arr.Add("Operario")
                arr.Add(reader3.Item(1))
                arr.Add(reader3.Item(2))
                Return arr
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        End Try

    End Function

    Function mostrar_empleados() As DataTable

        Dim command As String = "SELECT * FROM empleado"
        Dim dt As New DataTable
        Try
            conn.Open()
            Dim da As New OdbcDataAdapter(command, conn)
            conn.Close()
            da.Fill(dt)

        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        End Try
        Return dt

    End Function

    Function eliminar_registro(cedula As String, tabla As String)

        Dim consulta1 = "DELETE FROM " & tabla & " WHERE cedula = " & cedula
        Dim consulta2 = "DELETE FROM empleado WHERE cedula = " & cedula
        Dim command1 As New OdbcCommand(consulta1, conn)
        Dim command2 As New OdbcCommand(consulta2, conn)

        conn.Close()

        Try

            conn.Open()
            command1.ExecuteNonQuery()
            command2.ExecuteNonQuery()
            conn.Close()

        Catch ex As Exception
            MsgBox("Error : " & ex.Message)

        End Try


    End Function

    Function hasEmp() As Byte

        Dim consulta1 = "SELECT COUNT(*) FROM empleado"
        Dim cant As Byte
        Try
            conn.Open()
            Dim command As New OdbcCommand(consulta1, conn)
            cant = command.ExecuteScalar()

            If cant > 0 Then
                Return 1
            Else
                Return 0
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        End Try

    End Function


End Class
