namespace easyPokerHUD
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.licenseKeyTextBox = new System.Windows.Forms.TextBox();
            this.licenseKeyStatusLabel = new System.Windows.Forms.Label();
            this.versionNumberLabel = new System.Windows.Forms.Label();
            this.checkLicenseKeyButton = new System.Windows.Forms.Button();
            this.buyMessage = new System.Windows.Forms.Label();
            this.buyButton = new System.Windows.Forms.Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.successMessage = new System.Windows.Forms.Label();
            this.errorMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // licenseKeyTextBox
            // 
            this.licenseKeyTextBox.Location = new System.Drawing.Point(104, 575);
            this.licenseKeyTextBox.Name = "licenseKeyTextBox";
            this.licenseKeyTextBox.Size = new System.Drawing.Size(332, 29);
            this.licenseKeyTextBox.TabIndex = 1;
            this.licenseKeyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // licenseKeyStatusLabel
            // 
            this.licenseKeyStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.licenseKeyStatusLabel.ForeColor = System.Drawing.Color.White;
            this.licenseKeyStatusLabel.Location = new System.Drawing.Point(-2, 520);
            this.licenseKeyStatusLabel.Name = "licenseKeyStatusLabel";
            this.licenseKeyStatusLabel.Size = new System.Drawing.Size(556, 41);
            this.licenseKeyStatusLabel.TabIndex = 2;
            this.licenseKeyStatusLabel.Text = "Already have a license key?";
            this.licenseKeyStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // versionNumberLabel
            // 
            this.versionNumberLabel.AutoSize = true;
            this.versionNumberLabel.ForeColor = System.Drawing.Color.White;
            this.versionNumberLabel.Location = new System.Drawing.Point(14, 937);
            this.versionNumberLabel.Name = "versionNumberLabel";
            this.versionNumberLabel.Size = new System.Drawing.Size(144, 25);
            this.versionNumberLabel.TabIndex = 3;
            this.versionNumberLabel.Text = "versionNumber";
            this.versionNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkLicenseKeyButton
            // 
            this.checkLicenseKeyButton.AutoSize = true;
            this.checkLicenseKeyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            this.checkLicenseKeyButton.FlatAppearance.BorderSize = 0;
            this.checkLicenseKeyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkLicenseKeyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.checkLicenseKeyButton.ForeColor = System.Drawing.Color.White;
            this.checkLicenseKeyButton.Location = new System.Drawing.Point(163, 624);
            this.checkLicenseKeyButton.Name = "checkLicenseKeyButton";
            this.checkLicenseKeyButton.Size = new System.Drawing.Size(223, 43);
            this.checkLicenseKeyButton.TabIndex = 4;
            this.checkLicenseKeyButton.Text = "Unlock all features";
            this.checkLicenseKeyButton.UseVisualStyleBackColor = false;
            this.checkLicenseKeyButton.Click += new System.EventHandler(this.checkLicenseKeyButton_Click);
            // 
            // buyMessage
            // 
            this.buyMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.buyMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buyMessage.ForeColor = System.Drawing.Color.White;
            this.buyMessage.Location = new System.Drawing.Point(19, 282);
            this.buyMessage.Name = "buyMessage";
            this.buyMessage.Size = new System.Drawing.Size(525, 185);
            this.buyMessage.TabIndex = 7;
            this.buyMessage.Text = "Want more features? Unlock the pro version!\r\n\r\n\r\n";
            this.buyMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buyButton
            // 
            this.buyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(75)))), ((int)(((byte)(97)))));
            this.buyButton.FlatAppearance.BorderSize = 0;
            this.buyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buyButton.ForeColor = System.Drawing.Color.White;
            this.buyButton.Location = new System.Drawing.Point(185, 398);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(169, 44);
            this.buyButton.TabIndex = 8;
            this.buyButton.Text = "$19.99";
            this.buyButton.UseVisualStyleBackColor = false;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::easyPokerHUD.Properties.Resources.Logo_weiß_easyPokerHUD;
            this.logoPictureBox.InitialImage = null;
            this.logoPictureBox.Location = new System.Drawing.Point(92, 72);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(380, 170);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 6;
            this.logoPictureBox.TabStop = false;
            // 
            // successMessage
            // 
            this.successMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.successMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.successMessage.Location = new System.Drawing.Point(3, 713);
            this.successMessage.Name = "successMessage";
            this.successMessage.Size = new System.Drawing.Size(551, 90);
            this.successMessage.TabIndex = 10;
            this.successMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorMessage
            // 
            this.errorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.errorMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.errorMessage.Location = new System.Drawing.Point(3, 803);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(551, 98);
            this.errorMessage.TabIndex = 11;
            this.errorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(558, 985);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.successMessage);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.buyMessage);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.checkLicenseKeyButton);
            this.Controls.Add(this.versionNumberLabel);
            this.Controls.Add(this.licenseKeyStatusLabel);
            this.Controls.Add(this.licenseKeyTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "easyPokerHUD";
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox licenseKeyTextBox;
        private System.Windows.Forms.Label licenseKeyStatusLabel;
        private System.Windows.Forms.Label versionNumberLabel;
        private System.Windows.Forms.Button checkLicenseKeyButton;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label buyMessage;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Label successMessage;
        private System.Windows.Forms.Label errorMessage;
    }
}