using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (chkXemPhim.Checked)
            {
                MessageBox.Show("Bạn đã chọn xem phim");
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn xem phim");
            }
        }
    }
}
