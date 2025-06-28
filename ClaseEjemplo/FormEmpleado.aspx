<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FormEmpleado.aspx.vb" Inherits="ClaseEjemplo.FormEmpleado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:HiddenField ID="IDEmpreado" runat="server" />
    <div class="row mb-3">
        <div class="col-md-4">

            <div class="form-group mb-3">
                <label for="TxtNombre">Nombre</label>
                <asp:TextBox ID="TxtNombre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            
            <div class="form-group mb-3">
                <label for="TxtApellido">Apellido</label>
                <asp:TextBox ID="TxtApellidos" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="form-group mb-3">
                <label for="DdlPuestos">Puestos</label>
                <asp:DropDownList ID="DdlPuestos" CssClass="form-control" runat="server">
                    <asp:ListItem>Seleccionar un Puesto</asp:ListItem>
                    <asp:ListItem>Desarrollador .NET</asp:ListItem>
                    <asp:ListItem>Gerente de Proyectos</asp:ListItem>
                    <asp:ListItem>Diseñadora UX/UI</asp:ListItem>
                </asp:DropDownList>
            </div>

            <div class="form-group mb-3">
                <label for="TxtSueldo">Sueldo</label>
                <asp:TextBox TextMode="Number" ID="TxtSueldo" CssClass="form-control" runat="server"></asp:TextBox>
            </div>

            <div class="form-group">
                <asp:Button ID="btnGuardar" CssClass="btn btn-primary" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
            </div>
        </div>
        
        <asp:Label ID="LblMensaje" runat="server" Text=""></asp:Label>
    </div>

    <asp:GridView ID="GvEmpleados" runat="server" AllowPaging="True"
        OnSelectedIndexChanged="GvEmpleados_SelectedIndexChanged"
        OnRowDeleting="GvEmpleados_RowDeleting"
        AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="EmpleadoID" 
        DataSourceID="SqlDataSource" Width="794px">
        <Columns>
            <asp:CommandField ShowSelectButton="True"/>
            <asp:BoundField DataField="EmpleadoID" HeaderText="EmpleadoID" InsertVisible="False" ReadOnly="True" SortExpression="EmpleadoID" />
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
            <asp:BoundField DataField="Apellidos" HeaderText="Apellidos" SortExpression="Apellidos" />
            <asp:BoundField DataField="Cargo" HeaderText="Cargo" SortExpression="Cargo" />
            <asp:BoundField DataField="Salario" HeaderText="Salario" SortExpression="Salario" />            
            <asp:CommandField ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:conexionDB %>"
        SelectCommand="SELECT * FROM [Empleados]">
    </asp:SqlDataSource>
</asp:Content>
