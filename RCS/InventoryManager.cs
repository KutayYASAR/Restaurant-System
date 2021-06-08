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
    public partial class InventoryManager : UserControl
    {
        int ID;
        
        public InventoryManager()
        {
            InitializeComponent();
        }

        private void InventoryManager_Load(object sender, EventArgs e)
        {
            Inventory i = new Inventory();
            dataGridView1.DataSource = i.viewInventory();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataAccess db = new DataAccess();
            ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            CBItype.SelectedIndex = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            TBIname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            TBIprice.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            TBIamount.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            CBIamountType.SelectedIndex = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
            TBIsupplier.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

        }

        private void BIadd_Click(object sender, EventArgs e)
        {
            try
            {
                Inventory i = new Inventory();
                var Type = CBItype.SelectedItem.ToString();
                var Price = int.Parse(TBIprice.Text.Trim());
                var Amount = int.Parse(TBIamount.Text.Trim());
                var AmountType = CBIamountType.SelectedItem.ToString();
                var Supplier = int.Parse(TBIsupplier.Text.Trim());
                dataGridView1.DataSource = i.addInventory(Type, TBIname.Text.Trim(), Price, Amount, AmountType,Supplier);
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen gerekli tüm alanları doldurunuz");
            }
        }

        private void BIupdate_Click(object sender, EventArgs e)
        {
            try
            {
                Inventory i = new Inventory();
                var Type = CBItype.SelectedItem.ToString();
                var Price = int.Parse(TBIprice.Text.Trim());
                var Amount = int.Parse(TBIamount.Text.Trim());
                var AmountType = CBIamountType.SelectedItem.ToString();
                var Supplier = int.Parse(TBIsupplier.Text.Trim());
                dataGridView1.DataSource = i.updateInventory(ID, Type, TBIname.Text.Trim(), Price, Amount, AmountType, Supplier);

            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen gerekli tüm alanları doldurunuz");
            }
        }

        private void BIremove_Click(object sender, EventArgs e)
        {
            var i = new Inventory();
            dataGridView1.DataSource = i.removeInventory(ID);
        }
    }
}
