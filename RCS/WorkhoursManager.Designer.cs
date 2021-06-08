namespace RCS
{
    partial class WorkhoursManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkhoursManager));
            this.dataGridView_workhour = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_workhour = new System.Windows.Forms.TextBox();
            this.textBox_emp_id = new System.Windows.Forms.TextBox();
            this.button_create_pdf = new System.Windows.Forms.Button();
            this.BTUpdate = new System.Windows.Forms.Button();
            this.BTRemove = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_workhour)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_workhour
            // 
            this.dataGridView_workhour.AllowUserToAddRows = false;
            this.dataGridView_workhour.AllowUserToDeleteRows = false;
            this.dataGridView_workhour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_workhour.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_workhour.Name = "dataGridView_workhour";
            this.dataGridView_workhour.ReadOnly = true;
            this.dataGridView_workhour.Size = new System.Drawing.Size(568, 678);
            this.dataGridView_workhour.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(675, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(675, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "WorkHour";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(675, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Employee ID";
            // 
            // textBox_id
            // 
            this.textBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_id.Location = new System.Drawing.Point(784, 117);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(151, 26);
            this.textBox_id.TabIndex = 4;
            // 
            // textBox_workhour
            // 
            this.textBox_workhour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_workhour.Location = new System.Drawing.Point(784, 174);
            this.textBox_workhour.Name = "textBox_workhour";
            this.textBox_workhour.Size = new System.Drawing.Size(151, 26);
            this.textBox_workhour.TabIndex = 5;
            // 
            // textBox_emp_id
            // 
            this.textBox_emp_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_emp_id.Location = new System.Drawing.Point(784, 227);
            this.textBox_emp_id.Name = "textBox_emp_id";
            this.textBox_emp_id.Size = new System.Drawing.Size(151, 26);
            this.textBox_emp_id.TabIndex = 6;
            // 
            // button_create_pdf
            // 
            this.button_create_pdf.Image = ((System.Drawing.Image)(resources.GetObject("button_create_pdf.Image")));
            this.button_create_pdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_create_pdf.Location = new System.Drawing.Point(754, 544);
            this.button_create_pdf.Name = "button_create_pdf";
            this.button_create_pdf.Size = new System.Drawing.Size(123, 38);
            this.button_create_pdf.TabIndex = 49;
            this.button_create_pdf.Text = "CREATE A PDF";
            this.button_create_pdf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_create_pdf.UseVisualStyleBackColor = true;
            this.button_create_pdf.Click += new System.EventHandler(this.button_create_pdf_Click);
            // 
            // BTUpdate
            // 
            this.BTUpdate.BackColor = System.Drawing.Color.Lime;
            this.BTUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTUpdate.Image = ((System.Drawing.Image)(resources.GetObject("BTUpdate.Image")));
            this.BTUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTUpdate.Location = new System.Drawing.Point(826, 319);
            this.BTUpdate.Name = "BTUpdate";
            this.BTUpdate.Size = new System.Drawing.Size(136, 58);
            this.BTUpdate.TabIndex = 48;
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
            this.BTRemove.Location = new System.Drawing.Point(750, 392);
            this.BTRemove.Name = "BTRemove";
            this.BTRemove.Size = new System.Drawing.Size(136, 58);
            this.BTRemove.TabIndex = 47;
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
            this.button2.Location = new System.Drawing.Point(676, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 58);
            this.button2.TabIndex = 46;
            this.button2.Text = "         SAVE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // WorkhoursManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_create_pdf);
            this.Controls.Add(this.BTUpdate);
            this.Controls.Add(this.BTRemove);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox_emp_id);
            this.Controls.Add(this.textBox_workhour);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_workhour);
            this.Name = "WorkhoursManager";
            this.Size = new System.Drawing.Size(1055, 678);
            this.Load += new System.EventHandler(this.WorkhoursManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_workhour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_workhour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_workhour;
        private System.Windows.Forms.TextBox textBox_emp_id;
        private System.Windows.Forms.Button button_create_pdf;
        private System.Windows.Forms.Button BTUpdate;
        private System.Windows.Forms.Button BTRemove;
        private System.Windows.Forms.Button button2;
    }
}
