using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RCS
{
    public partial class ManagerForm : Form
    {
        EmployeeManager emp = new EmployeeManager();
        SupplierManager sup = new SupplierManager();
        TableManager tab = new TableManager();
        MenuManager men = new MenuManager();
        GiftManager gft = new GiftManager();
        InventoryManager ivt = new InventoryManager();
        WorkhoursManager wh = new WorkhoursManager();
        PaymentManager py = new PaymentManager();
        public ManagerForm()
        {
            InitializeComponent();
            panel3.Hide();
            Controls.Add(emp);
            Controls.Add(py);
            Controls.Add(sup);
            Controls.Add(tab);
            Controls.Add(men);
            Controls.Add(wh);
            Controls.Add(gft);
            Controls.Add(ivt);
            emp.Location = panel2.Location;
            sup.Location = panel2.Location;
           tab.Location = panel2.Location;
            men.Location = panel2.Location;
            gft.Location = panel2.Location;
            ivt.Location = panel2.Location;
            wh.Location = panel2.Location;
            py.Location = panel2.Location;
        }

        private void BTEmployee_Click(object sender, EventArgs e)
        {
            panel3.Show();
            panel3.Height = BTEmployee.Height;
            panel3.Top = BTEmployee.Top;
            emp.Show();emp.BringToFront();
            sup.Hide();
            tab.Hide();
            men.Hide();
            gft.Hide();
            py.Hide();
            wh.Hide();
            ivt.Hide();
        }

        private void BTSuppliers_Click(object sender, EventArgs e)
        {
            panel3.Show();
            panel3.Height = BTSuppliers.Height;
            panel3.Top = BTSuppliers.Top;
            sup.Show(); sup.BringToFront();
            emp.Hide();
            tab.Hide();
            men.Hide();
            wh.Hide();
            gft.Hide();
            ivt.Hide();
            py.Hide();
        }

        private void BTTable_Click(object sender, EventArgs e)
        {
            panel3.Show();
            panel3.Height = BTTable.Height;
            panel3.Top = BTTable.Top;
             tab.Show(); tab.BringToFront();
            sup.Hide();
            emp.Hide();
            wh.Hide();
            men.Hide();
            gft.Hide();
            ivt.Hide();
            py.Hide();
        }

        private void BTMenu_Click(object sender, EventArgs e)
        {
            panel3.Show();
            panel3.Height =BTMenu.Height;
            panel3.Top = BTMenu.Top;
            men.Show(); men.BringToFront();
            sup.Hide();
             tab.Hide();
            wh.Hide();
            emp.Hide();
            gft.Hide();
            ivt.Hide();
            py.Hide();
        }

        private void BTGiftCard_Click(object sender, EventArgs e)
        {
            panel3.Show();
            panel3.Height = BTGiftCard.Height;
            panel3.Top = BTGiftCard.Top;
            gft.Show(); gft.BringToFront();
            sup.Hide();
             tab.Hide();
            men.Hide();
            emp.Hide();
            py.Hide();
            wh.Hide();
            ivt.Hide();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            gft.Hide();
            sup.Hide();
             tab.Hide();
            men.Hide();
            emp.Hide();
            py.Hide();
            wh.Hide();
            ivt.Hide();
        }

        private void BTInventory_Click(object sender, EventArgs e)
        {
            panel3.Show();
            panel3.Height = BTInventory.Height;
            panel3.Top = BTInventory.Top;
            ivt.Show(); ivt.BringToFront();
            gft.Hide();
            sup.Hide();
            tab.Hide();
            py.Hide();
            men.Hide();
            emp.Hide();
            wh.Hide();
            
        }

        private void BTWorkHours_Click(object sender, EventArgs e)
        {
            panel3.Show();
            panel3.Height = BTWorkHours.Height;
            panel3.Top = BTWorkHours.Top;
            wh.Show(); wh.BringToFront();
            emp.Hide();
            sup.Hide();
            tab.Hide();
            men.Hide();
            py.Hide();
            gft.Hide();
            ivt.Hide();
        }

        private void BTSales_Click(object sender, EventArgs e)
        {
            panel3.Show();
            panel3.Height = BTSales.Height;
            panel3.Top = BTSales.Top;
            py.Show(); py.BringToFront();
            wh.Hide();
            emp.Hide();
            sup.Hide();
            tab.Hide();
            men.Hide();
            gft.Hide();
            ivt.Hide();
        }
    }
}
