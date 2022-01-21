<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="BankProject.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title></title>


    
     
<style type="text/css">  
.auto-style1 {  
     width: 100%;  
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
    <asp:TextBox ID="txtname" runat="server" required="true"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtname" ErrorMessage="Name should not be empty"></asp:RequiredFieldValidator>
        </td>  
    </tr>  

       <tr>  
    <td>  
    <asp:Label ID="Label7" runat="server" Text="Address"></asp:Label>  
    </td>  
    <td>  
    <asp:TextBox ID="txtaddress" runat="server" required="true"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtaddress" ErrorMessage="address should not be empty"></asp:RequiredFieldValidator>
           </td>  
    </tr>  

       <tr>  
    <td>  
    <asp:Label ID="Label8" runat="server" Text="City"></asp:Label>  
    </td>  
    <td>  
    <asp:TextBox ID="txtcity" runat="server" required="true"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtcity" ErrorMessage="city should not be empty"></asp:RequiredFieldValidator>
           </td>  
    </tr>  

    <tr>  
    <td>  
    <asp:Label ID="Label6" runat="server" Text="Email ID"></asp:Label>  
    </td>  
    <td>  
    <asp:TextBox ID="txtemail" runat="server" TextMode="Email"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtemail" ErrorMessage="email cannot  be empty"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator runat="server" ControlToValidate="txtemail" ErrorMessage="email is incorrect" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </td>  
    </tr> 
      
       <tr>  
    <td>  
    <asp:Label ID="Label9" runat="server" Text="Contact no"></asp:Label>  
    </td>  
    <td>  
    <asp:TextBox ID="txtcont" runat="server" required="true"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtcont" ErrorMessage="contactnumber cannot be empty"></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtcont" ErrorMessage="Invalid contact number" MaximumValue="9999999999" MinimumValue="0000000000" Type="Double"></asp:RangeValidator>
           </td>  
    </tr>  



       <tr>  
    <td>  
    <asp:Label ID="Label10" runat="server" Text="Card no"></asp:Label>  
    </td>  
    <td>  
    <asp:TextBox ID="txtcard" runat="server" required="true"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtcard" ErrorMessage="cardnumber cannot be empty"></asp:RequiredFieldValidator>
           </td>  
    </tr>  

       <tr>  
    <td>  
    <asp:Label ID="Label11" runat="server" Text="Pin no"></asp:Label>  
    </td>  
    <td>  
    <asp:TextBox ID="txtpin" runat="server" required="true"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtpin" ErrorMessage="pin number cannot be empty"></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="txtpin" ErrorMessage="invalid pin" MaximumValue="999999" MinimumValue="000000"></asp:RangeValidator>
           </td>  
    </tr>  

      <tr>  
    <td>  
    <asp:Label ID="Label12" runat="server" Text="Account Type"></asp:Label>  
    </td>  
    <td>  
    <asp:TextBox ID="txtacc" runat="server" required="true"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtacc" ErrorMessage="account type cannot be empty"></asp:RequiredFieldValidator>
          </td>  
    </tr>  

    <tr>  
    <td>  
    <asp:Label ID="Label13" runat="server" Text="Account No"></asp:Label>  
    </td>  
    <td>  
    <asp:TextBox ID="txtaccno" runat="server" required="true"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtaccno" ErrorMessage="account number cannot be empty"></asp:RequiredFieldValidator>
        </td>  
    </tr> 

<tr>  
    <td>  
    <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>  
    </td>  
    <td>  
    <asp:TextBox ID="txtpwd" runat="server" required="true" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtpwd" ErrorMessage="Require password"></asp:RequiredFieldValidator>
    </td>  
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
       
    </div>  

       
    </form>
</body>
</html>
