using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai22._3_Object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            #region Khởi tạo NhanVien
            NhanVien nv1 = new NhanVien();
            nv1.MaNV = 1;
            nv1.TenNV = "Nhân Viên 1";

            Console.WriteLine("Mã nhân viên là: " + nv1.MaNV + "\nTên nhân viên là: " + nv1.TenNV);
            Console.WriteLine("lương " + nv1.TenNV + ": " + nv1.TinhLuong());
            #endregion

            #region Khởi tạo NhanVienHanhChinh
            NhanVienHanhChinh hc1 = new NhanVienHanhChinh();
            hc1.MaNV = 2;
            hc1.TenNV = "Nhân Viên Hành Chính 1";

            Console.WriteLine("Mã nhân viên là: " + hc1.MaNV + "\nTên nhân viên là: " + hc1.TenNV);
            Console.WriteLine("lương " + hc1.TenNV + ": " + hc1.TinhLuong());
            #endregion

            #region Khởi tạo NhanVienDiCa
            NhanVienDiCa ca1 = new NhanVienDiCa();
            ca1.MaNV = 3;
            ca1.TenNV = "Nhân Viên Đi Ca 1";
            ca1.Ca = "Ca ngày";

            Console.WriteLine("Mã nhân viên là: " +ca1.MaNV + "\nTên nhân viên là: " + ca1.TenNV + "\nCa làm việc: " + ca1.Ca);
            Console.WriteLine("lương " + ca1.TenNV + ": " + ca1.TinhLuong());

            #endregion

            #region hàm ảo virtual
            Console.WriteLine("********************************************");
            Console.WriteLine(nv1.ThuongDuCong(26));
            Console.WriteLine(hc1.ThuongDuCong(26));
            Console.WriteLine(ca1.ThuongDuCong(26));
            #endregion

            Console.ReadKey();
        }
    }
}
