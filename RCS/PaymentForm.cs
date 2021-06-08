using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary.Model;

namespace RCS
{
    public partial class PaymentForm : Form
    {
        int TableID;
        float Discount = 0;
        float CostTotal = 0;
        float SaleTotal = 0;
        DataAccess db = new DataAccess();
        public PaymentForm(int TableID)
        {
            InitializeComponent();
            this.TableID = TableID;
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            var pSale = (from m in db.MenuItems
                         join ma in db.Cart on m.ID equals ma.ProductID
                         where ma.TableID == this.TableID
                         select new
                         {
                             m.SellPrice,
                         }).ToList();
            var pCost = (from m in db.MenuItems
                         join ma in db.Cart on m.ID equals ma.ProductID
                         where ma.TableID == this.TableID
                         select new
                         {
                             m.Cost,
                         }).ToList();
            foreach (var item in pSale)
            {
                SaleTotal += item.SellPrice;
            }
            foreach (var item in pCost)
            {
                CostTotal += item.Cost;
            }
            label2.Text = SaleTotal.ToString();
            dataGridView1.DataSource = (from m in db.MenuItems
                                        join ma in db.Cart on m.ID equals ma.ProductID
                                        where ma.TableID == this.TableID
                                        select new
                                        {
                                            m.Name,
                                            m.SellPrice
                                        }).ToList();

        }

        private void BTComp_Click(object sender, EventArgs e)
        {
            Payment p = new Payment();
            try
            {

                p.Add(DateTime.Now, LoginEmployee.EmployeeID, CostTotal, SaleTotal, CBMetod.SelectedItem.ToString(), (SaleTotal - CostTotal));

            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen bütün alanları doldurun!");
            }
            p.Reciept(dataGridView1, DateTime.Now.ToShortDateString(),SaleTotal);
            var rem = db.Cart.Where(x => x.TableID == TableID).ToList();
            foreach (var item in rem)
            {
                db.Cart.Remove(item);
                db.SaveChanges();
            }
            if (TBGift.Text.Length>15)
            {
                try
                {
                    var gf = new Giftcard();
                    gf.updateGiftcard(TBGift.Text.Trim(), SaleTotal);
                }
                catch (Exception)
                {
                    MessageBox.Show("Bakiyeniz Yetersiz!");
                }
            }
            PaymentForm.ActiveForm.Hide();
        }

        private void TBDisc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (CBDisc.SelectedIndex == 0)
                {
                    Discount = int.Parse(TBDisc.Text.ToString());
                    label2.Text = (SaleTotal - Discount).ToString();
                }
                else if (CBDisc.SelectedIndex == 1)
                {
                    Discount = SaleTotal * (float.Parse(TBDisc.Text.ToString()) / 100.0f);
                    label2.Text = (SaleTotal - Discount).ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
