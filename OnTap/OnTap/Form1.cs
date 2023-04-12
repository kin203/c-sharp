using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTap
{
    public partial class FormDangNhap : Form
    {
        KetNoi kn = new KetNoi();
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "select * from tbTaiKhoan where TaiKhoan ='{0}'and MatKhau='{1}'",
                txtID.Text,
                txtPass.Text
                );
            DataSet ds = kn.LayDuLieu(query);
            if (ds.Tables[0].Rows.Count == 1)
            {
                MessageBox.Show("Dang nhap thanh cong !");
                FormChuongTrinh f = new FormChuongTrinh();
                this.Hide();
                f.Show();
            }
            else MessageBox.Show("Tai Khoan Hoac Mat Khau Khong Dung !");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
