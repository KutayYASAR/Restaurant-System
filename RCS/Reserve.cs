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
    public partial class Reserve : Form
    {
        ReservationManager r = new ReservationManager();
        public Reserve()
        {
            InitializeComponent();
            Controls.Add(r);
            r.Location = panel1.Location;
            
        }

        private void Reserve_Load(object sender, EventArgs e)
        {
            r.Show();
            r.BringToFront();
        }
    }
}
