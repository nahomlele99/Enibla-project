namespace Enibla_project
{
    partial class DeactivateAccount
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDeactivation = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnNo = new Guna.UI2.WinForms.Guna2Button();
            this.btnYes = new Guna.UI2.WinForms.Guna2Button();
            this.lblDeactivation.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Red;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(76, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(307, 41);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Deactivate Account";
            // 
            // lblDeactivation
            // 
            this.lblDeactivation.Controls.Add(this.guna2HtmlLabel3);
            this.lblDeactivation.Controls.Add(this.btnNo);
            this.lblDeactivation.Controls.Add(this.btnYes);
            this.lblDeactivation.Location = new System.Drawing.Point(12, 47);
            this.lblDeactivation.Name = "lblDeactivation";
            this.lblDeactivation.Size = new System.Drawing.Size(734, 220);
            this.lblDeactivation.TabIndex = 4;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Red;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(0, 3);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(718, 41);
            this.guna2HtmlLabel3.TabIndex = 2;
            this.guna2HtmlLabel3.Text = "Are you Sure You want to Deactivate Account?";
            // 
            // btnNo
            // 
            this.btnNo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnNo.ForeColor = System.Drawing.Color.Black;
            this.btnNo.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNo.Location = new System.Drawing.Point(416, 162);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(180, 45);
            this.btnNo.TabIndex = 1;
            this.btnNo.Text = "No";
            // 
            // btnYes
            // 
            this.btnYes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnYes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnYes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnYes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnYes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnYes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnYes.ForeColor = System.Drawing.Color.Black;
            this.btnYes.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnYes.Location = new System.Drawing.Point(44, 162);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(180, 45);
            this.btnYes.TabIndex = 0;
            this.btnYes.Text = "Yes";
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // DeactivateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(775, 343);
            this.ControlBox = false;
            this.Controls.Add(this.lblDeactivation);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Name = "DeactivateAccount";
            this.lblDeactivation.ResumeLayout(false);
            this.lblDeactivation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel lblDeactivation;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2Button btnNo;
        private Guna.UI2.WinForms.Guna2Button btnYes;
    }
}