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
    public partial class FormChuongTrinh : Form
    {
        KetNoi kn = new KetNoi();

        public FormChuongTrinh()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormDangNhap f = new FormDangNhap();
            f.Show();
            this.Close();
        }

        private void btnF5_Click(object sender, EventArgs e)
        {
            getData();
            clearText();
        }

        public void clearText()//xoa thong tin nhap 
        {
            txtMaCD.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaCD.Clear();
            txtMaPH.Clear();
            txtTen.Clear();
            txtCMND.Clear();
            cbGioiTinh.Text="";
            txtNamSinh.Clear();
            txtSDT.Clear();
            txtMaCD.Focus();
        }

        public void getData()//lay du lieu tu bang
        {
            string query = "select * from DieuTraDS";
            DataSet ds = kn.LayDuLieu(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void FormChuongTrinh_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "insert into DieuTraDS values('{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}','{6}')",
                txtMaCD.Text,
                txtMaPH.Text,
                txtTen.Text,
                txtCMND.Text,
                cbGioiTinh.Text,
                txtNamSinh.Text,
                txtSDT.Text
                );
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Them moi thanh cong");
                btnF5.PerformClick();
            }
            else MessageBox.Show("Loi !!!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "update DieuTraDS set MaPhuong='{1}',TenCD='{2}',CMND='{3}',GioiTinh='{4}',NamSinh='{5}',SoDienThoai='{6}' where MaCD='{0}'",
                txtMaCD.Text,
                txtMaPH.Text,
                txtTen.Text,
                txtCMND.Text,
                cbGioiTinh.Text,
                txtNamSinh.Text,
                txtSDT.Text
                );
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Sua thanh cong");
                btnF5.PerformClick();
            }
            else MessageBox.Show("Loi !!!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "delete from DieuTraDS where MaCD='{0}'",
                txtMaCD.Text,
                txtMaPH.Text,
                txtTen.Text,
                txtCMND.Text,
                cbGioiTinh.Text,
                txtNamSinh.Text,
                txtSDT.Text
                );
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Da xoa thong tin");
                btnF5.PerformClick();
            }
            else MessageBox.Show("Loi !!!");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "select * from DieuTraDS where MaCD like '%{0}%'",
                txtSearch.Text
                );
            DataSet ds = kn.LayDuLieu(query);
            if (ds.Tables[0].Rows.Count==1)
            {
                dataGridView1.DataSource=ds.Tables[0]; //khac truy van btnF5
            }
            else MessageBox.Show("Khong Tim Thay Thong Tin");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            txtMaCD.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            if (r >= 0) {
                txtMaCD.Text = dataGridView1.Rows[r].Cells["MaCD"].Value.ToString();
                txtMaPH.Text = dataGridView1.Rows[r].Cells["MaPhuong"].Value.ToString();
                txtTen.Text = dataGridView1.Rows[r].Cells["TenCD"].Value.ToString();
                txtCMND.Text = dataGridView1.Rows[r].Cells["CMND"].Value.ToString(); 
                cbGioiTinh.Text = dataGridView1.Rows[r].Cells["GioiTinh"].Value.ToString();
                txtNamSinh.Text = dataGridView1.Rows[r].Cells["NamSinh"].Value.ToString();
                txtSDT.Text = dataGridView1.Rows[r].Cells["SoDienThoai"].Value.ToString();
            }
        }

    }
}
