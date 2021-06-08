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
    public partial class PaymentManager : UserControl
    {
        float Cost=0;
        float Sale=0;
        float Profit=0;
        public PaymentManager()
        {
            InitializeComponent();
        }

        private void PaymentManager_Load(object sender, EventArgs e)
        {
            var p = new Payment();
            DTAnnual.Format = DateTimePickerFormat.Custom;
            DTAnnual.CustomFormat="yyyy";
            DTAnnual.ShowUpDown = true;
            dateTimePicker4.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.CustomFormat="MMMM yyyy";
            dateTimePicker4.ShowUpDown = true;
            dataGridView1.DataSource = p.View();
            changeLabels();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var p = new Payment();
            dataGridView1.DataSource = p.Search(dateTimePicker1.Value);
            changeLabels();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            var p = new Payment();
            dataGridView1.DataSource= p.Search(dateTimePicker1.Value,dateTimePicker2.Value);
            changeLabels();
        }

        private void DTAnnual_ValueChanged(object sender, EventArgs e)
        {
            var sl = new SaleReport();
            dataGridView1.DataSource = sl.Annual(DTAnnual.Value.Year);
            changeLabels();
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            var sl = new SaleReport();
               dataGridView1.DataSource= sl.Monthly(dateTimePicker4.Value.Month, dateTimePicker4.Value.Year);
            changeLabels();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var salerep = new SaleReport();
            salerep.Reciept(dataGridView1, "Sale Report", Sale, Cost, Profit);
        }
        private void changeLabels()
        {
            for (int rows = 0; rows < dataGridView1.Rows.Count; rows++)
            {

                Cost += float.Parse(dataGridView1.Rows[rows].Cells[3].Value.ToString());
                Sale += float.Parse(dataGridView1.Rows[rows].Cells[4].Value.ToString());
                Profit += float.Parse(dataGridView1.Rows[rows].Cells[6].Value.ToString());
            }
            LBCost.Text = Cost.ToString() + "  TL";
            LBSale.Text = Sale.ToString() + "  TL";
            LBProfit.Text = Profit.ToString() + "  TL";
        }
    }
}
