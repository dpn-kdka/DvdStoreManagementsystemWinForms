using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using DvdDLL.Common;//  namespace created by us

namespace DvdDLL
{
    public class Music
    {
        public int iudMusic(string Artist, string Album,string Releaseyear, int Quantity, decimal Price, int MusicGenerID, int ItemTypeID,int ID,string Mode)
        {
            int result = 0;
            //1. establish connection 
            SqlConnection con = new SqlConnection(dbConnection.dbCon);//here dbConnection is user defined class and dbCon is its property

            //2. add commands 
            SqlCommand cmd = new SqlCommand("usp_Music", con);//usp_InsertRoles is procedure's name
            cmd.CommandType = CommandType.StoredProcedure;//defining stored procedure

            //add parameters to the cmd 
            cmd.Parameters.AddWithValue("@Artist", Artist);
            cmd.Parameters.AddWithValue("@Album", Album);
            cmd.Parameters.AddWithValue("@Releaseyear", Releaseyear);
            cmd.Parameters.AddWithValue("@Quantity",Quantity);
            cmd.Parameters.AddWithValue("@Price",Price);
            cmd.Parameters.AddWithValue("@MusicGenerID", MusicGenerID);
            cmd.Parameters.AddWithValue("@ItemTypeID", ItemTypeID);
            cmd.Parameters.AddWithValue("@ID",ID);
            cmd.Parameters.AddWithValue("@Mode",Mode);
            

            con.Open();//opens connection 
            result = cmd.ExecuteNonQuery();//this executes query(insert, update and delete) and return the number of rows effected
            con.Close();//closes connection 
            return result;
 
        }
        public DataSet musicGenerList()//displaying items in music gener combobox
        {
            DataSet lstMusic = new DataSet();
            SqlConnection con = new SqlConnection(dbConnection.dbCon);//here dbConnection is user defined class and dbCon is its property

            //2. add commands 
            SqlCommand cmd = new SqlCommand("usp_MusicGenerBinding", con);//usp_MusicGenerBinding is procedure's name
            cmd.CommandType = CommandType.StoredProcedure;//defining stored procedure

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(lstMusic);
            return lstMusic;
        }

        public DataSet displayMusic()
        {
            DataSet allMusic = new DataSet();
            SqlConnection con = new SqlConnection(dbConnection.dbCon);
            SqlCommand cmd = new SqlCommand("usp_getMusic", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(allMusic);
            return allMusic;
        }
    }
}
