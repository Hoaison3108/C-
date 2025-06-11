using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai8_Winform_VanDung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int x;
            errorProvider1.Clear(); 
            if (int.TryParse(txtInput.Text, out x))
            {
                lstSo.Items.Add(x);
                txtInput.Text="";
            }    
            else
            {
                errorProvider1.SetError(txtInput, "Nhập số nguyên");
            }    
            


        }

        private void btnXoaDC_Click(object sender, EventArgs e)
        {
            lstSo.Items.RemoveAt(0); // Xóa theo chỉ số phần tử đầu
            lstSo.Items.Remove(lstSo.Items.Count - 1); // Xóa theo chỉ số phần tử cuối
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int sum=0;
            foreach (int i in lstSo.Items)
            {
                sum += i;
            }
            MessageBox.Show("Tổng là: " + sum);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            while (lstSo.SelectedIndex != -1)
            {
                lstSo.Items.RemoveAt(lstSo.SelectedIndex);
            }
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int x = (int)lstSo.Items[i];
                lstSo.Items[i] = x + 2;
            }
        }

        private void btnBinhPhuong_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int x = (int)lstSo.Items[i];
                lstSo.Items[i] = x * x;
            }
        }

        private void btnChan_Click(object sender, EventArgs e)
        {
            lstSo.SelectedIndex = -1; // Bỏ chọn tất cả các phần tử
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int x = (int)lstSo.Items[i];
                if (x % 2 == 0)
                {
                    lstSo.SelectedIndex = i;
                }
            }
        }

        private void btnLe_Click(object sender, EventArgs e)
        {

            lstSo.SelectedIndex = -1; // Bỏ chọn tất cả các phần tử
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int x = (int)lstSo.Items[i];
                if (x % 2 != 0)
                {
                    lstSo.SelectedIndex = i;
                }
            }

        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn thoát không?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
