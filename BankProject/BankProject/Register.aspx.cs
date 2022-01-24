using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BankProjectEntity;
using BankProjectBusiness;
using BankProject.BankApplication;

namespace BankProject
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            Customer customerObj = new Customer();
            BankApplication.CustomerModel CustomerModelObj = new BankApplication.CustomerModel();

            CustomerModelObj.name = txtname.Text;
            CustomerModelObj.address = txtaddress.Text;
            CustomerModelObj.city = txtcity.Text;
            CustomerModelObj.email_address = txtemail.Text;
            CustomerModelObj.contact_info = Convert.ToInt32(txtcont.Text);
            CustomerModelObj.card_no  = Convert.ToInt32(txtcard.Text);
            CustomerModelObj.pin_no = Convert.ToInt32(txtpin.Text);
            CustomerModelObj.account_type =txtacc.Text;
            CustomerModelObj.account_number = Convert.ToInt32(txtaccno.Text);
            CustomerModelObj.Password = txtpwd.Text;

            string msg = customerObj.InsertCustomer(CustomerModelObj);
            lblResult.Text = msg;

            LoadCustomerData();
        }
        public void LoadCustomerData()
        {
           Customer  customerObj = new Customer();
           // DataTable dtResult = customerObj.InsertCustomer();
           // gvCustomerDetails.DataSource = dtResult;
           // gvCustomerDetails.DataBind();
        }
    }
}