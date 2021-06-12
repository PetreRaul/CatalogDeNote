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
    public partial class Catalog : MaterialSkin.Controls.MaterialForm
    {
        public Catalog()
        {
            InitializeComponent();
        }

        private void Catalog_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void iesirebtn_Click(object sender, EventArgs e)
        {
            mainform window = new mainform();
            this.Close();
            window.ShowDialog();
        }
    }
}
