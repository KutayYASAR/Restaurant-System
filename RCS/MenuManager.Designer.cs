namespace RCS
{
    partial class MenuManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuManager));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TBMName = new System.Windows.Forms.TextBox();
            this.TBMCost = new System.Windows.Forms.TextBox();
            this.TBMPrice = new System.Windows.Forms.TextBox();
            this.TBMNut = new System.Windows.Forms.TextBox();
            this.TBMAllergy = new System.Windows.Forms.TextBox();
            this.TBMAvailable = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.BTRemove = new System.Windows.Forms.Button();
            this.BTUpdate = new System.Windows.Forms.Button();
            this.TBMCategory = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_create_pdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(726, 678);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // TBMName
            // 
            this.TBMName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBMName.Location = new System.Drawing.Point(771, 29);
            this.TBMName.Name = "TBMName";
            this.TBMName.Size = new System.Drawing.Size(106, 26);
            this.TBMName.TabIndex = 1;
            // 
            // TBMCost
            // 
            this.TBMCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBMCost.Location = new System.Drawing.Point(904, 29);
            this.TBMCost.Name = "TBMCost";
            this.TBMCost.Size = new System.Drawing.Size(106, 26);
            this.TBMCost.TabIndex = 2;
            // 
            // TBMPrice
            // 
            this.TBMPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBMPrice.Location = new System.Drawing.Point(771, 88);
            this.TBMPrice.Name = "TBMPrice";
            this.TBMPrice.Size = new System.Drawing.Size(106, 26);
            this.TBMPrice.TabIndex = 3;
            // 
            // TBMNut
            // 
            this.TBMNut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBMNut.Location = new System.Drawing.Point(904, 88);
            this.TBMNut.Name = "TBMNut";
            this.TBMNut.Size = new System.Drawing.Size(106, 26);
            this.TBMNut.TabIndex = 4;
            // 
            // TBMAllergy
            // 
            this.TBMAllergy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBMAllergy.Location = new System.Drawing.Point(771, 153);
            this.TBMAllergy.Name = "TBMAllergy";
            this.TBMAllergy.Size = new System.Drawing.Size(106, 26);
            this.TBMAllergy.TabIndex = 5;
            // 
            // TBMAvailable
            // 
            this.TBMAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBMAvailable.Location = new System.Drawing.Point(904, 153);
            this.TBMAvailable.Name = "TBMAvailable";
            this.TBMAvailable.Size = new System.Drawing.Size(106, 26);
            this.TBMAvailable.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(904, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 53);
            this.button1.TabIndex = 7;
            this.button1.Text = "Browse";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(771, 275);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(770, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(903, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(770, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(904, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nutritions";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(767, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Allergics";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(903, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Available";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(923, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Choose Image";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(755, 504);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 58);
            this.button2.TabIndex = 16;
            this.button2.Text = "          SAVE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTRemove
            // 
            this.BTRemove.BackColor = System.Drawing.Color.Red;
            this.BTRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTRemove.ForeColor = System.Drawing.Color.White;
            this.BTRemove.Image = ((System.Drawing.Image)(resources.GetObject("BTRemove.Image")));
            this.BTRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTRemove.Location = new System.Drawing.Point(823, 568);
            this.BTRemove.Name = "BTRemove";
            this.BTRemove.Size = new System.Drawing.Size(141, 58);
            this.BTRemove.TabIndex = 17;
            this.BTRemove.Text = "REMOVE";
            this.BTRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTRemove.UseVisualStyleBackColor = false;
            this.BTRemove.Click += new System.EventHandler(this.BTRemove_Click);
            // 
            // BTUpdate
            // 
            this.BTUpdate.BackColor = System.Drawing.Color.Lime;
            this.BTUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTUpdate.Image = ((System.Drawing.Image)(resources.GetObject("BTUpdate.Image")));
            this.BTUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTUpdate.Location = new System.Drawing.Point(902, 504);
            this.BTUpdate.Name = "BTUpdate";
            this.BTUpdate.Size = new System.Drawing.Size(139, 58);
            this.BTUpdate.TabIndex = 18;
            this.BTUpdate.Text = "UPDATE";
            this.BTUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTUpdate.UseVisualStyleBackColor = false;
            this.BTUpdate.Click += new System.EventHandler(this.BTUpdate_Click);
            // 
            // TBMCategory
            // 
            this.TBMCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBMCategory.Location = new System.Drawing.Point(771, 219);
            this.TBMCategory.Name = "TBMCategory";
            this.TBMCategory.Size = new System.Drawing.Size(106, 26);
            this.TBMCategory.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(770, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Category";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(757, 275);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(14, 198);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(1010, 275);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(14, 198);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(757, 260);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 15);
            this.panel3.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(757, 473);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(267, 15);
            this.panel4.TabIndex = 24;
            // 
            // button_create_pdf
            // 
            this.button_create_pdf.Image = ((System.Drawing.Image)(resources.GetObject("button_create_pdf.Image")));
            this.button_create_pdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_create_pdf.Location = new System.Drawing.Point(829, 632);
            this.button_create_pdf.Name = "button_create_pdf";
            this.button_create_pdf.Size = new System.Drawing.Size(123, 38);
            this.button_create_pdf.TabIndex = 32;
            this.button_create_pdf.Text = "CREATE A PDF";
            this.button_create_pdf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_create_pdf.UseVisualStyleBackColor = true;
            this.button_create_pdf.Click += new System.EventHandler(this.button_create_pdf_Click);
            // 
            // MenuManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button_create_pdf);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TBMCategory);
            this.Controls.Add(this.BTUpdate);
            this.Controls.Add(this.BTRemove);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TBMAvailable);
            this.Controls.Add(this.TBMAllergy);
            this.Controls.Add(this.TBMNut);
            this.Controls.Add(this.TBMPrice);
            this.Controls.Add(this.TBMCost);
            this.Controls.Add(this.TBMName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MenuManager";
            this.Size = new System.Drawing.Size(1055, 678);
            this.Load += new System.EventHandler(this.MenuManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TBMName;
        private System.Windows.Forms.TextBox TBMCost;
        private System.Windows.Forms.TextBox TBMPrice;
        private System.Windows.Forms.TextBox TBMNut;
        private System.Windows.Forms.TextBox TBMAllergy;
        private System.Windows.Forms.TextBox TBMAvailable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BTRemove;
        private System.Windows.Forms.Button BTUpdate;
        private System.Windows.Forms.TextBox TBMCategory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button_create_pdf;
    }
}
