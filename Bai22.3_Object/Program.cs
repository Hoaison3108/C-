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
            NhanVien nv1 = new NhanVien();
            nv1.MaNV = 1;
            nv1.TenNV = "Nguyen Van A";
            Console.WriteLine("Tên nhân viên là " + nv1.TenNV + "\nMã nhân viên là " + nv1.MaNV);
            Console.WriteLine("lương nhân viên 1 là: " + nv1.tinhLuong());


            //kế thừa
            NhanVienHanhChinh hc1 = new NhanVienHanhChinh();
            hc1.MaNV = 2;
            hc1.TenNV = "Hành chính văn phòng";
            Console.WriteLine("Tên nhân viên là " + hc1.TenNV + "\nMã nhân viên là " + hc1.MaNV);
            Console.WriteLine("Lương nhân viên hành chính là: " + hc1.tinhLuong());


            //Kế thừa và bổ sung thuộc tính
            NhanVienDiCa ca1 = new NhanVienDiCa();
            ca1.MaNV = 3;
            ca1.TenNV = "Nhân viên đi ca";
            ca1.Ca = "Ca ngày";
            Console.WriteLine("Tên nhân viên là: " + ca1.TenNV + "\nMã nhân viên là: " + ca1.MaNV + "\nCa làm việc: " + ca1.Ca);
            Console.WriteLine("Lương nhân viên đi ca là: "+ ca1.tinhLuong());

            Console.WriteLine("******************************");
            Console.WriteLine(nv1.ThuongDuCong(26));
            Console.WriteLine(hc1.ThuongDuCong(26));
            Console.WriteLine(ca1.ThuongDuCong(26));









            Console.ReadKey();  
        }
    }
}
