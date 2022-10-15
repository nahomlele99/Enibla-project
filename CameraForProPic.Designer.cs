namespace Enibla_project
{
    partial class CameraForProPic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CameraForProPic));
            this.Save = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NameText = new Enibla_project.KGTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.ActiveBorderThickness = 1;
            this.Save.ActiveCornerRadius = 20;
            this.Save.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Save.ActiveForecolor = System.Drawing.Color.White;
            this.Save.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Save.BackColor = System.Drawing.Color.White;
            this.Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Save.BackgroundImage")));
            this.Save.ButtonText = "Capture";
            this.Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.SeaGreen;
            this.Save.IdleBorderThickness = 1;
            this.Save.IdleCornerRadius = 20;
            this.Save.IdleFillColor = System.Drawing.Color.White;
            this.Save.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Save.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Save.Location = new System.Drawing.Point(638, 41);
            this.Save.Margin = new System.Windows.Forms.Padding(5);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(181, 48);
            this.Save.TabIndex = 1;
            this.Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "Quit";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.Location = new System.Drawing.Point(657, 119);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(149, 56);
            this.bunifuThinButton23.TabIndex = 2;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(51, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(536, 352);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(634, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(634, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Selected Product:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(638, 310);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(638, 369);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(181, 21);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(634, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cam Resolution";
            // 
            // NameText
            // 
            this.NameText.BackColor = System.Drawing.SystemColors.Window;
            this.NameText.BorderColor = System.Drawing.Color.Gray;
            this.NameText.BorderFocusColor = System.Drawing.Color.White;
            this.NameText.BorderRadius = 8;
            this.NameText.BorderSize = 1;
            this.NameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameText.ForeColor = System.Drawing.Color.DimGray;
            this.NameText.Location = new System.Drawing.Point(638, 244);
            this.NameText.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.NameText.Multiline = false;
            this.NameText.Name = "NameText";
            this.NameText.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.NameText.PasswordChar = false;
            this.NameText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.NameText.PlaceholderText = "";
            this.NameText.Size = new System.Drawing.Size(181, 29);
            this.NameText.TabIndex = 4;
            this.NameText.Texts = "";
            this.NameText.UnderlinedStyle = false;
            // 
            // CameraForProPic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(853, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuThinButton23);
            this.Controls.Add(this.Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CameraForProPic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 Save;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private System.Windows.Forms.PictureBox pictureBox1;
        private KGTextBox NameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
    }
}