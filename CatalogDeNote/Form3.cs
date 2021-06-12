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
    public partial class disciplinaform : MaterialSkin.Controls.MaterialForm
    {
        public disciplinaform()
        {
            InitializeComponent();
        }

        private void disciplineform_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void denumiretxt_Click(object sender, EventArgs e)
        {

        }

        private void creditetxt_Click(object sender, EventArgs e)
        {

        }

        private void iesirebtn_Click(object sender, EventArgs e)
        {
            mainform window = new mainform();
            this.Hide();
            window.ShowDialog();
        }
    }
}
