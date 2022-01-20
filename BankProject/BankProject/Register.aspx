<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="BankProject.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title></title>


    
     
<style type="text/css">  
.auto-style1 {  
     width: 100%;  
      }  
.auto-style2 {  
     width: 278px;  
       }  
.auto-style3 {  
      width: 278px;  
      height: 23px;  
        }  
.auto-style4 {  
      height: 23px;  
        }  
</style>  
</head>
    <body>
        <form id="form1" runat="server">
    <h2>
        Register
    </h2>
<div>           
  <table class="auto-style1"> 
    <tr>  
    <td>  
    <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>  
    </td>  
    <td>  
    <asp:TextBox ID="txtname" runat="server" required="true"></asp:TextBox></td>  
    </tr>  

       <tr>  
    <td>  
    <asp:Label ID="Label7" runat="server" Text="Address"></asp:Label>  
    </td>  
    <td>  
    <asp:TextBox ID="txtaddress" runat="server" required="true"></asp:TextBox></td>  
    </tr>  

       <tr>  
    <td>  
    <asp:Label ID="Label8" runat="server" Text="City"></asp:Label>  
    </td>  
    <td>  
    <asp:TextBox ID="txtcity" runat="server" required="true"></asp:TextBox></td>  
    </tr>  

    <tr>  
    <td>  
    <asp:Label ID="Label6" runat="server" Text="Email ID"></asp:Label>  
    </td>  
    <td>  
    <asp:TextBox ID="txtemail" runat="server" TextMode="Email"></asp:TextBox></td>  
    </tr> 
      
       <tr>  
    <td>  
    <asp:Label ID="Label9" runat="server" Text="Contact no"></asp:Label>  
    </td>  
    <td>  
    <asp:TextBox ID="txtcont" runat="server" required="true"></asp:TextBox></td>  
    </tr>  



       <tr>  
    <td>  
    <asp:Label ID="Label10" runat="server" Text="Card no"></asp:Label>  
    </td>  
    <td>  
    <asp:TextBox ID="txtcard" runat="server" required="true"></asp:TextBox></td>  
    </tr>  

       <tr>  
    <td>  
    <asp:Label ID="Label11" runat="server" Text="Pin no"></asp:Label>  
    </td>  
    <td>  
    <asp:TextBox ID="txtpin" runat="server" required="true"></asp:TextBox></td>  
    </tr>  

      <tr>  
    <td>  
    <asp:Label ID="Label12" runat="server" Text="Account Type"></asp:Label>  
    </td>  
    <td>  
    <asp:TextBox ID="txtacc" runat="server" required="true"></asp:TextBox></td>  
    </tr>  

    <tr>  
    <td>  
    <asp:Label ID="Label13" runat="server" Text="Account No"></asp:Label>  
    </td>  
    <td>  
    <asp:TextBox ID="txtaccno" runat="server" required="true"></asp:TextBox></td>  
    </tr> 

<tr>  
    <td>  
    <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>  
    </td>  
    <td>  
    <asp:TextBox ID="txtpwd" runat="server" required="true" TextMode="Password"></asp:TextBox></td>  
    </tr> 

      
    <br />  
      <tr>
          <td>
   <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" />
    </td>  
    </tr>  
    </table> 
    
        <hr />
        <asp:Label Text="" ID="lblResult" runat="server" />
        <hr />
        <h2>Customer Details</h2>

        <asp:GridView ID="gvCustomerDetails" runat="server"></asp:GridView>
    </div>  

       
    </form>
</body>
</html>
