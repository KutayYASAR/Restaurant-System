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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BTMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            var r = new MenuForm();
            r.Closed += (s, args) => this.Close();
            r.StartPosition = FormStartPosition.CenterScreen;
            r.Show();
        }

        private void BTManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            var r = new LoginManager();
            r.Closed += (s, args) => this.Close();
            r.StartPosition = FormStartPosition.CenterScreen;
            r.Show();
        }

        private void BTWaiter_Click(object sender, EventArgs e)
        {
            this.Hide();
            var r = new LoginEmployee();
            r.Closed += (s, args) => this.Close();
            r.StartPosition = FormStartPosition.CenterScreen;
            r.Show();
        }
    }
}
