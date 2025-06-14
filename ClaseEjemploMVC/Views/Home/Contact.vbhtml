@Code
    ViewData("Title") = "Contact"
End Code

<main aria-labelledby="title">
    <h2 id="title">@ViewData("Title").</h2>
    <h3>@ViewData("Message")</h3>


    <div class="row">
        <div class="col-md-4">
            @Code
                Using Html.BeginForm("Contactar", "Home", FormMethod.Post)
            End Code
            <div class="form-group mb-3">
                <label for="TxtNombre">Nombre</label>
                @Html.TextBox("TxtNombre", Nothing, New With {.class = "form-control", .id = "TxtNombre"})
            </div>

            <div class="form-group mb-3">
                <label for="TxtApellido">Apellido</label>
                @Html.TextBox("TxtApellido", Nothing, New With {.class = "form-control", .id = "TxtApellido"})
            </div>

            <div class="form-group mb-3">
                <label for="TxtEmail">Email</label>
                @Html.TextBox("TxtEmail", Nothing, New With {.class = "form-control", .id = "TxtEmail"})
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
