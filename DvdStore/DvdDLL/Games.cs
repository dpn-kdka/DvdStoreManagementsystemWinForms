using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using DvdDLL.Common;//  namespace created by us

namespace DvdDLL
{
    public class Games
    {
       public int iudGames(string Name,string Requirement,int Quantity, decimal Price,int GameTypeID, int ItemTypeID,int ID,string Mode) 
       {
           int result = 0;

           //1. establish connection
           SqlConnection con = new SqlConnection(dbConnection.dbCon);

           //2. add commands
           SqlCommand cmd = new SqlCommand("usp_Game",con);
           cmd.CommandType = CommandType.StoredProcedure;

           //add parameters to cmd

           cmd.Parameters.AddWithValue("@Name",Name);
           cmd.Parameters.AddWithValue("@Requirement",Requirement);
           cmd.Parameters.AddWithValue("@Quantity",Quantity);
           cmd.Parameters.AddWithValue("@Price",Price);
           cmd.Parameters.AddWithValue("@GameTypeID",GameTypeID);
           cmd.Parameters.AddWithValue("@ItemTypeID", ItemTypeID);
           cmd.Parameters.AddWithValue("@ID",ID);
           cmd.Parameters.AddWithValue("@Mode",Mode);

           con.Open();//opens connection
           result = cmd.ExecuteNonQuery();//this executes query(insert, update and delete) and return the number of rows effected
           con.Close();//close connection

           return result;
       }
       public DataSet gameTypeList()
       {
           DataSet lstGame = new DataSet();

           SqlConnection con = new SqlConnection(dbConnection.dbCon);

           SqlCommand cmd = new SqlCommand("usp_GameTypeBinding", con);
           cmd.CommandType = CommandType.StoredProcedure;

           SqlDataAdapter adapter = new SqlDataAdapter();
           adapter.SelectCommand = cmd;
           adapter.Fill(lstGame);
           return lstGame;
          
       }

       public DataSet displayGame()
       {
           DataSet allGame = new DataSet();
           SqlConnection con = new SqlConnection(dbConnection.dbCon);
           SqlCommand cmd = new SqlCommand("usp_getGame", con);
           cmd.CommandType = CommandType.StoredProcedure;

           SqlDataAdapter adapter = new SqlDataAdapter();
           adapter.SelectCommand = cmd;
           adapter.Fill(allGame);
           return allGame;
       }
    }
}
