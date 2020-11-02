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
    public partial class UserRegistration : Form
    {
        UserRegistrationClass uReg = new UserRegistrationClass();
        public UserRegistration()
        {
            InitializeComponent();
        }

        private void UserRegistration_Load(object sender, EventArgs e)
        {
            BindRoles();
            BindGender();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string isActive = "0";
            
            if(txtFName.Text==""&&txtLastName.Text==""&&txtAddress.Text==""&&txtEmail.Text==""&&txtPassword.Text==""&&txtUserName.Text=="")
            {
                MessageBox.Show("Fill All Boxes", "Blank Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {  
                if (chkIsActive.Checked == true)
                isActive = "1";
            else
                isActive = "0";
            string FName = txtFName.Text;
            string LName = txtLastName.Text;
            string Address = txtAddress.Text;
            int Gender = Convert.ToInt32(cmbGender.SelectedValue);
            string Email = txtEmail.Text;
            string userName = txtUserName.Text;
            string password = txtPassword.Text.GetHashCode().ToString();
            int RoleId = Convert.ToInt32(cmbRoles.SelectedValue);

            int result = uReg.userRegistration(FName, LName, Address, Gender, Email, userName, password, RoleId, isActive,0,"I");
            if (result > 0)
            {
                MessageBox.Show("User Created", "Success!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("User register failed", "Registeration Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            }

        private void BindRoles()
        {
            DataTable dt = uReg.GetRoles();
            cmbRoles.DataSource = dt;
            cmbRoles.DisplayMember = "Role_Name";
            cmbRoles.ValueMember = "RoleID";
        }
        private void BindGender()
        {
            DataTable dts = uReg.GetGender();
            cmbGender.DataSource = dts;
            cmbGender.DisplayMember = "Description";
            cmbGender.ValueMember = "GenderID";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
