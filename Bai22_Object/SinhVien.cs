using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai22_Object
{
    public class SinhVien
    {
        #region biến lớp
        //#khai báo biến lớp
        private int maSV;
        private string tenSV;
        private float diemThiDH;
        #endregion

        //khai báo contructor mặc định
        //contructor hàm dùng khởi tạo giá trí cho đối tượng

        #region constructor
        //#Khai báo contructor
        //khai báo contructor mặc định
        public SinhVien()
        {
            this.maSV = 0;
            this.tenSV = "No name";
            this.diemThiDH = 0f;
        }

        //khai báo contructor có tham số
        public SinhVien(int maSV, string tenSV, float diemThiDH)
        {
            this.maSV = maSV;
            this.tenSV = tenSV;
            this.diemThiDH = diemThiDH;
        }
        #endregion

        #region Property
        //#Khai báo property
        //khai báo Property để truy xuất sửa dối dữ liệu

        public float DiemThiDH
        {
            get { return diemThiDH; } //get chỉ đọc
            set { diemThiDH = value; } //set chỉ ghi
        }

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
        #endregion

        #region Method
        //#Method
        //phương thức có sẵn ToString() để xuất thông tin đối tượng
        public override string ToString()
        {
            return this.maSV + " - " + this.tenSV;
        }

        //Suport method (private method) sử dụng trong lớp, không truy xuất từ bên ngoài
        private bool CheckDiemThiDH()
        {
            return (this.diemThiDH - 21 >= 0);
        }


        //service method (public method) sử dụng bên ngoài lớp, truy xuất từ bên ngoài
        public void XuatThongTin()
        {
            if (CheckDiemThiDH() == false)
             {
                Console.WriteLine("Điểm thi DH < 21, cần kiểm tra lại hồ sơ");
             }    
            else
             {
                Console.WriteLine(ToString() + " Đủ điều kiện"); //xuât ra thông tin đối tượng
              }    
               
        }

        //Phương thức tính tổng
        public int Tong (int x, int y)
        {
            return x + y;
        }

        public int Tong (int x, int y, int z)
        {
            return x + y + z;
        }

        public double Tong (double x, double y, double z)
        {
            return x + y + z;
        }

        //parameter method (phương thức có tham số) với số lượng tham số không xác định
        //tính tổng sử dụng params

        public float TBKetThucHocKy(params float[] mangDiemThi)
        {
            float tongDiemThi = 0f;
            foreach (float f in mangDiemThi)
            {
                tongDiemThi += f; //cộng dồn điểm thi
            }
            return (tongDiemThi/ mangDiemThi.Count()); //trả về điểm trung bình
        }

        #endregion
    }
}
