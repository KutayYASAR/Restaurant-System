using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using ClassLibrary.Model;
namespace RCS
{
    public partial class EmployeeManager : UserControl
    {
        private int id;
        public EmployeeManager()
        {
            InitializeComponent();
        }

        private void EmployeeManager_Load(object sender, EventArgs e)
        {
            Employee em = new Employee();
            dataGridView1.DataSource = em.viewEmployee();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Employee em = new Employee();
                dataGridView1.DataSource = em.addEmployee(TBEName.Text.Trim(), TBESurname.Text.Trim(), TBEPhone.Text.Trim(), comboBox1.SelectedIndex, TBEPass.Text.Trim());
            }
            catch (Exception)
            {
                MessageBox.Show("Gereken alanların hepsini doldurunuz!");
            }
        }

        private void BTUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Employee em = new Employee();
                dataGridView1.DataSource = em.updateEmployee(id, TBEName.Text.Trim(), TBESurname.Text.Trim(), TBEPhone.Text.Trim(), comboBox1.SelectedIndex, TBEPass.Text.Trim());
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen çalışanı seçiniz");
            }
        }

        private void BTRemove_Click(object sender, EventArgs e)
        {
            try
            {
                Employee em = new Employee();
                dataGridView1.DataSource = em.removeEmployee(id);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                TBEName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                TBESurname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                TBEPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                comboBox1.SelectedIndex = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                TBEPass.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void BTUpdateRank_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem==null)
                {
                    MessageBox.Show("EMPTY");
                }

                else
                {

                    var x = new Manager();
                    dataGridView1.DataSource = x.Promote_Demote(comboBox1.SelectedIndex);

                }




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void button_create_pdf_Click(object sender, EventArgs e)
        {
            ExportDataGridToPdf(dataGridView1, "INFORMATION OF EMPLOYEES");
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
