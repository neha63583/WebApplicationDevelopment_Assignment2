<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Customers.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href='<%= ResolveUrl("~/App_Styles/Customers.css") %>' rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <br />
&nbsp;&nbsp;&nbsp;&nbsp;<h1><b>&nbsp;&nbsp;&nbsp;&nbsp; Customers - </b>Search and view your customer contact information</h1>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Select a customer&nbsp;&nbsp;
        <asp:DropDownList ID="DDLCustomers" runat="server" Height="16px" Width="273px" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="CustomerID" AutoPostBack="True">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Customers]"></asp:SqlDataSource>
        <div class="row">
            <div class="container">
                <br />
                <label>
                <br />
                <asp:Label ID="lblCAdress0" runat="server" Text="Address: " Width="165px"></asp:Label>
                </label>
                <strong>
                <asp:Label ID="lblCustomerAddress" runat="server"></asp:Label>
                ,&nbsp;
                <asp:Label ID="lblCustomerCity" runat="server"></asp:Label>
                ,
                </strong>&nbsp;<asp:Label ID="lblCustomerState" runat="server"></asp:Label>
                <br />
                <br />
                <label>
                <asp:Label ID="lblCPhone" runat="server" Text="Phone: " Width="165px"></asp:Label>
                </label>
                <strong>
                <asp:Label ID="lblCustomerPhone" runat="server"></asp:Label>
                </strong>
                <br />
                <br />
                <label>
                <asp:Label ID="lblCEmail" runat="server" Text="Email: " Width="165px"></asp:Label>
                </label>
                <strong>
                <asp:Label ID="lblCustomerEmail" runat="server"></asp:Label>
                </strong>
            </div>
        </div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:Button  ID="btnAddToContact" runat="server" style="margin-right: 86px" Text="Add to Contact List" Width="209px" Height="33px" OnClick="btnAddToContact_Click"/>
        <asp:Button ID="btnDisplayContact" runat="server" OnClick="btnDisplayContact_Click" Text="Display Contact List" Height="33px" Width="209px" />
        <br />
</asp:Content>

