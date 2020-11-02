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
    public partial class frmGames : Form
    {
        Games gm = new Games();
        static string gameName;
        static string gameReq;
        static int gameQuantity;
        static decimal gamePrice;
        static int gameGameTypeID;
        static int gameItemTypeID;
        static int gameID;
        static string gameMode = "I";
        
        public frmGames()
        {
            InitializeComponent();
            txtGameName.Clear();
            txtGameRequirements.Clear();
            txtGameQuantity.Clear();
            txtGamePrice.Clear();
        }
        public frmGames(string Name,string Requirement,int Quantity, decimal Price,int GameTypeID, int ItemTypeID,int ID,string Mode)
        {
            InitializeComponent();
            gameName = Name;
            gameReq = Requirement;
            gameQuantity = Quantity;
            gamePrice = Price;
            gameGameTypeID = GameTypeID;
            gameItemTypeID = ItemTypeID;
            gameID = ID;
            gameMode = Mode;

        }
        private void frmGames_Load(object sender, EventArgs e)
        {
            DataSet ds = gm.gameTypeList();
            cmbGameType.DataSource = ds.Tables[0];
            cmbGameType.DisplayMember = "Description";
            cmbGameType.ValueMember = "GameTypeID";
            if (gameMode == "U")
            {
                txtGameName.Text = gameName;
                txtGameRequirements.Text = gameReq;
                txtGameQuantity.Text = gameQuantity.ToString();
                txtGamePrice.Text = gamePrice.ToString();
                cmbGameType.SelectedValue = gameGameTypeID;
            }
        }

        private void txtGamePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txtGamePrice.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back);
        }

        private void txtGameQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void btnGameCancel_Click(object sender, EventArgs e)
        {
            txtGameName.Clear();
            txtGameRequirements.Clear();
            txtGameQuantity.Clear();
            txtGamePrice.Clear();
            this.Close();
        }

        private void btnGameSave_Click(object sender, EventArgs e)
        {
            int ItemStoreType = 3; // 3 indicates music 
            int result = 0;

            if (txtGameName.Text == "" && txtGamePrice.Text == "" && txtGameQuantity.Text == "" && txtGameRequirements.Text == "")
            {
                MessageBox.Show("Fill All Boxes", "Blank Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (gameMode == "I")
                {
                    result = gm.iudGames(txtGameName.Text, txtGameRequirements.Text, Convert.ToInt32(txtGameQuantity.Text), Convert.ToDecimal(txtGamePrice.Text), Convert.ToInt32(cmbGameType.SelectedValue), ItemStoreType, 0, gameMode);
                    if (result > 0)
                    {
                        MessageBox.Show("Data save successfully", "Inserted!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtGameName.Clear();
                        txtGameRequirements.Clear();
                        txtGameQuantity.Clear();
                        txtGamePrice.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Data save failed", "Insert Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (gameMode == "U")
                {
                    result = gm.iudGames(txtGameName.Text, txtGameRequirements.Text, Convert.ToInt32(txtGameQuantity.Text), Convert.ToDecimal(txtGamePrice.Text), Convert.ToInt32(cmbGameType.SelectedValue), ItemStoreType, gameID, gameMode);
                    if (result > 0)
                    {
                        MessageBox.Show("Data updated successfully", "Updated!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Data update failed", "Update Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    txtGameName.Clear();
                    txtGameRequirements.Clear();
                    txtGameQuantity.Clear();
                    txtGamePrice.Clear();
                    this.Close();
                }

            }
        }
    }
}
