<%@ Page Title="Rounding" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Rounding.aspx.cs" Inherits="TestDemo.Rounding" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="Scripts/jquery-1.10.2.js"></script>
    
    <script type="text/javascript" >

        function ValidateDateTime()
        {           
            var dateTxt = document.getElementById("<%=txtDateTime.ClientID%>").value;
            var date = new Date(dateTxt);
            if (isNaN(date))
            { 
                alert('Not a valid date; Date format must be yyyy-MM-dd hh:mm');
                document.getElementById("<%=txtDateTime.ClientID%>").value = '';
                document.getElementById("<%=lblroundedTime.ClientID%>").innerText = "Rounded Time:";
                return false;
            }                
            else
                return true;
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

 <div class="jumbotron">
     <h2>ROUNDING</h2>
     <div class="form-group" >
        <asp:Label runat="server" ID="lblDateTime" Text="Enter Date & Time" ></asp:Label>
        <asp:TextBox runat="server" ID="txtDateTime"  ToolTip="Date Format yyyy-MM-dd hh:mm" MaxLength="16" ></asp:TextBox>
     </div>  
     <div class="form-group">
      <asp:Label runat="server" ID="lblroundedTime" Text="Rounded Time:"></asp:Label>  
    </div>  
         <div class="form-group">
        <asp:Button runat="server" ID="btnSave" Text="Save Time" CssClass="btn btn-primary btn-lg" OnClientClick="return ValidateDateTime();" OnClick="btnSave_Click" />
        <asp:LinkButton runat="server" Text="Go To Home Page" CssClass="btn btn-primary btn-sm" ID="lnkHome" OnClick="lnkHome_Click"   ></asp:LinkButton>
    </div> 
</div>
</asp:Content>
