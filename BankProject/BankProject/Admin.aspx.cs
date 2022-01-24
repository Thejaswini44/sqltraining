using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BankProject
{
    public partial class Admin1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-NI2Q43U5;Initial Catalog=ATM;Persist Security Info=True;User ID=sa; password=12345678");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminLogin.aspx");
        }
    }
}