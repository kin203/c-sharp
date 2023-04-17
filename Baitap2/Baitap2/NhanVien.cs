using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Baitap2
{
    public partial class NhanVien : Form
    {
        KetNoi kn = new KetNoi();
        public NhanVien()
        {
            InitializeComponent();
        }

        public void getData() {
            string query = "select * from NhanVien";
            DataSet ds = kn.LayDuLieu(query);
            dgvNhanVien.DataSource = ds.Tables[0];
        }

        public void clearText() {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtDiachi.Clear();
            dateNS.Value= DateTime.Now;
            txtMaLoaiNV.Clear();
            txtMaNV.Focus();
        }

        public void XuLyNhapLieu() {
            if (txtMaNV.Text.Length > 0)
            {
                btnXoa.Enabled = true;
            }
            else { btnXoa.Enabled = false; }
            if (txtMaNV.Text.Length > 0 && txtTenNV.Text.Length > 0 && txtDiachi.Text.Length > 0 && txtMaLoaiNV.Text.Length > 0)
            {
                btnThem.Enabled = true;
                btnSua.Enabled = true;
            }
            else
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
            }
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "insert into NhanVien values('{0}','{1}','{2}','{3}','{4}')",
                txtMaNV.Text,
                txtTenNV.Text,
                dateNS.Value.ToString("yyyy-MMM-dd"),
                txtDiachi.Text,
                txtMaLoaiNV.Text
                );
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("THEM THANH CONG");
                btnCapNhatTT.PerformClick();
            }
            else { MessageBox.Show("THEM KHONG THANH CONG"); }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if(r >= 0){
                txtMaNV.Text=dgvNhanVien.Rows[r].Cells["MaNV"].Value.ToString();
                txtTenNV.Text = dgvNhanVien.Rows[r].Cells["TenNV"].Value.ToString();
                txtDiachi.Text = dgvNhanVien.Rows[r].Cells["DiaChi"].Value.ToString();
                txtMaLoaiNV.Text = dgvNhanVien.Rows[r].Cells["MaLoaiNV"].Value.ToString();
                string a = dgvNhanVien.Rows[r].Cells["NgaySinh"].Value.ToString();
                if (a == "") {
                    return;
                }
                dateNS.Value=DateTime.Parse(a);
            }
        }

        private void btnCapNhatTT_Click(object sender, EventArgs e)
        {
            getData();
            clearText();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HeThong ht = new HeThong();
            ht.Show();
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "update NhanVien set TenNV = '{1}', NgaySinh= '{2}', DiaChi = '{3}', MaLoaiNV = '{4}' where MaNV ='{0}'",
                txtMaNV.Text,
                txtTenNV.Text,
                dateNS.Value.ToString("yyyy-MMM-dd"),
                txtDiachi.Text,
                txtMaLoaiNV.Text
                );
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("SUA THANH CONG");
                btnCapNhatTT.PerformClick();
            }
            else { MessageBox.Show("SUA KHONG THANH CONG"); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "delete from NhanVien where MaNV='{0}'",
                txtMaNV.Text
                );
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("XOA THANH CONG");
                btnCapNhatTT.PerformClick();
            }
            else { MessageBox.Show("XOA KHONG THANH CONG"); }
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            XuLyNhapLieu();
        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {
            XuLyNhapLieu();
        }

        private void txtDiachi_TextChanged(object sender, EventArgs e)
        {
            XuLyNhapLieu();
        }

        private void txtMaLoaiNV_TextChanged(object sender, EventArgs e)
        {
            XuLyNhapLieu();
        }
    }
}
