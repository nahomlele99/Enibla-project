namespace Enibla_project
{
    partial class AvailableProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvailableProduct));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAvaialble = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1109, 398);
            this.dataGridView1.TabIndex = 38;
            // 
            // btnAvaialble
            // 
            this.btnAvaialble.ActiveBorderThickness = 1;
            this.btnAvaialble.ActiveCornerRadius = 20;
            this.btnAvaialble.ActiveFillColor = System.Drawing.Color.Black;
            this.btnAvaialble.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAvaialble.ActiveLineColor = System.Drawing.Color.Black;
            this.btnAvaialble.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAvaialble.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAvaialble.BackgroundImage")));
            this.btnAvaialble.ButtonText = "Ingrediates Available";
            this.btnAvaialble.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAvaialble.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvaialble.ForeColor = System.Drawing.Color.Black;
            this.btnAvaialble.IdleBorderThickness = 1;
            this.btnAvaialble.IdleCornerRadius = 20;
            this.btnAvaialble.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAvaialble.IdleForecolor = System.Drawing.Color.Black;
            this.btnAvaialble.IdleLineColor = System.Drawing.Color.Black;
            this.btnAvaialble.Location = new System.Drawing.Point(14, 14);
            this.btnAvaialble.Margin = new System.Windows.Forms.Padding(5);
            this.btnAvaialble.Name = "btnAvaialble";
            this.btnAvaialble.Size = new System.Drawing.Size(316, 39);
            this.btnAvaialble.TabIndex = 37;
            this.btnAvaialble.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AvailableProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1123, 450);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAvaialble);
            this.Name = "AvailableProduct";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAvaialble;
    }
}