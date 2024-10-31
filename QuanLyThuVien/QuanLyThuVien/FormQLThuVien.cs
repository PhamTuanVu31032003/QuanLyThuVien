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
    public partial class FormQLThuVien : Form
    {
        public FormQLThuVien()
        {
            InitializeComponent();
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQLSach formQlSach = new FormQLSach();
            formQlSach.Show();
        }

        private void quảnLýĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQLDocGia formDocGia = new FormQLDocGia();
            formDocGia.Show();
        }

        private void quảnLýTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQLTacGia formQLTacGia = new FormQLTacGia();
            formQLTacGia.Show();
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHeThong formHeThong = new FormHeThong();
            formHeThong.Show();
        }

        

        private void FormQLThuVien_Load(object sender, EventArgs e)
        {

        }

        private void quảnLýMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQLMuon formQLMuon = new FormQLMuon();
            formQLMuon.Show();
        }

        private void quảnLýTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQLTra formQLTra = new FormQLTra();
            formQLTra.Show();
        }
    }
}
