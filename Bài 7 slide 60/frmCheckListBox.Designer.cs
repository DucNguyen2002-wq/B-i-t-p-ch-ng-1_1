﻿namespace Bài_7_slide_60
{
	 partial class frmCheckListBox
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
				this.clbMonHoc = new System.Windows.Forms.CheckedListBox();
				this.SuspendLayout();
				// 
				// clbMonHoc
				// 
				this.clbMonHoc.CheckOnClick = true;
				this.clbMonHoc.FormattingEnabled = true;
				this.clbMonHoc.Items.AddRange(new object[] {
            "CC và MTLT 1",
            "Cơ sở dữ liệu",
            "Tiếng Anh 2",
            "Quản trị mạng"});
				this.clbMonHoc.Location = new System.Drawing.Point(95, 91);
				this.clbMonHoc.Name = "clbMonHoc";
				this.clbMonHoc.Size = new System.Drawing.Size(120, 123);
				this.clbMonHoc.TabIndex = 0;
				this.clbMonHoc.SelectedIndexChanged += new System.EventHandler(this.clbMonHoc_SelectedIndexChanged);
				// 
				// frmCheckListBox
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(800, 450);
				this.Controls.Add(this.clbMonHoc);
				this.Name = "frmCheckListBox";
				this.Text = "Demo CheckListBox";
				this.ResumeLayout(false);

		  }

		  #endregion

		  private System.Windows.Forms.CheckedListBox clbMonHoc;
	 }
}

