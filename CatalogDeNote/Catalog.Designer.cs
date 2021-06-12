
namespace CatalogDeNote
{
    partial class Catalog
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
            this.noteadd = new System.Windows.Forms.TextBox();
            this.notelist = new System.Windows.Forms.ListBox();
            this.disciplinalist = new System.Windows.Forms.ListBox();
            this.studentlist = new System.Windows.Forms.ListBox();
            iesirebtn = new System.Windows.Forms.Button();
            stergerebtn = new System.Windows.Forms.Button();
            modificarebtn = new System.Windows.Forms.Button();
            adaugarebtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(-23, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(930, 38);
            this.label2.TabIndex = 32;
            this.label2.Text = "CATALOG";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            iesirebtn.Click += new System.EventHandler(this.iesirebtn_Click);
            // 
            // stergerebtn
            // 
            stergerebtn.BackColor = System.Drawing.Color.Firebrick;
            stergerebtn.FlatAppearance.BorderSize = 0;
            stergerebtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            stergerebtn.ForeColor = System.Drawing.Color.Black;
            stergerebtn.Location = new System.Drawing.Point(18, 215);
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
            modificarebtn.Location = new System.Drawing.Point(18, 159);
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
            adaugarebtn.Location = new System.Drawing.Point(18, 98);
            adaugarebtn.Name = "adaugarebtn";
            adaugarebtn.Size = new System.Drawing.Size(191, 40);
            adaugarebtn.TabIndex = 2;
            adaugarebtn.Text = "ADAUGARE";
            adaugarebtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(this.noteadd);
            this.panel1.Controls.Add(iesirebtn);
            this.panel1.Controls.Add(stergerebtn);
            this.panel1.Controls.Add(modificarebtn);
            this.panel1.Controls.Add(adaugarebtn);
            this.panel1.ForeColor = System.Drawing.Color.OliveDrab;
            this.panel1.Location = new System.Drawing.Point(674, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 415);
            this.panel1.TabIndex = 31;
            // 
            // noteadd
            // 
            this.noteadd.Location = new System.Drawing.Point(73, 30);
            this.noteadd.Multiline = true;
            this.noteadd.Name = "noteadd";
            this.noteadd.Size = new System.Drawing.Size(67, 48);
            this.noteadd.TabIndex = 6;
            // 
            // notelist
            // 
            this.notelist.FormattingEnabled = true;
            this.notelist.Location = new System.Drawing.Point(454, 63);
            this.notelist.Name = "notelist";
            this.notelist.Size = new System.Drawing.Size(223, 407);
            this.notelist.TabIndex = 40;
            // 
            // disciplinalist
            // 
            this.disciplinalist.FormattingEnabled = true;
            this.disciplinalist.Location = new System.Drawing.Point(229, 63);
            this.disciplinalist.Name = "disciplinalist";
            this.disciplinalist.Size = new System.Drawing.Size(228, 407);
            this.disciplinalist.TabIndex = 41;
            // 
            // studentlist
            // 
            this.studentlist.FormattingEnabled = true;
            this.studentlist.Location = new System.Drawing.Point(0, 63);
            this.studentlist.Name = "studentlist";
            this.studentlist.Size = new System.Drawing.Size(231, 407);
            this.studentlist.TabIndex = 42;
            // 
            // Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 470);
            this.Controls.Add(this.disciplinalist);
            this.Controls.Add(this.notelist);
            this.Controls.Add(this.studentlist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Catalog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Catalog_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox noteadd;
        private System.Windows.Forms.ListBox notelist;
        private System.Windows.Forms.ListBox disciplinalist;
        private System.Windows.Forms.ListBox studentlist;
    }
}