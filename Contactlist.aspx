<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Contactlist.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href='<%= ResolveUrl("~/App_Styles/Contactlist.css") %>' rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp;&nbsp; <h1>Contact List- Manage your contact list</h1><br />
        <h3>Contact List:</h3>&nbsp;<table>
            <tr>
                <td class=" customerList" rowspan="3">
                    <asp:ListBox ID="lbContactList" runat="server" Height="250px" Width="782px" style="margin-right: 0px" AutoPostBack="True"></asp:ListBox>
                </td>
                <td>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnRemove" runat="server" Text="Remove Contact" style="margin-left: 0px" OnClick="btnRemove_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnEmpty" runat="server" Text="Empty List" OnClick="btnEmpty_Click" />
                </td>
            </tr>
            <tr>
                <td>
                &nbsp;
                </td>
            </tr>
        </table>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:Button ID="btnSelect" runat="server"  OnClick="btnSelect_Click" Text="Select Additional Customers" Width="345px" />
        <br />
</asp:Content>

