<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BankProject.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    <fieldset style ="width:500px;">
    <legend> Customer Login page </legend>
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
</body>
</html>
