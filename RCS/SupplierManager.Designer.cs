namespace RCS
{
    partial class SupplierManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierManager));
            this.BTUpdate = new System.Windows.Forms.Button();
            this.BTRemove = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBSInfo = new System.Windows.Forms.TextBox();
            this.TBSContact = new System.Windows.Forms.TextBox();
            this.TBSName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button_create_pdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTUpdate
            // 
            this.BTUpdate.BackColor = System.Drawing.Color.Lime;
            this.BTUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTUpdate.Image = ((System.Drawing.Image)(resources.GetObject("BTUpdate.Image")));
            this.BTUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTUpdate.Location = new System.Drawing.Point(894, 349);
            this.BTUpdate.Name = "BTUpdate";
            this.BTUpdate.Size = new System.Drawing.Size(136, 58);
            this.BTUpdate.TabIndex = 43;
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
            this.BTRemove.Location = new System.Drawing.Point(818, 422);
            this.BTRemove.Name = "BTRemove";
            this.BTRemove.Size = new System.Drawing.Size(136, 58);
            this.BTRemove.TabIndex = 42;
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
            this.button2.Location = new System.Drawing.Point(744, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 58);
            this.button2.TabIndex = 41;
            this.button2.Text = "         SAVE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(741, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(741, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Contact";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(741, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Name";
            // 
            // TBSInfo
            // 
            this.TBSInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBSInfo.Location = new System.Drawing.Point(744, 267);
            this.TBSInfo.Name = "TBSInfo";
            this.TBSInfo.Size = new System.Drawing.Size(276, 26);
            this.TBSInfo.TabIndex = 33;
            // 
            // TBSContact
            // 
            this.TBSContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBSContact.Location = new System.Drawing.Point(744, 208);
            this.TBSContact.Name = "TBSContact";
            this.TBSContact.Size = new System.Drawing.Size(276, 26);
            this.TBSContact.TabIndex = 32;
            // 
            // TBSName
            // 
            this.TBSName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBSName.Location = new System.Drawing.Point(744, 147);
            this.TBSName.Name = "TBSName";
            this.TBSName.Size = new System.Drawing.Size(276, 26);
            this.TBSName.TabIndex = 31;
            this.TBSName.TextChanged += new System.EventHandler(this.TBSName_TextChanged);
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
            this.dataGridView1.Size = new System.Drawing.Size(705, 675);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // button_create_pdf
            // 
            this.button_create_pdf.Image = ((System.Drawing.Image)(resources.GetObject("button_create_pdf.Image")));
            this.button_create_pdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_create_pdf.Location = new System.Drawing.Point(826, 563);
            this.button_create_pdf.Name = "button_create_pdf";
            this.button_create_pdf.Size = new System.Drawing.Size(123, 38);
            this.button_create_pdf.TabIndex = 45;
            this.button_create_pdf.Text = "CREATE A PDF";
            this.button_create_pdf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_create_pdf.UseVisualStyleBackColor = true;
            this.button_create_pdf.Click += new System.EventHandler(this.button_create_pdf_Click);
            // 
            // SupplierManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button_create_pdf);
            this.Controls.Add(this.BTUpdate);
            this.Controls.Add(this.BTRemove);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBSInfo);
            this.Controls.Add(this.TBSContact);
            this.Controls.Add(this.TBSName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SupplierManager";
            this.Size = new System.Drawing.Size(1055, 678);
            this.Load += new System.EventHandler(this.SupplierManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTUpdate;
        private System.Windows.Forms.Button BTRemove;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBSInfo;
        private System.Windows.Forms.TextBox TBSContact;
        private System.Windows.Forms.TextBox TBSName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.Button button_create_pdf;
    }
}
