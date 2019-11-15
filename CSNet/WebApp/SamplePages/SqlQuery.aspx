<%@ Page Title="SqlQuery" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SqlQuery.aspx.cs" Inherits="WebApp.SamplePages.SqlQuery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1> Using SqlQuery: non pkey queries</h1>
    <div class="offset-2">
        <asp:Label ID="Label1" runat="server" Text="Select a Category: "></asp:Label>&nbsp;&nbsp;   
        <asp:DropDownList ID="CategoryList" runat="server"></asp:DropDownList>&nbsp;&nbsp;
        <asp:Button ID="Fetch" runat="server" Text="Fetch" 
             CausesValidation="false" OnClick="Fetch_Click"/>
        <br /><br />
        <asp:Label ID="MessageLabel" runat="server" ></asp:Label>
        <br />
        <asp:GridView ID="ProductList" runat="server"></asp:GridView>
    </div>
</asp:Content>
