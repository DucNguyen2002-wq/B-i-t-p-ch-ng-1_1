namespace Bài_3_slide_48
{
    partial class frmDemoComboBox
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
				this.label1 = new System.Windows.Forms.Label();
				this.cboNgoaiNgu = new System.Windows.Forms.ComboBox();
				this.SuspendLayout();
				// 
				// label1
				// 
				this.label1.AutoSize = true;
				this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.label1.Location = new System.Drawing.Point(78, 120);
				this.label1.Name = "label1";
				this.label1.Size = new System.Drawing.Size(125, 20);
				this.label1.TabIndex = 0;
				this.label1.Text = "Chọn ngoại ngữ";
				// 
				// cboNgoaiNgu
				// 
				this.cboNgoaiNgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.cboNgoaiNgu.FormattingEnabled = true;
				this.cboNgoaiNgu.Location = new System.Drawing.Point(239, 117);
				this.cboNgoaiNgu.Name = "cboNgoaiNgu";
				this.cboNgoaiNgu.Size = new System.Drawing.Size(171, 28);
				this.cboNgoaiNgu.TabIndex = 1;
				this.cboNgoaiNgu.SelectedIndexChanged += new System.EventHandler(this.cboNgoaiNgu_SelectedIndexChanged);
				// 
				// frmDemoComboBox
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(800, 450);
				this.Controls.Add(this.cboNgoaiNgu);
				this.Controls.Add(this.label1);
				this.Name = "frmDemoComboBox";
				this.Text = "Demo ComboBox";
				this.Load += new System.EventHandler(this.frmDemoComboBox_Load);
				this.ResumeLayout(false);
				this.PerformLayout();

        }

		  #endregion

		  private System.Windows.Forms.Label label1;
		  private System.Windows.Forms.ComboBox cboNgoaiNgu;
	 }
}

