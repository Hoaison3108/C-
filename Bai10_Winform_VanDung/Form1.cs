using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai10_Winform_VanDung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection itemCollection =
                chklbDS1.CheckedItems;
            //Duyệt chọn
            foreach (string item in itemCollection)
            {
               chklbDS2.Items.Add(item);
            }

            //Duyệt xóa
            foreach (string s in chklbDS2.Items)
            {
                chklbDS1.Items.Remove(s);
            }

        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            chklbDS2.Items.AddRange(chklbDS1.Items);

            //Xóa tất cả
            chklbDS1.Items.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection itemCollection =
                chklbDS2.CheckedItems;
            //Duyệt chọn
            foreach (string item in itemCollection)
            {
                chklbDS1.Items.Add(item);
            }

            //Duyệt xóa
            foreach (string s in chklbDS1.Items)
            {
                chklbDS2.Items.Remove(s);
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            chklbDS1.Items.AddRange(chklbDS2.Items);

            //Xóa tất cả
            chklbDS2.Items.Clear();
        }
    }
}
