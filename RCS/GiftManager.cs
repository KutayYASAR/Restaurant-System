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
    public partial class GiftManager : UserControl
    {
        private string code;
        public GiftManager()
        {
            InitializeComponent();
        }

        private void GiftManager_Load(object sender, EventArgs e)
        {
            Giftcard g = new Giftcard();
            dataGridView1.DataSource = g.viewGiftcards();
        }

        private void BTGenerate_Click(object sender, EventArgs e)
        {
            Giftcard g = new Giftcard();
            try
            {
                dataGridView1.DataSource = g.addGiftcard(float.Parse(TBGBalance.Text.Trim()));
            }
            catch
            {
                MessageBox.Show("Lütfen Bakiyeyi giriniz");
            }
        }

        private void BTUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (code != null)
                {
                    Giftcard g = new Giftcard();
                    dataGridView1.DataSource = g.updateGiftcard(code, float.Parse(TBGBalance.Text.Trim()));
                }
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void BTRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (code!=null)
                {
                    Giftcard g = new Giftcard();
                    dataGridView1.DataSource = g.removeGiftcard(code);
                }
                else
                {
                    MessageBox.Show("Lütfen giftcardı seçiniz");
                }
            }
            catch
            {
                MessageBox.Show("Lütfen giftcardı seçiniz");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            code = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TBGBalance.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            label1.Text = code;
        }

        private void button_create_pdf_Click(object sender, EventArgs e)
        {
            ExportDataGridToPdf(dataGridView1, "INFORMATION OF GIFT CARDS");
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
