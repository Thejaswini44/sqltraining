<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BankProject.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    <fieldset style ="width:200px;">
    <legend>Login page </legend>
        <asp:TextBox ID="txtusername" placeholder="username" runat="server"
            Width="180px"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="txtpassword" placeholder="password" runat="server"
            Width="180px" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnsubmit" runat="server" Text="Submit"
           Width="81px" onclick="btnsubmit_Click" />
            <br />
           
    </fieldset>
    </div>

    </form>
</body>
</body>
</html>
