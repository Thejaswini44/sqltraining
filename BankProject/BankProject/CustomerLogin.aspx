<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerLogin.aspx.cs" Inherits="BankProject.CustomerLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
              <div align="center">
    <fieldset style ="width:200px;">
    <legend>Customer Login page </legend>
            <asp:Button ID="Login" runat="server" Text="Login" OnClick="Login_Click" />
            <asp:Button ID="Register" runat="server" Text="Register" OnClick="Register_Click" />
         </fieldset>
        </div>
    </form>
</body>
</html>
