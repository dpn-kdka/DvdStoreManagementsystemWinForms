namespace DvdStore
{
    partial class frmMusic
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
            this.dtpReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMusicCancel = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cmbMusicGener = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblGener = new System.Windows.Forms.Label();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.btnMusicSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpReleaseDate
            // 
            this.dtpReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReleaseDate.Location = new System.Drawing.Point(79, 77);
            this.dtpReleaseDate.Name = "dtpReleaseDate";
            this.dtpReleaseDate.Size = new System.Drawing.Size(191, 20);
            this.dtpReleaseDate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Quantity:";
            // 
            // btnMusicCancel
            // 
            this.btnMusicCancel.Location = new System.Drawing.Point(176, 216);
            this.btnMusicCancel.Name = "btnMusicCancel";
            this.btnMusicCancel.Size = new System.Drawing.Size(75, 23);
            this.btnMusicCancel.TabIndex = 56;
            this.btnMusicCancel.Text = "Cancel";
            this.btnMusicCancel.UseVisualStyleBackColor = true;
            this.btnMusicCancel.Click += new System.EventHandler(this.btnMusicCancel_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(79, 136);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(189, 20);
            this.txtQuantity.TabIndex = 4;
            // 
            // cmbMusicGener
            // 
            this.cmbMusicGener.FormattingEnabled = true;
            this.cmbMusicGener.Location = new System.Drawing.Point(79, 107);
            this.cmbMusicGener.Name = "cmbMusicGener";
            this.cmbMusicGener.Size = new System.Drawing.Size(189, 21);
            this.cmbMusicGener.Sorted = true;
            this.cmbMusicGener.TabIndex = 3;
            this.cmbMusicGener.Text = "  ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpReleaseDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.cmbMusicGener);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.lblGener);
            this.groupBox1.Controls.Add(this.lblReleaseDate);
            this.groupBox1.Controls.Add(this.lblArtist);
            this.groupBox1.Controls.Add(this.lblAlbum);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtArtist);
            this.groupBox1.Controls.Add(this.txtAlbum);
            this.groupBox1.Location = new System.Drawing.Point(7, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(282, 201);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Music";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(5, 167);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 47;
            this.lblPrice.Text = "Price:";
            // 
            // lblGener
            // 
            this.lblGener.AutoSize = true;
            this.lblGener.Location = new System.Drawing.Point(5, 110);
            this.lblGener.Name = "lblGener";
            this.lblGener.Size = new System.Drawing.Size(39, 13);
            this.lblGener.TabIndex = 46;
            this.lblGener.Text = "Gener:";
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Location = new System.Drawing.Point(5, 81);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(72, 13);
            this.lblReleaseDate.TabIndex = 45;
            this.lblReleaseDate.Text = "Release year:";
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Location = new System.Drawing.Point(5, 53);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(63, 13);
            this.lblArtist.TabIndex = 44;
            this.lblArtist.Text = "Artist/Band:";
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Location = new System.Drawing.Point(5, 24);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(39, 13);
            this.lblAlbum.TabIndex = 43;
            this.lblAlbum.Text = "Album:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(79, 164);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(191, 20);
            this.txtPrice.TabIndex = 5;
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(79, 50);
            this.txtArtist.MaxLength = 50;
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(190, 20);
            this.txtArtist.TabIndex = 1;
            // 
            // txtAlbum
            // 
            this.txtAlbum.Location = new System.Drawing.Point(79, 22);
            this.txtAlbum.MaxLength = 50;
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(191, 20);
            this.txtAlbum.TabIndex = 0;
            this.txtAlbum.Tag = "";
            // 
            // btnMusicSave
            // 
            this.btnMusicSave.Location = new System.Drawing.Point(56, 216);
            this.btnMusicSave.Name = "btnMusicSave";
            this.btnMusicSave.Size = new System.Drawing.Size(75, 23);
            this.btnMusicSave.TabIndex = 55;
            this.btnMusicSave.Text = "Save";
            this.btnMusicSave.UseVisualStyleBackColor = true;
            this.btnMusicSave.Click += new System.EventHandler(this.btnMusicSave_Click);
            // 
            // frmMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(300, 246);
            this.Controls.Add(this.btnMusicCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMusicSave);
            this.Name = "frmMusic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Add Music";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMusic_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpReleaseDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMusicCancel;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cmbMusicGener;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblGener;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.Button btnMusicSave;


    }
}