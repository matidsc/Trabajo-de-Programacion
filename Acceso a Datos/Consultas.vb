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
    ' modificar registro

    Overloads Function modificar_registro(cedula As Integer, nombre As String, segundo_nombre As String, apellido As String, segundo_apellido As String, sueldo As Integer, variable As Integer, tabla As String, columna As String) As Boolean

        Dim consulta As String = "UPDATE empleado SET "
        '       update empleado set 
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
        '       update empleado set 
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


    Function tomarEmpleado(cedula As String) As OdbcDataReader
        Dim consulta As String = "Select * from empleado where cedula=" & cedula
        conn.Open()
        Dim reader = New OdbcCommand(consulta, conn).ExecuteReader()

        If reader.HasRows Then
            Return reader
        End If
        conn.Close()

    End Function
    Function buscar_empleados_en_tablas(cedula As String) As Object
        Dim consulta1 As String = "Select * from Administrativo where cedula=" & cedula
        Dim consulta2 As String = "Select * from Gerente where cedula=" & cedula
        Dim consulta3 As String = "Select * from Operario where cedula=" & cedula
        Dim reader1 = New OdbcCommand(consulta1, conn).ExecuteReader()
        Dim reader2 = New OdbcCommand(consulta2, conn).ExecuteReader()
        Dim reader3 = New OdbcCommand(consulta3, conn).ExecuteReader()
        If reader1.HasRows Then
            Return {"Administrativo", reader1}
        ElseIf reader2.HasRows Then
            Return {"Gerente", reader2}
        ElseIf reader3.HasRows Then
            Return {"Operario", reader3}
        End If
    End Function
    Overloads Function mostrar_empleados() As DataTable

        Dim conn As New OdbcConnection("dsn=driverODBC;uid=root;pwd=;")
        Dim command As String = "SELECT * FROM empleado"
        Dim dt As New DataTable
        Try
            conn.Open()
            Dim da As New OdbcDataAdapter(command, conn)
            da.Fill(dt)
            conn.Close()
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        End Try
        Return dt
    End Function
End Class
