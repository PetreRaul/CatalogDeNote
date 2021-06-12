
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
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.denumiretxt = new System.Windows.Forms.Label();
            this.creditetxt = new System.Windows.Forms.Label();
            this.codtxt = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            iesirebtn = new System.Windows.Forms.Button();
            stergerebtn = new System.Windows.Forms.Button();
            modificarebtn = new System.Windows.Forms.Button();
            adaugarebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid
            // 
            this.datagrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.datagrid.Location = new System.Drawing.Point(-2, 64);
            this.datagrid.Name = "datagrid";
            this.datagrid.Size = new System.Drawing.Size(273, 386);
            this.datagrid.TabIndex = 8;
            this.datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_CellContentClick);
            // 
            // iesirebtn
            // 
            iesirebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(173)))));
            iesirebtn.FlatAppearance.BorderSize = 0;
            iesirebtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            iesirebtn.ForeColor = System.Drawing.Color.Black;
            iesirebtn.Location = new System.Drawing.Point(6, 307);
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
            stergerebtn.Location = new System.Drawing.Point(6, 164);
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
            modificarebtn.Location = new System.Drawing.Point(6, 96);
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
            adaugarebtn.Location = new System.Drawing.Point(6, 28);
            adaugarebtn.Name = "adaugarebtn";
            adaugarebtn.Size = new System.Drawing.Size(191, 40);
            adaugarebtn.TabIndex = 2;
            adaugarebtn.Text = "ADAUGARE";
            adaugarebtn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(-7, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(800, 38);
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
            this.panel1.Location = new System.Drawing.Point(596, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 386);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(271, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(325, 386);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // denumiretxt
            // 
            this.denumiretxt.BackColor = System.Drawing.Color.LightGray;
            this.denumiretxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.denumiretxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denumiretxt.ForeColor = System.Drawing.Color.Black;
            this.denumiretxt.Location = new System.Drawing.Point(277, 107);
            this.denumiretxt.Name = "denumiretxt";
            this.denumiretxt.Size = new System.Drawing.Size(120, 25);
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
            this.creditetxt.Location = new System.Drawing.Point(277, 187);
            this.creditetxt.Name = "creditetxt";
            this.creditetxt.Size = new System.Drawing.Size(124, 23);
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
            this.codtxt.Location = new System.Drawing.Point(277, 285);
            this.codtxt.Name = "codtxt";
            this.codtxt.Size = new System.Drawing.Size(124, 22);
            this.codtxt.TabIndex = 14;
            this.codtxt.Text = "Cod Disciplina";
            this.codtxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(280, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 20);
            this.textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(280, 320);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(83, 20);
            this.textBox2.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(280, 240);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // disciplinaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.codtxt);
            this.Controls.Add(this.creditetxt);
            this.Controls.Add(this.denumiretxt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "disciplinaform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.disciplineform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label denumiretxt;
        private System.Windows.Forms.Label creditetxt;
        private System.Windows.Forms.Label codtxt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}