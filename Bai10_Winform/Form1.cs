using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai10_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            chklbSanPham.Items.Add("Sản phẩm new 1");
            chklbSanPham.Items.Add("Sản phẩm new 2");
            chklbSanPham.Items.Add("Sản phẩm new 3");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            chklbSanPham.Items.Insert(0, "Sản phẩm new 4");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chklbSanPham.Items.AddRange(new string[] { "Sản phẩm new 5", "Sản phẩm new 6", "Sản phẩm new 7" });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Số phàn tử là : " + chklbSanPham.Items.Count.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chklbSanPham.Items.Remove("Sản phẩm 4");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chklbSanPham.Items.RemoveAt(1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            chklbSanPham.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedIndexCollection indexCollection = 
                chklbSanPham.CheckedIndices;
            string strCheck = "";
            foreach (int i in indexCollection)
            {
                strCheck += i + " ";
            }
            MessageBox.Show("Các chỉ số đã chọn là: " + strCheck);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection itemCollection =
                chklbSanPham.CheckedItems;
            string strItem = "";
            foreach (string s in itemCollection)
            {
                strItem += s + " ";
            }
            MessageBox.Show("Các chỉ số đã chọn là: " + strItem );
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string strCheck = "";
            string strItem = "";
            for (int i = 0; i < chklbSanPham.Items.Count; i++)
            {
                if (chklbSanPham.GetItemChecked(i)) //true
                {
                    strCheck += i + " "; //xuất tại index
                    strItem += chklbSanPham.Items[i].ToString() + " "; //xuất tại item
                }
            }
            MessageBox.Show("Các chỉ số đã chọn là {0} và {1}: " + strCheck + strItem);
        }
    }
}
