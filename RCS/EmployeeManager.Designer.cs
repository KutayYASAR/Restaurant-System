namespace RCS
{
    partial class EmployeeManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeManager));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BTUpdate = new System.Windows.Forms.Button();
            this.BTRemove = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TBEName = new System.Windows.Forms.TextBox();
            this.TBESurname = new System.Windows.Forms.TextBox();
            this.TBEPhone = new System.Windows.Forms.TextBox();
            this.TBEPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BTUpdateRank = new System.Windows.Forms.Button();
            this.button_create_pdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.dataGridView1.Size = new System.Drawing.Size(690, 678);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(743, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Rank";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Garson",
            "Şef",
            "Supervisor",
            "Manager"});
            this.comboBox1.Location = new System.Drawing.Point(747, 309);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(278, 28);
            this.comboBox1.TabIndex = 26;
            // 
            // BTUpdate
            // 
            this.BTUpdate.BackColor = System.Drawing.Color.Lime;
            this.BTUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTUpdate.Image = ((System.Drawing.Image)(resources.GetObject("BTUpdate.Image")));
            this.BTUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTUpdate.Location = new System.Drawing.Point(889, 442);
            this.BTUpdate.Name = "BTUpdate";
            this.BTUpdate.Size = new System.Drawing.Size(159, 58);
            this.BTUpdate.TabIndex = 29;
            this.BTUpdate.Text = "          UPDATE";
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
            this.BTRemove.Location = new System.Drawing.Point(818, 506);
            this.BTRemove.Name = "BTRemove";
            this.BTRemove.Size = new System.Drawing.Size(159, 58);
            this.BTRemove.TabIndex = 28;
            this.BTRemove.Text = "           REMOVE";
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
            this.button2.Location = new System.Drawing.Point(719, 442);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 58);
            this.button2.TabIndex = 27;
            this.button2.Text = "       SAVE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TBEName
            // 
            this.TBEName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBEName.Location = new System.Drawing.Point(747, 52);
            this.TBEName.Name = "TBEName";
            this.TBEName.Size = new System.Drawing.Size(276, 26);
            this.TBEName.TabIndex = 15;
            // 
            // TBESurname
            // 
            this.TBESurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBESurname.Location = new System.Drawing.Point(747, 112);
            this.TBESurname.Name = "TBESurname";
            this.TBESurname.Size = new System.Drawing.Size(276, 26);
            this.TBESurname.TabIndex = 16;
            // 
            // TBEPhone
            // 
            this.TBEPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBEPhone.Location = new System.Drawing.Point(747, 178);
            this.TBEPhone.Name = "TBEPhone";
            this.TBEPhone.Size = new System.Drawing.Size(276, 26);
            this.TBEPhone.TabIndex = 17;
            // 
            // TBEPass
            // 
            this.TBEPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBEPass.Location = new System.Drawing.Point(747, 248);
            this.TBEPass.Name = "TBEPass";
            this.TBEPass.Size = new System.Drawing.Size(278, 26);
            this.TBEPass.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(743, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(743, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(743, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(743, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Password";
            // 
            // BTUpdateRank
            // 
            this.BTUpdateRank.Image = ((System.Drawing.Image)(resources.GetObject("BTUpdateRank.Image")));
            this.BTUpdateRank.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTUpdateRank.Location = new System.Drawing.Point(818, 343);
            this.BTUpdateRank.Name = "BTUpdateRank";
            this.BTUpdateRank.Size = new System.Drawing.Size(127, 43);
            this.BTUpdateRank.TabIndex = 30;
            this.BTUpdateRank.Text = "UPDATE RANK";
            this.BTUpdateRank.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTUpdateRank.UseVisualStyleBackColor = true;
            this.BTUpdateRank.Click += new System.EventHandler(this.BTUpdateRank_Click);
            // 
            // button_create_pdf
            // 
            this.button_create_pdf.Image = ((System.Drawing.Image)(resources.GetObject("button_create_pdf.Image")));
            this.button_create_pdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_create_pdf.Location = new System.Drawing.Point(838, 624);
            this.button_create_pdf.Name = "button_create_pdf";
            this.button_create_pdf.Size = new System.Drawing.Size(123, 38);
            this.button_create_pdf.TabIndex = 31;
            this.button_create_pdf.Text = "CREATE A PDF";
            this.button_create_pdf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_create_pdf.UseVisualStyleBackColor = true;
            this.button_create_pdf.Click += new System.EventHandler(this.button_create_pdf_Click);
            // 
            // EmployeeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button_create_pdf);
            this.Controls.Add(this.BTUpdateRank);
            this.Controls.Add(this.BTUpdate);
            this.Controls.Add(this.BTRemove);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBEPass);
            this.Controls.Add(this.TBEPhone);
            this.Controls.Add(this.TBESurname);
            this.Controls.Add(this.TBEName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmployeeManager";
            this.Size = new System.Drawing.Size(1055, 678);
            this.Load += new System.EventHandler(this.EmployeeManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button BTUpdate;
        private System.Windows.Forms.Button BTRemove;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TBEName;
        private System.Windows.Forms.TextBox TBESurname;
        private System.Windows.Forms.TextBox TBEPhone;
        private System.Windows.Forms.TextBox TBEPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTUpdateRank;
        private System.Windows.Forms.Button button_create_pdf;
    }
}
