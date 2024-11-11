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
        public FormQLTacGia()
        {
            InitializeComponent();
        }

        private void txt_matacgia_TextChanged(object sender, EventArgs e)
        {
            txt_matacgia.Text = "vu an cut";
        }
    }
}
