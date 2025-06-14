Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
    Function ContactPersona() As ActionResult
        ViewData("Message") = "Your contact persona page."

        Return View()
    End Function


    Function Contactar() As ActionResult
        Dim nombre As String = Request.Form("TxtNombre")
        Dim apellido As String = Request.Form("TxtApellido")
        Dim email As String = Request.Form("TxtEmail")

        Dim persona As New Persona(nombre, apellido, email)
        ViewData("Mensaje") = $"Gracias por contactarnos {persona.NombreCompleto}"

        Return View("Contact")
    End Function

    Function ContactarPersona(model As Persona) As ActionResult
        If ModelState.IsValid Then
            ViewData("Mensaje") = $"Gracias por contactarnos {model.NombreCompleto}"
        Else
            ViewData("Mensaje") = "Por favor, complete todos los campos requeridos."
        End If

        Return View("ContactPersona", model)
    End Function
End Class
