namespace Bài_4_slide_52
{
	 partial class frmListBox
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
				this.lbDanhSach = new System.Windows.Forms.ListBox();
				this.lbDanhSachChon = new System.Windows.Forms.ListBox();
				this.btnAdd = new System.Windows.Forms.Button();
				this.btnRemove = new System.Windows.Forms.Button();
				this.label1 = new System.Windows.Forms.Label();
				this.label2 = new System.Windows.Forms.Label();
				this.SuspendLayout();
				// 
				// lbDanhSach
				// 
				this.lbDanhSach.FormattingEnabled = true;
				this.lbDanhSach.ItemHeight = 16;
				this.lbDanhSach.Items.AddRange(new object[] {
            "123",
            "456",
            "798",
            "AAA",
            "BBB",
            "CCC"});
				this.lbDanhSach.Location = new System.Drawing.Point(25, 110);
				this.lbDanhSach.Name = "lbDanhSach";
				this.lbDanhSach.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
				this.lbDanhSach.Size = new System.Drawing.Size(281, 292);
				this.lbDanhSach.TabIndex = 0;
				this.lbDanhSach.SelectedIndexChanged += new System.EventHandler(this.lbDanhSach_SelectedIndexChanged);
				// 
				// lbDanhSachChon
				// 
				this.lbDanhSachChon.FormattingEnabled = true;
				this.lbDanhSachChon.ItemHeight = 16;
				this.lbDanhSachChon.Location = new System.Drawing.Point(490, 110);
				this.lbDanhSachChon.Name = "lbDanhSachChon";
				this.lbDanhSachChon.Size = new System.Drawing.Size(281, 292);
				this.lbDanhSachChon.TabIndex = 0;
				this.lbDanhSachChon.SelectedIndexChanged += new System.EventHandler(this.lbDanhSachChon_SelectedIndexChanged);
				// 
				// btnAdd
				// 
				this.btnAdd.Location = new System.Drawing.Point(355, 203);
				this.btnAdd.Name = "btnAdd";
				this.btnAdd.Size = new System.Drawing.Size(83, 29);
				this.btnAdd.TabIndex = 1;
				this.btnAdd.Text = "Chọn";
				this.btnAdd.UseVisualStyleBackColor = true;
				this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
				// 
				// btnRemove
				// 
				this.btnRemove.Location = new System.Drawing.Point(355, 274);
				this.btnRemove.Name = "btnRemove";
				this.btnRemove.Size = new System.Drawing.Size(83, 29);
				this.btnRemove.TabIndex = 1;
				this.btnRemove.Text = "Xóa";
				this.btnRemove.UseVisualStyleBackColor = true;
				this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
				// 
				// label1
				// 
				this.label1.AutoSize = true;
				this.label1.Location = new System.Drawing.Point(22, 91);
				this.label1.Name = "label1";
				this.label1.Size = new System.Drawing.Size(148, 16);
				this.label1.TabIndex = 2;
				this.label1.Text = "Danh sách sinh viên lớp";
				// 
				// label2
				// 
				this.label2.AutoSize = true;
				this.label2.Location = new System.Drawing.Point(487, 91);
				this.label2.Name = "label2";
				this.label2.Size = new System.Drawing.Size(233, 16);
				this.label2.TabIndex = 2;
				this.label2.Text = "Danh sách sinh viên tham gia bóng đá";
				// 
				// frmListBox
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(800, 450);
				this.Controls.Add(this.label2);
				this.Controls.Add(this.label1);
				this.Controls.Add(this.btnRemove);
				this.Controls.Add(this.btnAdd);
				this.Controls.Add(this.lbDanhSachChon);
				this.Controls.Add(this.lbDanhSach);
				this.Name = "frmListBox";
				this.Text = "ListBox";
				this.ResumeLayout(false);
				this.PerformLayout();

		  }

		  #endregion

		  private System.Windows.Forms.ListBox lbDanhSach;
		  private System.Windows.Forms.ListBox lbDanhSachChon;
		  private System.Windows.Forms.Button btnAdd;
		  private System.Windows.Forms.Button btnRemove;
		  private System.Windows.Forms.Label label1;
		  private System.Windows.Forms.Label label2;
	 }
}

