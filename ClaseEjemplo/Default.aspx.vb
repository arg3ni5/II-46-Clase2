Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim persona As New Persona("Fabian", "Chinchilla", 0)
        Titulo.Text = "Bienvenido a la clase de ASP.NET"
        LbPersona.Text = persona.NombreCompleto
    End Sub
End Class