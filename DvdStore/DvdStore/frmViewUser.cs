using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DvdDLL;
namespace DvdStore
{
    public partial class frmViewUser : Form
    {
        UserRegistrationClass urc = new UserRegistrationClass();
        public frmViewUser()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmViewUser_Load(object sender, EventArgs e)
        {
            bindUser();
        }
        private void bindUser()
        {
            DataTable dt = urc.getRegisteredUser();
            grdViewUser.DataSource = dt;
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you Sure You Want Delete Item?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                int result = urc.userRegistration("","","",0,"",lblId.Text,"",0,"",0 , "D");
                if (result > 0)
                {
                    MessageBox.Show("Data Delete successfully");
                    bindUser();
                }

            }
        }

        private void grdViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = grdViewUser.SelectedRows[0].Cells[0].Value.ToString();
           
        }

    }
}
