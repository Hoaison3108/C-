using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai22._3_Object
{
    /// <summary>
    /// Lớp NhanVienHanhChinh là con của lớp NhanVien, đại diện cho một nhân viên làm việc theo ca.
    /// </summary>
    /// <remarks>
    /// Lớp này có thể được mở rộng để bao gồm các thuộc tính và phương thức liên quan đến nhân viên.
    /// </remarks>
    /// </summary>
    public class NhanVienHanhChinh: NhanVien
    {
        #region Tái định nghĩa ThuongDuCong nạp chồng phương thức virtual của lớp cha NhanVien
        public override double ThuongDuCong(int ngayCong)
        {
            return 0; // Nhân viên hành chính không có thưởng nếu làm đủ ngày công
        }
        #endregion
    }
}
