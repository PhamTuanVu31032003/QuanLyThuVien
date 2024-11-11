using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace QuanLyThuVien
{
    public partial class FormQLSach : Form
    {
        Sach sach =new Sach();
        public FormQLSach()
        {
            InitializeComponent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string Masach = tb_masach.Text;
            string Tensach = tb_tensach.Text;
            string Matg = tb_matg.Text;
            string Tentg = tb_tentg.Text;
            string Nhaxb = tb_nhaxb.Text;
            int Namxb = int.Parse(tb_namxb.Text);
            string theloai = tb_theloai.Text;
            int Soluong = int.Parse(tb_soluong.Text);
            int soluongconlai = int.Parse(tb_soluongcl.Text);
            sach.Createbook(Masach, Tensach, Matg, Tentg, Nhaxb, Namxb, theloai, Soluong, soluongconlai);
            FormQLSach_Load(sender, e);
        }

        private void FormQLSach_Load(object sender, EventArgs e)
        {
            dgv_sach.DataSource = sach.Getallbook();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string Masach = tb_masach.Text;
            string Tensach = tb_tensach.Text;
            string Matg = tb_matg.Text;
            string Tentg = tb_tentg.Text;
            string Nhaxb = tb_nhaxb.Text;
            int Namxb = int.Parse(tb_namxb.Text);
            string theloai = tb_theloai.Text;
            int Soluong = int.Parse(tb_soluong.Text);
            int soluongconlai = int.Parse(tb_soluongcl.Text);
            sach.Deletebook(Masach, Tensach, Matg, Tentg, Nhaxb, Namxb, theloai, Soluong, soluongconlai);
            FormQLSach_Load(sender, e);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string Masach = tb_masach.Text;
            string Tensach = tb_tensach.Text;
            string Matg = tb_matg.Text;
            string Tentg = tb_tentg.Text;
            string Nhaxb = tb_nhaxb.Text;
            int Namxb = int.Parse(tb_namxb.Text);
            string theloai = tb_theloai.Text;
            int Soluong = int.Parse(tb_soluong.Text);
            int soluongconlai = int.Parse(tb_soluongcl.Text);
            sach.Updatebook(Masach, Tensach, Matg, Tentg, Nhaxb, Namxb, theloai, Soluong, soluongconlai);
            FormQLSach_Load(sender, e);
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string tim = tb_masach.Text;
            dgv_sach.DataSource = sach.Searchmabook(tim);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            FormQLThuVien formQLThuVien = new FormQLThuVien();
            formQLThuVien.Show();
            this.Close();
        }
    }
}
