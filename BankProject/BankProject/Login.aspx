﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BankProject.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
 

body, html {
  height: 100%;
  margin: 0;
}

.bg {
    text-align=center;
  /* The image used */
  background-image: url('https://www.google.com/url?sa=i&url=https%3A%2F%2Fwallpaperbat.com%2Fbanking-wallpapers&psig=AOvVaw3_tUkpkDz0k-qg7FUYH6en&ust=1643111309871000&source=images&cd=vfe&ved=0CAsQjRxqFwoTCKiHk-aoyvUCFQAAAAAdAAAAABAD');
  /* Full height */
  height: 620px; 

  /* Center and scale the image nicely */
  background-position: center;
  background-repeat: no-repeat;
  background-size: cover;
      padding-top:100px;
}
</style>
</head>
<body>
    
    <div class="bg"  align="center">
        <form id="form1" runat="server">
    <fieldset style ="width:700px;">
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
        </form>
    </div>

   
</body>
</html>
