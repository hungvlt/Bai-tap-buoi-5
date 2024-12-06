namespace Lab03_03
{
   partial class MainForm
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuAddNew = new System.Windows.Forms.ToolStripMenuItem();
      this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.toolAddNew = new System.Windows.Forms.ToolStripButton();
      this.toolSearch = new System.Windows.Forms.ToolStripButton();
      this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
      this.dgvStudents = new System.Windows.Forms.DataGridView();
      this.SoThuTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.MaSoSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.TenSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DiemTrungBinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
      this.toolClear = new System.Windows.Forms.ToolStripButton();
      this.menuStrip1.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(640, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // chứcNăngToolStripMenuItem
      // 
      this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddNew,
            this.menuExit});
      this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
      this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
      this.chứcNăngToolStripMenuItem.Text = "Chức năng";
      // 
      // menuAddNew
      // 
      this.menuAddNew.Name = "menuAddNew";
      this.menuAddNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
      this.menuAddNew.Size = new System.Drawing.Size(171, 22);
      this.menuAddNew.Text = "Thêm mới";
      this.menuAddNew.Click += new System.EventHandler(this.menuAddNew_Click);
      // 
      // menuExit
      // 
      this.menuExit.Name = "menuExit";
      this.menuExit.Size = new System.Drawing.Size(171, 22);
      this.menuExit.Text = "Thoát";
      this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
      // 
      // toolStrip1
      // 
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAddNew,
            this.toolSearch,
            this.txtSearch,
            this.toolClear});
      this.toolStrip1.Location = new System.Drawing.Point(0, 24);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(640, 25);
      this.toolStrip1.TabIndex = 1;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // toolAddNew
      // 
      this.toolAddNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolAddNew.Image = ((System.Drawing.Image)(resources.GetObject("toolAddNew.Image")));
      this.toolAddNew.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolAddNew.Name = "toolAddNew";
      this.toolAddNew.Size = new System.Drawing.Size(23, 22);
      this.toolAddNew.Text = "Thêm mới";
      this.toolAddNew.Click += new System.EventHandler(this.toolAddNew_Click);
      // 
      // toolSearch
      // 
      this.toolSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolSearch.Image = ((System.Drawing.Image)(resources.GetObject("toolSearch.Image")));
      this.toolSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolSearch.Name = "toolSearch";
      this.toolSearch.Size = new System.Drawing.Size(23, 22);
      this.toolSearch.Text = "Tìm kiếm theo tên";
      this.toolSearch.Click += new System.EventHandler(this.toolSearch_Click);
      // 
      // txtSearch
      // 
      this.txtSearch.AccessibleDescription = "";
      this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.txtSearch.Name = "txtSearch";
      this.txtSearch.Size = new System.Drawing.Size(150, 25);
      this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
      this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
      this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
      // 
      // dgvStudents
      // 
      this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoThuTu,
            this.MaSoSinhVien,
            this.TenSinhVien,
            this.Khoa,
            this.DiemTrungBinh});
      this.dgvStudents.Location = new System.Drawing.Point(7, 71);
      this.dgvStudents.Name = "dgvStudents";
      this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvStudents.Size = new System.Drawing.Size(623, 362);
      this.dgvStudents.TabIndex = 2;
      // 
      // SoThuTu
      // 
      this.SoThuTu.HeaderText = "Số thứ tự";
      this.SoThuTu.Name = "SoThuTu";
      // 
      // MaSoSinhVien
      // 
      this.MaSoSinhVien.HeaderText = "Mã số SV";
      this.MaSoSinhVien.Name = "MaSoSinhVien";
      // 
      // TenSinhVien
      // 
      this.TenSinhVien.HeaderText = "Tên SV";
      this.TenSinhVien.Name = "TenSinhVien";
      // 
      // Khoa
      // 
      this.Khoa.HeaderText = "Khoa";
      this.Khoa.Name = "Khoa";
      // 
      // DiemTrungBinh
      // 
      this.DiemTrungBinh.HeaderText = "Điểm TB";
      this.DiemTrungBinh.Name = "DiemTrungBinh";
      // 
      // toolClear
      // 
      this.toolClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolClear.Image = ((System.Drawing.Image)(resources.GetObject("toolClear.Image")));
      this.toolClear.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolClear.Name = "toolClear";
      this.toolClear.Size = new System.Drawing.Size(23, 22);
      this.toolClear.Text = "Xóa";
      this.toolClear.Click += new System.EventHandler(this.toolClear_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(640, 439);
      this.Controls.Add(this.dgvStudents);
      this.Controls.Add(this.toolStrip1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "QUẢN LÝ SINH VIÊN";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
      private System.Windows.Forms.ToolStrip toolStrip1;
      private System.Windows.Forms.ToolStripButton toolAddNew;
      private System.Windows.Forms.ToolStripButton toolSearch;
      private System.Windows.Forms.BindingSource bindingSource1;
      private System.Windows.Forms.DataGridView dgvStudents;
      private System.Windows.Forms.ToolStripTextBox txtSearch;
      private System.Windows.Forms.ToolStripMenuItem menuAddNew;
      private System.Windows.Forms.ToolStripMenuItem menuExit;
      private System.Windows.Forms.DataGridViewTextBoxColumn SoThuTu;
      private System.Windows.Forms.DataGridViewTextBoxColumn MaSoSinhVien;
      private System.Windows.Forms.DataGridViewTextBoxColumn TenSinhVien;
      private System.Windows.Forms.DataGridViewTextBoxColumn Khoa;
      private System.Windows.Forms.DataGridViewTextBoxColumn DiemTrungBinh;
    private System.Windows.Forms.ToolStripButton toolClear;
  }
}

