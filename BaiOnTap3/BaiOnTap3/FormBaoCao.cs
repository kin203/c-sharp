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
    public partial class FormBaoCao : Form
    {
        KetNoi kn = new KetNoi();
        public FormBaoCao()
        {
            InitializeComponent();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string query = string.Format("select * from Diem where MaSV='{0}' and NamHoc={1}",
                txtMaSV.Text,
                txtNamHoc.Text
                );
            DataSet ds = kn.LayDuLieu(query);
            if (ds.Tables[0].Rows.Count>0)
            {
                MessageBox.Show("OK");
                dgvThongKe.DataSource = ds.Tables[0];
            }
            else { MessageBox.Show("Khong Co Thong Tin"); }
        }
    }
}
