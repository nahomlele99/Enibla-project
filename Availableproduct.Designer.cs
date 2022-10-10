namespace Enibla_project
{
    partial class Availableproduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Availableproduct));
            this.btnAvaialble = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAvaialble
            // 
            this.btnAvaialble.ActiveBorderThickness = 1;
            this.btnAvaialble.ActiveCornerRadius = 20;
            this.btnAvaialble.ActiveFillColor = System.Drawing.Color.Black;
            this.btnAvaialble.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAvaialble.ActiveLineColor = System.Drawing.Color.Black;
            this.btnAvaialble.BackColor = System.Drawing.Color.Black;
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
            this.btnAvaialble.Location = new System.Drawing.Point(37, 33);
            this.btnAvaialble.Margin = new System.Windows.Forms.Padding(5);
            this.btnAvaialble.Name = "btnAvaialble";
            this.btnAvaialble.Size = new System.Drawing.Size(316, 39);
            this.btnAvaialble.TabIndex = 34;
            this.btnAvaialble.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAvaialble.Click += new System.EventHandler(this.btnAvaialble_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1109, 398);
            this.dataGridView1.TabIndex = 36;
            // 
            // Availableproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1119, 500);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAvaialble);
            this.Name = "Availableproduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Availableproduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 btnAvaialble;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}