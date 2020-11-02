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

namespace DvdStore
{
    public partial class frmAllAction : Form
    {
        search sea = new search();
        Apps objApps = new Apps();
        Music objMusic = new Music();
        Games objGames = new Games();
        Movie objMovie = new Movie();


        DataSet dsa = new DataSet();
        

        public frmAllAction()
        {
            InitializeComponent();
        }

        private void frmAllAction_Load(object sender, EventArgs e)
        {
            LoadTypeCombo();
        }

        public void bindingApps()
        {           
            DataSet ds = objApps.displayApps();
            grdAll.DataSource = ds.Tables[0];
        }


        private void LoadTypeCombo()
        {
            DataSet dsm = sea.itemTypeList();
            cmbSearchType.DataSource = dsm.Tables[0];
            cmbSearchType.DisplayMember = "Name";
            cmbSearchType.ValueMember = "ItemID";  
        }

        private void bindingMusic()
        {            
            DataSet ds = objMusic.displayMusic();
            grdAll.DataSource = ds.Tables[0]; 
        }

        private void bindingMovies()//for displaying movies in data grid view
        {
                        
            DataSet ds = objMovie.displayMovie();
            grdAll.DataSource = ds.Tables[0];
          
        }
        private void bindingGames()
        {
           
            DataSet ds = objGames.displayGame();
            grdAll.DataSource = ds.Tables[0];
 
        }



