using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap2_1
{
    public partial class HeThong : Form
    {
        public HeThong()
        {
            InitializeComponent();
        }

        private void loaiNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoaiNhanVien f1 = new LoaiNhanVien();
            f1.MdiParent = this;
            f1.Show();
        }

        private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien f2 = new NhanVien();
            f2.MdiParent = this;
            f2.Show();
        }

        private void HeThong_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
