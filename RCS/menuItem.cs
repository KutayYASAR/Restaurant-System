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
    public partial class menuItem : UserControl
    {
        DataAccess db = new DataAccess();
        int id;
        DataGridView Grid;
        public menuItem(Image img,string name,int nutritions,float price,int ID, DataGridView Grid)
        {
            InitializeComponent();
            this.pictureBox1.Image = img;
            this.LBName.Text = name;
            this.LBPrice.Text = price.ToString()+"TL";
            this.LBCals.Text = nutritions + " Kalori";
            id = ID;
            this.Grid = Grid;
        }

        private void menuItem_Load(object sender, EventArgs e)
        {

        }
        public void fillCart(DataGridView Grid)
        {
            var clm = (from m in db.MenuItems
                       join ma in db.Cart on m.ID equals ma.ProductID
                       where ma.TableID == MenuForm.Tableid
                       select new
                       {
                           m.Name,
                           m.SellPrice

                       }).ToList();
            Grid.DataSource = clm;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            MenutoCart m = new MenutoCart();
            m.addCart(id, MenuForm.Tableid);
            fillCart(Grid);
        }
    }
}
