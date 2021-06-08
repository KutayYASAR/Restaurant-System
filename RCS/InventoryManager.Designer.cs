namespace RCS
{
    partial class InventoryManager
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryManager));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BIadd = new System.Windows.Forms.Button();
            this.BIupdate = new System.Windows.Forms.Button();
            this.BIremove = new System.Windows.Forms.Button();
            this.TBIprice = new System.Windows.Forms.TextBox();
            this.TBIname = new System.Windows.Forms.TextBox();
            this.TBIamount = new System.Windows.Forms.TextBox();
            this.CBItype = new System.Windows.Forms.ComboBox();
            this.CBIamountType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TBIsupplier = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_create_pdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(705, 678);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BIadd
            // 
            this.BIadd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BIadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BIadd.ForeColor = System.Drawing.Color.White;
            this.BIadd.Image = ((System.Drawing.Image)(resources.GetObject("BIadd.Image")));
            this.BIadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BIadd.Location = new System.Drawing.Point(717, 424);
            this.BIadd.Name = "BIadd";
            this.BIadd.Size = new System.Drawing.Size(154, 58);
            this.BIadd.TabIndex = 1;
            this.BIadd.Text = "        SAVE";
            this.BIadd.UseVisualStyleBackColor = false;
            this.BIadd.Click += new System.EventHandler(this.BIadd_Click);
            // 
            // BIupdate
            // 
            this.BIupdate.BackColor = System.Drawing.Color.Lime;
            this.BIupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BIupdate.Image = ((System.Drawing.Image)(resources.GetObject("BIupdate.Image")));
            this.BIupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BIupdate.Location = new System.Drawing.Point(877, 424);
            this.BIupdate.Name = "BIupdate";
            this.BIupdate.Size = new System.Drawing.Size(154, 58);
            this.BIupdate.TabIndex = 2;
            this.BIupdate.Text = "          UPDATE";
            this.BIupdate.UseVisualStyleBackColor = false;
            this.BIupdate.Click += new System.EventHandler(this.BIupdate_Click);
            // 
            // BIremove
            // 
            this.BIremove.BackColor = System.Drawing.Color.Red;
            this.BIremove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BIremove.ForeColor = System.Drawing.Color.White;
            this.BIremove.Image = ((System.Drawing.Image)(resources.GetObject("BIremove.Image")));
            this.BIremove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BIremove.Location = new System.Drawing.Point(796, 498);
            this.BIremove.Name = "BIremove";
            this.BIremove.Size = new System.Drawing.Size(154, 58);
            this.BIremove.TabIndex = 3;
            this.BIremove.Text = "         REMOVE";
            this.BIremove.UseVisualStyleBackColor = false;
            this.BIremove.Click += new System.EventHandler(this.BIremove_Click);
            // 
            // TBIprice
            // 
            this.TBIprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBIprice.Location = new System.Drawing.Point(771, 176);
            this.TBIprice.Name = "TBIprice";
            this.TBIprice.Size = new System.Drawing.Size(201, 26);
            this.TBIprice.TabIndex = 4;
            // 
            // TBIname
            // 
            this.TBIname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBIname.Location = new System.Drawing.Point(771, 108);
            this.TBIname.Name = "TBIname";
            this.TBIname.Size = new System.Drawing.Size(201, 26);
            this.TBIname.TabIndex = 5;
            // 
            // TBIamount
            // 
            this.TBIamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBIamount.Location = new System.Drawing.Point(771, 239);
            this.TBIamount.Name = "TBIamount";
            this.TBIamount.Size = new System.Drawing.Size(201, 26);
            this.TBIamount.TabIndex = 6;
            // 
            // CBItype
            // 
            this.CBItype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CBItype.FormattingEnabled = true;
            this.CBItype.Location = new System.Drawing.Point(771, 49);
            this.CBItype.Name = "CBItype";
            this.CBItype.Size = new System.Drawing.Size(201, 28);
            this.CBItype.TabIndex = 7;
            // 
            // CBIamountType
            // 
            this.CBIamountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CBIamountType.FormattingEnabled = true;
            this.CBIamountType.Location = new System.Drawing.Point(771, 303);
            this.CBIamountType.Name = "CBIamountType";
            this.CBIamountType.Size = new System.Drawing.Size(201, 28);
            this.CBIamountType.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(767, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(767, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(767, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Buy Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(769, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(770, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Amount Type";
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
            // TBIsupplier
            // 
            this.TBIsupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBIsupplier.Location = new System.Drawing.Point(771, 372);
            this.TBIsupplier.Name = "TBIsupplier";
            this.TBIsupplier.Size = new System.Drawing.Size(199, 26);
            this.TBIsupplier.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(770, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Supplier ID";
            // 
            // button_create_pdf
            // 
            this.button_create_pdf.Image = ((System.Drawing.Image)(resources.GetObject("button_create_pdf.Image")));
            this.button_create_pdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_create_pdf.Location = new System.Drawing.Point(815, 626);
            this.button_create_pdf.Name = "button_create_pdf";
            this.button_create_pdf.Size = new System.Drawing.Size(123, 38);
            this.button_create_pdf.TabIndex = 32;
            this.button_create_pdf.Text = "CREATE A PDF";
            this.button_create_pdf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_create_pdf.UseVisualStyleBackColor = true;
            // 
            // InventoryManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button_create_pdf);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TBIsupplier);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBIamountType);
            this.Controls.Add(this.CBItype);
            this.Controls.Add(this.TBIamount);
            this.Controls.Add(this.TBIname);
            this.Controls.Add(this.TBIprice);
            this.Controls.Add(this.BIremove);
            this.Controls.Add(this.BIupdate);
            this.Controls.Add(this.BIadd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "InventoryManager";
            this.Size = new System.Drawing.Size(1055, 678);
            this.Load += new System.EventHandler(this.InventoryManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BIadd;
        private System.Windows.Forms.Button BIupdate;
        private System.Windows.Forms.Button BIremove;
        private System.Windows.Forms.TextBox TBIprice;
        private System.Windows.Forms.TextBox TBIname;
        private System.Windows.Forms.TextBox TBIamount;
        private System.Windows.Forms.ComboBox CBItype;
        private System.Windows.Forms.ComboBox CBIamountType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TextBox TBIsupplier;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_create_pdf;
    }
}
