using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using System.IO;

namespace ClassLibrary.Model
{
    public class SaleReport
    {
        DataAccess db = new DataAccess();
        public void Reciept(DataGridView Dgw, string Filename, float Sale,float Cost,float profit)
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
                    pdfdoc.Add(new Paragraph("Toplam Maliyet : " + Cost + "TL"));
                    pdfdoc.Add(new Paragraph("Toplam Satış : " + Sale + "TL"));
                    pdfdoc.Add(new Paragraph("Toplam Kar: " + profit + "TL"));
                    pdfdoc.Close();
                    stream.Close();
                }
            }

        }
        public List<Payment>Annual(int Year)
        {
            var pyt = db.Payment.Where(x => x.Date.Year == Year).ToList();
            return pyt;
        }
        public List<Payment>Monthly(int Month,int Year)
        {
            var pyt = db.Payment.Where(x => x.Date.Month == Year && x.Date.Month==Month).ToList();
            return pyt;
        }
    }
}
