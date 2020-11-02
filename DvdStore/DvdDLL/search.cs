using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using DvdDLL.Common;//  namespace created by us

namespace DvdDLL
{
    public class search
    {
        public DataSet itemTypeList()//displaying items in search type  combobox
        {
            DataSet lstItemType = new DataSet();
            SqlConnection con = new SqlConnection(dbConnection.dbCon);//here dbConnection is user defined class and dbCon is its property

            //2. add commands 
            SqlCommand cmd = new SqlCommand("usp_searchItem", con);
            cmd.CommandType = CommandType.StoredProcedure;//defining stored procedure

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(lstItemType);
            return lstItemType;
        }

        public DataSet displaySearchItem(string whichItem,int whatToSearch)
        {
            DataSet searchItem = new DataSet();
            SqlConnection con = new SqlConnection(dbConnection.dbCon);
            SqlCommand cmd = new SqlCommand("usp_getSearchItem", con);
            cmd.Parameters.AddWithValue("@whichItem", whichItem);
            cmd.Parameters.AddWithValue("@whatToSearch", whatToSearch);           
            cmd.CommandType = CommandType.StoredProcedure;

            //con.Open();
            //cmd.ExecuteReader();
            //con.Close();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(searchItem);
            return searchItem;
        }

        public DataSet displaySearchItemFromName(string whichItem, int whatToSearch, string item)
        {
            DataSet searchItem = new DataSet();
            SqlConnection con = new SqlConnection(dbConnection.dbCon);
            SqlCommand cmd = new SqlCommand("usp_getSearchItemFromName", con);
            cmd.Parameters.AddWithValue("@whichItem", whichItem);
            cmd.Parameters.AddWithValue("@whatToSearch", whatToSearch);
            cmd.Parameters.AddWithValue("@itemName", item);
            cmd.CommandType = CommandType.StoredProcedure;

            //con.Open();
            //cmd.ExecuteReader();
            //con.Close();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(searchItem);
            return searchItem;
        }

    }
}
