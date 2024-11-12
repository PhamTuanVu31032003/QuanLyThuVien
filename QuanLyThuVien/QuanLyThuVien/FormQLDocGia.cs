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
        Docgia docgia = new Docgia();
        public FormQLDocGia()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string madocgia = txt_madocgia.Text;
            string hoten = txt_hoten.Text;
            string gioitinh = txt_gioitinh.Text;
            DateTime ngaysinh = dtp_ngaysinh.Value;
            DateTime ngaydangky = dtp_ngaydangky.Value;
            string diachi = txt_diachi.Text;
            string sodienthoai = txt_dienthoai.Text;
            string email = txt_email.Text;
            docgia.Createdocgia(madocgia, hoten, gioitinh, ngaysinh, ngaydangky, diachi, sodienthoai, email);
            FormQLDocGia_Load(sender, e);
        }

        private void dgv_madocgia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormQLDocGia_Load(object sender, EventArgs e)
        {
            dgv_docgia.DataSource = docgia.Getalldocgia();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string madocgia = txt_madocgia.Text;
            string hoten = txt_hoten.Text;
            string gioitinh = txt_gioitinh.Text;
            DateTime ngaysinh = dtp_ngaysinh.Value;
            DateTime ngaydangky = dtp_ngaydangky.Value;
            string diachi = txt_diachi.Text;
            string sodienthoai = txt_dienthoai.Text;
            string email = txt_email.Text;
            docgia.Updatedocgia(madocgia, hoten, gioitinh, ngaysinh, ngaydangky, diachi, sodienthoai, email);
            FormQLDocGia_Load(sender, e);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string madocgia = txt_madocgia.Text;
            docgia.Deletedocgia(madocgia);
            FormQLDocGia_Load(sender, e);
        }

        private void dgv_docgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                DataGridViewRow row = dgv_docgia.Rows[e.RowIndex];
                txt_madocgia.Text = row.Cells["madocgia"].Value.ToString();
                txt_hoten.Text = row.Cells["hoten"].Value?.ToString();
                txt_gioitinh.Text = row.Cells["gioitinh"].Value.ToString();
                dtp_ngaysinh.Value = row.Cells["ngaysinh"].Value == DBNull.Value ? DateTime.Now : Convert.ToDateTime(row.Cells["ngaysinh"].Value);
               dtp_ngaydangky.Value = row.Cells["ngaydangky"].Value == DBNull.Value ? DateTime.Now : Convert.ToDateTime(row.Cells["ngaydangky"].Value);
                txt_diachi.Text = row.Cells["diachi"].Value.ToString();
                txt_dienthoai.Text = row.Cells["sodienthoai"].Value?.ToString();
                txt_email.Text = row.Cells["email"].Value.ToString();
            }
        }
    }
}
