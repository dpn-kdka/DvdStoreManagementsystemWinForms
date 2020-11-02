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
    
    public partial class frmMovie : Form
    {
        Movie mv = new Movie();
        static string mName;
        static string mActor;
        static string mDirector;
        static int mLanguageID;
        static string mRYear;
        static decimal mPrice;
        static int mQuantity;
        static int mMovieGenerID;
        static int mItemTypeID;
        static int movieID;
        static string movieMode = "I";

        public frmMovie()
        {
            InitializeComponent();
            txtMovieName.Clear();
            txtMovieActor.Clear();
            txtMovieDirector.Clear();
            txtMoviePrice.Clear();
            txtMovieQuantity.Clear();
        }
        public frmMovie(string Name, string Actor, string Director,int languageID, string ReleaseYear, decimal Price, int Quantity, int MovieGenerID, int ItemTypeID, int ID, string Mode)
        {
            InitializeComponent();
            mName = Name;
            mActor = Actor;
            mDirector = Director;
            mLanguageID = languageID;
            mRYear = ReleaseYear;
            mPrice = Price;
            mQuantity = Quantity;
            mMovieGenerID = MovieGenerID;
            mItemTypeID = ItemTypeID;
            movieID = ID;
            movieMode = Mode;

        }

        private void frmMovie_Load(object sender, EventArgs e)
        {
            DataSet dsm = mv.movieGenerList();
            cmbMovieGener.DataSource = dsm.Tables[0];
            cmbMovieGener.DisplayMember = "Description";
            cmbMovieGener.ValueMember = "MovieGenerID";

            DataSet dsl = mv.languageList();
            cmbMovieLanguage.DataSource = dsl.Tables[0];
            cmbMovieLanguage.DisplayMember = "Language";
            cmbMovieLanguage.ValueMember = "LanguageID";

            if (movieMode == "U")
            {
                txtMovieName.Text = mName;
                txtMovieActor.Text = mActor;
                txtMovieDirector.Text = mDirector;
                cmbMovieLanguage.SelectedValue = mLanguageID;
                dtpMovieReleaseYear.Text = mRYear;
                txtMoviePrice.Text = mPrice.ToString();
                txtMovieQuantity.Text = mQuantity.ToString();
               cmbMovieGener.SelectedValue=mMovieGenerID; 
            }      
        }



        private void txtMoviePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txtMoviePrice.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back);
        }

        private void txtMovieQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }


        private void btnMovieSave_Click(object sender, EventArgs e)
        {

            int ItemStoreType = 4; // 4 indicates movie
            int result = 0;
            if(txtMovieActor.Text==""&&txtMovieDirector.Text==""&&txtMovieName.Text==""&&txtMoviePrice.Text==""&&txtMovieQuantity.Text=="")
            {
                MessageBox.Show("Fill All Boxes","Blank Box",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                
            if (movieMode == "I")
            {
                result = mv.iudMovies(txtMovieName.Text, txtMovieActor.Text, txtMovieDirector.Text, Convert.ToInt32(cmbMovieLanguage.SelectedValue), dtpMovieReleaseYear.Text, Convert.ToDecimal(txtMoviePrice.Text), Convert.ToInt32(txtMovieQuantity.Text), Convert.ToInt32(cmbMovieGener.SelectedValue), ItemStoreType, 0, movieMode);
                if (result > 0)
                {
                    MessageBox.Show("Data save successfully", "Inserted!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMovieName.Clear();
                    txtMovieActor.Clear();
                    txtMovieDirector.Clear();
                    txtMoviePrice.Clear();
                    txtMovieQuantity.Clear();
                }
                else
                {
                    MessageBox.Show("Data save failed", "Insert Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (movieMode == "U")
            {
                result = mv.iudMovies(txtMovieName.Text, txtMovieActor.Text, txtMovieDirector.Text, Convert.ToInt32(cmbMovieLanguage.SelectedValue), dtpMovieReleaseYear.Text, Convert.ToDecimal(txtMoviePrice.Text), Convert.ToInt32(txtMovieQuantity.Text), Convert.ToInt32(cmbMovieGener.SelectedValue), ItemStoreType, movieID, movieMode);
                if (result > 0)
                {

                    MessageBox.Show("Data updated successfully", "Updated!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data update failed", "Update Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtMovieName.Clear();
                txtMovieActor.Clear();
                txtMovieDirector.Clear();
                txtMoviePrice.Clear();
                txtMovieQuantity.Clear();
                this.Close();
            }
        }
            }

        private void btnMovieCancel_Click(object sender, EventArgs e)
        {
            txtMovieName.Clear();
            txtMovieActor.Clear();
            txtMovieDirector.Clear();
            txtMoviePrice.Clear();
            txtMovieQuantity.Clear();
            this.Close();
        }

      
    }
}
