<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>LOGIN</h1>
        <p class="lead">Usuário <asp:TextBox ID="txtusuario" runat="server"> </asp:TextBox> <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="* Campo usuário é obrigatório" ControlToValidate="txtusuario" ForeColor="#CC0000"></asp:RequiredFieldValidator></p>
        <p class="lead">Senha&nbsp;&nbsp; <asp:TextBox ID="txtsenha" runat = "server" TextMode="Password"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="* Campo Senha é obrigatório" ControlToValidate="txtsenha" ForeColor="#CC0000"></asp:RequiredFieldValidator></p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnlogin" runat="server" Text="Entrar" OnClick="btnlogin_Click" />
        </p>
    </div>

 
</asp:Content>
