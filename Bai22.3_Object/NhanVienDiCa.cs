using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai22._3_Object
{
    /// <summary>
    /// Lớp NhanVienDiCa là con của lớp NhanVien, đại diện cho một nhân viên làm việc theo ca.
    /// </summary>
    /// <remarks>
    /// Lớp này có thể được mở rộng để bao gồm các thuộc tính và phương thức liên quan đến nhân viên.
    /// </remarks>
    /// </summary>
    public class NhanVienDiCa: NhanVien
    {
        //Khai báo thêm các thuộc tính riêng cho NhanVienDiCa
        // ca ngay, ca đêm
        public string Ca { get; set; }

        #region Khai báo phương thức tính lương riêng cho NhanVienDiCa
        public new double TinhLuong()
        {
            return base.TinhLuong() * 1.05; // gọi lại phương thức của cha là 1000, nhân viên đi ca được cộng thêm 1.05
        }

        #endregion
    }
}
