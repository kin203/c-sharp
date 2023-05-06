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
    public partial class LoaiNhanVien : Form
    {
        KetNoi kn = new KetNoi();
        public LoaiNhanVien()
        {
            InitializeComponent();
        }

        private void LoaiNhanVien_Load(object sender, EventArgs e)
        {
            string query = "select * from LoaiNhanVien";
            DataSet ds = kn.LayDuLieu(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
