using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapVanDung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            1) Viết chương trình tạo 1 mảng 1 chiều gồm các phần tử là số nguyên có n phần tử
            ngẫu nhiên, n do người dùng nhập từ bàn phím
            2) Xuất các giá trị trong mảng
            3) Đảo ngược mảng và xuất mảng sau khi đảo ngược
            4) Sắp xếp mảng tăng dần
            5) Tính tổng các phần tử trong mảng
            6) Cho người dùng nhập vào 1 số bất kỳ, kiểm tra số đó có tồn tại trong mảng hay không,
            nếu có xuất ra vị trí index của số đó trong mảng
             
             */
            Console.OutputEncoding = Encoding.UTF8; 
            Console.WriteLine("Nhập vào số phần tử của mảng: ");
            int n = int.Parse(Console.ReadLine());
            int[] mang = new int[n];
            for (int i = 0; i < n; i++)
            {
                //Random r = new Random();
                //mang[i] = r.Next(1, 100);
                Console.Write(mang[i] + " ");
               
            }
            Console.WriteLine();

            //1. Nhập giá trị ngẫu nhiên
            Console.ReadKey();
        }
    }
}
