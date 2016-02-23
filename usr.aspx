<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="usr.aspx.cs" Inherits="usr" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td style="width: 104px">
                <asp:Label ID="Label1" runat="server" Text="Bem Vindo (a) :"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblusuario" runat="server" Font-Bold="True" ForeColor="#3333CC"></asp:Label>
            </td>
            <td>
                <asp:Button ID="btnoff" runat="server" OnClick="btnoff_Click" Text="LogOff" />
            </td>
        </tr>
        <tr>
            <td colspan="3">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

