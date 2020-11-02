using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using DvdDLL.Common;
using DvdDLL;

namespace DvdDLL
{
    
    public class UserRegistrationClass
    {
        public int iudRoles(string roleName, string isActive, string desc, int Id, string mode)
        {
            int result = 0;
            //1. establish connection
            SqlConnection con = new SqlConnection(dbConnection.dbCon);
            //2. add commands
            SqlCommand cmd = new SqlCommand("usp_iudRoles", con);
            cmd.CommandType = CommandType.StoredProcedure;
            //Add Parameters to the cmd
            cmd.Parameters.AddWithValue("@RoleName", roleName);
            cmd.Parameters.AddWithValue("@IsActive", isActive);
            cmd.Parameters.AddWithValue("@Description", desc);
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@Mode", mode);
            con.Open();
            result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }

        public int userRegistration(string First_Name, string Last_Name, string Address, int Gender, string Email, string UserName, string Password, int RoleID, string IsActive, int Id, string mode)
        {
            int result = 0;
            //1. establish connection 
            SqlConnection con = new SqlConnection(dbConnection.dbCon);//here dbConnection is user defined class and dbCon is its property

            //2. add commands 
            SqlCommand cmd = new SqlCommand("usp_userManagement", con);//usp_InsertRoles is procedure's name
            cmd.CommandType = CommandType.StoredProcedure;//defining stored procedure

            //add parameters to the cmd 
            cmd.Parameters.AddWithValue("@First_Name",First_Name);
            cmd.Parameters.AddWithValue("@Last_Name",Last_Name);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Gender",Gender);
            cmd.Parameters.AddWithValue("@Email",Email);
            cmd.Parameters.AddWithValue("@UserName",UserName);
            cmd.Parameters.AddWithValue("@Password",Password);
            cmd.Parameters.AddWithValue("@RoleID",RoleID);
            cmd.Parameters.AddWithValue("@IsActive",IsActive);
            cmd.Parameters.AddWithValue("@ID", Id);
            cmd.Parameters.AddWithValue("@Mode", mode);


            con.Open();//opens connection 
            result = cmd.ExecuteNonQuery();//this executes query(insert, update and delete) and return the number of rows effected
            con.Close();//closes connection 
            return result;

        }

        public DataTable GetRoles()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(dbConnection.dbCon);
            SqlCommand cmd = new SqlCommand("usp_getRole", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable GetGender()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(dbConnection.dbCon);
            SqlCommand cmd = new SqlCommand("usp_getGender", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable getRegisteredUser()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(dbConnection.dbCon);
            SqlCommand cmd = new SqlCommand("usp_getRegisteredUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            con.Close();
            return dt;
        }
     }
}

