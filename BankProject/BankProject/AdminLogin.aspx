<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="BankProject.AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <form id="form2" runat="server">
    <div align="center">
    <fieldset style ="width:500px;">
    <legend> Admin Login page </legend>
        <asp:Label ID="Label1" runat="server" Text="username              "></asp:Label> <asp:TextBox ID="txtusername" placeholder="username" runat="server"
            Width="280px"></asp:TextBox>
       
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="password               "></asp:Label> <asp:TextBox ID="txtpassword" placeholder="password" runat="server"
            Width="280px" TextMode="Password"></asp:TextBox>
       
        <br />
        <br />
        <asp:Button ID="btnLogin" runat="server" Text="Login"
           Width="81px" onclick="btnLogin_Click" />
            <br />
           
    </fieldset>
        
        <hr />
        <asp:Label Text="" ID="lblResult" runat="server" />
        <hr />
       
    </div>

    </form>
    
</body>
</html>
