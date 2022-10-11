namespace Enibla_project
{
    partial class Shopping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shopping));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.availablefoodsanddrinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllEquipmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hireDeliveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viaEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viaPhoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.utilitiesToolStripMenuItem,
            this.hireDeliveryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(921, 31);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.availablefoodsanddrinksToolStripMenuItem,
            this.addToolStripMenuItem});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(111, 27);
            this.productsToolStripMenuItem.Text = "Products";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // availablefoodsanddrinksToolStripMenuItem
            // 
            this.availablefoodsanddrinksToolStripMenuItem.Name = "availablefoodsanddrinksToolStripMenuItem";
            this.availablefoodsanddrinksToolStripMenuItem.Size = new System.Drawing.Size(454, 28);
            this.availablefoodsanddrinksToolStripMenuItem.Text = "Available Food and Drink Ingrediates ";
            this.availablefoodsanddrinksToolStripMenuItem.Click += new System.EventHandler(this.availablefoodsanddrinksToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(454, 28);
            this.addToolStripMenuItem.Text = "ADD food and drink Ingrediates";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // utilitiesToolStripMenuItem
            // 
            this.utilitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllEquipmentsToolStripMenuItem});
            this.utilitiesToolStripMenuItem.Name = "utilitiesToolStripMenuItem";
            this.utilitiesToolStripMenuItem.Size = new System.Drawing.Size(103, 27);
            this.utilitiesToolStripMenuItem.Text = "Utilities";
            this.utilitiesToolStripMenuItem.Click += new System.EventHandler(this.utilitiesToolStripMenuItem_Click);
            // 
            // viewAllEquipmentsToolStripMenuItem
            // 
            this.viewAllEquipmentsToolStripMenuItem.Name = "viewAllEquipmentsToolStripMenuItem";
            this.viewAllEquipmentsToolStripMenuItem.Size = new System.Drawing.Size(287, 28);
            this.viewAllEquipmentsToolStripMenuItem.Text = "View All Equipments";
            // 
            // hireDeliveryToolStripMenuItem
            // 
            this.hireDeliveryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viaEmailToolStripMenuItem,
            this.viaPhoneToolStripMenuItem});
            this.hireDeliveryToolStripMenuItem.Name = "hireDeliveryToolStripMenuItem";
            this.hireDeliveryToolStripMenuItem.Size = new System.Drawing.Size(156, 27);
            this.hireDeliveryToolStripMenuItem.Text = "Hire Delivery";
            this.hireDeliveryToolStripMenuItem.Click += new System.EventHandler(this.hireDeliveryToolStripMenuItem_Click);
            // 
            // viaEmailToolStripMenuItem
            // 
            this.viaEmailToolStripMenuItem.Name = "viaEmailToolStripMenuItem";
            this.viaEmailToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.viaEmailToolStripMenuItem.Text = "Via Emial";
            this.viaEmailToolStripMenuItem.Click += new System.EventHandler(this.viaEmailToolStripMenuItem_Click);
            // 
            // viaPhoneToolStripMenuItem
            // 
            this.viaPhoneToolStripMenuItem.Name = "viaPhoneToolStripMenuItem";
            this.viaPhoneToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.viaPhoneToolStripMenuItem.Text = "Via Phone";
            // 
            // Shopping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(921, 450);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Shopping";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hireDeliveryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem availablefoodsanddrinksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllEquipmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viaEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viaPhoneToolStripMenuItem;
    }
}