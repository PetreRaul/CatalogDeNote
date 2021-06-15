using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogDeNote
{
    public partial class mainform : MaterialSkin.Controls.MaterialForm
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            catalogform window = new catalogform();
            this.Hide();
            window.Show();
        }
        private void studentibtn_Click(object sender, EventArgs e)
        {
            studentiform window = new studentiform();
            this.Hide();
            window.ShowDialog();
        }

        private void disciplinebtn_Click(object sender, EventArgs e)
        {
            disciplinaform window = new disciplinaform();
            this.Hide();
            window.ShowDialog();
        }

        private void iesirebtn_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Ești sigur că vrei să ieși? ", "Exit", buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
