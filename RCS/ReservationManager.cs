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
    public partial class ReservationManager : UserControl
    {
        int ID;
        public ReservationManager()
        {
            InitializeComponent();
        }

        private void ReservationManager_Load(object sender, EventArgs e)
        {
            Reservation r = new Reservation();
            dataGridView1.DataSource = r.viewReservation();
        }

        private void BRadd_Click(object sender, EventArgs e)
        {
            try
            {
                Reservation r = new Reservation();
                var tableId = int.Parse( TBRid.Text.Trim());
                var status = TBRstatus.SelectedItem.ToString();
                dataGridView1.DataSource = r.addReservation(TBRdate.Text.Trim(), tableId, TBRname.Text.Trim(),TBRinfo.Text.Trim(),status);
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen gerekli tüm alanları doldurunuz");
            }
        }

        private void BRupdate_Click(object sender, EventArgs e)
        {
            try
            {
                Reservation r = new Reservation();
                var tableId = int.Parse(TBRid.Text.Trim());
                var status = TBRstatus.SelectedItem.ToString();
                dataGridView1.DataSource = r.updateReservation(ID, TBRdate.Text.Trim(), tableId, TBRname.Text.Trim(), TBRinfo.Text.Trim(), status);

            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen gerekli tüm alanları doldurunuz");
            }
        }

        private void BRemove_Click(object sender, EventArgs e)
        {
            try
            {
                Reservation r = new Reservation();
                dataGridView1.DataSource = r.removeReservation(ID);
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen gerekli tüm alanları doldurunuz");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataAccess db = new DataAccess();
            ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            TBRdate.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TBRid.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            TBRname.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            TBRinfo.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            TBRstatus.SelectedIndex = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString()); 
        }

        private void button_create_pdf_Click(object sender, EventArgs e)
        {
            ExportDataGridToPdf(dataGridView1, "INFORMATION OF RESERVATIONS");
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
