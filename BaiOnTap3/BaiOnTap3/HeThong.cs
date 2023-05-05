using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiOnTap3
{
    public partial class HeThong : Form
    {
        public HeThong()
        {
            InitializeComponent();
        }

        private void danhMucLopToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Lop Lop = new Lop();
            Lop.MdiParent = this;
            Lop.Show();
        }

        private void quanLyDiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Diem diem = new Diem();
            diem.MdiParent = this;
            diem.Show();
        }

        private void thongKeDiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBaoCao fbc = new FormBaoCao();
            fbc.MdiParent = this;
            fbc.Show();
        }

        private void HeThong_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
