namespace Enibla_project
{
    partial class RandomHotelHome
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandomHotelHome));
            this.SPLogo = new System.Windows.Forms.PictureBox();
            this.SPName = new System.Windows.Forms.Label();
            this.SPAddress = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.distancelabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SPLocation = new System.Windows.Forms.WebBrowser();
            this.randomHome1 = new Enibla_project.RandomHome();
            ((System.ComponentModel.ISupportInitialize)(this.SPLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // SPLogo
            // 
            this.SPLogo.Image = ((System.Drawing.Image)(resources.GetObject("SPLogo.Image")));
            this.SPLogo.Location = new System.Drawing.Point(513, 48);
            this.SPLogo.Name = "SPLogo";
            this.SPLogo.Size = new System.Drawing.Size(130, 132);
            this.SPLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SPLogo.TabIndex = 2;
            this.SPLogo.TabStop = false;
            // 
            // SPName
            // 
            this.SPName.AutoSize = true;
            this.SPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SPName.Location = new System.Drawing.Point(477, 197);
            this.SPName.Name = "SPName";
            this.SPName.Size = new System.Drawing.Size(188, 24);
            this.SPName.TabIndex = 3;
            this.SPName.Text = "Sheraton Addis Hotel";
            // 
            // SPAddress
            // 
            this.SPAddress.AutoSize = true;
            this.SPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(151)))), ((int)(((byte)(31)))));
            this.SPAddress.Location = new System.Drawing.Point(477, 418);
            this.SPAddress.Name = "SPAddress";
            this.SPAddress.Size = new System.Drawing.Size(207, 20);
            this.SPAddress.TabIndex = 4;
            this.SPAddress.Text = " Taitu St, Addis Ababa 1000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(510, 475);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "The Delivery will arrive in:";
            // 
            // distancelabel
            // 
            this.distancelabel.AutoSize = true;
            this.distancelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distancelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(151)))), ((int)(((byte)(31)))));
            this.distancelabel.Location = new System.Drawing.Point(537, 450);
            this.distancelabel.Name = "distancelabel";
            this.distancelabel.Size = new System.Drawing.Size(106, 25);
            this.distancelabel.TabIndex = 6;
            this.distancelabel.Text = "~13.5  km";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(151)))), ((int)(((byte)(31)))));
            this.label3.Location = new System.Drawing.Point(553, 506);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "~15 min";
            // 
            // SPLocation
            // 
            this.SPLocation.Location = new System.Drawing.Point(439, 233);
            this.SPLocation.MinimumSize = new System.Drawing.Size(20, 20);
            this.SPLocation.Name = "SPLocation";
            this.SPLocation.Size = new System.Drawing.Size(294, 160);
            this.SPLocation.TabIndex = 10;
            this.SPLocation.Url = new System.Uri(resources.GetString("SPLocation.Url"), System.UriKind.Absolute);
            // 
            // randomHome1
            // 
            this.randomHome1.BackColor = System.Drawing.Color.White;
            this.randomHome1.Location = new System.Drawing.Point(85, 0);
            this.randomHome1.Name = "randomHome1";
            this.randomHome1.Size = new System.Drawing.Size(281, 653);
            this.randomHome1.TabIndex = 0;
            // 
            // RandomHotelHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.SPLocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.distancelabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SPAddress);
            this.Controls.Add(this.SPName);
            this.Controls.Add(this.SPLogo);
            this.Controls.Add(this.randomHome1);
            this.DoubleBuffered = true;
            this.Name = "RandomHotelHome";
            this.Size = new System.Drawing.Size(871, 653);
            ((System.ComponentModel.ISupportInitialize)(this.SPLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RandomHome randomHome1;
        private System.Windows.Forms.PictureBox SPLogo;
        private System.Windows.Forms.Label SPName;
        private System.Windows.Forms.Label SPAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label distancelabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.WebBrowser SPLocation;
    }
}
