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
    public partial class Register : Form
    {
        KetNoi kn = new KetNoi();
        public Register()
        {
            InitializeComponent();
        }

        private void lbdk_Click(object sender, EventArgs e)
        {
            string query = string.Format("insert into NguoiDung values ('{0}','{1}')",
            txtid.Text,
            txtpass.Text
            );
            if (kn.ThucThi(query)== true)
            {
                MessageBox.Show("Dang Ky Thanh Cong");
                Form1 f = new Form1();
                f.Show();
                this.Close();
            }
            else { MessageBox.Show("Dang Nhap 0 Thanh Cong"); }
        }
    }
}
