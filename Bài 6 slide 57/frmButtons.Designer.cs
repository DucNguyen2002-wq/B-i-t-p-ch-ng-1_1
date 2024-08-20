namespace Bài_6_slide_57
{
	 partial class frmButtons
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
				this.btnButton = new System.Windows.Forms.Button();
				this.ckbMauChu = new System.Windows.Forms.CheckBox();
				this.rdFlat = new System.Windows.Forms.RadioButton();
				this.ckbMauNen = new System.Windows.Forms.CheckBox();
				this.rdPopup = new System.Windows.Forms.RadioButton();
				this.btnButtonFlat = new System.Windows.Forms.Button();
				this.SuspendLayout();
				// 
				// btnButton
				// 
				this.btnButton.Location = new System.Drawing.Point(65, 70);
				this.btnButton.Name = "btnButton";
				this.btnButton.Size = new System.Drawing.Size(126, 29);
				this.btnButton.TabIndex = 0;
				this.btnButton.Text = "Button";
				this.btnButton.UseVisualStyleBackColor = true;
				this.btnButton.Click += new System.EventHandler(this.btnButton_Click);
				// 
				// ckbMauChu
				// 
				this.ckbMauChu.AutoSize = true;
				this.ckbMauChu.Location = new System.Drawing.Point(264, 53);
				this.ckbMauChu.Name = "ckbMauChu";
				this.ckbMauChu.Size = new System.Drawing.Size(135, 20);
				this.ckbMauChu.TabIndex = 1;
				this.ckbMauChu.Text = "Thay đổi màu chữ";
				this.ckbMauChu.UseVisualStyleBackColor = true;
				this.ckbMauChu.CheckedChanged += new System.EventHandler(this.ckbMauChu_CheckedChanged);
				// 
				// rdFlat
				// 
				this.rdFlat.AutoSize = true;
				this.rdFlat.Location = new System.Drawing.Point(264, 143);
				this.rdFlat.Name = "rdFlat";
				this.rdFlat.Size = new System.Drawing.Size(79, 20);
				this.rdFlat.TabIndex = 2;
				this.rdFlat.TabStop = true;
				this.rdFlat.Text = "Kiểu Flat";
				this.rdFlat.UseVisualStyleBackColor = true;
				this.rdFlat.CheckedChanged += new System.EventHandler(this.rdFlat_CheckedChanged);
				// 
				// ckbMauNen
				// 
				this.ckbMauNen.AutoSize = true;
				this.ckbMauNen.Location = new System.Drawing.Point(264, 79);
				this.ckbMauNen.Name = "ckbMauNen";
				this.ckbMauNen.Size = new System.Drawing.Size(136, 20);
				this.ckbMauNen.TabIndex = 1;
				this.ckbMauNen.Text = "Thay đổi màu nền";
				this.ckbMauNen.UseVisualStyleBackColor = true;
				this.ckbMauNen.CheckedChanged += new System.EventHandler(this.ckbMauNen_CheckedChanged);
				// 
				// rdPopup
				// 
				this.rdPopup.AutoSize = true;
				this.rdPopup.Location = new System.Drawing.Point(264, 169);
				this.rdPopup.Name = "rdPopup";
				this.rdPopup.Size = new System.Drawing.Size(97, 20);
				this.rdPopup.TabIndex = 2;
				this.rdPopup.TabStop = true;
				this.rdPopup.Text = "Kiểu Popup";
				this.rdPopup.UseVisualStyleBackColor = true;
				// 
				// btnButtonFlat
				// 
				this.btnButtonFlat.Location = new System.Drawing.Point(65, 143);
				this.btnButtonFlat.Name = "btnButtonFlat";
				this.btnButtonFlat.Size = new System.Drawing.Size(126, 29);
				this.btnButtonFlat.TabIndex = 0;
				this.btnButtonFlat.Text = "Button Flat";
				this.btnButtonFlat.UseVisualStyleBackColor = true;
				this.btnButtonFlat.Click += new System.EventHandler(this.btnButtonFlat_Click);
				// 
				// frmButtons
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(800, 450);
				this.Controls.Add(this.rdPopup);
				this.Controls.Add(this.rdFlat);
				this.Controls.Add(this.ckbMauNen);
				this.Controls.Add(this.ckbMauChu);
				this.Controls.Add(this.btnButtonFlat);
				this.Controls.Add(this.btnButton);
				this.Name = "frmButtons";
				this.Text = "Form1";
				this.ResumeLayout(false);
				this.PerformLayout();

		  }

		  #endregion

		  private System.Windows.Forms.Button btnButton;
		  private System.Windows.Forms.CheckBox ckbMauChu;
		  private System.Windows.Forms.RadioButton rdFlat;
		  private System.Windows.Forms.CheckBox ckbMauNen;
		  private System.Windows.Forms.RadioButton rdPopup;
		  private System.Windows.Forms.Button btnButtonFlat;
	 }
}

