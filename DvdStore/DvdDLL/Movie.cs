using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using DvdDLL.Common;//  namespace created by us

namespace DvdDLL
{
    public class Movie
    {
        public int iudMovies(string Name, string Actor, string Director, int languageID, string ReleaseYear, decimal Price, int Quantity, int MovieGenerID, int ItemTypeID, int ID, String Mode)
        {
            int result = 0;
            //1. establish connection 
            SqlConnection con = new SqlConnection(dbConnection.dbCon);//here dbConnection is user defined class and dbCon is its property

            //2. add commands 
            SqlCommand cmd = new SqlCommand("usp_Movie", con);//usp_InsertRoles is procedure's name
            cmd.CommandType = CommandType.StoredProcedure;//defining stored procedure

            //add parameters to the cmd 
            cmd.Parameters.AddWithValue("@Name",Name);
            cmd.Parameters.AddWithValue("@Actor", Actor);
            cmd.Parameters.AddWithValue("@Director", Director);
            cmd.Parameters.AddWithValue("@LanguageID",languageID);
            cmd.Parameters.AddWithValue("@ReleaseYear", ReleaseYear);
            cmd.Parameters.AddWithValue("@Price", Price);
            cmd.Parameters.AddWithValue("@Quantity", Quantity);
            cmd.Parameters.AddWithValue("@MovieGenerID", MovieGenerID);
            cmd.Parameters.AddWithValue("@ItemTypeID", ItemTypeID);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@Mode", Mode);

            con.Open();//opens connection 
            result = cmd.ExecuteNonQuery();//this executes query(insert, update and delete) and return the number of rows effected
            con.Close();//closes connection 
            return result;

        }

        public DataSet movieGenerList()//displaying items in movie gener combobox
        {
            DataSet lstMovie = new DataSet();
            SqlConnection con = new SqlConnection(dbConnection.dbCon);//here dbConnection is user defined class and dbCon is its property

            //2. add commands 
            SqlCommand cmd = new SqlCommand("usp_MovieGenerBinding", con);//usp_MusicGenerBinding is procedure's name
            cmd.CommandType = CommandType.StoredProcedure;//defining stored procedure

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(lstMovie);
            return lstMovie;
        }
        public DataSet languageList()//displaying items in language gener combobox
        {
            DataSet lstLanguage = new DataSet();
            SqlConnection con = new SqlConnection(dbConnection.dbCon);//here dbConnection is user defined class and dbCon is its property

            //2. add commands 
            SqlCommand cmd = new SqlCommand("usp_LanguageBinding", con);//usp_MusicGenerBinding is procedure's name
            cmd.CommandType = CommandType.StoredProcedure;//defining stored procedure

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(lstLanguage);
            return lstLanguage;
        }
        public DataSet displayMovie()
        {
            DataSet allMovie = new DataSet();
            SqlConnection con = new SqlConnection(dbConnection.dbCon);
            SqlCommand cmd = new SqlCommand("usp_getMovie", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(allMovie);
            return allMovie;
        }
    }
}
