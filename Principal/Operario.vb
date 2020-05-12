Imports Acceso_a_Datos

Public Class Operario
    Inherits Empleado

    Property _cant_horas As Double
    Property _precio_hora As Double

    Public Sub New()

    End Sub

    Public Sub New(cedula As Integer, primer_nombre As String, segundo_nombre As String, primer_apellido As String, segundo_apellido As String, tipo As String,
                    sueldo As Double, cant_horas As Double,
                    precio_hora As Double)

        Me._cedula = cedula
        Me._primer_nombre = primer_nombre
        Me._segundo_nombre = segundo_nombre
        Me._primer_apellido = primer_apellido
        Me._segundo_apellido = segundo_apellido
        Me._tipo = tipo
        Me._sueldo = sueldo
        Me._cant_horas = cant_horas
        Me._precio_hora = precio_hora

    End Sub

    Public Overloads Sub Sueldo()

        _sueldo = (_sueldo + (_cant_horas * _precio_hora)) * 1.2

    End Sub

    Public Overloads Function agregar()

        Dim datos As New Consultas

        Return datos.agregar_registro(_cedula, _primer_nombre, _segundo_nombre, _primer_apellido, _segundo_apellido, _sueldo, _cant_horas, _precio_hora)
    End Function
    Public Overloads Function modificar()

        Dim datos As New Consultas

        Return datos.modificar_registro(_cedula, _primer_nombre, _segundo_nombre, _primer_apellido, _segundo_apellido, _sueldo, _cant_horas, _precio_hora)
    End Function
End Class
