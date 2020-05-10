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

End Class
