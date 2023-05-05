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
    public partial class LichDangKy : Form
    {
        KetNoi kn = new KetNoi();
        public void getData(){
            string query = "select * from LichDangKy";
            DataSet ds= kn.LayDuLieu(query);
            dgvLichDK.DataSource=ds.Tables[0];
        }
        public void clearText() {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtmapm.Enabled = true;
            txtmapm.Clear();
            txtmagv.Clear();
            txtbatdau.Clear();
            txtketthuc.Clear();
            txtnamhoc.Clear();
        }
        public LichDangKy()
        {
            InitializeComponent();
        }

        private void LichDangKy_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = string.Format("insert into LichDangKy values('{0}','{1}','{2}','{3}','{4}')",
                txtmapm.Text,
                txtmagv.Text,
                txtbatdau.Text,
                txtketthuc.Text,
                txtnamhoc.Text);
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Them Thanh Cong");
                btnLamMoi.PerformClick();
            }
            else { MessageBox.Show("Them 0 Thanh Cong"); }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            clearText();
            getData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = string.Format("update LichDangKy set MaGV='{1}',Batdau='{2}',Ketthuc='{3}',NamHoc='{4}' where MaPM='{0}')",
                txtmapm.Text,
                txtmagv.Text,
                txtbatdau.Text,
                txtketthuc.Text,
                txtnamhoc.Text);
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Sua Thanh Cong");
                btnLamMoi.PerformClick();
            }
            else { MessageBox.Show("Sua 0 Thanh Cong"); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = string.Format("delete from LichDangKy where MaPM='{0}')",
                txtmapm.Text
                );
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Xoa Thanh Cong");
                btnLamMoi.PerformClick();
            }
            else { MessageBox.Show("Xoa 0 Thanh Cong"); }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string query = string.Format("select * from LichDangKy where MaPM like '%{0}%' ", txtSearch.Text);
            DataSet ds = kn.LayDuLieu(query);
            if (ds.Tables[0].Rows.Count >0)
            {
                dgvLichDK.DataSource = ds.Tables[0];
            }
            else { 
                MessageBox.Show("Khong co du lieu !!");
                dgvLichDK.DataSource = ds.Tables[0];
            }
        }

        private void dgvLichDK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0) {
                txtmapm.Text = dgvLichDK.Rows[r].Cells[0].Value.ToString();
                txtmagv.Text = dgvLichDK.Rows[r].Cells[1].Value.ToString();
                txtbatdau.Text = Convert.ToDateTime(dgvLichDK.Rows[r].Cells[2].Value).ToShortDateString();
                txtketthuc.Text= Convert.ToDateTime(dgvLichDK.Rows[r].Cells[3].Value).ToShortDateString();
                txtnamhoc.Text = dgvLichDK.Rows[r].Cells[4].Value.ToString();
                txtmapm.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void txtmapm_TextChanged(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;


        }

    }
}
