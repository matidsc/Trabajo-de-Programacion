Imports Acceso_a_Datos

Public Class Empleado
    Inherits Persona

    Property _tipo As String
    Property _sueldo As Integer

    Public Sub New()

    End Sub

    Public Sub New(cedula As String, primer_nombre As String, primer_apellido As String, segundo_nombre As String, segundo_apellido As String, tipo As String, sueldo As Integer)
        MyBase.New(cedula, primer_nombre, primer_apellido, segundo_nombre, segundo_apellido)

        Me._cedula = cedula
        Me._primer_nombre = primer_nombre
        Me._segundo_nombre = segundo_nombre
        Me._primer_apellido = primer_apellido
        Me._segundo_apellido = segundo_apellido
        Me._tipo = tipo
        Me._sueldo = sueldo

    End Sub

    Public Sub Sueldo()

    End Sub

    Public Function agregar() As Boolean

    End Function

End Class
