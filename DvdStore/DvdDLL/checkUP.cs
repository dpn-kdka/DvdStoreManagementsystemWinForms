using System;
using System.Collections.Generic;
using System.Text;

using DvdDLL.Common;
using System.Data;
using System.Data.SqlClient;
using DvdDLL;


namespace DvdDLL
{
    public class checkUP
    {
        public int checkUserPass(string UserName,string Password,int result)
        {
            SqlConnection con = new SqlConnection(dbConnection.dbCon);
            SqlCommand cmd = new SqlCommand("ulc_loginCheck", con);//check username and password in table
            cmd.CommandType = CommandType.StoredProcedure;//defining stored procedure
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@result", 0);

            con.Open();//opens connection 
             result = (Int32)cmd.ExecuteScalar();//this executes query(insert, update and delete) and return the number of rows effected
            con.Close();//closes connection 
            return result;
        }
    }
}
