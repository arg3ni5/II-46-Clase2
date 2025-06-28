Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim persona As New Persona With {
            .Nombre = "Juan",
            .Apellidos = "Pérez"
        }
        Dim persona2 As New Persona()
        persona2.Nombre = "Fabian"
        persona2.Apellidos = "Chinchilla"
        Titulo.Text = "Bienvenido a la clase de ASP.NET"
        LbPersona.Text = persona.NombreCompleto
    End Sub
End Class