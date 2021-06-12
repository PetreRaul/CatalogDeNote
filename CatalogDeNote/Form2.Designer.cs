
namespace CatalogDeNote
{
    partial class studentiform
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.listastudenti = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.codtxt = new System.Windows.Forms.Label();
            this.creditetxt = new System.Windows.Forms.Label();
            this.denumiretxt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            iesirebtn = new System.Windows.Forms.Button();
            stergerebtn = new System.Windows.Forms.Button();
            modificarebtn = new System.Windows.Forms.Button();
            adaugarebtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(-12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(930, 38);
            this.label2.TabIndex = 21;
            this.label2.Text = "STUDENTI";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // iesirebtn
            // 
            iesirebtn.BackColor = System.Drawing.Color.Gray;
            iesirebtn.FlatAppearance.BorderSize = 0;
            iesirebtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            iesirebtn.ForeColor = System.Drawing.Color.Black;
            iesirebtn.Location = new System.Drawing.Point(18, 306);
            iesirebtn.Name = "iesirebtn";
            iesirebtn.Size = new System.Drawing.Size(191, 40);
            iesirebtn.TabIndex = 5;
            iesirebtn.Text = "IESIRE";
            iesirebtn.UseVisualStyleBackColor = false;
            iesirebtn.Click += new System.EventHandler(this.iesirebtn_Click_2);
            // 
            // stergerebtn
            // 
            stergerebtn.BackColor = System.Drawing.Color.Firebrick;
            stergerebtn.FlatAppearance.BorderSize = 0;
            stergerebtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            stergerebtn.ForeColor = System.Drawing.Color.Black;
            stergerebtn.Location = new System.Drawing.Point(18, 151);
            stergerebtn.Name = "stergerebtn";
            stergerebtn.Size = new System.Drawing.Size(191, 40);
            stergerebtn.TabIndex = 4;
            stergerebtn.Text = "STERGERE";
            stergerebtn.UseVisualStyleBackColor = false;
            // 
            // modificarebtn
            // 
            modificarebtn.BackColor = System.Drawing.Color.Teal;
            modificarebtn.FlatAppearance.BorderSize = 0;
            modificarebtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            modificarebtn.ForeColor = System.Drawing.Color.Black;
            modificarebtn.Location = new System.Drawing.Point(18, 88);
            modificarebtn.Name = "modificarebtn";
            modificarebtn.Size = new System.Drawing.Size(191, 40);
            modificarebtn.TabIndex = 3;
            modificarebtn.Text = "MODIFICARE";
            modificarebtn.UseVisualStyleBackColor = false;
            // 
            // adaugarebtn
            // 
            adaugarebtn.BackColor = System.Drawing.Color.ForestGreen;
            adaugarebtn.FlatAppearance.BorderSize = 0;
            adaugarebtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            adaugarebtn.ForeColor = System.Drawing.Color.Black;
            adaugarebtn.Location = new System.Drawing.Point(18, 29);
            adaugarebtn.Name = "adaugarebtn";
            adaugarebtn.Size = new System.Drawing.Size(191, 40);
            adaugarebtn.TabIndex = 2;
            adaugarebtn.Text = "ADAUGARE";
            adaugarebtn.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.listastudenti);
            this.panel2.Location = new System.Drawing.Point(-6, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 414);
            this.panel2.TabIndex = 28;
            // 
            // listastudenti
            // 
            this.listastudenti.FormattingEnabled = true;
            this.listastudenti.Location = new System.Drawing.Point(24, 30);
            this.listastudenti.Name = "listastudenti";
            this.listastudenti.Size = new System.Drawing.Size(235, 355);
            this.listastudenti.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(322, 252);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(83, 20);
            this.textBox2.TabIndex = 26;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(322, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 20);
            this.textBox1.TabIndex = 25;
            // 
            // codtxt
            // 
            this.codtxt.BackColor = System.Drawing.Color.LightGray;
            this.codtxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.codtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codtxt.ForeColor = System.Drawing.Color.Black;
            this.codtxt.Location = new System.Drawing.Point(319, 228);
            this.codtxt.Name = "codtxt";
            this.codtxt.Size = new System.Drawing.Size(124, 21);
            this.codtxt.TabIndex = 24;
            this.codtxt.Text = "Numar Matricol";
            this.codtxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // creditetxt
            // 
            this.creditetxt.BackColor = System.Drawing.Color.LightGray;
            this.creditetxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creditetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditetxt.ForeColor = System.Drawing.Color.Black;
            this.creditetxt.Location = new System.Drawing.Point(322, 168);
            this.creditetxt.Name = "creditetxt";
            this.creditetxt.Size = new System.Drawing.Size(124, 18);
            this.creditetxt.TabIndex = 23;
            this.creditetxt.Text = "Prenume Student";
            this.creditetxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // denumiretxt
            // 
            this.denumiretxt.BackColor = System.Drawing.Color.LightGray;
            this.denumiretxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.denumiretxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denumiretxt.ForeColor = System.Drawing.Color.Black;
            this.denumiretxt.Location = new System.Drawing.Point(322, 102);
            this.denumiretxt.Name = "denumiretxt";
            this.denumiretxt.Size = new System.Drawing.Size(149, 25);
            this.denumiretxt.TabIndex = 22;
            this.denumiretxt.Text = "Nume Student";
            this.denumiretxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(iesirebtn);
            this.panel1.Controls.Add(stergerebtn);
            this.panel1.Controls.Add(modificarebtn);
            this.panel1.Controls.Add(adaugarebtn);
            this.panel1.ForeColor = System.Drawing.Color.OliveDrab;
            this.panel1.Location = new System.Drawing.Point(685, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 415);
            this.panel1.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(271, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(417, 423);
            this.dataGridView1.TabIndex = 19;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(322, 189);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(193, 20);
            this.textBox3.TabIndex = 29;
            // 
            // studentiform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 470);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.codtxt);
            this.Controls.Add(this.creditetxt);
            this.Controls.Add(this.denumiretxt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "studentiform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Studenti_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listastudenti;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label codtxt;
        private System.Windows.Forms.Label creditetxt;
        private System.Windows.Forms.Label denumiretxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox3;
    }
}