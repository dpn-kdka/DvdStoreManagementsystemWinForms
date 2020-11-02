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
    public partial class frmApps : Form
    {
        Apps apps = new Apps();
        static string appsName;
        static string appsVersion;
        static string appsRequirement;
        static int appsQuantity;
        static decimal appsPrice;
        static int appsAppsTypeID;
        static int appsItemTypeID;
        static int appsID;
        static string appsMode = "I" ;

        public frmApps()
        {
            InitializeComponent();
            txtAppsName.Clear();
            txtAppsVersion.Clear();
            txtAppsRequirements.Clear();
            txtAppsQuantity.Clear();
            txtAppsPrice.Clear();
          
        }
        public frmApps(string Name, string Version, string Requirement, int Quantity, decimal Price, int AppsTypeID, int ItemTypeID, int ID, string Mode)
        {
            InitializeComponent();
            appsName = Name; 
            appsVersion = Version;
            appsRequirement = Requirement;
            appsQuantity = Quantity;
            appsPrice = Price ;
            appsAppsTypeID = AppsTypeID;
            appsItemTypeID = ItemTypeID ;
            appsID = ID ;
            appsMode = Mode ;
     
        }

        private void frmApps_Load(object sender, EventArgs e)
        {
            DataSet dsa = apps.AppsType();
            cmbAppsType.DataSource = dsa.Tables[0];
            cmbAppsType.DisplayMember = "Description";
            cmbAppsType.ValueMember = "AppsTypeID";
            if (appsMode == "U")
            {
                txtAppsName.Text = appsName;
                txtAppsVersion.Text = appsVersion;
                txtAppsRequirements.Text = appsRequirement;
                txtAppsQuantity.Text = appsQuantity.ToString();
                txtAppsPrice.Text = appsPrice.ToString();
                cmbAppsType.SelectedValue = appsAppsTypeID;
            }
        }


        private void txtAppsPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txtAppsPrice.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back);
        }

        private void txtAppsQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }


        private void btnAppsCancel_Click(object sender, EventArgs e)
        {
            txtAppsName.Clear();
            txtAppsVersion.Clear();
            txtAppsRequirements.Clear();
            txtAppsQuantity.Clear();
            txtAppsPrice.Clear();
            this.Close();
        }

        private void btnAppsSave_Click(object sender, EventArgs e)
        {
            int result = 0;
            int ItemStoreType = 2; // 2 indicates Apps
            if(txtAppsName.Text==""&&txtAppsPrice.Text==""&&txtAppsQuantity.Text==""&&txtAppsRequirements.Text==""&&txtAppsVersion.Text=="")
            {
                MessageBox.Show("Fill All Boxes", "Blank Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (appsMode == "I")
                {
                    result = apps.iudApps(txtAppsName.Text, txtAppsVersion.Text, txtAppsRequirements.Text, Convert.ToInt32(txtAppsQuantity.Text), Convert.ToDecimal(txtAppsPrice.Text), Convert.ToInt32(cmbAppsType.SelectedValue), ItemStoreType, 0, appsMode);
                    if (result > 0)
                    {
                    MessageBox.Show("Data save successfully", "Inserted!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAppsName.Clear();
                    txtAppsVersion.Clear();
                    txtAppsRequirements.Clear();
                    txtAppsQuantity.Clear();
                    txtAppsPrice.Clear();
                     }
                    else
                    {
                    MessageBox.Show("Data save failed", "Insert Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else if (appsMode == "U")
                {
                    result = apps.iudApps(txtAppsName.Text, txtAppsVersion.Text, txtAppsRequirements.Text, Convert.ToInt32(txtAppsQuantity.Text), Convert.ToDecimal(txtAppsPrice.Text), Convert.ToInt32(cmbAppsType.SelectedValue), ItemStoreType, appsID, appsMode);
                    if (result > 0)
                    {

                        MessageBox.Show("Data Upadated successfully", "Updated!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtAppsName.Clear();
                        txtAppsVersion.Clear();
                        txtAppsRequirements.Clear();
                        txtAppsQuantity.Clear();
                        txtAppsPrice.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Data Upadate failed", "Update Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    this.Close();
                }
            }
        
                 
        }
    }
}
