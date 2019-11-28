<%@ Page Title="CRUD" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductCRUD.aspx.cs" 
    Inherits="WebApp.NorthwindPages.ProductCRUD" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <div class="page-header">
        <h1>Product CRUD Maintenance</h1>
    </div>

    <div class="col-md-12">
        <div class="alert alert-warning">
            <blockquote style="font-style: italic">
                This illustrates a single web form page CRUD maintenance. 
                This form will use basic bootstrap formatting
            </blockquote>
        </div>
    </div>
    
    <asp:RequiredFieldValidator ID="RequiredProductName" runat="server"
        ErrorMessage="Product name is required" Display="None" SetFocusOnError="true" ForeColor="Firebrick"
         ControlToValidate="ProductName"> </asp:RequiredFieldValidator>
    <asp:CompareValidator ID="CompareUnitPrice" runat="server" 
        ErrorMessage="Unit Price must be 0.00 or greater" Display="None" SetFocusOnError="true" ForeColor="Firebrick"
         ControlToValidate="UnitPrice" Operator="GreaterThanEqual" ValueToCompare="0.00" Type="Double"> </asp:CompareValidator>
    <asp:RangeValidator ID="RangeUnitsInStock" runat="server" 
        ErrorMessage="Units in stock must be between 0 and 32767" Display="None" SetFocusOnError="true" ForeColor="Firebrick"
         ControlToValidate="UnitsInStock"  MaximumValue="32767" MinimumValue="0" Type="Integer"> </asp:RangeValidator>
    <asp:RangeValidator ID="RangeUnitsOnOrder" runat="server" 
        ErrorMessage="Units on order must be between 0 and 32767" Display="None" SetFocusOnError="true" ForeColor="Firebrick"
         ControlToValidate="UnitsOnOrder"  MaximumValue="32767" MinimumValue="0" Type="Integer"> </asp:RangeValidator>
    <asp:RangeValidator ID="RangeReorderLevel" runat="server" 
        ErrorMessage="Reorder levlel must be between 0 and 32767" Display="None" SetFocusOnError="true" ForeColor="Firebrick"
         ControlToValidate="ReorderLevel"  MaximumValue="32767" MinimumValue="0" Type="Integer"> </asp:RangeValidator>
   
    <%-- Validation Summary control --%>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
         HeaderText="Address the following concerns about your entered data."/>

      <%--  this will be the lookup control area--%>
         <div class="col-md-12"> 
             <asp:Label ID="Label5" runat="server" Text="Select a Product"></asp:Label>&nbsp;&nbsp;
             <asp:DropDownList ID="ProductList" runat="server"></asp:DropDownList>&nbsp;&nbsp;
             <asp:LinkButton ID="Search" runat="server" Font-Size="X-Large" 
                 OnClick="Search_Click" CausesValidation="false" >Search</asp:LinkButton>&nbsp;&nbsp;
             <asp:LinkButton ID="Clear" runat="server" Font-Size="X-Large" 
                 OnClick="Clear_Click" CausesValidation="false" >Clear</asp:LinkButton>&nbsp;&nbsp;
             <asp:LinkButton ID="AddProduct" runat="server" Font-Size="X-Large" 
                 OnClick="AddProduct_Click" >Add</asp:LinkButton>&nbsp;&nbsp;
             <asp:LinkButton ID="UpdateProduct" runat="server" Font-Size="X-Large" 
                 OnClick="UpdateProduct_Click" >Update</asp:LinkButton>&nbsp;&nbsp;
             <asp:LinkButton ID="RemoveProduct" runat="server" Font-Size="X-Large" 
                 OnClick="RemoveProduct_Click"  CausesValidation="false"
                 OnClientClick="return confirm('Are you sure you wish to discontinue this product')" >Remove</asp:LinkButton>&nbsp;&nbsp;
         
             <br /><br />
             <asp:DataList ID="Message" runat="server">
                <ItemTemplate>
                    <%# Container.DataItem %>
                </ItemTemplate>
             </asp:DataList>

        
        </div>
      <%--  this will be the entity CRUD area--%>
        <div class ="col-md-12">
            <fieldset class="form-horizontal">
                <legend>Product Information</legend>
<%--                each control group will consist of a label and the associated control--%>
                <asp:Label ID="Label1" runat="server" Text="Product ID"
                     AssociatedControlID="ProductID"></asp:Label>
                <asp:Label ID="ProductID" runat="server" ></asp:Label> 
                  
                  <asp:Label ID="Label2" runat="server" Text="Name"
                     AssociatedControlID="ProductName"></asp:Label>
                <asp:TextBox ID="ProductName" runat="server" ></asp:TextBox> 
                  
                  <asp:Label ID="Label3" runat="server" Text="Supplier"
                     AssociatedControlID="SupplierList"></asp:Label>
                <asp:DropDownList ID="SupplierList" runat="server" Width="350px" DataSourceID="SupplierListODS" DataTextField="CompanyName" DataValueField="SupplierID"></asp:DropDownList> 

                    <asp:Label ID="Label6" runat="server" Text="Category"
                     AssociatedControlID="CategoryList"></asp:Label>
                <asp:DropDownList ID="CategoryList" runat="server" Width="350px" DataSourceID="CategoryListODS" DataTextField="CategoryName" DataValueField="CategoryID"></asp:DropDownList> 
               
                    <asp:Label ID="Label7" runat="server" Text="Quantity/Unit"
                     AssociatedControlID="QuantityPerUnit"></asp:Label>
                <asp:TextBox ID="QuantityPerUnit" runat="server" ></asp:TextBox>

             
                <asp:Label ID="Label8" runat="server" Text="Unit Price"
                     AssociatedControlID="UnitPrice"></asp:Label>
                <asp:TextBox ID="UnitPrice" runat="server" ></asp:TextBox> 

                    <asp:Label ID="Label9" runat="server" Text="In Stock"
                     AssociatedControlID="UnitsInStock"></asp:Label>
                <asp:TextBox ID="UnitsInStock" runat="server" ></asp:TextBox> 

                    <asp:Label ID="Label10" runat="server" Text="On Order"
                     AssociatedControlID="UnitsOnOrder"></asp:Label>
                <asp:TextBox ID="UnitsOnOrder" runat="server" ></asp:TextBox> 

                    <asp:Label ID="Label11" runat="server" Text="ROL"
                     AssociatedControlID="ReorderLevel"></asp:Label>
                <asp:TextBox ID="ReorderLevel" runat="server" ></asp:TextBox> 

                      <asp:Label ID="Label4" runat="server" Text="Status"
                     AssociatedControlID="Discontinued"></asp:Label>
                <asp:CheckBox ID="Discontinued" runat="server" Text="Discontinued" ></asp:CheckBox> 
            
            </fieldset>
        </div>
    <asp:ObjectDataSource ID="SupplierListODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="Supplier_List" TypeName="NorthwindSystem.BLL.SupplierController">

    </asp:ObjectDataSource>
    <asp:ObjectDataSource ID="CategoryListODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="Categories_List" TypeName="NorthwindSystem.BLL.CategoryController">

    </asp:ObjectDataSource>
    <script src="../Scripts/bootwrap-freecode.js"></script>
</asp:Content>
