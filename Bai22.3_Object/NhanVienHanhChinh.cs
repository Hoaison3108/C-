using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai22._3_Object
{
   public class NhanVienHanhChinh: NhanVien
    {
        //Tái định nghĩa override phương thức
        public override double ThuongDuCong(int ngayCong)
        {
            return 0; //không có thưởng cho nhân viên hành chính
        }



    }
}
