namespace Bài_5_slide_56
{
	 partial class frmRadioButton
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
				this.groupBox1 = new System.Windows.Forms.GroupBox();
				this.rbNam = new System.Windows.Forms.RadioButton();
				this.rbNu = new System.Windows.Forms.RadioButton();
				this.groupBox1.SuspendLayout();
				this.SuspendLayout();
				// 
				// groupBox1
				// 
				this.groupBox1.Controls.Add(this.rbNu);
				this.groupBox1.Controls.Add(this.rbNam);
				this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.groupBox1.Location = new System.Drawing.Point(32, 34);
				this.groupBox1.Name = "groupBox1";
				this.groupBox1.Size = new System.Drawing.Size(205, 124);
				this.groupBox1.TabIndex = 0;
				this.groupBox1.TabStop = false;
				this.groupBox1.Text = "Giới tính";
				// 
				// rbNam
				// 
				this.rbNam.AutoSize = true;
				this.rbNam.Location = new System.Drawing.Point(48, 33);
				this.rbNam.Name = "rbNam";
				this.rbNam.Size = new System.Drawing.Size(65, 24);
				this.rbNam.TabIndex = 0;
				this.rbNam.TabStop = true;
				this.rbNam.Text = "Nam";
				this.rbNam.UseVisualStyleBackColor = true;
				this.rbNam.CheckedChanged += new System.EventHandler(this.rbNam_CheckedChanged);
				// 
				// rbNu
				// 
				this.rbNu.AutoSize = true;
				this.rbNu.Location = new System.Drawing.Point(48, 76);
				this.rbNu.Name = "rbNu";
				this.rbNu.Size = new System.Drawing.Size(51, 24);
				this.rbNu.TabIndex = 0;
				this.rbNu.TabStop = true;
				this.rbNu.Text = "Nữ";
				this.rbNu.UseVisualStyleBackColor = true;
				this.rbNu.CheckedChanged += new System.EventHandler(this.rbNu_CheckedChanged);
				// 
				// frmRadioButton
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(298, 193);
				this.Controls.Add(this.groupBox1);
				this.Name = "frmRadioButton";
				this.Text = "Demo RadioButton";
				this.groupBox1.ResumeLayout(false);
				this.groupBox1.PerformLayout();
				this.ResumeLayout(false);

		  }

		  #endregion

		  private System.Windows.Forms.GroupBox groupBox1;
		  private System.Windows.Forms.RadioButton rbNu;
		  private System.Windows.Forms.RadioButton rbNam;
	 }
}

