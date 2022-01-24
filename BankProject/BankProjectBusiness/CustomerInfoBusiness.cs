using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankProjectData;
using BankProjectEntity;

namespace BankProjectBusiness
{
    class CustomerInfoBusiness
    {
        public string InsertCustomer(CustomerModel customermodelobj)
        {
            Customer customerobj = new Customer();
             string msg=customerobj.InsertCustomer(customermodelobj);
            return msg;

        }
            public DataTable ViewCustomer(CustomerModel customerModelObj, string username)
        {
            Customer customerobj = new Customer();
            DataTable dt = customerobj.ViewCustomer(customerModelObj , username);
            return dt;
        }
    }
}
