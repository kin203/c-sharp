namespace BaiOnTap3
{
    partial class HeThong
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhMucLopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMucLopToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyDiemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongKeDiemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMucLopToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhMucLopToolStripMenuItem
            // 
            this.danhMucLopToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMucLopToolStripMenuItem1,
            this.quanLyDiemToolStripMenuItem,
            this.thongKeDiemToolStripMenuItem});
            this.danhMucLopToolStripMenuItem.Name = "danhMucLopToolStripMenuItem";
            this.danhMucLopToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.danhMucLopToolStripMenuItem.Text = "Chuc Nang";
            // 
            // danhMucLopToolStripMenuItem1
            // 
            this.danhMucLopToolStripMenuItem1.Name = "danhMucLopToolStripMenuItem1";
            this.danhMucLopToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.danhMucLopToolStripMenuItem1.Text = "Danh Muc Lop";
            this.danhMucLopToolStripMenuItem1.Click += new System.EventHandler(this.danhMucLopToolStripMenuItem1_Click);
            // 
            // quanLyDiemToolStripMenuItem
            // 
            this.quanLyDiemToolStripMenuItem.Name = "quanLyDiemToolStripMenuItem";
            this.quanLyDiemToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.quanLyDiemToolStripMenuItem.Text = "Quan Ly Diem";
            this.quanLyDiemToolStripMenuItem.Click += new System.EventHandler(this.quanLyDiemToolStripMenuItem_Click);
            // 
            // thongKeDiemToolStripMenuItem
            // 
            this.thongKeDiemToolStripMenuItem.Name = "thongKeDiemToolStripMenuItem";
            this.thongKeDiemToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.thongKeDiemToolStripMenuItem.Text = "Thong Ke Diem";
            this.thongKeDiemToolStripMenuItem.Click += new System.EventHandler(this.thongKeDiemToolStripMenuItem_Click);
            // 
            // HeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 819);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 800);
            this.Name = "HeThong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HeThong";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HeThong_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMucLopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMucLopToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quanLyDiemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongKeDiemToolStripMenuItem;
    }
}