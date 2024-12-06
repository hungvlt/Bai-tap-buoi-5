namespace Lab03_03
{
   partial class AddStudentForm
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
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.txtStudentID = new System.Windows.Forms.TextBox();
      this.txtStudentName = new System.Windows.Forms.TextBox();
      this.txtGPA = new System.Windows.Forms.TextBox();
      this.cbDepartment = new System.Windows.Forms.ComboBox();
      this.btnAdd = new System.Windows.Forms.Button();
      this.btnExit = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(25, 41);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(106, 19);
      this.label1.TabIndex = 0;
      this.label1.Text = "Mã số sinh viên:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(25, 87);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(90, 19);
      this.label2.TabIndex = 1;
      this.label2.Text = "Tên sinh viên:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(25, 133);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(46, 19);
      this.label3.TabIndex = 2;
      this.label3.Text = "Khoa:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(25, 179);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(107, 19);
      this.label4.TabIndex = 3;
      this.label4.Text = "Điểm trung bình:";
      // 
      // txtStudentID
      // 
      this.txtStudentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtStudentID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtStudentID.Location = new System.Drawing.Point(148, 34);
      this.txtStudentID.Name = "txtStudentID";
      this.txtStudentID.Size = new System.Drawing.Size(165, 26);
      this.txtStudentID.TabIndex = 4;
      // 
      // txtStudentName
      // 
      this.txtStudentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtStudentName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtStudentName.Location = new System.Drawing.Point(148, 80);
      this.txtStudentName.Name = "txtStudentName";
      this.txtStudentName.Size = new System.Drawing.Size(272, 26);
      this.txtStudentName.TabIndex = 5;
      // 
      // txtGPA
      // 
      this.txtGPA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtGPA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtGPA.Location = new System.Drawing.Point(148, 172);
      this.txtGPA.Name = "txtGPA";
      this.txtGPA.Size = new System.Drawing.Size(69, 26);
      this.txtGPA.TabIndex = 6;
      // 
      // cbDepartment
      // 
      this.cbDepartment.BackColor = System.Drawing.SystemColors.Window;
      this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbDepartment.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbDepartment.FormattingEnabled = true;
      this.cbDepartment.Items.AddRange(new object[] {
            "Công nghệ Thông tin",
            "Ngôn ngữ Anh",
            "Quản trị Kinh doanh"});
      this.cbDepartment.Location = new System.Drawing.Point(148, 125);
      this.cbDepartment.Name = "cbDepartment";
      this.cbDepartment.Size = new System.Drawing.Size(272, 27);
      this.cbDepartment.TabIndex = 7;
      // 
      // btnAdd
      // 
      this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveBorder;
      this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
      this.btnAdd.Location = new System.Drawing.Point(241, 218);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(84, 32);
      this.btnAdd.TabIndex = 8;
      this.btnAdd.Text = "Thêm mới";
      this.btnAdd.UseVisualStyleBackColor = false;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // btnExit
      // 
      this.btnExit.BackColor = System.Drawing.SystemColors.ActiveBorder;
      this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
      this.btnExit.Location = new System.Drawing.Point(346, 218);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(75, 32);
      this.btnExit.TabIndex = 9;
      this.btnExit.Text = "Thoát";
      this.btnExit.UseVisualStyleBackColor = false;
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // AddStudentForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(459, 264);
      this.Controls.Add(this.btnExit);
      this.Controls.Add(this.btnAdd);
      this.Controls.Add(this.cbDepartment);
      this.Controls.Add(this.txtGPA);
      this.Controls.Add(this.txtStudentName);
      this.Controls.Add(this.txtStudentID);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "AddStudentForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Thêm sinh viên";
      this.Load += new System.EventHandler(this.AddStudentForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox txtStudentID;
      private System.Windows.Forms.TextBox txtStudentName;
      private System.Windows.Forms.TextBox txtGPA;
      private System.Windows.Forms.ComboBox cbDepartment;
      private System.Windows.Forms.Button btnAdd;
      private System.Windows.Forms.Button btnExit;
   }
}