﻿using System;
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

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void studentibtn_Click(object sender, EventArgs e)
        {
            studentiform studenti = new studentiform();
            this.Hide();
            studenti.ShowDialog();
        }

        private void disciplinebtn_Click(object sender, EventArgs e)
        {
            disciplinaform disciplina = new disciplinaform();
            this.Hide();
            disciplina.ShowDialog();
        }

        private void iesirebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
