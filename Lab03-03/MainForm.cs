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
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      dgvStudents.Columns.Clear();
      dgvStudents.Columns.Add("SoThuTu", "Số thứ tự");
      dgvStudents.Columns.Add("MaSoSinhVien", "Mã số SV");
      dgvStudents.Columns.Add("TenSinhVien", "Tên SV");
      dgvStudents.Columns.Add("Khoa", "Khoa");
      dgvStudents.Columns.Add("DiemTrungBinh", "Điểm TB");
      dgvStudents.Rows.Clear();
      SetWatermark();
    }

    private void AddStudentToGrid(Student student)
    {
      foreach (DataGridViewRow row in dgvStudents.Rows)
      {
        if (row.Cells["MaSoSinhVien"].Value?.ToString() == student.StudentID)
        {
          MessageBox.Show("Sinh viên này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          return;
        }
      }
      int newRowIndex = dgvStudents.Rows.Add();
      dgvStudents.Rows[newRowIndex].SetValues(newRowIndex + 1, student.StudentID, student.Name, student.Department, student.GPA);
    }

    // Goi Form nhap lieu sinh vien
    private void ShowAddStudentForm()
    {
      var addForm = new AddStudentForm();
      addForm.StudentAdded += AddStudentToGrid;
      addForm.ShowDialog();
    }

    private void menuAddNew_Click(object sender, EventArgs e)
    {
      ShowAddStudentForm();
    }

    private void toolAddNew_Click(object sender, EventArgs e)
    {
      ShowAddStudentForm();
    }

    private void menuExit_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void txtSearch_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        Search();
        e.Handled = true; // Ngăn hành động mặc định
        e.SuppressKeyPress = true; // Ngăn tiếng bíp khi nhấn Enter
      }
    }

    private void toolSearch_Click(object sender, EventArgs e)
    {
      Search();
    }

    private void Search()
    {
      string keyword = txtSearch.Text.Trim().ToLower();
      bool found = false;

      if (dgvStudents.Rows.Cast<DataGridViewRow>().All(r => r.IsNewRow))
      {
        MessageBox.Show("Danh sách sinh viên trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      // Duyet tat ca hang trong dgv nhung bo qua dong trong
      foreach (DataGridViewRow row in dgvStudents.Rows.Cast<DataGridViewRow>().Where(r => !r.IsNewRow))
      {
        if (row.IsNewRow)
          continue;

        // Lay gia tri cua 2 cot MSSV va TenSV
        string studentID = row.Cells["MaSoSinhVien"].Value?.ToString().ToLower();
        string studentName = row.Cells["TenSinhVien"].Value?.ToString().ToLower();

        // Kiem tra keyword xuat hien trong MSSV hoac TenSV
        bool isVisible = !string.IsNullOrEmpty(studentID) && studentID.Contains(keyword) ||
                         !string.IsNullOrEmpty(studentName) && studentName.Contains(keyword);

        row.Visible = isVisible;
        if (isVisible)
          found = true;
      }
      if (!found)
      {
        MessageBox.Show("Không tìm thấy kết quả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }

    // Thiet lap chu mo cho Textbox
    private void SetWatermark()
    {
      txtSearch.Text = "Tìm kiếm theo ID hoặc Tên";
      txtSearch.ForeColor = Color.Gray;
    }

    private void txtSearch_Enter(object sender, EventArgs e)
    {
      if (txtSearch.Text == "Tìm kiếm theo ID hoặc Tên")
      {
        txtSearch.Text = "";
        txtSearch.ForeColor = Color.Black;
      }
    }

    private void txtSearch_Leave(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(txtSearch.Text))
      {
        SetWatermark();
      }
    }

    // Xoá dữ liệu Textbox tìm kiếm
    private void toolClear_Click(object sender, EventArgs e)
    {
      txtSearch.Text = "";
      foreach (DataGridViewRow row in dgvStudents.Rows)
      {
        row.Visible = true;
      }
      SetWatermark();
    }
  }
}
