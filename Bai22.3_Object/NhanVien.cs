using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai22._3_Object
{
    public class NhanVien
    {
        //khởi tạo thuộc tính
        public int MaNV { get; set; }
        public String TenNV { get; set; }

        //phương thức 
        //tính lương nv
        public double tinhLuong()
        {
            return 1000; //Lương cơ bản
        }

        //hàm ảo virtual
        public virtual double ThuongDuCong(int ngayCong)
        {
            if (ngayCong >= 26)
                return 100;
            else
                return 0;
        }







    }
}
