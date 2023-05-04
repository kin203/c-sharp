using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanh4
{
    public partial class HeThong : Form
    {
        public HeThong()
        {
            InitializeComponent();
        }

        private void loaiPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoaiPhong lp = new LoaiPhong();
            lp.MdiParent = this;
            lp.Show();
        }

        private void lichDangKyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LichDangKy ldk = new LichDangKy();
            ldk.MdiParent = this;
            ldk.Show();
        }

        private void thongKeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKe tk = new ThongKe();
            tk.MdiParent = this;
            tk.Show();
        }
    }
}
