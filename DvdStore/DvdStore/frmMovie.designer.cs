namespace DvdStore
{
    partial class frmMovie
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
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.btnMovieCancel = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.dtpMovieReleaseYear = new System.Windows.Forms.DateTimePicker();
            this.lblMovieReleaseYear = new System.Windows.Forms.Label();
            this.lblMovieLanguage = new System.Windows.Forms.Label();
            this.btnMovieSave = new System.Windows.Forms.Button();
            this.cmbMovieLanguage = new System.Windows.Forms.ComboBox();
            this.txtMovieDirector = new System.Windows.Forms.TextBox();
            this.lblMovieDirector = new System.Windows.Forms.Label();
            this.txtMovieActor = new System.Windows.Forms.TextBox();
            this.lblMovieActor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMoviePrice = new System.Windows.Forms.TextBox();
            this.lblMoviePrice = new System.Windows.Forms.Label();
            this.cmbMovieGener = new System.Windows.Forms.ComboBox();
            this.lblMovieGener = new System.Windows.Forms.Label();
            this.txtMovieQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(80, 22);
            this.txtMovieName.MaxLength = 50;
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(185, 20);
            this.txtMovieName.TabIndex = 0;
            // 
            // btnMovieCancel
            // 
            this.btnMovieCancel.Location = new System.Drawing.Point(161, 278);
            this.btnMovieCancel.Name = "btnMovieCancel";
            this.btnMovieCancel.Size = new System.Drawing.Size(80, 30);
            this.btnMovieCancel.TabIndex = 45;
            this.btnMovieCancel.Text = "Cancel";
            this.btnMovieCancel.UseVisualStyleBackColor = true;
            this.btnMovieCancel.Click += new System.EventHandler(this.btnMovieCancel_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblName.Location = new System.Drawing.Point(8, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 39;
            this.lblName.Text = "Name:";
            // 
            // dtpMovieReleaseYear
            // 
            this.dtpMovieReleaseYear.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMovieReleaseYear.Location = new System.Drawing.Point(80, 162);
            this.dtpMovieReleaseYear.Name = "dtpMovieReleaseYear";
            this.dtpMovieReleaseYear.Size = new System.Drawing.Size(186, 20);
            this.dtpMovieReleaseYear.TabIndex = 5;
            // 
            // lblMovieReleaseYear
            // 
            this.lblMovieReleaseYear.AutoSize = true;
            this.lblMovieReleaseYear.Location = new System.Drawing.Point(8, 167);
            this.lblMovieReleaseYear.Name = "lblMovieReleaseYear";
            this.lblMovieReleaseYear.Size = new System.Drawing.Size(71, 13);
            this.lblMovieReleaseYear.TabIndex = 34;
            this.lblMovieReleaseYear.Text = "ReleaseYear:";
            // 
            // lblMovieLanguage
            // 
            this.lblMovieLanguage.AutoSize = true;
            this.lblMovieLanguage.Location = new System.Drawing.Point(8, 81);
            this.lblMovieLanguage.Name = "lblMovieLanguage";
            this.lblMovieLanguage.Size = new System.Drawing.Size(58, 13);
            this.lblMovieLanguage.TabIndex = 33;
            this.lblMovieLanguage.Text = "Language:";
            // 
            // btnMovieSave
            // 
            this.btnMovieSave.Location = new System.Drawing.Point(42, 278);
            this.btnMovieSave.Name = "btnMovieSave";
            this.btnMovieSave.Size = new System.Drawing.Size(80, 30);
            this.btnMovieSave.TabIndex = 44;
            this.btnMovieSave.Text = "Save";
            this.btnMovieSave.UseVisualStyleBackColor = true;
            this.btnMovieSave.Click += new System.EventHandler(this.btnMovieSave_Click);
            // 
            // cmbMovieLanguage
            // 
            this.cmbMovieLanguage.FormattingEnabled = true;
            this.cmbMovieLanguage.Location = new System.Drawing.Point(80, 79);
            this.cmbMovieLanguage.Name = "cmbMovieLanguage";
            this.cmbMovieLanguage.Size = new System.Drawing.Size(186, 21);
            this.cmbMovieLanguage.TabIndex = 2;
            // 
            // txtMovieDirector
            // 
            this.txtMovieDirector.Location = new System.Drawing.Point(80, 136);
            this.txtMovieDirector.MaxLength = 50;
            this.txtMovieDirector.Name = "txtMovieDirector";
            this.txtMovieDirector.Size = new System.Drawing.Size(186, 20);
            this.txtMovieDirector.TabIndex = 4;
            // 
            // lblMovieDirector
            // 
            this.lblMovieDirector.AutoSize = true;
            this.lblMovieDirector.Location = new System.Drawing.Point(8, 138);
            this.lblMovieDirector.Name = "lblMovieDirector";
            this.lblMovieDirector.Size = new System.Drawing.Size(47, 13);
            this.lblMovieDirector.TabIndex = 30;
            this.lblMovieDirector.Text = "Director:";
            // 
            // txtMovieActor
            // 
            this.txtMovieActor.Location = new System.Drawing.Point(80, 107);
            this.txtMovieActor.MaxLength = 100;
            this.txtMovieActor.Name = "txtMovieActor";
            this.txtMovieActor.Size = new System.Drawing.Size(186, 20);
            this.txtMovieActor.TabIndex = 3;
            // 
            // lblMovieActor
            // 
            this.lblMovieActor.AutoSize = true;
            this.lblMovieActor.Location = new System.Drawing.Point(8, 110);
            this.lblMovieActor.Name = "lblMovieActor";
            this.lblMovieActor.Size = new System.Drawing.Size(35, 13);
            this.lblMovieActor.TabIndex = 28;
            this.lblMovieActor.Text = "Actor:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMovieName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.dtpMovieReleaseYear);
            this.groupBox1.Controls.Add(this.lblMovieReleaseYear);
            this.groupBox1.Controls.Add(this.lblMovieLanguage);
            this.groupBox1.Controls.Add(this.cmbMovieLanguage);
            this.groupBox1.Controls.Add(this.txtMovieDirector);
            this.groupBox1.Controls.Add(this.lblMovieDirector);
            this.groupBox1.Controls.Add(this.txtMovieActor);
            this.groupBox1.Controls.Add(this.lblMovieActor);
            this.groupBox1.Controls.Add(this.txtMoviePrice);
            this.groupBox1.Controls.Add(this.lblMoviePrice);
            this.groupBox1.Controls.Add(this.cmbMovieGener);
            this.groupBox1.Controls.Add(this.lblMovieGener);
            this.groupBox1.Controls.Add(this.txtMovieQuantity);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(7, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(278, 264);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Movie";
            // 
            // txtMoviePrice
            // 
            this.txtMoviePrice.Location = new System.Drawing.Point(80, 193);
            this.txtMoviePrice.Name = "txtMoviePrice";
            this.txtMoviePrice.Size = new System.Drawing.Size(186, 20);
            this.txtMoviePrice.TabIndex = 6;
            // 
            // lblMoviePrice
            // 
            this.lblMoviePrice.AutoSize = true;
            this.lblMoviePrice.Location = new System.Drawing.Point(8, 195);
            this.lblMoviePrice.Name = "lblMoviePrice";
            this.lblMoviePrice.Size = new System.Drawing.Size(34, 13);
            this.lblMoviePrice.TabIndex = 26;
            this.lblMoviePrice.Text = "Price:";
            // 
            // cmbMovieGener
            // 
            this.cmbMovieGener.FormattingEnabled = true;
            this.cmbMovieGener.Location = new System.Drawing.Point(80, 50);
            this.cmbMovieGener.Name = "cmbMovieGener";
            this.cmbMovieGener.Size = new System.Drawing.Size(186, 21);
            this.cmbMovieGener.TabIndex = 1;
            // 
            // lblMovieGener
            // 
            this.lblMovieGener.AutoSize = true;
            this.lblMovieGener.Location = new System.Drawing.Point(8, 53);
            this.lblMovieGener.Name = "lblMovieGener";
            this.lblMovieGener.Size = new System.Drawing.Size(39, 13);
            this.lblMovieGener.TabIndex = 16;
            this.lblMovieGener.Text = "Gener:";
            // 
            // txtMovieQuantity
            // 
            this.txtMovieQuantity.Location = new System.Drawing.Point(80, 221);
            this.txtMovieQuantity.Name = "txtMovieQuantity";
            this.txtMovieQuantity.Size = new System.Drawing.Size(186, 20);
            this.txtMovieQuantity.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Quantity:";
            // 
            // frmMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(296, 315);
            this.Controls.Add(this.btnMovieCancel);
            this.Controls.Add(this.btnMovieSave);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMovie";
            this.Text = "Add Movie";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMovie_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.Button btnMovieCancel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DateTimePicker dtpMovieReleaseYear;
        private System.Windows.Forms.Label lblMovieReleaseYear;
        private System.Windows.Forms.Label lblMovieLanguage;
        private System.Windows.Forms.Button btnMovieSave;
        private System.Windows.Forms.ComboBox cmbMovieLanguage;
        private System.Windows.Forms.TextBox txtMovieDirector;
        private System.Windows.Forms.Label lblMovieDirector;
        private System.Windows.Forms.TextBox txtMovieActor;
        private System.Windows.Forms.Label lblMovieActor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMoviePrice;
        private System.Windows.Forms.Label lblMoviePrice;
        private System.Windows.Forms.ComboBox cmbMovieGener;
        private System.Windows.Forms.Label lblMovieGener;
        private System.Windows.Forms.TextBox txtMovieQuantity;
        private System.Windows.Forms.Label label3;

    }
}