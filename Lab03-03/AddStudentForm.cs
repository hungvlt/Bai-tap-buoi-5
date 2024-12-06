using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_03
{
  public partial class AddStudentForm : Form
  {
    public delegate void StudentAddedEventHandler(Student student);
    public event StudentAddedEventHandler StudentAdded;

    public AddStudentForm()
    {
      InitializeComponent();
    }

    private void AddStudentForm_Load(object sender, EventArgs e)
    {
      cbDepartment.SelectedIndex = 0;
    }

    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
      if (keyData == Keys.Enter &&
        (txtStudentID.Focused || txtStudentName.Focused || txtGPA.Focused || cbDepartment.Focused))
      {
        // Gọi phương thức thêm sinh viên
        btnAdd.PerformClick();
        return true;
      }
      return base.ProcessCmdKey(ref msg, keyData);
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrWhiteSpace(txtStudentID.Text) ||
          string.IsNullOrWhiteSpace(txtStudentName.Text) ||
          cbDepartment.SelectedItem == null ||
          string.IsNullOrWhiteSpace(txtGPA.Text))
      {
        MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      if (!decimal.TryParse(txtGPA.Text, out decimal gpa) || gpa < 0 || gpa > 10)
      {
        MessageBox.Show("Điểm trung bình phải nằm trong khoảng 0 - 10", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      var student = new Student
      {
        StudentID = txtStudentID.Text,
        Name = txtStudentName.Text,
        Department = cbDepartment.SelectedItem.ToString(),
        GPA = gpa
      };

      StudentAdded?.Invoke(student);
      txtStudentID.Clear();
      txtStudentName.Clear();
      cbDepartment.SelectedIndex = 0;
      txtGPA.Clear();
      txtStudentID.Focus();
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      this.Close();
    }

  }
}
