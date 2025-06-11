using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapVanDung_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Bài 25: Viết chuong trình nhập vào 1 danh sách  list sau đó:
            #1. tạo ra 1 list mới bình phương các phần tử
            #2. Xác định bao nhiêu phàn tử lớn hơn 50
             */
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số lượng phần tử n: ");
            int n = int.Parse(Console.ReadLine());
            List<int> ds2 = new List<int>();
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                ds2.Add(random.Next(1, 21));
            }

            foreach (var i in ds2)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            //1. tạo ra list mới bình phương các phần tử
            List<double> ds3 = new List<double>();
            //Cách 1 duyệt foreach
            foreach (int i in ds2)
            {
                ds3.Add(Math.Pow(i, 2));
            }

            //ds3 = ds2.Select(x => x * x).ToList(); //Cách 2
            Console.WriteLine("List 3 là");
            foreach (var i in ds3)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            //2. Xác định bao nhiêu phàn tử lớn hơn 50
            int dem = 0;
            foreach (var i in ds3)
            {
                if (i > 50)
                {
                    dem++;
                }
            }
            Console.WriteLine("Có {0} phần tử lớn hơn 50", dem);

            Console.ReadKey();
        }
    }
}
