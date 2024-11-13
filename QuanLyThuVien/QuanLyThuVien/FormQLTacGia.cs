using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class FormQLTacGia : Form
    {
        Tg tg = new Tg();
        public FormQLTacGia()
        {
            InitializeComponent();
            dataGridView1.DataSource = tg.GetallTacGia();
        }

        private void txt_matacgia_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string maTacGia = txt_matacgia.Text;
            string tenTacGia = txt_hoten.Text;
            string gioitinh = cb_gioitinh.SelectedItem.ToString();
            string diachi = txt_quequan.Text;
            tg.CreateTacGia(maTacGia, tenTacGia, gioitinh, diachi);
            FormQLTacGia_Load(sender, e);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string maTacGia = txt_matacgia.Text;
            string tenTacGia = txt_hoten.Text;
            string gioitinh = cb_gioitinh.SelectedItem.ToString();
            string diachi = txt_quequan.Text;
            tg.UpdateTacGia(maTacGia, tenTacGia, gioitinh, diachi);
            FormQLTacGia_Load(sender, e);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string maTacGia = txt_matacgia.Text;
            tg.DeleteTacGia(maTacGia);
            FormQLTacGia_Load(sender, e);
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                string giaTriTimKiem = txtTim.Text.Trim();

                if (string.IsNullOrEmpty(giaTriTimKiem))
                {
                    MessageBox.Show("Vui lòng nhập giá trị tìm kiếm.");
                    return;
                }

                DataTable ketQuaTimKiem;

                
                if (cbTim.SelectedIndex == 0) 
                {
                    ketQuaTimKiem = tg.SearchmaTacGia(giaTriTimKiem);
                }
                else if (cbTim.SelectedIndex == 1) // Lựa chọn thứ hai: Tìm kiếm theo tên độc giả
                {
                    ketQuaTimKiem = tg.SearchtenTacGia(giaTriTimKiem);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn kiểu tìm kiếm.");
                    return;
                }

                // Hiển thị kết quả tìm kiếm (cập nhật DataGridView hoặc bất kỳ điều khiển nào bạn đang sử dụng để hiển thị dữ liệu)
                dataGridView1.DataSource = ketQuaTimKiem;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                // lay du lieu cot va day vao tb
                txt_matacgia.Text = row.Cells["maTacGia"].Value.ToString();
                txt_hoten.Text = row.Cells["tenTacGia"].Value.ToString();
                txt_quequan.Text = row.Cells["quequan"].Value.ToString();
                cb_gioitinh.Text = row.Cells["gioitinh"].Value.ToString();
            }
        }

        private void FormQLTacGia_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tg.GetallTacGia();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
