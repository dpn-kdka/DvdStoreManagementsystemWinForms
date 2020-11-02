using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DvdDLL;//userdefined namespace 

namespace DvdStore
{
    public partial class frmMusic : Form
    {
        Music iMD = new Music();
        static string muArtist;
        static string muAlbum;
        static string muRYear;
        static int muQuantity;
        static decimal muPrice;
        static int muMusicGenerID;
        static int muItemTypeID;
        static int musicID;
        static string musicMode = "I";

        public frmMusic()
        {
            InitializeComponent();
            txtArtist.Clear();
            txtAlbum.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
        }

        public frmMusic(string Artist, string Album,string Releaseyear, int Quantity, decimal Price, int MusicGenerID, int ItemTypeID,int ID,string Mode)
        {
            InitializeComponent();
            muArtist = Artist;
            muAlbum = Album;
            muRYear = Releaseyear;
            muQuantity = Quantity;
            muPrice = Price;
            muMusicGenerID = MusicGenerID;
            muItemTypeID = ItemTypeID;
            musicID = ID;
            musicMode = Mode;
        }


        private void frmMusic_Load(object sender, EventArgs e)
        {
            DataSet ds = iMD.musicGenerList();
            cmbMusicGener.DataSource = ds.Tables[0];
            cmbMusicGener.DisplayMember = "Description";
            cmbMusicGener.ValueMember = "MusicGenerID";

            if (musicMode == "U")
            {
                txtArtist.Text = muArtist;
                txtAlbum.Text = muAlbum;
                dtpReleaseDate.Text = muRYear;
                txtQuantity.Text = muQuantity.ToString();
                txtPrice.Text = muPrice.ToString();
                cmbMusicGener.SelectedValue = muMusicGenerID;
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txtPrice.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back);
            
        }


        private void btnMusicSave_Click(object sender, EventArgs e)
        {
            int ItemStoreType = 1; // 1 indicates music 

            int result = 0;
            
            if(txtAlbum.Text==""&&txtArtist.Text==""&&txtPrice.Text==""&&txtQuantity.Text=="")
            {
                MessageBox.Show("Fill All Boxes", "Blank Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
            if (musicMode == "I")
            {
                result = iMD.iudMusic(txtArtist.Text, txtAlbum.Text, dtpReleaseDate.Text, Convert.ToInt32(txtQuantity.Text), Convert.ToDecimal(txtPrice.Text), Convert.ToInt32(cmbMusicGener.SelectedValue), ItemStoreType, 0, musicMode);
                if (result > 0)
                {
                    MessageBox.Show("Data save successfully", "Inserted!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtQuantity.Clear();
                    txtAlbum.Clear();
                    txtArtist.Clear();
                    txtPrice.Clear();
                }
                else
                {
                    MessageBox.Show("Data save failed", "Insert Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (musicMode == "U")
            {
                result = iMD.iudMusic(txtArtist.Text, txtAlbum.Text, dtpReleaseDate.Text, Convert.ToInt32(txtQuantity.Text), Convert.ToDecimal(txtPrice.Text), Convert.ToInt32(cmbMusicGener.SelectedValue), ItemStoreType, musicID, musicMode);
                if (result > 0)
                {

                    MessageBox.Show("Data updated successfully", "Updated!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data update failed", "Update Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtArtist.Clear();
                txtAlbum.Clear();
                txtQuantity.Clear();
                txtPrice.Clear();
                this.Close();
            }
        }

            }
        private void btnMusicCancel_Click(object sender, EventArgs e)
        {
            txtArtist.Clear();
            txtAlbum.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
            this.Close();
        }


    }
}
