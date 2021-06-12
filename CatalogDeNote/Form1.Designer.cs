
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
            this.catalogbtn = new System.Windows.Forms.Button();
            this.studentibtn = new System.Windows.Forms.Button();
            this.disciplinebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // catalogbtn
            // 
            this.catalogbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.catalogbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.catalogbtn.Location = new System.Drawing.Point(110, 118);
            this.catalogbtn.Name = "catalogbtn";
            this.catalogbtn.Size = new System.Drawing.Size(191, 40);
            this.catalogbtn.TabIndex = 0;
            this.catalogbtn.Text = "CATALOG";
            this.catalogbtn.UseVisualStyleBackColor = true;
            this.catalogbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // studentibtn
            // 
            this.studentibtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.studentibtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.studentibtn.Location = new System.Drawing.Point(110, 189);
            this.studentibtn.Name = "studentibtn";
            this.studentibtn.Size = new System.Drawing.Size(191, 40);
            this.studentibtn.TabIndex = 2;
            this.studentibtn.Text = "STUDENTI";
            this.studentibtn.UseVisualStyleBackColor = true;
            // 
            // disciplinebtn
            // 
            this.disciplinebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.disciplinebtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.disciplinebtn.Location = new System.Drawing.Point(110, 264);
            this.disciplinebtn.Name = "disciplinebtn";
            this.disciplinebtn.Size = new System.Drawing.Size(191, 40);
            this.disciplinebtn.TabIndex = 3;
            this.disciplinebtn.Text = "DISCIPLINE";
            this.disciplinebtn.UseVisualStyleBackColor = true;
            this.disciplinebtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(906, 470);
            this.Controls.Add(this.disciplinebtn);
            this.Controls.Add(this.studentibtn);
            this.Controls.Add(this.catalogbtn);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button catalogbtn;
        private System.Windows.Forms.Button studentibtn;
        private System.Windows.Forms.Button disciplinebtn;
    }
}

