using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai22_Object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //1. Tạo đối tượng sinh viên mới không truyền giá trị
            SinhVien sinhVien1 = new SinhVien();
            SinhVien sinhVien2 = new SinhVien();

            //Xuất thông tin sinh viên
            Console.WriteLine(sinhVien1.MaSV);
            Console.WriteLine(sinhVien1.TenSV);
            Console.WriteLine(sinhVien2.MaSV);
            Console.WriteLine(sinhVien2.TenSV);
            Console.WriteLine("Tên sinh viên là: " + sinhVien1.TenSV);

            //2. Tạo đối tượng sinh viên mới truyền giá trị
            SinhVien sinhVien3 = new SinhVien(3, "Nguyễn Văn A");

            //Xuất thông tin sinh viên 3
            Console.WriteLine(sinhVien3.MaSV);
            Console.WriteLine(sinhVien3.TenSV);

            //3. Sửa dữ liệu đối tượng
            sinhVien3.MaSV = 123;
            sinhVien3.TenSV = "Nguyễn Văn B";

            Console.WriteLine(sinhVien3.MaSV);
            Console.WriteLine(sinhVien3.TenSV);


            Console.ReadKey();
        }
    }
}
