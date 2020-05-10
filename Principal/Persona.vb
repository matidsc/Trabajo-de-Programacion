Public Class Persona

    Property _cedula As String
    Property _primer_nombre As String
    Property _primer_apellido As String
    Property _segundo_nombre As String
    Property _segundo_apellido As String

    Public Sub New()

    End Sub

    Public Sub New(cedula As String, nombre As String, apellido As String, segundoNombre As String, segundoApellido As String)
        Me._cedula = cedula
        Me._primer_nombre = nombre
        Me._primer_apellido = apellido
        Me._segundo_nombre = segundoNombre
        Me._segundo_apellido = segundoApellido
    End Sub

End Class
