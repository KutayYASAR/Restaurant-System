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

namespace RCS
{
    public partial class TableItem : UserControl
    {
        DataAccess db;
        DataGridView Grid;
        Label lab;
        public TableItem(int tableid,int Reserved,int Available, DataGridView Grid,Label lab)
        {
            InitializeComponent();
            label1.Text = tableid.ToString();
            if (Reserved == 1)
            {
                this.BackColor = Color.Orange;
            }
            else if (Available == 0 )
            {
                this.BackColor = Color.Red;
            }
            else
            {
                this.BackColor = Color.Lime;
            }
            this.Grid = Grid;
            this.lab = lab;
            db = new DataAccess();
        }

        private void TableItem_Click(object sender, EventArgs e)
        {
            WaiterForm.TabID = int.Parse(this.label1.Text.ToString());
            Grid.DataSource = null;
            var clm = (from m in db.MenuItems
                       join ma in db.Cart on m.ID equals ma.ProductID
                       where ma.TableID == int.Parse(this.label1.Text.ToString())
                       select new
                       {
                           m.Name,
                           m.SellPrice
                       }).ToList();
            Grid.DataSource = clm;
            int tabid = int.Parse(this.label1.Text.ToString());
            double total=0;            
                for (int rows = 0; rows < Grid.Rows.Count; rows++)
            {

                total += Convert.ToDouble(Grid.Rows[rows].Cells[1].Value);
            }
            lab.Text = total.ToString();
        }
    }
}

