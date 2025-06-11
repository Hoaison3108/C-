using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Cảm ơn đã xem", 
                "Thông báo", 
                MessageBoxButtons.YesNoCancel, 
                MessageBoxIcon.Warning);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show(
            //    "Bạn có muốn thoát không?",
            //    "Thông báo",
            //    MessageBoxButtons.YesNo,
            //    MessageBoxIcon.Warning);
            //if (result == DialogResult.Yes)
            //{
            //    Application.Exit();
            //}
            //else if(result == DialogResult.No)
            //{
            //    MessageBox.Show("Mời tiếp tục sử dụng");
            //}
          
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                e.Cancel = false; // Cho phép thoát
            }    
            else
            {
                e.Cancel = true; // Không cho phép thoát
                MessageBox.Show("Mời tiếp tục sử dụng");
            }    
        }
    }
}