        private void cmbSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            if (Convert.ToString(cmbSearchType.Text) == "Apps")
            {
                dsa = objApps.AppsType();
                cmbSearchFrom.DataSource = dsa.Tables[0];
                cmbSearchFrom.DisplayMember = "Description";
                cmbSearchFrom.ValueMember = "AppsTypeID";
                //cmbSearchFrom.SelectedIndex = 0;

                lblIndicator.Text = "Apps";
                bindingApps();

            }
            else if (Convert.ToString(cmbSearchType.Text) == "Games")
            {
                dsa = objGames.gameTypeList();
                cmbSearchFrom.DataSource = dsa.Tables[0];
                cmbSearchFrom.DisplayMember = "Description";
                cmbSearchFrom.ValueMember = "GameTypeID";

                lblIndicator.Text = "Games";
                bindingGames();
            }
            else if (Convert.ToString(cmbSearchType.Text) == "Movies")
            {
                dsa = objMovie.movieGenerList();
                cmbSearchFrom.DataSource = dsa.Tables[0];
                cmbSearchFrom.DisplayMember = "Description";
                cmbSearchFrom.ValueMember = "MovieGenerID";

                lblIndicator.Text = "Movies";
                bindingMovies();
            }
            else if (Convert.ToString(cmbSearchType.Text) == "Music")
            {
                dsa = objMusic.musicGenerList();
                cmbSearchFrom.DataSource = dsa.Tables[0];
                cmbSearchFrom.DisplayMember = "Description";
                cmbSearchFrom.ValueMember = "MusicGenerID";

                lblIndicator.Text = "Music";
                bindingMusic();
            }
        
        }

       
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataSet searchItem = sea.displaySearchItemFromName(lblIndicator.Text, Convert.ToInt32(cmbSearchFrom.SelectedValue), txtSearch.Text);
            grdAll.DataSource = searchItem.Tables[0];
            
        }

        private void grdAll_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = grdAll.SelectedRows[0].Cells[0].Value.ToString();
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string Mode = "U";
            if (lblIndicator.Text == "Apps")
            {      
                frmApps uApps = new frmApps(grdAll.SelectedRows[0].Cells[1].Value.ToString(), 
                                            grdAll.SelectedRows[0].Cells[2].Value.ToString(),
                                            grdAll.SelectedRows[0].Cells[3].Value.ToString(), 
                                            Convert.ToInt32(grdAll.SelectedRows[0].Cells[4].Value.ToString()),
                                            Convert.ToDecimal(grdAll.SelectedRows[0].Cells[5].Value.ToString()), 
                                            Convert.ToInt32(grdAll.SelectedRows[0].Cells[6].Value.ToString()), 
                                            Convert.ToInt32(grdAll.SelectedRows[0].Cells[7].Value.ToString()),
                                            Convert.ToInt32( lblId.Text),Mode);
                uApps.Show();
            }
            else if (lblIndicator.Text == "Games")
            {
                frmGames uGames = new frmGames(grdAll.SelectedRows[0].Cells[1].Value.ToString(), 
                                                grdAll.SelectedRows[0].Cells[2].Value.ToString(),
                                                Convert.ToInt32(grdAll.SelectedRows[0].Cells[3].Value.ToString()), 
                                                Convert.ToDecimal(grdAll.SelectedRows[0].Cells[4].Value.ToString()),
                                                Convert.ToInt32(grdAll.SelectedRows[0].Cells[5].Value.ToString()),
                                                Convert.ToInt32(grdAll.SelectedRows[0].Cells[6].Value.ToString()),
                                                Convert.ToInt32( lblId.Text),Mode);
                uGames.Show();
            }
            else if (lblIndicator.Text == "Movies")
            {
                frmMovie uMovies = new frmMovie(grdAll.SelectedRows[0].Cells[1].Value.ToString(), 
                                                grdAll.SelectedRows[0].Cells[2].Value.ToString(), 
                                                grdAll.SelectedRows[0].Cells[3].Value.ToString(), 
                                                Convert.ToInt32(grdAll.SelectedRows[0].Cells[4].Value.ToString()),
                                                grdAll.SelectedRows[0].Cells[5].Value.ToString(), 
                                                Convert.ToDecimal(grdAll.SelectedRows[0].Cells[6].Value.ToString()),
                                                Convert.ToInt32(grdAll.SelectedRows[0].Cells[7].Value.ToString()), 
                                                Convert.ToInt32(grdAll.SelectedRows[0].Cells[8].Value.ToString()),
                                                Convert.ToInt32(grdAll.SelectedRows[0].Cells[9].Value.ToString()), 
                                                Convert.ToInt32(lblId.Text), Mode);
                uMovies.Show();
            }

            else if (lblIndicator.Text == "Music")
            {
                frmMusic uMusic = new frmMusic(grdAll.SelectedRows[0].Cells[1].Value.ToString(),
                                                grdAll.SelectedRows[0].Cells[2].Value.ToString(),
                                                grdAll.SelectedRows[0].Cells[3].Value.ToString(),
                                                Convert.ToInt32(grdAll.SelectedRows[0].Cells[4].Value.ToString()),
                                                Convert.ToDecimal(grdAll.SelectedRows[0].Cells[5].Value.ToString()),
                                                Convert.ToInt32(grdAll.SelectedRows[0].Cells[6].Value.ToString()),
                                                Convert.ToInt32(grdAll.SelectedRows[0].Cells[7].Value.ToString()),
                                                Convert.ToInt32(lblId.Text), Mode);
                uMusic.Show();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)//for deleting Purpose from Data Grid View
        {
            string Mode = "D";
            if (lblIndicator.Text == "Apps")
            {         
               if ((MessageBox.Show("Are you Sure You Want Delete Item?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    int result = objApps.iudApps("", "", "", 0, 0, 0, 0,Convert.ToInt32(lblId.Text), Mode);
                    if (result > 0)
                    {
                        MessageBox.Show("Data Delete successfully");
                        bindingApps();
                  }

                }
            }
            else if(lblIndicator.Text=="Games")
            {
                if ((MessageBox.Show("Are you Sure You Want Delete Item?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    int result = objGames.iudGames("","",0,0,0,0,Convert.ToInt32(lblId.Text), Mode);
                    if (result > 0)
                    {
                        MessageBox.Show("Data Delete successfully");
                        bindingGames();
                    }

                }
            }
            else if (lblIndicator.Text == "Movies")
            {
                if ((MessageBox.Show("Are you Sure You Want Delete Item?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    int result = objMovie.iudMovies("", "", "", 0, "", 0, 0, 0, 0, Convert.ToInt32(lblId.Text), Mode);
                    if (result > 0)
                    {
                        MessageBox.Show("Data Delete successfully");
                        bindingMovies();
                    }
                }
            }
            else if (lblIndicator.Text == "Music")
            {
                if ((MessageBox.Show("Are you Sure You Want Delete Item?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    int result = objMusic.iudMusic("", "", "", 0, 0, 0, 0, Convert.ToInt32(lblId.Text), Mode);
                    if (result > 0)
                    {
                        MessageBox.Show("Data Delete successfully");
                        bindingMusic();
                    }
                }
            }
        }

        private void cmbSearchFrom_SelectedIndexChanged(object sender, EventArgs e)
        {

            string ItemType = cmbSearchType.Text;
            FilterGridView(ItemType);
        }


        private void FilterGridView(string searchtext)
        {
            if (cmbSearchFrom.SelectedIndex > 0)
            {

                int TypeId = int.Parse(cmbSearchFrom.SelectedValue.ToString());
                DataSet ds = sea.displaySearchItem(searchtext, TypeId);

              //  grdAll.Rows.Clear();
                grdAll.DataSource = ds.Tables[0];
            }


           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (lblIndicator.Text == "Apps")
            {
                bindingApps();
            }
            else if (lblIndicator.Text == "Games")
            {
                bindingGames();
            }
            else if (lblIndicator.Text == "Movies")
            {
                bindingMovies();
            }
            else if (lblIndicator.Text == "Music")
            {
                bindingMusic();
            }

        }
    }
}
