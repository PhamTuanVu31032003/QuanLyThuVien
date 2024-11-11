using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    internal class Ketnoi
    {
        SqlConnection conn;
        string kn = @"Server=LAPTOP-TKDRUJMP;Database=QuanLyThuVien;Integrated Security=True";
        public void ketnoi()
        {
            conn = new SqlConnection(kn);
            conn.Open();
        }
        public void dongkn()
        {
            conn.Close();
        }

        //CRUD
        public DataTable Readdata(string sql, SqlParameter[] sqlParameters = null)
        {
            DataTable dt = new DataTable();
            try
            {
                ketnoi();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (sqlParameters != null)
                    {
                        cmd.Parameters.AddRange(sqlParameters);
                    }
                    using (SqlDataReader sr = cmd.ExecuteReader())
                    {
                        dt.Load(sr);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dongkn();
            }
            return dt;
        }

        public void CUD(string table, SqlParameter[] sqlParameters = null)
        {
            try
            {
                ketnoi();
                using (SqlCommand cmd = new SqlCommand(table, conn))
                {
                    if (sqlParameters != null)
                    {
                        cmd.Parameters.AddRange(sqlParameters);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dongkn();
            }
        }
    }
}
