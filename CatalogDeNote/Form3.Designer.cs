
namespace CatalogDeNote
{
    partial class disciplinaform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button iesirebtn;
            System.Windows.Forms.Button stergerebtn;
            System.Windows.Forms.Button modificarebtn;
            System.Windows.Forms.Button adaugarebtn;
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.denumiretxt = new System.Windows.Forms.Label();
            this.creditetxt = new System.Windows.Forms.Label();
            this.codtxt = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listadiscipline = new System.Windows.Forms.ListBox();
            iesirebtn = new System.Windows.Forms.Button();
            stergerebtn = new System.Windows.Forms.Button();
            modificarebtn = new System.Windows.Forms.Button();
            adaugarebtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // iesirebtn
            // 
            iesirebtn.BackColor = System.Drawing.Color.Gray;
            iesirebtn.FlatAppearance.BorderSize = 0;
            iesirebtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            iesirebtn.ForeColor = System.Drawing.Color.Black;
            iesirebtn.Location = new System.Drawing.Point(13, 309);
            iesirebtn.Name = "iesirebtn";
            iesirebtn.Size = new System.Drawing.Size(191, 40);
            iesirebtn.TabIndex = 5;
            iesirebtn.Text = "IESIRE";
            iesirebtn.UseVisualStyleBackColor = false;
            iesirebtn.Click += new System.EventHandler(this.iesirebtn_Click);
            // 
            // stergerebtn
            // 
            stergerebtn.BackColor = System.Drawing.Color.Firebrick;
            stergerebtn.FlatAppearance.BorderSize = 0;
            stergerebtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            stergerebtn.ForeColor = System.Drawing.Color.Black;
            stergerebtn.Location = new System.Drawing.Point(13, 151);
            stergerebtn.Name = "stergerebtn";
            stergerebtn.Size = new System.Drawing.Size(191, 40);
            stergerebtn.TabIndex = 4;
            stergerebtn.Text = "STERGERE";
            stergerebtn.UseVisualStyleBackColor = false;
            stergerebtn.Click += new System.EventHandler(this.stergerebtn_Click);
            // 
            // modificarebtn
            // 
            modificarebtn.BackColor = System.Drawing.Color.Teal;
            modificarebtn.FlatAppearance.BorderSize = 0;
            modificarebtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            modificarebtn.ForeColor = System.Drawing.Color.Black;
            modificarebtn.Location = new System.Drawing.Point(13, 88);
            modificarebtn.Name = "modificarebtn";
            modificarebtn.Size = new System.Drawing.Size(191, 40);
            modificarebtn.TabIndex = 3;
            modificarebtn.Text = "MODIFICARE";
            modificarebtn.UseVisualStyleBackColor = false;
            modificarebtn.Click += new System.EventHandler(this.modificarebtn_Click);
            // 
            // adaugarebtn
            // 
            adaugarebtn.BackColor = System.Drawing.Color.ForestGreen;
            adaugarebtn.FlatAppearance.BorderSize = 0;
            adaugarebtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            adaugarebtn.ForeColor = System.Drawing.Color.Black;
            adaugarebtn.Location = new System.Drawing.Point(13, 29);
            adaugarebtn.Name = "adaugarebtn";
            adaugarebtn.Size = new System.Drawing.Size(191, 40);
            adaugarebtn.TabIndex = 2;
            adaugarebtn.Text = "ADAUGARE";
            adaugarebtn.UseVisualStyleBackColor = false;
            adaugarebtn.Click += new System.EventHandler(this.adaugarebtn_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(-7, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(930, 38);
            this.label2.TabIndex = 11;
            this.label2.Text = "DISCIPLINE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(iesirebtn);
            this.panel1.Controls.Add(stergerebtn);
            this.panel1.Controls.Add(modificarebtn);
            this.panel1.Controls.Add(adaugarebtn);
            this.panel1.ForeColor = System.Drawing.Color.OliveDrab;
            this.panel1.Location = new System.Drawing.Point(690, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 415);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(276, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(417, 423);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // denumiretxt
            // 
            this.denumiretxt.BackColor = System.Drawing.Color.LightGray;
            this.denumiretxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.denumiretxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denumiretxt.ForeColor = System.Drawing.Color.Black;
            this.denumiretxt.Location = new System.Drawing.Point(327, 100);
            this.denumiretxt.Name = "denumiretxt";
            this.denumiretxt.Size = new System.Drawing.Size(149, 25);
            this.denumiretxt.TabIndex = 12;
            this.denumiretxt.Text = "Denumire Disciplina";
            this.denumiretxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.denumiretxt.Click += new System.EventHandler(this.denumiretxt_Click);
            // 
            // creditetxt
            // 
            this.creditetxt.BackColor = System.Drawing.Color.LightGray;
            this.creditetxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creditetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditetxt.ForeColor = System.Drawing.Color.Black;
            this.creditetxt.Location = new System.Drawing.Point(327, 166);
            this.creditetxt.Name = "creditetxt";
            this.creditetxt.Size = new System.Drawing.Size(124, 18);
            this.creditetxt.TabIndex = 13;
            this.creditetxt.Text = "Credite Disciplina";
            this.creditetxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.creditetxt.Click += new System.EventHandler(this.creditetxt_Click);
            // 
            // codtxt
            // 
            this.codtxt.BackColor = System.Drawing.Color.LightGray;
            this.codtxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.codtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codtxt.ForeColor = System.Drawing.Color.Black;
            this.codtxt.Location = new System.Drawing.Point(327, 226);
            this.codtxt.Name = "codtxt";
            this.codtxt.Size = new System.Drawing.Size(124, 21);
            this.codtxt.TabIndex = 14;
            this.codtxt.Text = "Cod Disciplina";
            this.codtxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.codtxt.Click += new System.EventHandler(this.codtxt_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(327, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(327, 250);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(83, 20);
            this.textBox2.TabIndex = 16;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(327, 187);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.listadiscipline);
            this.panel2.Location = new System.Drawing.Point(-1, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 414);
            this.panel2.TabIndex = 18;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // listadiscipline
            // 
            this.listadiscipline.FormattingEnabled = true;
            this.listadiscipline.Location = new System.Drawing.Point(24, 30);
            this.listadiscipline.Name = "listadiscipline";
            this.listadiscipline.Size = new System.Drawing.Size(235, 355);
            this.listadiscipline.TabIndex = 2;
            this.listadiscipline.SelectedIndexChanged += new System.EventHandler(this.listastudenti_SelectedIndexChanged);
            // 
            // disciplinaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(906, 470);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.codtxt);
            this.Controls.Add(this.creditetxt);
            this.Controls.Add(this.denumiretxt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "disciplinaform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.disciplineform_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label denumiretxt;
        private System.Windows.Forms.Label creditetxt;
        private System.Windows.Forms.Label codtxt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listadiscipline;
    }
}