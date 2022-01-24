<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="BankProject.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>ATM Banking</title>
<style>
 

body, html {
  height: 100%;
  margin: 0;
}

.bg {
    text-align=center;
  /* The image used */
  background-image: url('https://securecdn.pymnts.com/wp-content/uploads/2019/11/South-Korea-Open-Banking-1000x600.jpg');
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
        <div  class="bg" align="center">
          <form runat="server">
            
          <asp:Label ID="lblBank" runat="server" Font-Bold="True"  Font-Size="50px"  Text="ATM Banking"></asp:Label>
      <br />
              <br />
    <asp:Button ID="Admin" runat="server" Font-Size="30px"  Text="Admin" OnClick="Admin_Click" />
            <br />
              <br />
        
            <asp:Button ID="Customer" runat="server"  Font-Size="30px" Text="Customer"  OnClick="Customer_Click"  />
       
    </form>
         </div>
</body>
</html>
