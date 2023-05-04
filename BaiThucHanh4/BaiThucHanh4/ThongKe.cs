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
    public partial class ThongKe : Form
    {
        KetNoi kn = new KetNoi();

        public ThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = string.Format("select * from LichDangKy where MaGV='{0}' and NamHoc='{1}'",
                txtgv.Text,
                txtnh.Text);
            DataSet ds = kn.LayDuLieu(query);
            if (ds.Tables[0].Rows.Count >= 1)
            {
                dgvtk.DataSource = ds.Tables[0];
            }
            else { MessageBox.Show("0 co du lieu"); }
        }
    }
}
