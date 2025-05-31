<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="ClaseEjemplo._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">
                <asp:Label ID="Titulo" runat="server" Text="Label"></asp:Label>
            </h1>
            <p class="lead">
                <asp:Label ID="LbPersona" runat="server" Text="Label"></asp:Label>
            </p>
            <p><a href="https://github.com/arg3ni5" class="btn btn-primary btn-md">Github</a></p>
        </section>

        <div class="row">
            <section class="col-md-4" aria-labelledby="gettingStartedTitle">
                <h2 id="gettingStartedTitle">Programación Orientada a Objetos (POO)</h2>
                <p>
                    La Programación Orientada a Objetos (POO) es un paradigma de programación que utiliza "objetos" para diseñar aplicaciones y sistemas informáticos.
                </p>
                <p>
                    <a class="btn btn-default" href="https://arg3ni5.github.io/poo-interactivo/">Ir a enlace &raquo;</a>
                </p>
            </section>
            <section class="col-md-4" aria-labelledby="librariesTitle">
                <h2 id="librariesTitle">Git: Una Explicación Visual e Interactiva</h2>
                <p>
                    Imagina que tienes un proyecto personal. Git te permite llevar un registro de cada cambio que haces, como si tomaras una 'instantánea' en el tiempo.
                </p>
                <p>
                    <a class="btn btn-default" href="https://arg3ni5.github.io/git-interactivo/">Ir a enlace &raquo;</a>
                </p>
            </section>
            <section class="col-md-4" aria-labelledby="hostingTitle">
                <h2 id="hostingTitle">Primer Clase con ASP.NET</h2>
                <p>
                    Este es el repositio del proyecto de ASP.NET, trabajado en clase.
                </p>
                <p>
                    <a class="btn btn-default" href="https://github.com/arg3ni5/II-46-Clase2">Ver repositorio &raquo;</a>
                </p>
            </section>
        </div>
    </main>

</asp:Content>
