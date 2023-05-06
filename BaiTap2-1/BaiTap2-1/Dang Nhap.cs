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
    public partial class Form1 : Form
    {
        KetNoi kn = new KetNoi();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string query = string.Format("select * from NguoiDung where id= '{0}' and pass='{1}'",txtid.Text,txtPass.Text);
            DataSet ds = kn.LayDuLieu(query);
            if (ds.Tables[0].Rows.Count == 1)
            {
                MessageBox.Show("Dang nhap thanh cong !!");
                HeThong ht = new HeThong();
                ht.Show();
                this.Hide();
            }
            else { MessageBox.Show("Dang nhap that bai"); }
        }
    }
}
