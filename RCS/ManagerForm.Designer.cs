namespace RCS
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTGiftCard = new System.Windows.Forms.Button();
            this.BTSales = new System.Windows.Forms.Button();
            this.BTInventory = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BTMenu = new System.Windows.Forms.Button();
            this.BTTable = new System.Windows.Forms.Button();
            this.BTSuppliers = new System.Windows.Forms.Button();
            this.BTWorkHours = new System.Windows.Forms.Button();
            this.BTEmployee = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.BTGiftCard);
            this.panel1.Controls.Add(this.BTSales);
            this.panel1.Controls.Add(this.BTInventory);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.BTMenu);
            this.panel1.Controls.Add(this.BTTable);
            this.panel1.Controls.Add(this.BTSuppliers);
            this.panel1.Controls.Add(this.BTWorkHours);
            this.panel1.Controls.Add(this.BTEmployee);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 678);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 77);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // BTGiftCard
            // 
            this.BTGiftCard.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTGiftCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTGiftCard.Image = ((System.Drawing.Image)(resources.GetObject("BTGiftCard.Image")));
            this.BTGiftCard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTGiftCard.Location = new System.Drawing.Point(20, 549);
            this.BTGiftCard.Name = "BTGiftCard";
            this.BTGiftCard.Size = new System.Drawing.Size(188, 64);
            this.BTGiftCard.TabIndex = 7;
            this.BTGiftCard.Text = "GIFT CARD";
            this.BTGiftCard.UseVisualStyleBackColor = false;
            this.BTGiftCard.Click += new System.EventHandler(this.BTGiftCard_Click);
            // 
            // BTSales
            // 
            this.BTSales.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTSales.Image = ((System.Drawing.Image)(resources.GetObject("BTSales.Image")));
            this.BTSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTSales.Location = new System.Drawing.Point(20, 484);
            this.BTSales.Name = "BTSales";
            this.BTSales.Size = new System.Drawing.Size(188, 64);
            this.BTSales.TabIndex = 6;
            this.BTSales.Text = "SALES";
            this.BTSales.UseVisualStyleBackColor = false;
            this.BTSales.Click += new System.EventHandler(this.BTSales_Click);
            // 
            // BTInventory
            // 
            this.BTInventory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTInventory.Image = ((System.Drawing.Image)(resources.GetObject("BTInventory.Image")));
            this.BTInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTInventory.Location = new System.Drawing.Point(20, 419);
            this.BTInventory.Name = "BTInventory";
            this.BTInventory.Size = new System.Drawing.Size(188, 64);
            this.BTInventory.TabIndex = 5;
            this.BTInventory.Text = "INVENTORY";
            this.BTInventory.UseVisualStyleBackColor = false;
            this.BTInventory.Click += new System.EventHandler(this.BTInventory_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Fuchsia;
            this.panel3.Location = new System.Drawing.Point(2, 94);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(17, 64);
            this.panel3.TabIndex = 0;
            // 
            // BTMenu
            // 
            this.BTMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTMenu.Image = ((System.Drawing.Image)(resources.GetObject("BTMenu.Image")));
            this.BTMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTMenu.Location = new System.Drawing.Point(20, 354);
            this.BTMenu.Name = "BTMenu";
            this.BTMenu.Size = new System.Drawing.Size(188, 64);
            this.BTMenu.TabIndex = 4;
            this.BTMenu.Text = "MENU";
            this.BTMenu.UseVisualStyleBackColor = false;
            this.BTMenu.Click += new System.EventHandler(this.BTMenu_Click);
            // 
            // BTTable
            // 
            this.BTTable.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTTable.Image = ((System.Drawing.Image)(resources.GetObject("BTTable.Image")));
            this.BTTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTTable.Location = new System.Drawing.Point(20, 289);
            this.BTTable.Name = "BTTable";
            this.BTTable.Size = new System.Drawing.Size(188, 64);
            this.BTTable.TabIndex = 3;
            this.BTTable.Text = "TABLE";
            this.BTTable.UseVisualStyleBackColor = false;
            this.BTTable.Click += new System.EventHandler(this.BTTable_Click);
            // 
            // BTSuppliers
            // 
            this.BTSuppliers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTSuppliers.Image = ((System.Drawing.Image)(resources.GetObject("BTSuppliers.Image")));
            this.BTSuppliers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTSuppliers.Location = new System.Drawing.Point(20, 224);
            this.BTSuppliers.Name = "BTSuppliers";
            this.BTSuppliers.Size = new System.Drawing.Size(188, 64);
            this.BTSuppliers.TabIndex = 2;
            this.BTSuppliers.Text = "SUPPLIERS";
            this.BTSuppliers.UseVisualStyleBackColor = false;
            this.BTSuppliers.Click += new System.EventHandler(this.BTSuppliers_Click);
            // 
            // BTWorkHours
            // 
            this.BTWorkHours.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTWorkHours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTWorkHours.Image = ((System.Drawing.Image)(resources.GetObject("BTWorkHours.Image")));
            this.BTWorkHours.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTWorkHours.Location = new System.Drawing.Point(20, 159);
            this.BTWorkHours.Name = "BTWorkHours";
            this.BTWorkHours.Size = new System.Drawing.Size(188, 64);
            this.BTWorkHours.TabIndex = 1;
            this.BTWorkHours.Text = "WORK HOURS";
            this.BTWorkHours.UseVisualStyleBackColor = false;
            this.BTWorkHours.Click += new System.EventHandler(this.BTWorkHours_Click);
            // 
            // BTEmployee
            // 
            this.BTEmployee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTEmployee.Image = ((System.Drawing.Image)(resources.GetObject("BTEmployee.Image")));
            this.BTEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTEmployee.Location = new System.Drawing.Point(20, 94);
            this.BTEmployee.Name = "BTEmployee";
            this.BTEmployee.Size = new System.Drawing.Size(188, 64);
            this.BTEmployee.TabIndex = 0;
            this.BTEmployee.Text = "EMPLOYEE";
            this.BTEmployee.UseVisualStyleBackColor = false;
            this.BTEmployee.Click += new System.EventHandler(this.BTEmployee_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(209, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1055, 678);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MANAGER MENU";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTMenu;
        private System.Windows.Forms.Button BTTable;
        private System.Windows.Forms.Button BTSuppliers;
        private System.Windows.Forms.Button BTWorkHours;
        private System.Windows.Forms.Button BTEmployee;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BTGiftCard;
        private System.Windows.Forms.Button BTSales;
        private System.Windows.Forms.Button BTInventory;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}