namespace Lab03_01
{
   partial class frmWindowsMedia
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWindowsMedia));
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.msFile = new System.Windows.Forms.ToolStripMenuItem();
         this.smsOpen = new System.Windows.Forms.ToolStripMenuItem();
         this.smsExit = new System.Windows.Forms.ToolStripMenuItem();
         this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.statusStrip1 = new System.Windows.Forms.StatusStrip();
         this.ssTime = new System.Windows.Forms.ToolStripStatusLabel();
         this.timer1 = new System.Windows.Forms.Timer(this.components);
         this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
         this.menuStrip1.SuspendLayout();
         this.statusStrip1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
         this.SuspendLayout();
         // 
         // menuStrip1
         // 
         this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
         this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msFile});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
         this.menuStrip1.Size = new System.Drawing.Size(1467, 42);
         this.menuStrip1.TabIndex = 0;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // msFile
         // 
         this.msFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smsOpen,
            this.smsExit});
         this.msFile.Name = "msFile";
         this.msFile.Size = new System.Drawing.Size(62, 34);
         this.msFile.Text = "File";
         // 
         // smsOpen
         // 
         this.smsOpen.Name = "smsOpen";
         this.smsOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
         this.smsOpen.Size = new System.Drawing.Size(257, 40);
         this.smsOpen.Text = "Open";
         this.smsOpen.Click += new System.EventHandler(this.smsOpen_Click);
         // 
         // smsExit
         // 
         this.smsExit.Name = "smsExit";
         this.smsExit.Size = new System.Drawing.Size(257, 40);
         this.smsExit.Text = "Exit";
         this.smsExit.Click += new System.EventHandler(this.smsExit_Click);
         // 
         // contextMenuStrip1
         // 
         this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
         this.contextMenuStrip1.Name = "contextMenuStrip1";
         this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
         // 
         // statusStrip1
         // 
         this.statusStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
         this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssTime});
         this.statusStrip1.Location = new System.Drawing.Point(0, 792);
         this.statusStrip1.Name = "statusStrip1";
         this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 26, 0);
         this.statusStrip1.Size = new System.Drawing.Size(1467, 39);
         this.statusStrip1.TabIndex = 2;
         this.statusStrip1.Text = "statusStrip1";
         // 
         // ssTime
         // 
         this.ssTime.Name = "ssTime";
         this.ssTime.Size = new System.Drawing.Size(100, 30);
         this.ssTime.Text = "Thời gian";
         // 
         // timer1
         // 
         this.timer1.Enabled = true;
         this.timer1.Interval = 1000;
         this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
         // 
         // axWindowsMediaPlayer1
         // 
         this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.axWindowsMediaPlayer1.Enabled = true;
         this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 42);
         this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(4);
         this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
         this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
         this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1467, 750);
         this.axWindowsMediaPlayer1.TabIndex = 3;
         // 
         // frmWindowsMedia
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.AutoSize = true;
         this.ClientSize = new System.Drawing.Size(1467, 831);
         this.Controls.Add(this.axWindowsMediaPlayer1);
         this.Controls.Add(this.statusStrip1);
         this.Controls.Add(this.menuStrip1);
         this.MainMenuStrip = this.menuStrip1;
         this.Margin = new System.Windows.Forms.Padding(6);
         this.Name = "frmWindowsMedia";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "CHUƠNG TRÌNH WINDOWS MEDIA";
         this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         this.statusStrip1.ResumeLayout(false);
         this.statusStrip1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
      private System.Windows.Forms.ToolStripMenuItem msFile;
      private System.Windows.Forms.ToolStripMenuItem smsOpen;
      private System.Windows.Forms.ToolStripMenuItem smsExit;
      private System.Windows.Forms.StatusStrip statusStrip1;
      private System.Windows.Forms.ToolStripStatusLabel ssTime;
      private System.Windows.Forms.Timer timer1;
      private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
   }
}