namespace DvdStore
{
    partial class frmGames
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGameQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGamePrice = new System.Windows.Forms.TextBox();
            this.lblGamePrice = new System.Windows.Forms.Label();
            this.cmbGameType = new System.Windows.Forms.ComboBox();
            this.txtGameRequirements = new System.Windows.Forms.TextBox();
            this.txtGameName = new System.Windows.Forms.TextBox();
            this.lblRequirements = new System.Windows.Forms.Label();
            this.lblGameName = new System.Windows.Forms.Label();
            this.lblGameType = new System.Windows.Forms.Label();
            this.btnGameSave = new System.Windows.Forms.Button();
            this.btnGameCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGameQuantity);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtGamePrice);
            this.groupBox1.Controls.Add(this.lblGamePrice);
            this.groupBox1.Controls.Add(this.cmbGameType);
            this.groupBox1.Controls.Add(this.txtGameRequirements);
            this.groupBox1.Controls.Add(this.txtGameName);
            this.groupBox1.Controls.Add(this.lblRequirements);
            this.groupBox1.Controls.Add(this.lblGameName);
            this.groupBox1.Controls.Add(this.lblGameType);
            this.groupBox1.Location = new System.Drawing.Point(6, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(256, 322);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Games";
            // 
            // txtGameQuantity
            // 
            this.txtGameQuantity.Location = new System.Drawing.Point(55, 106);
            this.txtGameQuantity.Name = "txtGameQuantity";
            this.txtGameQuantity.Size = new System.Drawing.Size(189, 20);
            this.txtGameQuantity.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Quantity:";
            // 
            // txtGamePrice
            // 
            this.txtGamePrice.Location = new System.Drawing.Point(55, 78);
            this.txtGamePrice.Name = "txtGamePrice";
            this.txtGamePrice.Size = new System.Drawing.Size(190, 20);
            this.txtGamePrice.TabIndex = 2;
            // 
            // lblGamePrice
            // 
            this.lblGamePrice.AutoSize = true;
            this.lblGamePrice.Location = new System.Drawing.Point(6, 80);
            this.lblGamePrice.Name = "lblGamePrice";
            this.lblGamePrice.Size = new System.Drawing.Size(34, 13);
            this.lblGamePrice.TabIndex = 24;
            this.lblGamePrice.Text = "Price:";
            // 
            // cmbGameType
            // 
            this.cmbGameType.FormattingEnabled = true;
            this.cmbGameType.Location = new System.Drawing.Point(55, 21);
            this.cmbGameType.Name = "cmbGameType";
            this.cmbGameType.Size = new System.Drawing.Size(190, 21);
            this.cmbGameType.Sorted = true;
            this.cmbGameType.TabIndex = 0;
            // 
            // txtGameRequirements
            // 
            this.txtGameRequirements.Location = new System.Drawing.Point(54, 168);
            this.txtGameRequirements.MaxLength = 100;
            this.txtGameRequirements.Multiline = true;
            this.txtGameRequirements.Name = "txtGameRequirements";
            this.txtGameRequirements.Size = new System.Drawing.Size(190, 141);
            this.txtGameRequirements.TabIndex = 4;
            // 
            // txtGameName
            // 
            this.txtGameName.Location = new System.Drawing.Point(55, 50);
            this.txtGameName.MaxLength = 50;
            this.txtGameName.Name = "txtGameName";
            this.txtGameName.Size = new System.Drawing.Size(189, 20);
            this.txtGameName.TabIndex = 1;
            // 
            // lblRequirements
            // 
            this.lblRequirements.AutoSize = true;
            this.lblRequirements.Location = new System.Drawing.Point(52, 151);
            this.lblRequirements.Name = "lblRequirements";
            this.lblRequirements.Size = new System.Drawing.Size(75, 13);
            this.lblRequirements.TabIndex = 17;
            this.lblRequirements.Text = "Requirements:";
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.Location = new System.Drawing.Point(6, 52);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(38, 13);
            this.lblGameName.TabIndex = 15;
            this.lblGameName.Text = "Name:";
            // 
            // lblGameType
            // 
            this.lblGameType.AutoSize = true;
            this.lblGameType.Location = new System.Drawing.Point(6, 24);
            this.lblGameType.Name = "lblGameType";
            this.lblGameType.Size = new System.Drawing.Size(34, 13);
            this.lblGameType.TabIndex = 14;
            this.lblGameType.Text = "Type:";
            // 
            // btnGameSave
            // 
            this.btnGameSave.Location = new System.Drawing.Point(31, 328);
            this.btnGameSave.Name = "btnGameSave";
            this.btnGameSave.Size = new System.Drawing.Size(75, 25);
            this.btnGameSave.TabIndex = 31;
            this.btnGameSave.Text = "Save";
            this.btnGameSave.UseVisualStyleBackColor = true;
            this.btnGameSave.Click += new System.EventHandler(this.btnGameSave_Click);
            // 
            // btnGameCancel
            // 
            this.btnGameCancel.Location = new System.Drawing.Point(166, 328);
            this.btnGameCancel.Name = "btnGameCancel";
            this.btnGameCancel.Size = new System.Drawing.Size(75, 25);
            this.btnGameCancel.TabIndex = 32;
            this.btnGameCancel.Text = "Cancel";
            this.btnGameCancel.UseVisualStyleBackColor = true;
            this.btnGameCancel.Click += new System.EventHandler(this.btnGameCancel_Click);
            // 
            // frmGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(270, 363);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGameSave);
            this.Controls.Add(this.btnGameCancel);
            this.Name = "frmGames";
            this.Text = "Add Games";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGames_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGameQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGamePrice;
        private System.Windows.Forms.Label lblGamePrice;
        private System.Windows.Forms.ComboBox cmbGameType;
        private System.Windows.Forms.TextBox txtGameRequirements;
        private System.Windows.Forms.TextBox txtGameName;
        private System.Windows.Forms.Label lblRequirements;
        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.Label lblGameType;
        private System.Windows.Forms.Button btnGameSave;
        private System.Windows.Forms.Button btnGameCancel;

    }
}