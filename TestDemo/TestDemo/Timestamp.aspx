<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Timestamp.aspx.cs" Inherits="TestDemo.Timestamp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h2>Timestamp Page</h2>
        <div class="form-group">
            <asp:Button runat="server" ID="btnLogTime" CssClass="btn btn-primary btn-lg" ToolTip="Click to add timestamp to grid" Text="Log Timestamp" OnClientClick="return confirm('Do you want to log Timestamp?');" OnClick="btnLogTime_Click" />
            <asp:LinkButton runat="server" CssClass="btn btn-primary btn-sm" Text="Go To Home Page" ID="lnkHome" OnClick="lnkHome_Click"></asp:LinkButton>
        </div>
        <div ><p></p></div>
        <div class="table table-hover">
            <asp:DataGrid runat="server" ID="gvTimeStamp" AutoGenerateColumns="false" CssClass="table-bordered" HeaderStyle-BackColor="WindowFrame">
                <Columns> 
                    <asp:BoundColumn DataField="Row" HeaderText="#"></asp:BoundColumn>
                    <asp:BoundColumn DataField="TimeStamp" HeaderText="Time Stamp"></asp:BoundColumn>
                </Columns>
            </asp:DataGrid>
        </div>
    </div>
</asp:Content>
