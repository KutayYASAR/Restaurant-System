using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary.Model;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace RCS
{
    public partial class TableManager : UserControl
    {
        int id;
        public TableManager()
        {
            InitializeComponent();
        }

        private void TableManager_Load(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            var t = new Table();
            var employe = db.Employees.Select(x => x.Name).ToList();
            foreach (var item in employe)
            {
                comboBox1.Items.Add(item);
            }
            dataGridView1.DataSource= t.viewTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            var t = new Table();
            var employeName = comboBox1.SelectedItem.ToString();
            var employee = db.Employees.FirstOrDefault(x=> x.Name == employeName);
            int isReserved;
            int isAvailable;
            if (CBAv.Checked)
            {
                isAvailable = 1;
            }
            else
                isAvailable = 0;
            if (CBRes.Checked)
            {
                isReserved = 1;
            }
            else
                isReserved = 0;
            dataGridView1.DataSource = t.addTable(comboBox2.SelectedIndex, isAvailable, isReserved, employee.ID);
        }

        private void BTUpdate_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            var t = new Table();
            var employeName = comboBox1.SelectedItem.ToString();
            var employee = db.Employees.FirstOrDefault(x => x.Name == employeName);
            int isReserved;
            int isAvailable;
            if (CBAv.Checked)
            {
                isAvailable = 1;
            }
            else
                isAvailable = 0;
            if (CBRes.Checked)
            {
                isReserved = 1;
            }
            else
                isReserved = 0;
            dataGridView1.DataSource = t.updateTable(id, comboBox2.SelectedIndex, isAvailable, isReserved, employee.ID);
        }

        private void BTRemove_Click(object sender, EventArgs e)
        {
            var t = new Table();
            dataGridView1.DataSource = t.removeTable(id);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataAccess db = new DataAccess();
            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            comboBox2.SelectedIndex = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            if (int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString()) == 1)
            {
                CBAv.Checked = true;
            }
            else
                CBAv.Checked = false;
            if (int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()) == 1)
            {
                CBRes.Checked = true;
            }
            else
                CBRes.Checked = false;
            comboBox1.SelectedItem = db.Employees.FirstOrDefault(x => x.ID == int.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString())).Name;
        }

        private void button_create_pdf_Click(object sender, EventArgs e)
        {
            ExportDataGridToPdf(dataGridView1, "INFORMATION OF TABLES");
        }

        public void ExportDataGridToPdf(DataGridView Dgw, string Filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.EMBEDDED);
            PdfPTable pdfPTable = new PdfPTable(Dgw.Columns.Count);
            pdfPTable.DefaultCell.Padding = 3;
            pdfPTable.WidthPercentage = 100;
            pdfPTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfPTable.DefaultCell.BorderWidth = 1;
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);

            //ADD HEADER
            foreach (DataGridViewColumn column in Dgw.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfPTable.AddCell(cell);

            }

            //ADD datarow

            foreach (DataGridViewRow row in Dgw.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfPTable.AddCell(new Phrase(cell.Value.ToString(), text));
                }

            }

            var savefiledialoge = new SaveFileDialog();
            savefiledialoge.FileName = Filename;
            savefiledialoge.DefaultExt = ".pdf";
            if (savefiledialoge.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialoge.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdfPTable);
                    pdfdoc.Close();
                    stream.Close();
                }
            }

        }

    }
}
