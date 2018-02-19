<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="SurveyComplete.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
            &nbsp;</p>
        <p>
            Survay Complete -
            <asp:Label ID="Feedback" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            Thank you for your time and feedback!</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnReturnSurvey" runat="server" OnClick="btnReturnSurvey_Click" Text="Return to Survey" Width="196px" />
        </p>
        <p>
            &nbsp;</p>
</asp:Content>

