<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href='<%= ResolveUrl("~/App_Styles/Home.css") %>' rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <p>
        &nbsp;</p>
        <h1><b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Welcome to SportsPro Support Portal</b></h1>
        <p><b>&nbsp;&nbsp;</b></p>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2"><a href="Customers.aspx"><i class="home-icon large material-icons  z-depth-2">1</i></a>
                 <br /><br /><br /><br />   
                </td>
                <td><h2><b>&nbsp;Getting Started</b></h2>
                    &nbsp; Go to &nbsp;<asp:LinkButton ID="linkBtnCustomers" runat="server" PostBackUrl="~/Customers.aspx">customers</asp:LinkButton>
&nbsp;section to search for your customer information &nbsp;
                    <br />
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style2"><a href="Surveys.aspx"> <i class="home-icon large material-icons  z-depth-2">2</i>
                    <br /><br /><br /><br />
                    </td>
                <td><h2><b>What do you think of our service?</b></h2>&nbsp;<asp:LinkButton ID="linkBtnSubmitSurvey" runat="server" PostBackUrl="~/Surveys.aspx">Submit a survey</asp:LinkButton>
&nbsp;to provide your feedback for any support we have provided to you recently
                    <br />
                    <br />
                    <br />
                    <br />
                </td>
                
            </tr>
            <tr>
                <td class="auto-style2"><a href="CustomersAdmin.aspx"> <i class="home-icon large material-icons  z-depth-2">3</i>
                    <br /><br /><br /><br />
                    </td>
                <td><h2><b>Administration</b></h2>&nbsp;Modify
                    <asp:LinkButton ID="linkBtnCustomersAdmin" runat="server" PostBackUrl="~/CustomersAdmin.aspx">Customers</asp:LinkButton>
&nbsp;and
                    <asp:LinkButton ID="linkBtnProductsAdmin" runat="server" PostBackUrl="~/ProductsAdmin.aspx">Products</asp:LinkButton>
                    <br />
                    <br />
                    <br />
                </td>
               
            </tr>
            
        </table>
        <h2><b>&nbsp;&nbsp;&nbsp;&nbsp; Group Members </b></h2>
       
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 1.</td>
                    <td>Justin Frasca</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 2.</td>
                    <td>Neha Arora</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 3.</td>
                    <td>Flora Najafabadi</td>
                </tr>
                </table>
       
        </asp:Content>

