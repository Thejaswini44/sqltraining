using BankProjectEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProjectData
{
    public class Customer

    {
        string sqlConnectionStr = "Data Source=LAPTOP-NI2Q43U5;Initial Catalog=ATM;Integrated Security=True";
        public string InsertCustomer(CustomerModel CustomerModelObj)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            #region connectecd approach
            //SqlCommand sqlCommandObj = new SqlCommand("insert into Tutorial values("+tutorialModelObj.TutorialId+",'"+tutorialModelObj.TutorialName+"','"+tutorialModelObj.TutorialDesc+"',"+tutorialModelObj.Published+")", sqlConnectionObj);
            //sqlConnectionObj.Open();
            //sqlCommandObj.ExecuteNonQuery();
            //sqlConnectionObj.Close();
            #endregion

            #region disconnected approach
            SqlDataAdapter adp = new SqlDataAdapter("insert into Customer values('" + CustomerModelObj.name + "','" + CustomerModelObj.address + "','" + CustomerModelObj.city + "','" + CustomerModelObj.email_address + "'," +
                CustomerModelObj.contact_info + "," + CustomerModelObj.card_no + "," + CustomerModelObj.pin_no + ",'" + CustomerModelObj.account_type +
                "'," + CustomerModelObj.account_number + ",'" + CustomerModelObj.Password + "')", sqlConnectionObj);
            adp.Fill(dt);
            #endregion
            return "Customer details saved successfully";
        }



        //public DataTable GetCustomer()
        //{
        //    Customer CustomerObj = new Customer();
        //    DataTable dt =CustomerObj.GetCustomer();
        //    return dt;
        //}
        //public DataTable GetCustomer()
        //{
        //    DataTable dt = new DataTable();
        //    SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
        //    SqlDataAdapter adp = new SqlDataAdapter("select * from Customer", sqlConnectionObj);
        //    adp.Fill(dt);
        //    return dt;
        //}

        public DataTable ViewCustomer(CustomerModel CustomerModelObj, string username)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            #region connected approach
            //    //SqlCommand sqlCommandObj = new SqlCommand("insert into Tutorial values("+tutorialModelObj.TutorialId+",'"+tutorialModelObj.TutorialName+"','"+tutorialModelObj.TutorialDesc+"',"+tutorialModelObj.Published+")", sqlConnectionObj);
            //    //sqlConnectionObj.Open();
            //    //sqlCommandObj.ExecuteNonQuery();
            //    //sqlConnectionObj.Close();
            #endregion

            #region disconnected approach
            //SqlDataAdapter adp = new SqlDataAdapter("select * from Customer where emailaddress='"+username+"'", sqlConnectionObj);

            SqlDataAdapter adp = new SqlDataAdapter("select  name,address,city,emailaddress,contact_info,card_no,pin_no,account_type,account_number from Customer where emailaddress='" + username + "'", sqlConnectionObj);
            adp.Fill(dt);
            #endregion
            return dt;

        }
        public DataTable LoginCheck(string email, string password)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("select emailaddress,Password from Customer where emailaddress='" + email + "' and Password='" + password + "'", sqlConnectionObj);
            adp.Fill(dt);
            return dt;
        }

    }
}
