namespace RCS
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BTMenu = new System.Windows.Forms.Button();
            this.BTWaiter = new System.Windows.Forms.Button();
            this.BTManager = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTMenu
            // 
            this.BTMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.BTMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTMenu.BackgroundImage")));
            this.BTMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTMenu.Location = new System.Drawing.Point(2, 0);
            this.BTMenu.Name = "BTMenu";
            this.BTMenu.Size = new System.Drawing.Size(240, 240);
            this.BTMenu.TabIndex = 0;
            this.BTMenu.UseVisualStyleBackColor = false;
            this.BTMenu.Click += new System.EventHandler(this.BTMenu_Click);
            // 
            // BTWaiter
            // 
            this.BTWaiter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.BTWaiter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTWaiter.BackgroundImage")));
            this.BTWaiter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTWaiter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTWaiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTWaiter.Location = new System.Drawing.Point(348, 0);
            this.BTWaiter.Name = "BTWaiter";
            this.BTWaiter.Size = new System.Drawing.Size(240, 240);
            this.BTWaiter.TabIndex = 1;
            this.BTWaiter.UseVisualStyleBackColor = false;
            this.BTWaiter.Click += new System.EventHandler(this.BTWaiter_Click);
            // 
            // BTManager
            // 
            this.BTManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.BTManager.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTManager.BackgroundImage")));
            this.BTManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTManager.Location = new System.Drawing.Point(698, 0);
            this.BTManager.Name = "BTManager";
            this.BTManager.Size = new System.Drawing.Size(240, 240);
            this.BTManager.TabIndex = 2;
            this.BTManager.UseVisualStyleBackColor = false;
            this.BTManager.Click += new System.EventHandler(this.BTManager_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(941, 239);
            this.Controls.Add(this.BTManager);
            this.Controls.Add(this.BTWaiter);
            this.Controls.Add(this.BTMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTMenu;
        private System.Windows.Forms.Button BTWaiter;
        private System.Windows.Forms.Button BTManager;
    }
}