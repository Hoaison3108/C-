using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai17_Winform_ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lvSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Kiểm tra xem có item nào được chọn hay không
            if (lvSanPham.SelectedItems.Count > 0)
            {
               // MessageBox.Show("Có dòng đang chọn");
                ListViewItem lv1 = lvSanPham.SelectedItems[0];
                string maSP = lv1.SubItems[0].Text;
                string tenSP = lv1.SubItems[1].Text;
                string giaSP = lv1.SubItems[2].Text;

                //MessageBox.Show("Mã sản phẩm: " + maSP + "\nTên sản phẩm: " + tenSP + "\nGiá sản phẩm: " + giaSP);
               
                //Gán giá trị từ ListView vào các TextBox
                txtMaSP.Text = maSP;
                txtTenSP.Text = tenSP;
                txtGiaSP.Text = giaSP;
            }   
        }

        private void lvSanPham_ColumnClick(object sender, ColumnClickEventArgs e)
        {
               // MessageBox.Show(lvSanPham.Columns[e.Column].ToString());
            if(e.Column != -1)
            {
                ColumnHeader col = lvSanPham.Columns[e.Column];
                MessageBox.Show("Tên cột: " + col.Text);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Khởi tạo ô đầu dòng
            ListViewItem lv1 = new ListViewItem(txtMaSP.Text);

            //Thêm các ô con
            lv1.SubItems.Add(txtTenSP.Text);
            lv1.SubItems.Add(txtGiaSP.Text);

            //Thêm vào ListView
            lvSanPham.Items.Add(lv1);
        }

        private void btnRemoveAt_Click(object sender, EventArgs e)
        {
            while (lvSanPham.SelectedItems.Count > 0)
            {
                //Xóa dòng đầu tiên trong danh sách các dòng được chọn
                lvSanPham.Items.RemoveAt(lvSanPham.SelectedItems[0].Index);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            while (lvSanPham.SelectedItems.Count > 0)
            {
                //Xóa dòng đầu tiên trong danh sách các dòng được chọn
                lvSanPham.Items.Remove(lvSanPham.SelectedItems[0]);
                MessageBox.Show("Xóa thành công");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count > 0)
            {
                ListViewItem lv1 = lvSanPham.SelectedItems[0];
                lv1.SubItems[0].Text = txtMaSP.Text;
                lv1.SubItems[1].Text = txtTenSP.Text;
                lv1.SubItems[2].Text = txtGiaSP.Text;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa");
            }
        }
    }
}
