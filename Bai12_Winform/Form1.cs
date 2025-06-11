using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai12_Winform
{
    public partial class frmForm1 : Form
    {
        public frmForm1()
        {
            InitializeComponent();
        }

        private void mnuOpenForm1_Click(object sender, EventArgs e)
        {
            frmChild1 Form1 = new frmChild1(); //Khai báo form mới
            Form1.MdiParent = this; //Chỉ định là form con
            Form1.Show();   //Hiển thị form
        }

        private void mnuOpenForm2_Click(object sender, EventArgs e)
        {
            frmChild2 Form2 = new frmChild2(); //Khai báo form mới
           Form2.MdiParent = this; //Chỉ định là form con
            Form2.Show();   //Hiển thị form
        }

        private void mnuOpenForm3_Click(object sender, EventArgs e)
        {
            frmChild3 Form3 = new frmChild3(); //Khai báo form mới
            Form3.MdiParent = this; //Chỉ định là form con
            Form3.Show();   //Hiển thị form
        }

        private void mnuOpenForm4_Click(object sender, EventArgs e)
        {
            frmChild4 Form4 = new frmChild4(); //Khai báo form mới  
            Form4.MdiParent = this; //Chỉ định là form con
            Form4.Show();   //Hiển thị form
        }

        private void kiểuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons); //Sắp xếp theo kiểu biểu tượng
        }

        private void kiểu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade); //Sắp xếp theo kiểu thác nước
            //LayoutMdi(MdiLayout.TileHorizontal); //Sắp xếp theo kiểu nằm ngang
           // LayoutMdi(MdiLayout.TileVertical); //Sắp xếp theo kiểu nằm dọc
          //  LayoutMdi(MdiLayout.ArrangeIcons); //Sắp xếp theo kiểu biểu tượng
           
        }

        private void kiểu2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal); //Sắp xếp theo kiểu nằm ngang
        }

        private void kiểu3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical); //Sắp xếp theo kiểu nằm dọc
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.MdiParent = this; //Chỉ định là form con
            login.Show();   //Hiển thị form
        }
    }
}
