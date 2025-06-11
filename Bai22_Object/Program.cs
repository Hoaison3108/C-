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
            SinhVien sinhVien3 = new SinhVien(3, "Nguyễn Văn A", 20);

            //Xuất thông tin sinh viên 3
            Console.WriteLine(sinhVien3.MaSV);
            Console.WriteLine(sinhVien3.TenSV);

            //3. Sửa dữ liệu đối tượng
            sinhVien3.MaSV = 123;
            sinhVien3.TenSV = "Nguyễn Văn B";

            Console.WriteLine(sinhVien3.MaSV);
            Console.WriteLine(sinhVien3.TenSV);

            //4. Phương thức ToString()
            //Sử dụng phương thúc đã được khai báo trong lớp SinhVien
            Console.WriteLine(sinhVien3.ToString());
            Console.WriteLine(sinhVien2.ToString());
            Console.WriteLine(sinhVien1);
            Console.WriteLine(sinhVien3);

            //service method & support method
            SinhVien sinhVien4 = new SinhVien(4, "Nguyễn Văn C", 25);

            //Check điểm và xuất thông tin
            sinhVien4.XuatThongTin();
            Console.WriteLine(sinhVien4.Tong(1, 2, 3));

            //parameter list method
            Console.WriteLine(sinhVien1.TBKetThucHocKy(7, 8, 9, 4, 5, 7, 8, 9, 6, 6));

            //auto-implemented properties
            HocSinh hocSinh1 = new HocSinh();
            hocSinh1.Name = "Nguyễn Văn D";
            hocSinh1.Email = "abc@gmail.com";
            hocSinh1.Phone = "0123456789";

            Console.WriteLine(hocSinh1.ToString());

            Console.ReadKey();
        }
    }
}
