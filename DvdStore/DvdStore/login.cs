using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using DvdDLL;
using DvdDLL.Common;
using DvdStore;
namespace DVDStore
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(dbConnection.dbCon);
            SqlCommand cmd = new SqlCommand("select count(*) from tbl_Usermanagement where [UserName]=@username and [Password]=@password",con);//proc to check username and password
            cmd.Parameters.AddWithValue("@username",txtUsername.Text);
            cmd.Parameters.AddWithValue("@password",(txtPassword.Text).GetHashCode());//.GetHashCode() changes the input password while checking into database
            cmd.Connection.Open();
          if((int)cmd.ExecuteScalar()>0)
             {
                 this.Hide();
                 MainForm mn = new MainForm();
                 mn.Show();
               
             }
          else
            {
              //Login failure
               MessageBox.Show("Invalid Username or password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
               txtPassword.Clear();
               txtUsername.Clear();
            }
        }

        private void btnLoginCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

    }
}

       
                
       
        
    
    

    
