using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai22._3_Object
{
    /// <summary>
    /// Lớp NhanVien là lớp cha đại diện cho một nhân viên trong hệ thống.
    /// </summary>
    /// <remarks>
    /// Lớp này có thể được mở rộng để bao gồm các thuộc tính và phương thức liên quan đến nhân viên.
    /// </remarks>
    /// </summary>
    public class NhanVien
    {
        #region khai báo NhanVien
        public int MaNV { get; set; }
        public string TenNV { get; set; }
        #endregion

        #region Khai báo phương thức tính lương NV
        public double TinhLuong()
        {
            return 1000; // Giả sử lương cơ bản là 1000
        }
        #endregion

        #region hàm ảo virtual
      public virtual double ThuongDuCong (int ngayCong)
        {
            if (ngayCong >= 26)
            {
                return 100;
            }    
            else
            {
                return 0;
            }    
        }

        #endregion
    }
}
