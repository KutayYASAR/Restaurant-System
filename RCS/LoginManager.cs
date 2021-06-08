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
    public partial class LoginManager : Form
    {
        public LoginManager()
        {
            InitializeComponent();
        }

        private void BTLoginManager_Click(object sender, EventArgs e)
        {
            var em = new Employee();
            int rank = -1;
            rank = em.Login(comboBox1.SelectedItem.ToString(), textBox1.Text.Trim());
            try
            {
                if (rank >= 3)
                {
                    this.Hide();
                    var r = new ManagerForm();
                    r.Closed += (s, args) => this.Close();
                    r.StartPosition = FormStartPosition.CenterScreen;
                    r.Show();
                }
                else
                    MessageBox.Show("Yetkiniz yetersiz ya da yanlış şifre girdiniz");
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen alanların hepsini doldurunuz!");
            }
        }

        private void LoginManager_Load(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            var t = new Table();
            var employe = db.Employees.Where(x=> x.Rank >2).Select(x=> x.Name).ToList();
            foreach (var item in employe)
            {
                comboBox1.Items.Add(item);
            }
        }
    }
}
