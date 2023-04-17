namespace Baitap2
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
            this.menuCHUCNANG = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutOtn = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatOtn = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMucNhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyNhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongKeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCHUCNANG,
            this.LogoutOtn,
            this.thoatOtn});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(518, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuCHUCNANG
            // 
            this.menuCHUCNANG.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMucNhanVienToolStripMenuItem,
            this.quanLyNhanVienToolStripMenuItem,
            this.thongKeToolStripMenuItem});
            this.menuCHUCNANG.Name = "menuCHUCNANG";
            this.menuCHUCNANG.Size = new System.Drawing.Size(89, 20);
            this.menuCHUCNANG.Text = "CHUC NANG";
            // 
            // LogoutOtn
            // 
            this.LogoutOtn.Name = "LogoutOtn";
            this.LogoutOtn.Size = new System.Drawing.Size(74, 20);
            this.LogoutOtn.Text = "Dang Xuat";
            this.LogoutOtn.Click += new System.EventHandler(this.LogoutOtn_Click);
            // 
            // thoatOtn
            // 
            this.thoatOtn.Name = "thoatOtn";
            this.thoatOtn.Size = new System.Drawing.Size(49, 20);
            this.thoatOtn.Text = "Thoat";
            this.thoatOtn.Click += new System.EventHandler(this.thoatOtn_Click);
            // 
            // danhMucNhanVienToolStripMenuItem
            // 
            this.danhMucNhanVienToolStripMenuItem.Name = "danhMucNhanVienToolStripMenuItem";
            this.danhMucNhanVienToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.danhMucNhanVienToolStripMenuItem.Text = "Danh Muc Nhan Vien";
            this.danhMucNhanVienToolStripMenuItem.Click += new System.EventHandler(this.danhMucNhanVienToolStripMenuItem_Click);
            // 
            // quanLyNhanVienToolStripMenuItem
            // 
            this.quanLyNhanVienToolStripMenuItem.Name = "quanLyNhanVienToolStripMenuItem";
            this.quanLyNhanVienToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.quanLyNhanVienToolStripMenuItem.Text = "Quan Ly Nhan Vien";
            this.quanLyNhanVienToolStripMenuItem.Click += new System.EventHandler(this.quanLyNhanVienToolStripMenuItem_Click);
            // 
            // thongKeToolStripMenuItem
            // 
            this.thongKeToolStripMenuItem.Name = "thongKeToolStripMenuItem";
            this.thongKeToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.thongKeToolStripMenuItem.Text = "Thong Ke";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 191);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(287, 26);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bay Gio La";
            // 
            // HeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 353);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HeThong";
            this.Text = "HeThong";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuCHUCNANG;
        private System.Windows.Forms.ToolStripMenuItem danhMucNhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyNhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongKeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogoutOtn;
        private System.Windows.Forms.ToolStripMenuItem thoatOtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
    }
}