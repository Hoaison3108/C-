using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai8_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstDanhSach.Items.Add("item 4");
            lstDanhSach.Items.Add("item 5");
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int a = lstDanhSach.Items.Count;
            MessageBox.Show("Số lượng phần tử trong danh sách là: " + a);
        }

        private void btnIndex_Click(object sender, EventArgs e)
        {
           for (int i = 0; i < lstDanhSach.Items.Count; i++)
            {
                MessageBox.Show(lstDanhSach.Items[i].ToString());
            }
   
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstDanhSach.Items.Remove(0);
        }

        private void btnSLI_Click(object sender, EventArgs e)
        {
            foreach (int i in lstDanhSach.SelectedIndices)
            {
                Console.WriteLine(i);
            }
            //trả về giá trị phần tử đầu tiên trong list đươc chọn
            Console.WriteLine(lstDanhSach.SelectedIndices[0]);

            //Đền phàn tử được chọn
            Console.WriteLine(lstDanhSach.SelectedIndices.Count);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            lstDanhSach.Items[0] = "item 1 edit";
        }

        private void btnSLIndex_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Index item đang được chọn là:  " + lstDanhSach.SelectedIndex);
        }
    }
}
