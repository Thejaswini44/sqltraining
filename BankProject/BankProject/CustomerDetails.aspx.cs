using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BankProject.BankApplication;
using System.Data;



namespace BankProject
{
    public partial class CustomerDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        
            {
                Customer CustomerObj = new Customer();
            //DataTable dt = CustomerObj.GetCustomer();
            string username = Session["email"].ToString();
            CustomerModel CustomerModelObj = new CustomerModel();
            DataTable dtResult = CustomerObj.ViewCustomer(CustomerModelObj,username);
            gvCustomerDetails.DataSource = dtResult;
            gvCustomerDetails.DataBind();
            //string msg = CustomerObj.ViewCustomer(CustomerModelObj);
            //lblResult.Text = msg;
           
        }
       
    }
}
       
