namespace RCS
{
    partial class TableManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableManager));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.BTUpdate = new System.Windows.Forms.Button();
            this.BTRemove = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CBAv = new System.Windows.Forms.CheckBox();
            this.CBRes = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_create_pdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(715, 678);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Üst Kat",
            "Teras",
            "Bodrum",
            "Orta Kat"});
            this.comboBox2.Location = new System.Drawing.Point(751, 185);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(278, 28);
            this.comboBox2.TabIndex = 36;
            // 
            // BTUpdate
            // 
            this.BTUpdate.BackColor = System.Drawing.Color.Lime;
            this.BTUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTUpdate.Image = ((System.Drawing.Image)(resources.GetObject("BTUpdate.Image")));
            this.BTUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTUpdate.Location = new System.Drawing.Point(893, 333);
            this.BTUpdate.Name = "BTUpdate";
            this.BTUpdate.Size = new System.Drawing.Size(135, 58);
            this.BTUpdate.TabIndex = 35;
            this.BTUpdate.Text = "UPDATE";
            this.BTUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTUpdate.UseVisualStyleBackColor = false;
            this.BTUpdate.Click += new System.EventHandler(this.BTUpdate_Click);
            // 
            // BTRemove
            // 
            this.BTRemove.BackColor = System.Drawing.Color.Red;
            this.BTRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTRemove.ForeColor = System.Drawing.Color.White;
            this.BTRemove.Image = ((System.Drawing.Image)(resources.GetObject("BTRemove.Image")));
            this.BTRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTRemove.Location = new System.Drawing.Point(822, 397);
            this.BTRemove.Name = "BTRemove";
            this.BTRemove.Size = new System.Drawing.Size(135, 58);
            this.BTRemove.TabIndex = 34;
            this.BTRemove.Text = "REMOVE";
            this.BTRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTRemove.UseVisualStyleBackColor = false;
            this.BTRemove.Click += new System.EventHandler(this.BTRemove_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(752, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 58);
            this.button2.TabIndex = 33;
            this.button2.Text = "           SAVE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(751, 249);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(278, 28);
            this.comboBox1.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(750, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Responsible Employee";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(750, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Location";
            // 
            // CBAv
            // 
            this.CBAv.AutoSize = true;
            this.CBAv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CBAv.Location = new System.Drawing.Point(749, 92);
            this.CBAv.Name = "CBAv";
            this.CBAv.Size = new System.Drawing.Size(91, 24);
            this.CBAv.TabIndex = 38;
            this.CBAv.Text = "Available";
            this.CBAv.UseVisualStyleBackColor = true;
            // 
            // CBRes
            // 
            this.CBRes.AutoSize = true;
            this.CBRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CBRes.Location = new System.Drawing.Point(947, 92);
            this.CBRes.Name = "CBRes";
            this.CBRes.Size = new System.Drawing.Size(96, 24);
            this.CBRes.TabIndex = 39;
            this.CBRes.Text = "Reserved";
            this.CBRes.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(823, 547);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 119);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // button_create_pdf
            // 
            this.button_create_pdf.Image = ((System.Drawing.Image)(resources.GetObject("button_create_pdf.Image")));
            this.button_create_pdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_create_pdf.Location = new System.Drawing.Point(829, 492);
            this.button_create_pdf.Name = "button_create_pdf";
            this.button_create_pdf.Size = new System.Drawing.Size(123, 38);
            this.button_create_pdf.TabIndex = 41;
            this.button_create_pdf.Text = "CREATE A PDF";
            this.button_create_pdf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_create_pdf.UseVisualStyleBackColor = true;
            this.button_create_pdf.Click += new System.EventHandler(this.button_create_pdf_Click);
            // 
            // TableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button_create_pdf);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CBRes);
            this.Controls.Add(this.CBAv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.BTUpdate);
            this.Controls.Add(this.BTRemove);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TableManager";
            this.Size = new System.Drawing.Size(1055, 678);
            this.Load += new System.EventHandler(this.TableManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button BTUpdate;
        private System.Windows.Forms.Button BTRemove;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CBAv;
        private System.Windows.Forms.CheckBox CBRes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_create_pdf;
    }
}
