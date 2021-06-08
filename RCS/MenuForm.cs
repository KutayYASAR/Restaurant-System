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
using System.IO;

namespace RCS
{
    public partial class MenuForm : Form
    {
        private menuItem previous = null;
        private int gapY = 250;
        private int gapX = 200;
        public int total = 0;
        public static int Tableid = 1;
        public static int Employeeid = 1;
        

        bool needClear = false;
        private List<menuItem> menu = new List<menuItem>();
        public MenuForm()
        {
            InitializeComponent();
        }
        private void MenuForm_Load(object sender, EventArgs e)
        {

            DataAccess db = new DataAccess();
            try
            {
                var column = (from m in db.MenuItems
                              select new
                              {
                                  m.Category
                              })
                             .Distinct().ToList();
                dataGridView2.DataSource = column;

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                if (needClear)
                {
                    foreach (var item in menu)
                    {
                        panel2.Controls.Remove(item);
                    }
                    menu.Clear();
                    previous = null;
                    needClear = false;
                    total = 0;
                }

            var db = new DataAccess();
            var menulist = db.MenuItems.Where(x=>x.Category==dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString()).ToList();
                foreach (var item in menulist)
                {
                    if (previous == null)
                    {
                        MemoryStream ms = new MemoryStream(item.Image);
                        menu.Add(new RCS.menuItem(Image.FromStream(ms), item.Name, int.Parse(item.Nutritions), item.SellPrice,item.ID,dataGridView1));
                        panel2.Controls.Add(menu[0]);
                        menu[0].Location = new Point(panel2.Location.X - 110, panel2.Location.Y + 50);
                        previous = menu[0];
                        total++;

                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(item.Image);
                        menu.Add(new RCS.menuItem(Image.FromStream(ms), item.Name, int.Parse(item.Nutritions), item.SellPrice,item.ID,dataGridView1));
                        panel2.Controls.Add(menu[menu.Count - 1]);
                        int preX = previous.Location.X;
                        int preY = previous.Location.Y;
                        Point point;
                        if (total % 4 == 0)
                        {
                            point = new Point(menu[0].Location.X, preY + gapY);
                        }
                        else
                        {
                            point = new Point(preX + gapX, preY);
                        }
                        menu[menu.Count - 1].Location = point;
                        previous = menu[menu.Count - 1];
                        total++;
                    }
                }
            needClear = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Sepetten Kaldırmak istediğinze emin misiniz?", "KALDIR", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                var db = new DataAccess();
                var clm = (from ma in db.Cart
                           join m in db.MenuItems on ma.ProductID equals m.ID
                           where m.Name == dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()
                           select new
                           {
                               ma.ID
                           }).FirstOrDefault();
                var a = db.Cart.FirstOrDefault(x => x.ID == clm.ID);
                db.Cart.Remove(a);
                db.SaveChanges();
                var clma = (from m in db.MenuItems
                            join ma in db.Cart on m.ID equals ma.ProductID
                            where ma.TableID == MenuForm.Tableid
                            select new
                            {
                                m.Name,
                                m.SellPrice

                            }).ToList();
                dataGridView1.DataSource = clma;
            }
        }

        private void BTComplete_Click(object sender, EventArgs e)
        {
            double total = 0;

            var db = new DataAccess();
            var Or = new Order();
            for(int rows =0; rows<dataGridView1.Rows.Count; rows++)
            {
                
                total = Convert.ToDouble(dataGridView1.Rows[rows].Cells[1].Value) + total;
            }
            Or.addOrder(MenuForm.Employeeid, total, "Order Taken", MenuForm.Tableid, "In Restaurant");

            
            
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTAskWaiter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Waiter is on his/her way !");
        }
    }
}
