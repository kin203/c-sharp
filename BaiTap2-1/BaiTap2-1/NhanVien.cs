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
    public partial class NhanVien : Form
    {
        KetNoi kn = new KetNoi();

        public void getData() {
            string query = "select * from NhanVien";
            DataSet ds = kn.LayDuLieu(query);
            dgvnhanvien.DataSource = ds.Tables[0];
        }

        public void clearText() {
            
            txtmanv.Enabled = true;
            txtmanv.Clear();
            txttennv.Clear(); ;
            txtngaysinh.Clear();
            txtdiachi.Clear();
            txtmaloainv.Clear();
        }

        public void xulynhaplieu() {
            btnthem.Enabled= txtmanv.Text.Length>0 && txttennv.Text.Length>0 && txtngaysinh.Text.Length>0 && txtdiachi.Text.Length>0 && txtmaloainv.Text.Length>0 ;
            btnsua.Enabled = txtmanv.Text.Length > 0 && txttennv.Text.Length > 0 && txtngaysinh.Text.Length > 0 && txtdiachi.Text.Length > 0 && txtmaloainv.Text.Length > 0;
            btnxoa.Enabled = txtmanv.Text.Length > 0;
        }
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string query = string.Format("insert into NhanVien values('{0}',N'{1}',N'{2}',N'{3}','{4}')",
                txtmanv.Text,
                txttennv.Text,
                txtngaysinh.Text,
                txtdiachi.Text,
                txtmaloainv.Text
                );
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Them Thanh Cong !!");
                btncapnhat.PerformClick();
            }
            else { MessageBox.Show("Them  khong Thanh Cong !!"); }
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            getData();
            clearText();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string query = string.Format("update NhanVien set TenNV=N'{1}',NgaySinh=N'{2}',DiaChi=N'{3}',MaLoaiNV='{4}' where MaNV='{0}'",
                txtmanv.Text,
                txttennv.Text,
                Convert.ToDateTime(txtngaysinh.Text),
                txtdiachi.Text,
                txtmaloainv.Text
                );
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Sua Thanh Cong !!");
                btncapnhat.PerformClick();
            }
            else { MessageBox.Show("Sua  khong Thanh Cong !!"); }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string query = string.Format("delete from NhanVien where MaNV='{0}'",
                txtmanv.Text
                );
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Xoa Thanh Cong !!");
                btncapnhat.PerformClick();
            }
            else { MessageBox.Show("Xoa khong Thanh Cong !!"); }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string query = string.Format("select * from NhanVien where MaNV like '%{0}%'",txttimkiem.Text);
            DataSet ds = kn.LayDuLieu(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                dgvnhanvien.DataSource = ds.Tables[0];
            }
            else {
                MessageBox.Show("Khong tim thay thong tin !!!");
            }
        }

        private void dgvnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0) {
                txtmanv.Text=dgvnhanvien.Rows[r].Cells[0].Value.ToString();
                txttennv.Text=dgvnhanvien.Rows[r].Cells[1].Value.ToString();
                if (string.IsNullOrEmpty(dgvnhanvien.Rows[r].Cells[2].Value.ToString()) == true)
                {
                    txtngaysinh.Text = "";
                }
                else
                {
                    txtngaysinh.Text = Convert.ToDateTime(dgvnhanvien.Rows[r].Cells[2].Value).ToShortDateString();
                } 
                txtdiachi.Text=dgvnhanvien.Rows[r].Cells[3].Value.ToString();
                txtmaloainv.Text=dgvnhanvien.Rows[r].Cells[4].Value.ToString();
                txtmanv.Enabled = false;
                btnthem.Enabled = false;
            }
        }

        private void txtmanv_TextChanged(object sender, EventArgs e)
        {
            xulynhaplieu();
        }

        private void txttennv_TextChanged(object sender, EventArgs e)
        {
            xulynhaplieu();
        }

        private void txtngaysinh_TextChanged(object sender, EventArgs e)
        {
            xulynhaplieu();
        }

        private void txtdiachi_TextChanged(object sender, EventArgs e)
        {
            xulynhaplieu();
        }

        private void txtmaloainv_TextChanged(object sender, EventArgs e)
        {
            xulynhaplieu();
        }


    }
}
