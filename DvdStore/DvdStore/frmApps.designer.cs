namespace DvdStore
{
    partial class frmApps
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
            this.txtAppsQuantity = new System.Windows.Forms.TextBox();
            this.lblAppsQuantity = new System.Windows.Forms.Label();
            this.txtAppsPrice = new System.Windows.Forms.TextBox();
            this.lblAppsPrice = new System.Windows.Forms.Label();
            this.cmbAppsType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAppsRequirements = new System.Windows.Forms.TextBox();
            this.txtAppsVersion = new System.Windows.Forms.TextBox();
            this.txtAppsName = new System.Windows.Forms.TextBox();
            this.lblRequrements = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAppsCancel = new System.Windows.Forms.Button();
            this.btnAppsSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAppsQuantity
            // 
            this.txtAppsQuantity.Location = new System.Drawing.Point(58, 136);
            this.txtAppsQuantity.Name = "txtAppsQuantity";
            this.txtAppsQuantity.Size = new System.Drawing.Size(190, 20);
            this.txtAppsQuantity.TabIndex = 4;
            // 
            // lblAppsQuantity
            // 
            this.lblAppsQuantity.AutoSize = true;
            this.lblAppsQuantity.Location = new System.Drawing.Point(9, 138);
            this.lblAppsQuantity.Name = "lblAppsQuantity";
            this.lblAppsQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblAppsQuantity.TabIndex = 16;
            this.lblAppsQuantity.Text = "Quantity:";
            // 
            // txtAppsPrice
            // 
            this.txtAppsPrice.Location = new System.Drawing.Point(58, 107);
            this.txtAppsPrice.Name = "txtAppsPrice";
            this.txtAppsPrice.Size = new System.Drawing.Size(190, 20);
            this.txtAppsPrice.TabIndex = 3;
            // 
            // lblAppsPrice
            // 
            this.lblAppsPrice.AutoSize = true;
            this.lblAppsPrice.Location = new System.Drawing.Point(9, 110);
            this.lblAppsPrice.Name = "lblAppsPrice";
            this.lblAppsPrice.Size = new System.Drawing.Size(34, 13);
            this.lblAppsPrice.TabIndex = 25;
            this.lblAppsPrice.Text = "Price:";
            // 
            // cmbAppsType
            // 
            this.cmbAppsType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbAppsType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAppsType.FormattingEnabled = true;
            this.cmbAppsType.Items.AddRange(new object[] {
            "Application",
            "System",
            "Utility"});
            this.cmbAppsType.Location = new System.Drawing.Point(58, 22);
            this.cmbAppsType.Name = "cmbAppsType";
            this.cmbAppsType.Size = new System.Drawing.Size(190, 21);
            this.cmbAppsType.Sorted = true;
            this.cmbAppsType.TabIndex = 0;
            this.cmbAppsType.Text = "      ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAppsQuantity);
            this.groupBox1.Controls.Add(this.lblAppsQuantity);
            this.groupBox1.Controls.Add(this.txtAppsPrice);
            this.groupBox1.Controls.Add(this.lblAppsPrice);
            this.groupBox1.Controls.Add(this.cmbAppsType);
            this.groupBox1.Controls.Add(this.txtAppsRequirements);
            this.groupBox1.Controls.Add(this.txtAppsVersion);
            this.groupBox1.Controls.Add(this.txtAppsName);
            this.groupBox1.Controls.Add(this.lblRequrements);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(287, 353);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Apps";
            // 
            // txtAppsRequirements
            // 
            this.txtAppsRequirements.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAppsRequirements.Location = new System.Drawing.Point(58, 199);
            this.txtAppsRequirements.MaxLength = 100;
            this.txtAppsRequirements.Multiline = true;
            this.txtAppsRequirements.Name = "txtAppsRequirements";
            this.txtAppsRequirements.Size = new System.Drawing.Size(190, 141);
            this.txtAppsRequirements.TabIndex = 5;
            // 
            // txtAppsVersion
            // 
            this.txtAppsVersion.Location = new System.Drawing.Point(58, 79);
            this.txtAppsVersion.MaxLength = 50;
            this.txtAppsVersion.Name = "txtAppsVersion";
            this.txtAppsVersion.Size = new System.Drawing.Size(190, 20);
            this.txtAppsVersion.TabIndex = 2;
            // 
            // txtAppsName
            // 
            this.txtAppsName.Location = new System.Drawing.Point(58, 50);
            this.txtAppsName.MaxLength = 50;
            this.txtAppsName.Name = "txtAppsName";
            this.txtAppsName.Size = new System.Drawing.Size(190, 20);
            this.txtAppsName.TabIndex = 1;
            // 
            // lblRequrements
            // 
            this.lblRequrements.AutoSize = true;
            this.lblRequrements.Location = new System.Drawing.Point(58, 176);
            this.lblRequrements.Name = "lblRequrements";
            this.lblRequrements.Size = new System.Drawing.Size(75, 13);
            this.lblRequrements.TabIndex = 20;
            this.lblRequrements.Text = "Requirements:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Version:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(9, 53);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Type:";
            // 
            // btnAppsCancel
            // 
            this.btnAppsCancel.Location = new System.Drawing.Point(170, 362);
            this.btnAppsCancel.Name = "btnAppsCancel";
            this.btnAppsCancel.Size = new System.Drawing.Size(75, 25);
            this.btnAppsCancel.TabIndex = 31;
            this.btnAppsCancel.Text = "Cancel";
            this.btnAppsCancel.UseVisualStyleBackColor = true;
            this.btnAppsCancel.Click += new System.EventHandler(this.btnAppsCancel_Click);
            // 
            // btnAppsSave
            // 
            this.btnAppsSave.Location = new System.Drawing.Point(46, 362);
            this.btnAppsSave.Name = "btnAppsSave";
            this.btnAppsSave.Size = new System.Drawing.Size(75, 25);
            this.btnAppsSave.TabIndex = 30;
            this.btnAppsSave.Text = "Save";
            this.btnAppsSave.UseVisualStyleBackColor = true;
            this.btnAppsSave.Click += new System.EventHandler(this.btnAppsSave_Click);
            // 
            // frmApps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(304, 393);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAppsCancel);
            this.Controls.Add(this.btnAppsSave);
            this.Name = "frmApps";
            this.Text = "Add Apps";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmApps_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtAppsQuantity;
        private System.Windows.Forms.Label lblAppsQuantity;
        private System.Windows.Forms.TextBox txtAppsPrice;
        private System.Windows.Forms.Label lblAppsPrice;
        private System.Windows.Forms.ComboBox cmbAppsType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAppsRequirements;
        private System.Windows.Forms.TextBox txtAppsVersion;
        private System.Windows.Forms.TextBox txtAppsName;
        private System.Windows.Forms.Label lblRequrements;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAppsCancel;
        private System.Windows.Forms.Button btnAppsSave;

    }
}