using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace BankProject.BankApplication
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
            SqlDataAdapter adp = new SqlDataAdapter("insert into Customer values('" + CustomerModelObj.name + "','" + CustomerModelObj.address + "','" + CustomerModelObj.city + "','" + CustomerModelObj.email_address + "',"+
                CustomerModelObj.contact_info + ","+ CustomerModelObj.card_no + "," + CustomerModelObj.pin_no + ",'" + CustomerModelObj.account_type + 
                "',"+ CustomerModelObj.account_num + ",'" + CustomerModelObj. Password + "')",sqlConnectionObj);
            adp.Fill(dt);
            #endregion
            return "Customer details saved successfully";
        }

        //public DataTable ViewCustomer(CustomerModel CustomerModelObj)
        //{
        //    DataTable dt = new DataTable();
        //    SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
        //    #region connectecd approach
        //    //SqlCommand sqlCommandObj = new SqlCommand("insert into Tutorial values("+tutorialModelObj.TutorialId+",'"+tutorialModelObj.TutorialName+"','"+tutorialModelObj.TutorialDesc+"',"+tutorialModelObj.Published+")", sqlConnectionObj);
        //    //sqlConnectionObj.Open();
        //    //sqlCommandObj.ExecuteNonQuery();
        //    //sqlConnectionObj.Close();
        //    #endregion

        //    #region disconnected approach
        //    SqlDataAdapter adp = new SqlDataAdapter("select * from Customer", sqlConnectionObj);
        //    adp.Fill(dt);
        //    #endregion
        //    return dt;


           
        //}

    }
    
}


