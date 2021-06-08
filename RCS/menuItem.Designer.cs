namespace RCS
{
    partial class menuItem
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBName = new System.Windows.Forms.Label();
            this.LBPrice = new System.Windows.Forms.Label();
            this.LBCals = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LBName
            // 
            this.LBName.AutoSize = true;
            this.LBName.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBName.ForeColor = System.Drawing.Color.Red;
            this.LBName.Location = new System.Drawing.Point(3, 157);
            this.LBName.Name = "LBName";
            this.LBName.Size = new System.Drawing.Size(0, 25);
            this.LBName.TabIndex = 0;
            this.LBName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBPrice
            // 
            this.LBPrice.AutoSize = true;
            this.LBPrice.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBPrice.ForeColor = System.Drawing.Color.Red;
            this.LBPrice.Location = new System.Drawing.Point(80, 178);
            this.LBPrice.Name = "LBPrice";
            this.LBPrice.Size = new System.Drawing.Size(0, 23);
            this.LBPrice.TabIndex = 1;
            this.LBPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBCals
            // 
            this.LBCals.AutoSize = true;
            this.LBCals.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBCals.ForeColor = System.Drawing.Color.Red;
            this.LBCals.Location = new System.Drawing.Point(3, 182);
            this.LBCals.Name = "LBCals";
            this.LBCals.Size = new System.Drawing.Size(0, 19);
            this.LBCals.TabIndex = 2;
            this.LBCals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // menuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LBCals);
            this.Controls.Add(this.LBPrice);
            this.Controls.Add(this.LBName);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "menuItem";
            this.Size = new System.Drawing.Size(151, 202);
            this.Load += new System.EventHandler(this.menuItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBName;
        private System.Windows.Forms.Label LBPrice;
        private System.Windows.Forms.Label LBCals;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
