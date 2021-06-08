namespace RCS
{
    partial class ReservationManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationManager));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BRupdate = new System.Windows.Forms.Button();
            this.BRemove = new System.Windows.Forms.Button();
            this.BRadd = new System.Windows.Forms.Button();
            this.TBRid = new System.Windows.Forms.TextBox();
            this.TBRname = new System.Windows.Forms.TextBox();
            this.TBRinfo = new System.Windows.Forms.TextBox();
            this.TBRstatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBRdate = new System.Windows.Forms.TextBox();
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
            // BRupdate
            // 
            this.BRupdate.BackColor = System.Drawing.Color.Lime;
            this.BRupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BRupdate.Image = ((System.Drawing.Image)(resources.GetObject("BRupdate.Image")));
            this.BRupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BRupdate.Location = new System.Drawing.Point(893, 384);
            this.BRupdate.Name = "BRupdate";
            this.BRupdate.Size = new System.Drawing.Size(138, 58);
            this.BRupdate.TabIndex = 38;
            this.BRupdate.Text = "UPDATE";
            this.BRupdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BRupdate.UseVisualStyleBackColor = false;
            this.BRupdate.Click += new System.EventHandler(this.BRupdate_Click);
            // 
            // BRemove
            // 
            this.BRemove.BackColor = System.Drawing.Color.Red;
            this.BRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BRemove.ForeColor = System.Drawing.Color.White;
            this.BRemove.Image = ((System.Drawing.Image)(resources.GetObject("BRemove.Image")));
            this.BRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BRemove.Location = new System.Drawing.Point(815, 448);
            this.BRemove.Name = "BRemove";
            this.BRemove.Size = new System.Drawing.Size(138, 58);
            this.BRemove.TabIndex = 37;
            this.BRemove.Text = "REMOVE";
            this.BRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BRemove.UseVisualStyleBackColor = false;
            this.BRemove.Click += new System.EventHandler(this.BRemove_Click);
            // 
            // BRadd
            // 
            this.BRadd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BRadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BRadd.ForeColor = System.Drawing.Color.White;
            this.BRadd.Image = ((System.Drawing.Image)(resources.GetObject("BRadd.Image")));
            this.BRadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BRadd.Location = new System.Drawing.Point(749, 384);
            this.BRadd.Name = "BRadd";
            this.BRadd.Size = new System.Drawing.Size(138, 58);
            this.BRadd.TabIndex = 36;
            this.BRadd.Text = "          SAVE";
            this.BRadd.UseVisualStyleBackColor = false;
            this.BRadd.Click += new System.EventHandler(this.BRadd_Click);
            // 
            // TBRid
            // 
            this.TBRid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBRid.Location = new System.Drawing.Point(765, 107);
            this.TBRid.Name = "TBRid";
            this.TBRid.Size = new System.Drawing.Size(239, 26);
            this.TBRid.TabIndex = 40;
            // 
            // TBRname
            // 
            this.TBRname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBRname.Location = new System.Drawing.Point(765, 164);
            this.TBRname.Name = "TBRname";
            this.TBRname.Size = new System.Drawing.Size(239, 26);
            this.TBRname.TabIndex = 41;
            // 
            // TBRinfo
            // 
            this.TBRinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBRinfo.Location = new System.Drawing.Point(765, 224);
            this.TBRinfo.Name = "TBRinfo";
            this.TBRinfo.Size = new System.Drawing.Size(239, 26);
            this.TBRinfo.TabIndex = 42;
            // 
            // TBRstatus
            // 
            this.TBRstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBRstatus.FormattingEnabled = true;
            this.TBRstatus.Location = new System.Drawing.Point(765, 282);
            this.TBRstatus.Name = "TBRstatus";
            this.TBRstatus.Size = new System.Drawing.Size(239, 28);
            this.TBRstatus.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(772, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(772, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "TableID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(772, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Customer Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(772, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "Info";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(772, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "Status";
            // 
            // TBRdate
            // 
            this.TBRdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBRdate.Location = new System.Drawing.Point(765, 38);
            this.TBRdate.Name = "TBRdate";
            this.TBRdate.Size = new System.Drawing.Size(239, 26);
            this.TBRdate.TabIndex = 49;
            // 
            // button_create_pdf
            // 
            this.button_create_pdf.Image = ((System.Drawing.Image)(resources.GetObject("button_create_pdf.Image")));
            this.button_create_pdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_create_pdf.Location = new System.Drawing.Point(817, 596);
            this.button_create_pdf.Name = "button_create_pdf";
            this.button_create_pdf.Size = new System.Drawing.Size(123, 38);
            this.button_create_pdf.TabIndex = 50;
            this.button_create_pdf.Text = "CREATE A PDF";
            this.button_create_pdf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_create_pdf.UseVisualStyleBackColor = true;
            this.button_create_pdf.Click += new System.EventHandler(this.button_create_pdf_Click);
            // 
            // ReservationManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.button_create_pdf);
            this.Controls.Add(this.TBRdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBRstatus);
            this.Controls.Add(this.TBRinfo);
            this.Controls.Add(this.TBRname);
            this.Controls.Add(this.TBRid);
            this.Controls.Add(this.BRupdate);
            this.Controls.Add(this.BRemove);
            this.Controls.Add(this.BRadd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ReservationManager";
            this.Size = new System.Drawing.Size(1053, 676);
            this.Load += new System.EventHandler(this.ReservationManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BRupdate;
        private System.Windows.Forms.Button BRemove;
        private System.Windows.Forms.Button BRadd;
        private System.Windows.Forms.TextBox TBRid;
        private System.Windows.Forms.TextBox TBRname;
        private System.Windows.Forms.TextBox TBRinfo;
        private System.Windows.Forms.ComboBox TBRstatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBRdate;
        private System.Windows.Forms.Button button_create_pdf;
    }
}
