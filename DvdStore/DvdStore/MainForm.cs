using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DVDStore;

namespace DvdStore
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
      
        private void mnuFileMusic_Click(object sender, EventArgs e)
        {
            frmAllAction smusic = new frmAllAction();
            smusic.MdiParent = this;
            smusic.Show();
        }

        private void mnuMusic_Click(object sender, EventArgs e)
        {
            frmMusic fMusic = new frmMusic();
            fMusic.MdiParent = this;
            fMusic.Show();
        }

        private void mnuMovies_Click(object sender, EventArgs e)
        {
            frmMovie fMovie = new frmMovie();
            fMovie.MdiParent = this;
            fMovie.Show();
        }

        private void mnuGames_Click(object sender, EventArgs e)
        {
            frmGames fGame = new frmGames();
            fGame.MdiParent = this;
            fGame.Show();
        }

        private void mnuApps_Click(object sender, EventArgs e)
        {
           frmApps fApps = new frmApps();
           fApps.MdiParent = this;
           fApps.Show();
        }

        private void mnuRegisterNewUser_Click(object sender, EventArgs e)
        {
            UserRegistration fur = new UserRegistration();
            fur.Show();
        }

        private void mnuUserRoleSetup_Click(object sender, EventArgs e)
        {
            frmUserRoleSetup fau = new frmUserRoleSetup();
            fau.Show();
        }

        private void mnuViewRegisteredUser_Click(object sender, EventArgs e)
        {
            frmViewUser fview = new frmViewUser();
            fview.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs abu = new AboutUs();
            abu.Show();
        }

        private void toolStripButtonSearch_Click(object sender, EventArgs e)
        {
            frmAllAction search = new frmAllAction();
            search.MdiParent = this;
            search.Show();
        }

        private void mnuSearch_Click(object sender, EventArgs e)
        {
            frmAllAction search = new frmAllAction();
            search.MdiParent = this;
            search.Show();
        }
    }
}
