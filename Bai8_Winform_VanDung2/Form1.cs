using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai8_Winform_VanDung2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.maSV = int.Parse(txtMa.Text);
            sv.tenSV = txtTen.Text;

                    string s = sv.maSV + " - " + sv.tenSV;
                    lstDS.Items.Add(s);
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lstDS.Items.Clear();
        }
    }
}
