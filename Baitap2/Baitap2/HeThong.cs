using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap2
{
    public partial class HeThong : Form
    {
        public HeThong()
        {
            InitializeComponent();
        }

        private void danhMucNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhMucNhanVien dmnv = new DanhMucNhanVien();
            dmnv.Show();
            this.Hide();
        }

        private void LogoutOtn_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap dn = new DangNhap();
            dn.Show();
            MessageBox.Show("Da Dang Xuat !!");
        }

        private void thoatOtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quanLyNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            this.Hide();
            nv.Show();
        }
    }
}
