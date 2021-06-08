using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ClassLibrary.Model;

namespace RCS
{
    public partial class MenuManager : UserControl
    {
        public int ID;

        private DataAccess db = new DataAccess();
        public MenuManager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choose a photo";
            ofd.Filter = "JPG|*.jpg|PNG|*.png|GIF|*gif";
            ofd.Multiselect = false;
            if (ofd.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                this.pictureBox1.ImageLocation = ofd.FileName;

            }
        }

        private byte[] ConvertFiletoByte(string path)
        {
            try
            {
                byte[] data = null;
                FileInfo fInfo = new FileInfo(path);
                long numBytes = fInfo.Length;
                FileStream fStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fStream);
                data = br.ReadBytes((int)numBytes);
                return data;
            }
            catch (Exception)
            {
                return db.MenuItems.Where(x => x.ID == ID).Select(x => x.Image).SingleOrDefault();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var menu = new ClassLibrary.Model.Menu();
                dataGridView1.DataSource=menu.addMenu(TBMName.Text.Trim(),
                float.Parse(TBMCost.Text.Trim()),
                float.Parse(TBMPrice.Text.Trim()),
                TBMNut.Text.Trim(),
                TBMAllergy.Text.Trim(),
                int.Parse(TBMAvailable.Text.Trim()),
                ConvertFiletoByte(this.pictureBox1.ImageLocation),
                TBMCategory.Text.Trim());
                
                
                
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }


        private void BTRemove_Click(object sender, EventArgs e)
        {
            var menu = new ClassLibrary.Model.Menu();
            dataGridView1.DataSource= menu.removeMenu(ID);
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                TBMName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                TBMCost.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                TBMPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                TBMNut.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                TBMAllergy.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                TBMAvailable.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                byte[] img = (byte[])dataGridView1.Rows[e.RowIndex].Cells[7].Value;
                if (img == null)
                    pictureBox1.Image = null;
                else
                {
                    MemoryStream ms = new MemoryStream(img);
                    pictureBox1.Image = Image.FromStream(ms);
                }
                TBMCategory.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void MenuManager_Load(object sender, EventArgs e)
        {
            
            var menu = new ClassLibrary.Model.Menu();
            dataGridView1.DataSource = menu.viewMenu();

        }

        private void BTUpdate_Click(object sender, EventArgs e)
        {
            var menu = new ClassLibrary.Model.Menu();
            dataGridView1.DataSource = menu.updateMenu(ID,
                TBMName.Text.Trim(),
                float.Parse(TBMCost.Text.Trim()),
                float.Parse(TBMPrice.Text.Trim()),
                TBMNut.Text.Trim(),
                TBMAllergy.Text.Trim(),  
                int.Parse(TBMAvailable.Text.Trim()),
                ConvertFiletoByte(this.pictureBox1.ImageLocation),
                TBMCategory.Text.Trim());
        }

        private void button_create_pdf_Click(object sender, EventArgs e)
        {

        }

    }
}
