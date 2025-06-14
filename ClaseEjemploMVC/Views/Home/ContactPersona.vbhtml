@ModelType ClaseEjemploMVC.Persona
@Html.ValidationSummary(True)

@Code
    ViewData("Title") = "ContactPersona"
End Code

<main aria-labelledby="title">
    <h2 id="title">@ViewData("Title").</h2>
    <h3>@ViewData("Message")</h3>


    <div class="row">
        <div class="col-md-4">
            @Code
                Using Html.BeginForm("ContactarPersona", "Home", FormMethod.Post)
            End Code
            <div class="form-group mb-3">
                @Html.LabelFor(Function(p) p.Nombre)
                @Html.TextBoxFor(Function(p) p.Nombre, New With {.class = "form-control", .id = "TxtNombre"})
            </div>

            <div class="form-group mb-3">
                @Html.LabelFor(Function(p) p.Apellido)
                @Html.TextBoxFor(Function(p) p.Apellido, New With {.class = "form-control", .id = "TxtApellido"})
                @Html.ValidationMessageFor(Function(p) p.Apellido, "", New With {.class = "text-danger"})
            </div>

            <div class="form-group mb-3">
                @Html.LabelFor(Function(p) p.Email)
                @Html.TextBoxFor(Function(p) p.Email, New With {.class = "form-control", .id = "TxtEmail"})
                @Html.ValidationMessageFor(Function(p) p.Email, "", New With {.class = "text-danger"})
            </div>

            <div class="form-group">
                <button type="submit" class="btn btn-primary">Contactar</button>
            </div>
            @Code
                End Using
            End Code
        </div>
        <label>@ViewData("Mensaje")</label>
    </div>
</main>
