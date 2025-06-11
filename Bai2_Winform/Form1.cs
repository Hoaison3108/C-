using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2_Winform
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void lblSoNguyenA_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int tong;
            Console.WriteLine(txtSoA.Text);
            Console.WriteLine(txtSob.Text);
            tong = int.Parse(txtSoA.Text) + int.Parse(txtSob.Text);
            lblKetQua.Text = txtSoA.Text + " + " + txtSob.Text + " = " + tong + "";
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            int hieu;
            Console.WriteLine(txtSoA.Text);
            Console.WriteLine(txtSob.Text);
            hieu = int.Parse(txtSoA.Text) - int.Parse(txtSob.Text);
            lblKetQua.Text = txtSoA.Text + " - " + txtSob.Text + " = " + hieu + "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn reset?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                lblKetQua.Text = "";
                txtSoA.Text = "";
                txtSob.Text = "";
            }
            
        }
    }
}
