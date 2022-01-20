using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace BankProject.BankApplication
{
    public class Admin
    {
       // string sqlConnectionStr = "Data Source=LAPTOP-NI2Q43U5;Initial Catalog=ATM;Integrated Security=True";
        //public string selectAdmin(AdminModel AdminModelObj)
        //{
        //    //DataTable dt = new DataTable();
        //    SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
        //    #region connectecd approach
        //    //SqlCommand sqlCommandObj = ("select * from admin ", sqlConnectionObj);
        //    sqlConnectionObj.Open();
        //    //  sqlCommandObj.ExecuteNonQuery();
        //    sqlConnectionObj.Close();
        //    #endregion

        //    #region disconnected approach
        //    // SqlDataAdapter adp = new SqlDataAdapter("select* from admin where username ="+ username + ""and password ="+ password + "", sqlConnectionObj);
        //    // adp.Fill(dt);
        //    //#endregion 
        //    return "Login successfully";
        //}
    }
}