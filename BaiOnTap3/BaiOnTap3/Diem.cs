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
    public partial class Diem : Form
    {
        KetNoi kn = new KetNoi();

        public Diem()
        {
            InitializeComponent();
        }

        public void xulybutton() {
            btnAdd.Enabled = txtMaMH.Text.Length > 0 && txtMaSV.Text.Length > 0 && txtdiem.Text.Length > 0 && txtNamhoc.Text.Length > 0 && txtKy.Text.Length > 0;
            btnModify.Enabled = txtMaMH.Text.Length > 0 && txtMaSV.Text.Length > 0 && txtdiem.Text.Length > 0 && txtNamhoc.Text.Length > 0 && txtKy.Text.Length > 0;
        }

        public void getData() {
            string query = "select * from Diem";
            DataSet ds = kn.LayDuLieu(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Diem_Load(object sender, EventArgs e)
        {
            getData();
        }

        public void clearText() {
            btnAdd.Enabled = false;
            btnModify.Enabled = false;
            txtMaSV.Clear();
            txtMaMH.Clear();
            txtdiem.Clear();
            txtNamhoc.Clear();
            txtKy.Clear();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "insert into Diem values('{0}','{1}','{2}','{3}','{4}')",
                txtMaSV.Text,
                txtMaMH.Text,
                txtdiem.Text,
                txtNamhoc.Text,
                txtKy.Text
                );
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Them Thanh Cong");
                btnF.PerformClick();
            }
            else { MessageBox.Show("Them 0 Thanh Cong"); }
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            clearText();
            getData();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "delete from Diem where MaSV='{0}'",
                txtMaSV.Text
                );
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Xoa Thanh Cong");
                btnF.PerformClick();
            }
            else { MessageBox.Show("Xoa 0 Thanh Cong"); }
        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {
            xulybutton();
            btnDel.Enabled = txtMaSV.Text.Length > 0;
        }

        private void txtMaMH_TextChanged(object sender, EventArgs e)
        {
            xulybutton();
        }

        private void txtdiem_TextChanged(object sender, EventArgs e)
        {
            xulybutton();
        }

        private void txtNamhoc_TextChanged(object sender, EventArgs e)
        {
            xulybutton();
        }

        private void txtKy_TextChanged(object sender, EventArgs e)
        {
            xulybutton();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0) {
                txtMaSV.Text=dataGridView1.Rows[r].Cells["MaSV"].Value.ToString();
                txtMaMH.Text=dataGridView1.Rows[r].Cells["MaMH"].Value.ToString();
                txtdiem.Text=dataGridView1.Rows[r].Cells["DiemTK"].Value.ToString();
                txtNamhoc.Text=dataGridView1.Rows[r].Cells["NamHoc"].Value.ToString();
                txtKy.Text = dataGridView1.Rows[r].Cells["Ky"].Value.ToString();
            }
        }
    }
}
