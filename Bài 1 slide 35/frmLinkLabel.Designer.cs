﻿namespace Bài_1_slide_35
{
    partial class frmLinkLabel
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
				this.linkLabel1 = new System.Windows.Forms.LinkLabel();
				this.linkLabel2 = new System.Windows.Forms.LinkLabel();
				this.label1 = new System.Windows.Forms.Label();
				this.label2 = new System.Windows.Forms.Label();
				this.SuspendLayout();
				// 
				// linkLabel1
				// 
				this.linkLabel1.AutoSize = true;
				this.linkLabel1.Location = new System.Drawing.Point(256, 63);
				this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
				this.linkLabel1.Name = "linkLabel1";
				this.linkLabel1.Size = new System.Drawing.Size(122, 16);
				this.linkLabel1.TabIndex = 0;
				this.linkLabel1.TabStop = true;
				this.linkLabel1.Text = "ctk44a@gmail.com";
				this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
				// 
				// linkLabel2
				// 
				this.linkLabel2.AutoSize = true;
				this.linkLabel2.Location = new System.Drawing.Point(256, 114);
				this.linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
				this.linkLabel2.Name = "linkLabel2";
				this.linkLabel2.Size = new System.Drawing.Size(99, 16);
				this.linkLabel2.TabIndex = 1;
				this.linkLabel2.TabStop = true;
				this.linkLabel2.Text = "www.cnttk44.net";
				this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
				// 
				// label1
				// 
				this.label1.AutoSize = true;
				this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.label1.ForeColor = System.Drawing.Color.Red;
				this.label1.Location = new System.Drawing.Point(96, 63);
				this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
				this.label1.Name = "label1";
				this.label1.Size = new System.Drawing.Size(114, 18);
				this.label1.TabIndex = 2;
				this.label1.Text = "Địa chỉ liên hệ";
				// 
				// label2
				// 
				this.label2.AutoSize = true;
				this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.label2.ForeColor = System.Drawing.Color.Red;
				this.label2.Location = new System.Drawing.Point(96, 114);
				this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
				this.label2.Name = "label2";
				this.label2.Size = new System.Drawing.Size(86, 18);
				this.label2.TabIndex = 2;
				this.label2.Text = "Trang web";
				// 
				// frmLinkLabel
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(479, 246);
				this.Controls.Add(this.label2);
				this.Controls.Add(this.label1);
				this.Controls.Add(this.linkLabel2);
				this.Controls.Add(this.linkLabel1);
				this.Margin = new System.Windows.Forms.Padding(4);
				this.Name = "frmLinkLabel";
				this.Text = "LinkLabel";
				this.Load += new System.EventHandler(this.frmLinkLabel_Load);
				this.Click += new System.EventHandler(this.frmLinkLabel_Load);
				this.ResumeLayout(false);
				this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

