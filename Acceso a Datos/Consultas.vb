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
        '       update empleado set 
        consulta = consulta & "pNom='" & nombre & " ', sNom ='" & segundo_nombre & " ', pApe= '" & apellido & "', sApe= '"
        consulta = consulta & segundo_apellido & "', sueldoTotal = " & sueldo & " where cedula = " & cedula & ";"


        Dim consulta2 As String
        consulta2 = "UPDATE " & tabla & " SET " & columna & "=" & variable & " where cedula = " & cedula & ";"
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

    Overloads Function modificar_registro(cedula As Integer, nombre As String, segundo_nombre As String, apellido As String, segundo_apellido As String, sueldo As Integer, cant_horas As Double, precio_hora As Double)

        Dim consulta As String = "UPDATE empleado SET "
        '       update empleado set 
        consulta = consulta & "pNom='" & nombre & " ', sNom ='" & segundo_nombre & " ', pApe= '" & apellido & "', sApe= '"
        consulta = consulta & segundo_apellido & "', sueldoTotal = " & sueldo & " where cedula = " & cedula & ";"


        Dim consulta2 As String
        consulta2 = "UPDATE OPERARIO SET cantHoras" & "=" & cant_horas & ", precioHora=" & precio_hora & " where cedula = " & cedula & ";"
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
    Function buscar_empleados_en_tablas(cedula As String) As String
        Dim consulta1 As String = "Select * from Administrativo where cedula=" & cedula
        Dim consulta2 As String = "Select * from Gerente where cedula=" & cedula
        Dim consulta3 As String = "Select * from Operario where cedula=" & cedula
        Dim command1 = New OdbcCommand(consulta1, conn).ExecuteReader()
        Dim command2 = New OdbcCommand(consulta2, conn).ExecuteReader()
        Dim command3 = New OdbcCommand(consulta3, conn).ExecuteReader()
        If command1.HasRows Then
            Return "Administrativo"
        ElseIf command2.HasRows Then
            Return "Gerente"
        ElseIf command3.HasRows Then
            Return "Operario"
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
