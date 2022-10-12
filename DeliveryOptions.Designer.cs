namespace Enibla_project
{
    partial class DeliveryOptions
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryOptions));
            this.pictureDelivery = new System.Windows.Forms.PictureBox();
            this.pnlDelivery = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCmpName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDeliveryType = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtRastName = new Enibla_project.KGTextBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.cmboCountry = new System.Windows.Forms.ComboBox();
            this.cmboType = new System.Windows.Forms.ComboBox();
            this.lblphone = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmboproducttype = new System.Windows.Forms.ComboBox();
            this.txtphone = new Enibla_project.KGTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDelivery)).BeginInit();
            this.pnlDelivery.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureDelivery
            // 
            this.pictureDelivery.Image = ((System.Drawing.Image)(resources.GetObject("pictureDelivery.Image")));
            this.pictureDelivery.Location = new System.Drawing.Point(342, -1);
            this.pictureDelivery.Name = "pictureDelivery";
            this.pictureDelivery.Size = new System.Drawing.Size(828, 453);
            this.pictureDelivery.TabIndex = 0;
            this.pictureDelivery.TabStop = false;
            // 
            // pnlDelivery
            // 
            this.pnlDelivery.Controls.Add(this.txtphone);
            this.pnlDelivery.Controls.Add(this.cmboproducttype);
            this.pnlDelivery.Controls.Add(this.label2);
            this.pnlDelivery.Controls.Add(this.lblphone);
            this.pnlDelivery.Controls.Add(this.cmboType);
            this.pnlDelivery.Controls.Add(this.cmboCountry);
            this.pnlDelivery.Controls.Add(this.txtRastName);
            this.pnlDelivery.Controls.Add(this.button2);
            this.pnlDelivery.Controls.Add(this.button1);
            this.pnlDelivery.Controls.Add(this.lblDeliveryType);
            this.pnlDelivery.Controls.Add(this.label6);
            this.pnlDelivery.Controls.Add(this.label5);
            this.pnlDelivery.Controls.Add(this.label3);
            this.pnlDelivery.Controls.Add(this.lblCmpName);
            this.pnlDelivery.Controls.Add(this.label1);
            this.pnlDelivery.Location = new System.Drawing.Point(0, -1);
            this.pnlDelivery.Name = "pnlDelivery";
            this.pnlDelivery.Size = new System.Drawing.Size(345, 453);
            this.pnlDelivery.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delivery Menu";
            // 
            // lblCmpName
            // 
            this.lblCmpName.AutoSize = true;
            this.lblCmpName.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCmpName.ForeColor = System.Drawing.Color.Gray;
            this.lblCmpName.Location = new System.Drawing.Point(6, 81);
            this.lblCmpName.Name = "lblCmpName";
            this.lblCmpName.Size = new System.Drawing.Size(172, 25);
            this.lblCmpName.TabIndex = 1;
            this.lblCmpName.Text = "Restaurant Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(7, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Country";
            // 
            // lblDeliveryType
            // 
            this.lblDeliveryType.AutoSize = true;
            this.lblDeliveryType.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryType.ForeColor = System.Drawing.Color.Gray;
            this.lblDeliveryType.Location = new System.Drawing.Point(6, 143);
            this.lblDeliveryType.Name = "lblDeliveryType";
            this.lblDeliveryType.Size = new System.Drawing.Size(111, 21);
            this.lblDeliveryType.TabIndex = 6;
            this.lblDeliveryType.Text = "Delivery Type";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 64);
            this.button1.TabIndex = 7;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(189, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 64);
            this.button2.TabIndex = 8;
            this.button2.Text = "Return";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtRastName
            // 
            this.txtRastName.BackColor = System.Drawing.SystemColors.Window;
            this.txtRastName.BorderColor = System.Drawing.Color.Orange;
            this.txtRastName.BorderFocusColor = System.Drawing.Color.White;
            this.txtRastName.BorderRadius = 0;
            this.txtRastName.BorderSize = 2;
            this.txtRastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRastName.ForeColor = System.Drawing.Color.DimGray;
            this.txtRastName.Location = new System.Drawing.Point(189, 81);
            this.txtRastName.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtRastName.Multiline = false;
            this.txtRastName.Name = "txtRastName";
            this.txtRastName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtRastName.PasswordChar = false;
            this.txtRastName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtRastName.PlaceholderText = "";
            this.txtRastName.Size = new System.Drawing.Size(151, 29);
            this.txtRastName.TabIndex = 9;
            this.txtRastName.Texts = "";
            this.txtRastName.UnderlinedStyle = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // cmboCountry
            // 
            this.cmboCountry.FormattingEnabled = true;
            this.cmboCountry.Location = new System.Drawing.Point(132, 199);
            this.cmboCountry.Name = "cmboCountry";
            this.cmboCountry.Size = new System.Drawing.Size(121, 21);
            this.cmboCountry.TabIndex = 11;
            this.cmboCountry.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmboType
            // 
            this.cmboType.FormattingEnabled = true;
            this.cmboType.Items.AddRange(new object[] {
            "Uber",
            "Airplane Package",
            "Train"});
            this.cmboType.Location = new System.Drawing.Point(132, 146);
            this.cmboType.Name = "cmboType";
            this.cmboType.Size = new System.Drawing.Size(121, 21);
            this.cmboType.TabIndex = 12;
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphone.ForeColor = System.Drawing.Color.Gray;
            this.lblphone.Location = new System.Drawing.Point(12, 258);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(124, 21);
            this.lblphone.TabIndex = 13;
            this.lblphone.Text = "Contact Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(12, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Delivery Product";
            // 
            // cmboproducttype
            // 
            this.cmboproducttype.FormattingEnabled = true;
            this.cmboproducttype.Items.AddRange(new object[] {
            "Uber",
            "Airplane Package",
            "Train"});
            this.cmboproducttype.Location = new System.Drawing.Point(171, 315);
            this.cmboproducttype.Name = "cmboproducttype";
            this.cmboproducttype.Size = new System.Drawing.Size(121, 21);
            this.cmboproducttype.TabIndex = 15;
            // 
            // txtphone
            // 
            this.txtphone.BackColor = System.Drawing.SystemColors.Window;
            this.txtphone.BorderColor = System.Drawing.Color.Orange;
            this.txtphone.BorderFocusColor = System.Drawing.Color.White;
            this.txtphone.BorderRadius = 0;
            this.txtphone.BorderSize = 2;
            this.txtphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.ForeColor = System.Drawing.Color.DimGray;
            this.txtphone.Location = new System.Drawing.Point(144, 258);
            this.txtphone.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtphone.Multiline = false;
            this.txtphone.Name = "txtphone";
            this.txtphone.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtphone.PasswordChar = false;
            this.txtphone.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtphone.PlaceholderText = "";
            this.txtphone.Size = new System.Drawing.Size(151, 29);
            this.txtphone.TabIndex = 16;
            this.txtphone.Texts = "";
            this.txtphone.UnderlinedStyle = false;
            // 
            // DeliveryOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1168, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pnlDelivery);
            this.Controls.Add(this.pictureDelivery);
            this.Name = "DeliveryOptions";
            this.Load += new System.EventHandler(this.DeliveryOptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureDelivery)).EndInit();
            this.pnlDelivery.ResumeLayout(false);
            this.pnlDelivery.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureDelivery;
        private System.Windows.Forms.Panel pnlDelivery;
        private System.Windows.Forms.Label lblDeliveryType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCmpName;
        private System.Windows.Forms.Label label1;
        private KGTextBox txtRastName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.ComboBox cmboCountry;
        private System.Windows.Forms.ComboBox cmboType;
        private KGTextBox txtphone;
        private System.Windows.Forms.ComboBox cmboproducttype;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblphone;
    }
}