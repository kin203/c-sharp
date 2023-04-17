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
    public partial class DangNhap : Form
    {
        KetNoi kn = new KetNoi();

        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                    "select * from NguoiDung where username ='{0}' and pass ='{1}'",
                    txtTaiKhoan.Text,
                    txtMatKhau.Text
                );
            DataSet ds = kn.LayDuLieu(query);
            if (ds.Tables[0].Rows.Count == 1)
            {
                MessageBox.Show("Dang nhap thanh cong :)");
                HeThong ht = new HeThong();
                ht.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Tai Khoan Hoac Mat Khau Khong Dung !!!!");
                txtMatKhau.Clear();
            }
        }

        public void XuLyNhapLieu() {
            if (txtTaiKhoan.Text.Length > 0 == true && txtMatKhau.Text.Length > 0 == true)
            {
                btnDangNhap.Enabled = true;
            }
            else {
                btnDangNhap.Enabled = false;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            XuLyNhapLieu();
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            XuLyNhapLieu();
        }
    }
}
