﻿namespace RunAsAdmin
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
            this.btnRunAsAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRunAsAdmin
            // 
            this.btnRunAsAdmin.Location = new System.Drawing.Point(107, 74);
            this.btnRunAsAdmin.Name = "btnRunAsAdmin";
            this.btnRunAsAdmin.Size = new System.Drawing.Size(227, 103);
            this.btnRunAsAdmin.TabIndex = 0;
            this.btnRunAsAdmin.Text = "Run as Admin";
            this.btnRunAsAdmin.UseVisualStyleBackColor = true;
            this.btnRunAsAdmin.Click += new System.EventHandler(this.btnRunAsAdmin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 262);
            this.Controls.Add(this.btnRunAsAdmin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRunAsAdmin;
    }
}

