using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_01
{
  public partial class frmWindowsMedia : Form
  {
    public frmWindowsMedia()
    {
      InitializeComponent();
    }

    private void smsExit_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      var now = DateTime.Now;
      this.ssTime.Text = $"{now:dd/MM/yyyy} - {now:hh:mm:ss tt}";
    }

    private void smsOpen_Click(object sender, EventArgs e)
    {
      OpenFileDialog dlg = new OpenFileDialog
      {
        Title = "Chọn tệp đa phương tiện",
        Filter = "All Files|*.*|AVI File (*.avi)|*.avi|MPEG File (*.mpeg)|*.mpeg|Wav File (*.wav)|*.wav|Midi File (*.midi)|*.midi|Mp4 File (*.mp4)|*.mp4|MP3 File (*.mp3)|*.mp3",
        InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer)
      };

      if (dlg.ShowDialog() == DialogResult.OK)
      {
        if (string.IsNullOrEmpty(dlg.FileName))
        {
          MessageBox.Show("Không tìm thấy tệp để mở!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          return;
        }
        if (!File.Exists(dlg.FileName))
        {
          MessageBox.Show("Tệp không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          return;
        }

        var supportedFormats = new HashSet<string> { ".avi", ".mpeg", ".wav", ".midi", ".mp4", ".mp3" };
        if (!supportedFormats.Contains(System.IO.Path.GetExtension(dlg.FileName).ToLower()))
        {
          MessageBox.Show("Định dạng file không được hỗ trợ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          return;
        }

        try
        {
          axWindowsMediaPlayer1.URL = dlg.FileName;
          this.Text = System.IO.Path.GetFileName(dlg.FileName);
        }
        catch (Exception ex)
        {
          MessageBox.Show($"Không thể mở tệp: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }
  }
}
