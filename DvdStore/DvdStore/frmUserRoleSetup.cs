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
    public partial class frmUserRoleSetup : Form
    {
        UserRegistrationClass urc = new UserRegistrationClass();
        public frmUserRoleSetup()
        {
            InitializeComponent();
       }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            BindRoles();
        }
        private void BindRoles()
        {
            DataTable dt = urc.GetRoles();
            grdRoles.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strIsActive = string.Empty;
            if (chkIsActive.Checked == true)
                strIsActive = "1";
            else
                strIsActive = "0";
            int result = urc.iudRoles(txtRoleName.Text, strIsActive, txtDescription.Text, 0, "I");
            if (result > 0)
            {
                MessageBox.Show("Data save successfully", "Inserted!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindRoles();
                ResetValues();
            }
            else
            {
                MessageBox.Show("Data save failed", "Insert Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string strIsActive = string.Empty;
            if (chkIsActive.Checked == true)
                strIsActive = "1";
            else
                strIsActive = "0";
            int result = urc.iudRoles("", "", "", Convert.ToInt32(lblId.Text),"D");
            if (result > 0)
            {
                MessageBox.Show("Data deleted successfully", "Success!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindRoles();
                ResetValues();
            }
            else
            {
                MessageBox.Show("Data delete failed", "Delete Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void grdRoles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = grdRoles.SelectedRows[0].Cells[0].Value.ToString();
            txtRoleName.Text = grdRoles.SelectedRows[0].Cells[1].Value.ToString();
            txtDescription.Text = grdRoles.SelectedRows[0].Cells[3].Value.ToString();
            chkIsActive.Checked = (Boolean)grdRoles.SelectedRows[0].Cells[2].Value;
        }

        private void ResetValues()
        {
            txtRoleName.Text = "";
            txtDescription.Text = "";
            chkIsActive.Checked = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string strIsActive = string.Empty;
            if (chkIsActive.Checked == true)
                strIsActive = "1";
            else
                strIsActive = "0";
            int result = urc.iudRoles(txtRoleName.Text, strIsActive, txtDescription.Text, Convert.ToInt32(lblId.Text), "U");
            if (result > 0)
            {
                MessageBox.Show("Data updated successfully", "Updated!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindRoles();
                ResetValues();
            }
            else
            {
                MessageBox.Show("Data update failed", "Update Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

   }
}
