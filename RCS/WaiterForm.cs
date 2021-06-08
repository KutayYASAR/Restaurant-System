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
    public partial class WaiterForm : Form
    {
        private TableItem previous = null;
        public static int TabID;
        private int gapY = 150;
        private int gapX = 150;
        private int total = 0;
        private List<TableItem> tables = new List<TableItem>();
        public WaiterForm()
        {
            InitializeComponent();
        }

        private void WaiterForm_Load(object sender, EventArgs e)
        {
            var db = new DataAccess();
            var table = db.Tables.ToList();
            foreach (var item in table)
            {
                if (previous == null)
                {

                    tables.Add(new RCS.TableItem(item.ID,item.IsReserved,item.IsAvailable,dataGridView1,label2));
                    panel2.Controls.Add(tables[0]);
                    tables[0].Location = new Point(panel2.Location.X + 75, panel2.Location.Y + 50);
                    previous = tables[0];
                    total++;

                }
                else
                {

                    tables.Add(new RCS.TableItem(item.ID,item.IsReserved, item.IsAvailable, dataGridView1,label2));
                    panel2.Controls.Add(tables[tables.Count - 1]);
                    int preX = previous.Location.X;
                    int preY = previous.Location.Y;
                    Point point;
                    if (total % 6 == 0)
                    {
                        point = new Point(tables[0].Location.X, preY + gapY);
                    }
                    else
                    {
                        point = new Point(preX + gapX, preY);
                    }
                    tables[tables.Count - 1].Location = point;
                    previous = tables[tables.Count - 1];
                    total++;
                }

            }
        }

        private void BTPayment_Click(object sender, EventArgs e)
        {
            try
            {
                var r = new PaymentForm(TabID);
                r.Closed += (s, args) => this.Close();
                r.StartPosition = FormStartPosition.CenterScreen;
                r.ShowDialog();
            }
            catch (Exception x )
            {
                MessageBox.Show(x.Message);
            }
            
        }

        private void BTRezervation_Click(object sender, EventArgs e)
        {
            var r = new Reserve();
            r.Closed += (s, args) => this.Close();
            r.StartPosition = FormStartPosition.CenterScreen;
            r.Show();
        }
    }
}
