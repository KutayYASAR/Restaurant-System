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
    public class Payment
    {
        DataAccess db = new DataAccess();
        public int ID { get; set; }
        public DateTime Date{ get; set; }
        public int EmployeeID { get; set; }
        public float Cost { get; set; }
        public float SalePrice{ get; set; }
        public string Method { get; set; }
        public float Profit { get; set; }
        public List<Payment> Add(DateTime Date,int EmployeeID,float Cost,float SalePrice,string Method,float Profit)
        {
            this.Date = Date;this.EmployeeID = EmployeeID;this.Cost = Cost;this.SalePrice = SalePrice;this.Cost = Cost;this.Method = Method;this.Profit = Profit;
            db.Payment.Add(this);
            db.SaveChanges();
            return View();
        }
        public List<Payment> Remove(int ID)
        {
            var paym = db.Payment.FirstOrDefault(x => x.ID==ID);
            db.Payment.Remove(paym);
            db.SaveChanges();
            return View();
        }
        public List<Payment> Search(DateTime dateTime, DateTime dateTime2)
        {
            List<Payment> tableItem = db.Payment.Where(x => x.Date >= dateTime && x.Date <= dateTime2).ToList();
            return tableItem;
        }
        public List<Payment> Search(DateTime dateTime)
        {
            List<Payment> tableItem = db.Payment.Where(x => x.Date >= dateTime).ToList();
            return tableItem;
        }
        public List<Payment> Update(int ID,DateTime Date, int EmployeeID, float Cost, float SalePrice, string Method, float Profit)
        {
            var paym = db.Payment.FirstOrDefault(x => x.ID == ID);
            paym.Date = Date; paym.EmployeeID = EmployeeID; paym.Cost = Cost; paym.SalePrice = SalePrice; paym.Cost = Cost; paym.Method = Method; paym.Profit = Profit;
            db.Update(paym);
            db.SaveChanges();
            return View();
        }
        
       /* public List<Payment> Search()
        {
            
        }*/
        public List<Payment> View()
        {
            return db.Payment.ToList();
        }
        public void Reciept(DataGridView Dgw, string Filename,float Total)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.EMBEDDED);
            PdfPTable pdfPTable = new PdfPTable(Dgw.Columns.Count);
            pdfPTable.DefaultCell.Padding = 3;
            pdfPTable.WidthPercentage = 100;
            pdfPTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfPTable.DefaultCell.BorderWidth = 1;
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);

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
                    pdfdoc.Add(new Paragraph("Toplam : " + Total + "TL"));
                    pdfdoc.Close();
                    stream.Close();
                }
            }

        }

    }
}
