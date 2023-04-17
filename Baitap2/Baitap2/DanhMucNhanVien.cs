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
    public partial class DanhMucNhanVien : Form
    {
        KetNoi kn = new KetNoi();
        public DanhMucNhanVien()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void getData() {
            string query = "select * from LoaiNhanVien";
            DataSet ds = kn.LayDuLieu(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            HeThong ht = new HeThong();
            ht.Show();
        }

        private void DanhMucNhanVien_Load(object sender, EventArgs e)
        {
            getData();
        }
    }
}
