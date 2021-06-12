
namespace CatalogDeNote
{
    partial class Form1
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
            this.disciplinebtn = new System.Windows.Forms.Button();
            this.studentibtn = new System.Windows.Forms.Button();
            this.catalogbtn = new System.Windows.Forms.Button();
            this.btniesire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // disciplinebtn
            // 
            this.disciplinebtn.BackColor = System.Drawing.Color.Teal;
            this.disciplinebtn.FlatAppearance.BorderSize = 0;
            this.disciplinebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disciplinebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.disciplinebtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.disciplinebtn.Location = new System.Drawing.Point(110, 264);
            this.disciplinebtn.Name = "disciplinebtn";
            this.disciplinebtn.Size = new System.Drawing.Size(191, 40);
            this.disciplinebtn.TabIndex = 3;
            this.disciplinebtn.Text = "DISCIPLINE";
            this.disciplinebtn.UseVisualStyleBackColor = false;
            this.disciplinebtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // studentibtn
            // 
            this.studentibtn.BackColor = System.Drawing.Color.Teal;
            this.studentibtn.FlatAppearance.BorderSize = 0;
            this.studentibtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentibtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.studentibtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.studentibtn.Location = new System.Drawing.Point(110, 189);
            this.studentibtn.Name = "studentibtn";
            this.studentibtn.Size = new System.Drawing.Size(191, 40);
            this.studentibtn.TabIndex = 2;
            this.studentibtn.Text = "STUDENTI";
            this.studentibtn.UseVisualStyleBackColor = false;
            // 
            // catalogbtn
            // 
            this.catalogbtn.BackColor = System.Drawing.Color.Teal;
            this.catalogbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.catalogbtn.FlatAppearance.BorderSize = 0;
            this.catalogbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catalogbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.catalogbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.catalogbtn.Location = new System.Drawing.Point(110, 118);
            this.catalogbtn.Name = "catalogbtn";
            this.catalogbtn.Size = new System.Drawing.Size(191, 40);
            this.catalogbtn.TabIndex = 0;
            this.catalogbtn.Text = "CATALOG";
            this.catalogbtn.UseVisualStyleBackColor = false;
            this.catalogbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // btniesire
            // 
            this.btniesire.BackColor = System.Drawing.Color.Teal;
            this.btniesire.FlatAppearance.BorderSize = 0;
            this.btniesire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btniesire.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btniesire.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btniesire.Location = new System.Drawing.Point(110, 337);
            this.btniesire.Name = "btniesire";
            this.btniesire.Size = new System.Drawing.Size(191, 40);
            this.btniesire.TabIndex = 4;
            this.btniesire.Text = "IESIRE";
            this.btniesire.UseVisualStyleBackColor = false;
            this.btniesire.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(906, 470);
            this.Controls.Add(this.btniesire);
            this.Controls.Add(this.disciplinebtn);
            this.Controls.Add(this.studentibtn);
            this.Controls.Add(this.catalogbtn);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Catalog Online";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button disciplinebtn;
        private System.Windows.Forms.Button studentibtn;
        private System.Windows.Forms.Button catalogbtn;
        private System.Windows.Forms.Button btniesire;
    }
}

