<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="BankProject.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title><h2>ATM Banking</h2></title>
</head>
<body>
          <form runat="server">
            <div>
          <asp:Label ID="lblBank" runat="server" Font-Bold="True"  Font-Size="50px" Text="ATM Banking"></asp:Label>
      <br />
    <asp:Button ID="Admin" runat="server" Text="Admin" OnClick="Admin_Click" />
            
        
            <asp:Button ID="Customer" runat="server" Text="Customer"  OnClick="Customer_Click"  />
        </div>
    </form>
</body>
</html>
