using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyThuVien
{
    public partial class FormQLDocGia : Form
    {
       
        String connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\qltv.mdf;Integrated Security=True;Connect Timeout=30";
        public FormQLDocGia()
        {
            InitializeComponent();
           
          
        }
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM tbDocgia";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv_madocgia.DataSource = dt;
                }
            }
        
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {

        }

        private void FormQLDocGia_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgv_madocgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

