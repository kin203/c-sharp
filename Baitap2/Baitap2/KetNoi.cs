using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Baitap2
{
    class KetNoi
    {
        string connStr = @"Data Source=DESKTOP-BF56CS1;Initial Catalog=NhanVien;Integrated Security=True";
        SqlConnection conn;
        public KetNoi(){
            conn = new SqlConnection(connStr);
        }
        public DataSet LayDuLieu(string truyvan) {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(truyvan, conn);
                da.Fill(ds);
                return ds;
            }
            catch { return null; }
        }
        public bool ThucThi(string truyvan) {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(truyvan, conn);
                int r = cmd.ExecuteNonQuery();
                conn.Close();
                return r > 0;
            }
            catch { return false; }
        }
    }
}
