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
    public partial class FormDangNhap : Form
    {
        KetNoi kn = new KetNoi();

        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                    "select * from NguoiDung where TaiKhoan='{0}' and MatKhau= '{1}'",
                    txtUser.Text,
                    txtPass.Text
                );
            DataSet ds= kn.LayDuLieu(query);
            if (ds.Tables[0].Rows.Count == 1)
            {
                MessageBox.Show("dang nhap thanh cong");
                this.Hide();
                HeThong ht = new HeThong();
                ht.Show();
            }
            else { 
                MessageBox.Show("dang nhap that bai");
                txtPass.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            if (txtUser.Text.Length > 0 && txtPass.Text.Length > 0)
            {
                btnLogin.Enabled = true;
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (txtUser.Text.Length > 0 && txtPass.Text.Length > 0)
            {
                btnLogin.Enabled = true;
            }
        }

    }
}
