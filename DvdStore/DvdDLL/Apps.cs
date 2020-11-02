using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using DvdDLL.Common;//  namespace created by us

namespace DvdDLL
{
    public class Apps
    {

        public int iudApps(string Name, string Version, string Requirement, int Quantity, decimal Price, int AppsTypeID, int ItemTypeID,int ID,String Mode)
        {
            int result = 0;

            //1. establish connection 
            SqlConnection con = new SqlConnection(dbConnection.dbCon);//here dbConnection is user defined class and dbCon is its property

            //2. add commands 
            SqlCommand cmd = new SqlCommand("usp_Apps", con);//usp_InsertRoles is procedure's name
            cmd.CommandType = CommandType.StoredProcedure;//defining stored procedure

            //add parameters to the cmd 
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Version", Version);
            cmd.Parameters.AddWithValue("@Requirement", Requirement);
            cmd.Parameters.AddWithValue("@Quantity", Quantity);
            cmd.Parameters.AddWithValue("@Price", Price);
            cmd.Parameters.AddWithValue("@AppsTypeID", AppsTypeID);
            cmd.Parameters.AddWithValue("@ItemTypeID", ItemTypeID);
            cmd.Parameters.AddWithValue("@ID",ID);
            cmd.Parameters.AddWithValue("@Mode", Mode);


            con.Open();//opens connection 
            result = cmd.ExecuteNonQuery();//this executes query(insert, update and delete) and return the number of rows effected
            con.Close();//closes connection 
            return result;

        }

        public DataSet AppsType()
        {
            DataSet lstApps = new DataSet();
            SqlConnection con = new SqlConnection(dbConnection.dbCon);

            //2. add commands 
            SqlCommand cmd = new SqlCommand("usp_AppsTypeBinding", con);
            cmd.CommandType = CommandType.StoredProcedure;
            
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(lstApps);
            con.Close();

            return lstApps;
        }


        public DataSet displayApps()
        {
            DataSet allApps = new DataSet();
            SqlConnection con = new SqlConnection(dbConnection.dbCon);
            SqlCommand cmd = new SqlCommand("usp_getApps", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(allApps);
            return allApps;
        }
    }
}

