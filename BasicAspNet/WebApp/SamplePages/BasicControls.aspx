<%@ Page Title="Common Web Controls" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BasicControls.aspx.cs" Inherits="WebApp.SamplePages.BasicControls" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1> Basic Common Web Controls</h1>
    <table align="center" style="width: 80%">
        <tr>
            <td align="right">Enter a value from 1 - 4</td>
            <td>
                <asp:TextBox ID="NumberChoice" runat="server" ToolTip="enter 1-4" ></asp:TextBox>
                    &nbsp;
                <asp:Button ID="SubmitNumberChoice" runat="server" Text="Submit" OnClick="SubmitNumberChoice_Click" />
            </td>
        </tr>
        <tr>
            <td align="right">
                <asp:Label ID="AlterLabel" runat="server" Text="Course Choices"></asp:Label></td>
            <td>
                <asp:RadioButtonList ID="ChoiceList" runat="server"
                     RepeatDirection="Horizontal" RepeatLayout="Flow">

                    <asp:ListItem Value="1">COMP1008</asp:ListItem>
                    <asp:ListItem Value="2">CPSC1517</asp:ListItem>
                    <asp:ListItem Value="3">DMIT1508</asp:ListItem>
                    <asp:ListItem Value="4">DMIT2018</asp:ListItem>
                </asp:RadioButtonList></td>
        </tr>
        <tr>
            <td align="right">
                <asp:Literal ID="Literal1" runat="server"
                     Text="Programing Course"></asp:Literal></td>
            <td>
                <asp:CheckBox ID="ProgrammingCourseActive" runat="server" 
                    Text="(programming course if checked)"/></td>
        </tr>
        <tr>
            <td align="right">
                <asp:Label ID="Label2" runat="server" 
                    Text="Using Label as Read Only Output"></asp:Label></td>
            <td>
                <asp:Label ID="DisplayDataRO" runat="server" ></asp:Label></td>
        </tr>
        <tr>
            <td align="right">
                <asp:Label ID="Label4" runat="server" Text="Selection of Course"></asp:Label></td>
            <td>
                <asp:DropDownList ID="CollectionChoiceList" runat="server"></asp:DropDownList>
                &nbsp;&nbsp;
                <asp:LinkButton ID="CollectionSubmit" runat="server" OnClick="CollectionSubmit_Click">Selection Submit</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;</td>
            
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Label ID="MessageLabel" runat="server"></asp:Label>
            </td>
            
        </tr>
    </table>

</asp:Content>
