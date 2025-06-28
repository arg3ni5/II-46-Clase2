<%@ Page Title="Contact" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.vb" Inherits="ClaseEjemplo.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %></h2>
        <p>Contactenos</p>

        <p>
            Si tiene alguna pregunta, comentario o sugerencia, no dude en ponerse en contacto con nosotros. Estamos aquí para ayudarle. 
        </p>

        <div class="row">
            <div class="col-md-4">

                <div class="form-group mb-3">
                    <label for="TxtNombre">Nombre</label>
                    <asp:TextBox ID="TxtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="form-group mb-3">
                    <label for="TxtApellido">Apellido</label>
                    <asp:TextBox ID="TxtApellido" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="form-group mb-3">
                    <label for="Email">Email</label>
                    <asp:TextBox TextMode="Email" ID="TxtEmail" CssClass="form-control" runat="server" aria-describedby="emailHelp"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Button ID="btnContactar" CssClass="btn btn-primary" runat="server" Text="Contactar" OnClick="btnContactar_Click"/>
                </div>
            </div>
            <asp:Label ID="LblMensaje" runat="server" Text=""></asp:Label>

        </div>
    </main>
</asp:Content>
