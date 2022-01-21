<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerDetails.aspx.cs" Inherits="BankProject.CustomerDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

           <div>
           
               <asp:Button ID="Button1" runat="server" Text="CustomerDetails" OnClick="Button1_Click" />
               <hr/>
               <br/>
               <asp:GridView ID="gvCustomerDetails" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
