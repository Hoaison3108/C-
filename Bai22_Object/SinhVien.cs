using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai22_Object
{
    public class SinhVien
    {
        //#khai báo biến lớp
        private int maSV;
        private string tenSV;

        //khai báo contructor mặc định
        //contructor hàm dùng khởi tạo giá trí cho đối tượng

        //#Khai báo contructor
        //khai báo contructor mặc định
        public SinhVien()
        {
            this.maSV = 0;
            this.tenSV = "No name";
        }

        //khai báo contructor có tham số
        public SinhVien(int maSV, string tenSV)
        {
            this.maSV = maSV;
            this.tenSV = tenSV;
        }

        //#Khai báo property
        //khai báo Property để truy xuất sửa dối dữ liệu

        public string TenSV
        {
            get { return tenSV; } //get chỉ đọc
            set { tenSV = value; } //set chỉ ghi
        }

        public int MaSV
        {
            get { return maSV; } //get chỉ đọc
            set { maSV = value; } //set chỉ ghi
        }


    }
}
