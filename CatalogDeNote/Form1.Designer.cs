﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.disciplinebtn = new System.Windows.Forms.Button();
            this.studentibtn = new System.Windows.Forms.Button();
            this.catalogbtn = new System.Windows.Forms.Button();
            this.btniesire = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // disciplinebtn
            // 
            this.disciplinebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(173)))));
            this.disciplinebtn.FlatAppearance.BorderSize = 0;
            this.disciplinebtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disciplinebtn.ForeColor = System.Drawing.Color.White;
            this.disciplinebtn.Image = ((System.Drawing.Image)(resources.GetObject("disciplinebtn.Image")));
            this.disciplinebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.disciplinebtn.Location = new System.Drawing.Point(13, 156);
            this.disciplinebtn.Name = "disciplinebtn";
            this.disciplinebtn.Size = new System.Drawing.Size(142, 40);
            this.disciplinebtn.TabIndex = 3;
            this.disciplinebtn.Text = "Discipline";
            this.disciplinebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.disciplinebtn.UseVisualStyleBackColor = false;
            this.disciplinebtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // studentibtn
            // 
            this.studentibtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(173)))));
            this.studentibtn.FlatAppearance.BorderSize = 0;
            this.studentibtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentibtn.ForeColor = System.Drawing.Color.White;
            this.studentibtn.Image = ((System.Drawing.Image)(resources.GetObject("studentibtn.Image")));
            this.studentibtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.studentibtn.Location = new System.Drawing.Point(13, 87);
            this.studentibtn.Name = "studentibtn";
            this.studentibtn.Size = new System.Drawing.Size(142, 40);
            this.studentibtn.TabIndex = 2;
            this.studentibtn.Text = "Studenți";
            this.studentibtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.studentibtn.UseVisualStyleBackColor = false;
            this.studentibtn.Click += new System.EventHandler(this.studentibtn_Click);
            // 
            // catalogbtn
            // 
            this.catalogbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(173)))));
            this.catalogbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.catalogbtn.FlatAppearance.BorderSize = 0;
            this.catalogbtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catalogbtn.ForeColor = System.Drawing.Color.White;
            this.catalogbtn.Image = ((System.Drawing.Image)(resources.GetObject("catalogbtn.Image")));
            this.catalogbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.catalogbtn.Location = new System.Drawing.Point(13, 21);
            this.catalogbtn.Name = "catalogbtn";
            this.catalogbtn.Size = new System.Drawing.Size(142, 40);
            this.catalogbtn.TabIndex = 0;
            this.catalogbtn.Text = "Catalog";
            this.catalogbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.catalogbtn.UseVisualStyleBackColor = false;
            this.catalogbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // btniesire
            // 
            this.btniesire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(173)))));
            this.btniesire.FlatAppearance.BorderSize = 0;
            this.btniesire.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniesire.ForeColor = System.Drawing.Color.White;
            this.btniesire.Image = ((System.Drawing.Image)(resources.GetObject("btniesire.Image")));
            this.btniesire.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btniesire.Location = new System.Drawing.Point(13, 365);
            this.btniesire.Name = "btniesire";
            this.btniesire.Size = new System.Drawing.Size(142, 40);
            this.btniesire.TabIndex = 4;
            this.btniesire.Text = "Ieșire";
            this.btniesire.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btniesire.UseVisualStyleBackColor = false;
            this.btniesire.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(this.catalogbtn);
            this.panel1.Controls.Add(this.btniesire);
            this.panel1.Controls.Add(this.studentibtn);
            this.panel1.Controls.Add(this.disciplinebtn);
            this.panel1.Location = new System.Drawing.Point(-1, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 408);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(906, 470);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Catalog Online";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button disciplinebtn;
        private System.Windows.Forms.Button studentibtn;
        private System.Windows.Forms.Button catalogbtn;
        private System.Windows.Forms.Button btniesire;
        private System.Windows.Forms.Panel panel1;
    }
}

