namespace DvdStore
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuApps = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGames = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMovies = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMusic = new System.Windows.Forms.ToolStripMenuItem();
            this.usermanagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegisterNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUserRoleSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewRegisteredUser = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSearch = new System.Windows.Forms.ToolStripButton();
            this.mnuSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.addToolStripMenuItem,
            this.usermanagementToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutUsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(688, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSearch,
            this.toolStripSeparator3,
            this.mnuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(152, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuApps,
            this.mnuGames,
            this.mnuMovies,
            this.mnuMusic});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.addToolStripMenuItem.Text = "Add option";
            // 
            // mnuApps
            // 
            this.mnuApps.Name = "mnuApps";
            this.mnuApps.Size = new System.Drawing.Size(152, 22);
            this.mnuApps.Text = "Apps";
            this.mnuApps.Click += new System.EventHandler(this.mnuApps_Click);
            // 
            // mnuGames
            // 
            this.mnuGames.Name = "mnuGames";
            this.mnuGames.Size = new System.Drawing.Size(152, 22);
            this.mnuGames.Text = "Games";
            this.mnuGames.Click += new System.EventHandler(this.mnuGames_Click);
            // 
            // mnuMovies
            // 
            this.mnuMovies.Name = "mnuMovies";
            this.mnuMovies.Size = new System.Drawing.Size(152, 22);
            this.mnuMovies.Text = "Movies";
            this.mnuMovies.Click += new System.EventHandler(this.mnuMovies_Click);
            // 
            // mnuMusic
            // 
            this.mnuMusic.Name = "mnuMusic";
            this.mnuMusic.Size = new System.Drawing.Size(152, 22);
            this.mnuMusic.Text = "Music";
            this.mnuMusic.Click += new System.EventHandler(this.mnuMusic_Click);
            // 
            // usermanagementToolStripMenuItem
            // 
            this.usermanagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRegisterNewUser,
            this.mnuUserRoleSetup,
            this.mnuViewRegisteredUser});
            this.usermanagementToolStripMenuItem.Name = "usermanagementToolStripMenuItem";
            this.usermanagementToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.usermanagementToolStripMenuItem.Text = "Usermanagement";
            // 
            // mnuRegisterNewUser
            // 
            this.mnuRegisterNewUser.Name = "mnuRegisterNewUser";
            this.mnuRegisterNewUser.Size = new System.Drawing.Size(183, 22);
            this.mnuRegisterNewUser.Text = "Register New User";
            this.mnuRegisterNewUser.Click += new System.EventHandler(this.mnuRegisterNewUser_Click);
            // 
            // mnuUserRoleSetup
            // 
            this.mnuUserRoleSetup.Name = "mnuUserRoleSetup";
            this.mnuUserRoleSetup.Size = new System.Drawing.Size(183, 22);
            this.mnuUserRoleSetup.Text = "User Role Setup";
            this.mnuUserRoleSetup.Click += new System.EventHandler(this.mnuUserRoleSetup_Click);
            // 
            // mnuViewRegisteredUser
            // 
            this.mnuViewRegisteredUser.Name = "mnuViewRegisteredUser";
            this.mnuViewRegisteredUser.Size = new System.Drawing.Size(183, 22);
            this.mnuViewRegisteredUser.Text = "View Registered User";
            this.mnuViewRegisteredUser.Click += new System.EventHandler(this.mnuViewRegisteredUser_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(688, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonSearch
            // 
            this.toolStripButtonSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSearch.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSearch.Image")));
            this.toolStripButtonSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSearch.Name = "toolStripButtonSearch";
            this.toolStripButtonSearch.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSearch.Text = "Search";
            this.toolStripButtonSearch.Click += new System.EventHandler(this.toolStripButtonSearch_Click);
            // 
            // mnuSearch
            // 
            this.mnuSearch.Name = "mnuSearch";
            this.mnuSearch.Size = new System.Drawing.Size(152, 22);
            this.mnuSearch.Text = "Search";
            this.mnuSearch.Click += new System.EventHandler(this.mnuSearch_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 417);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "DVD Store";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
           // this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuMusic;
        private System.Windows.Forms.ToolStripMenuItem mnuGames;
        private System.Windows.Forms.ToolStripMenuItem usermanagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuApps;
        private System.Windows.Forms.ToolStripMenuItem mnuMovies;
        private System.Windows.Forms.ToolStripMenuItem mnuRegisterNewUser;
        private System.Windows.Forms.ToolStripMenuItem mnuUserRoleSetup;
        private System.Windows.Forms.ToolStripMenuItem mnuViewRegisteredUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripButton toolStripButtonSearch;
        private System.Windows.Forms.ToolStripMenuItem mnuSearch;

        
    }
}

