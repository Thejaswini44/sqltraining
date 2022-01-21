using BankProject.BankApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace BankProject
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Customer Customerobj = new Customer();
            DataTable dtLogin = Customerobj.LoginCheck(txtusername.Text, txtpassword.Text);
            if (dtLogin.Rows.Count > 0)
            {
                Session["email"] = txtusername.Text;
                Response.Redirect("CustomerDetails.aspx");
            }
            else
            {
                lblResult.Text = "Email id or password wrong!";
            }
           
        }
    }
}