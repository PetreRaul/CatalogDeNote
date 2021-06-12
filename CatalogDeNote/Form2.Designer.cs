
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
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adaugarebtn = new System.Windows.Forms.Button();
            this.modificarebtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagrid
            // 
            this.datagrid.BackgroundColor = System.Drawing.Color.Teal;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.datagrid.Location = new System.Drawing.Point(-1, 64);
            this.datagrid.Name = "datagrid";
            this.datagrid.Size = new System.Drawing.Size(276, 386);
            this.datagrid.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(272, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(325, 386);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // adaugarebtn
            // 
            this.adaugarebtn.BackColor = System.Drawing.Color.ForestGreen;
            this.adaugarebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.adaugarebtn.FlatAppearance.BorderSize = 0;
            this.adaugarebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adaugarebtn.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.adaugarebtn.ForeColor = System.Drawing.Color.Black;
            this.adaugarebtn.Location = new System.Drawing.Point(6, 28);
            this.adaugarebtn.Name = "adaugarebtn";
            this.adaugarebtn.Size = new System.Drawing.Size(191, 40);
            this.adaugarebtn.TabIndex = 2;
            this.adaugarebtn.Text = "ADAUGARE";
            this.adaugarebtn.UseVisualStyleBackColor = false;
            // 
            // modificarebtn
            // 
            this.modificarebtn.BackColor = System.Drawing.Color.Teal;
            this.modificarebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.modificarebtn.FlatAppearance.BorderSize = 0;
            this.modificarebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificarebtn.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.modificarebtn.ForeColor = System.Drawing.Color.Black;
            this.modificarebtn.Location = new System.Drawing.Point(6, 96);
            this.modificarebtn.Name = "modificarebtn";
            this.modificarebtn.Size = new System.Drawing.Size(191, 40);
            this.modificarebtn.TabIndex = 3;
            this.modificarebtn.Text = "MODIFICARE";
            this.modificarebtn.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Firebrick;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(6, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "STERGERE";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(6, 307);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 40);
            this.button3.TabIndex = 5;
            this.button3.Text = "IESIRE";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.modificarebtn);
            this.panel1.Controls.Add(this.adaugarebtn);
            this.panel1.ForeColor = System.Drawing.Color.OliveDrab;
            this.panel1.Location = new System.Drawing.Point(597, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 386);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(0, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "STUDENTI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // studentiform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.datagrid);
            this.Name = "studentiform";
            this.Load += new System.EventHandler(this.Studenti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button adaugarebtn;
        private System.Windows.Forms.Button modificarebtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}