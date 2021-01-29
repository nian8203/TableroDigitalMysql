<%@ Page Title="" Language="C#" MasterPageFile="~/resources/Main.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="TableroDigitalV001.pages.home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h2>Bienvenidos</h2>
    <asp:Button ID="BtnListar" runat="server" Text="Listar" OnClick="BtnListar_Click"/>
    <asp:Button ID="BtnListarP" runat="server" Text="ListarP" OnClick="BtnListarP_Click"/>
    <asp:GridView ID="gvListarAlumnos" runat="server"></asp:GridView>
    <asp:GridView ID="gvListarPersonas" runat="server"></asp:GridView>
</asp:Content>
