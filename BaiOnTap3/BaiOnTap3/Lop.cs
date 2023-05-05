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
    public partial class Lop : Form
    {
        KetNoi kn = new KetNoi();
        public Lop()
        {
            InitializeComponent();
        }

        public void getData() {
            string query = "select * from Lop";
            DataSet ds = kn.LayDuLieu(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Lop_Load(object sender, EventArgs e)
        {
            getData();
        }
    }
}
