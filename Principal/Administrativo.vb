Imports Acceso_a_Datos

Public Class Administrativo
    Inherits Empleado

    Property _incentivo As Integer

    Public Sub New()

    End Sub

    Public Sub New(cedula As Integer, primer_nombre As String, segundo_nombre As String, primer_apellido As String, segundo_apellido As String,
                    tipo As String,
                    sueldo As Integer)

        Me._cedula = cedula
        Me._primer_nombre = primer_nombre
        Me._segundo_nombre = segundo_nombre
        Me._primer_apellido = primer_apellido
        Me._segundo_apellido = segundo_apellido
        Me._tipo = tipo
        Me._sueldo = sueldo

    End Sub

    Public Overloads Sub Sueldo()

        _sueldo = (_sueldo + _incentivo) * 1.5

    End Sub

    Public Overloads Function agregar()

        Dim datos As New Consultas

        Return datos.agregar_registro(_cedula, _primer_nombre, _segundo_nombre, _primer_apellido, _segundo_apellido, _sueldo, _incentivo, "administrativo", "incentivo")
    End Function
    Public Overloads Function modificar()

        Dim datos As New Consultas

        Return datos.modificar_registro(_cedula, _primer_nombre, _segundo_nombre, _primer_apellido, _segundo_apellido, _sueldo, _incentivo, "administrativo", "incentivo")
    End Function

End Class
