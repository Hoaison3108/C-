using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai22._3_Object
{
    internal class NhanVienDiCa: NhanVien
    {
        //Khai bao thêm thuộc tính
        public string Ca { get; set; }

        //Phương thức
        //tính lương cho nv đi ca
        public new double tinhLuong()
        {
            return base.tinhLuong() * 1.05; //Lương cơ bản (phuong thức của cha) + phụ cấp đi ca
        }








    }
}
