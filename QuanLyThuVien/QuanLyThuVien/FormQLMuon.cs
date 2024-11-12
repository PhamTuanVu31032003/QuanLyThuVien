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
    public partial class FormQLMuon : Form
    {
        MuonTraSach muon = new MuonTraSach();
        public FormQLMuon()
        {
            InitializeComponent();
            dgvMuonSach.DataSource = muon.GetAll();
        }

        private void FormQLMuon_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtTim.Text = "acb";
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
