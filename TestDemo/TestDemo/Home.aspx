<%@ Page Title="Home" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="TestDemo.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
        <div class="jumbotron">
        <h2>Welcome to Home Page</h2>
        <p></p><p></p> 
        <p> <asp:LinkButton runat="server" CssClass="btn btn-primary btn-lg" Text="Go To Rounding Page" ID="lnkRounding"  OnClick="lnkRounding_Click" ></asp:LinkButton>
         <asp:LinkButton runat="server" CssClass="btn btn-primary btn-lg" Text="Go To Timestamp Page" ID="lnkTimeStamp" OnClick="lnkTimeStamp_Click" ></asp:LinkButton></p>
    </div>   
</asp:Content>
