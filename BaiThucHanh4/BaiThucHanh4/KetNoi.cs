using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BaiThucHanh4
{
    class KetNoi
    {
        string connStr = @"Data Source=DESKTOP-BF56CS1;Initial Catalog=PhongMay;Integrated Security=True";
        SqlConnection conn;
        public KetNoi() {
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
            int r = 0;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(truyvan, conn);
                r = cmd.ExecuteNonQuery();
            }
            catch { }
            finally { conn.Close(); }
            return r > 0;
        }
    }
}
