using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            bool check = true; //biến kiểm tra nếu có lỗi thì check = false
            errorProvider1.Clear(); //xóa thông báo lỗi trước khi chạy

            //Kiểm tra họ tên
            if (txtPhone.Text == "")
            {
               errorProvider1.SetError(
                   txtPhone,
                   "Vui lòng nhập số điện thoại");
                check = false; //nếu không nhập thì check = false

            }

            //Kiểm tra tuổi
            int tuoi;
            if (int.TryParse(txtTuoi.Text, out tuoi) == false) //xử lý lỗi nhập tuổi nếu là số nguyên out ra biến tuổi ngược lại falsse
            {
                errorProvider1.SetError(
                    txtTuoi,
                    "Sai định dạng");
                check = false; //nếu không nhập thì check = false
            }
            else
            {
                if (tuoi < 17)
                {
                    errorProvider1.SetError(
                       txtTuoi,
                       "Bạn chưa đủ tuổi, 17+");
                    check = false; //nếu không nhập thì check = false
                }
            }

            //Kiểm tra ngày đăng ký trong tuần
            if (dtpNgayDK.Value.DayOfWeek == DayOfWeek.Monday) 
            {
                errorProvider1.SetError(
                    dtpNgayDK,
                    "Thứ 2 Không chiếu ");
                check = false; //nếu không nhập thì check = false
            }

            if (check == true) //nếu không có lỗi thì check = true
            {
                MessageBox.Show("Đăng ký thành công. Cảm ơn bạn!");
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại");
            }


        }
    }
}
