using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapVanDung_24_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Bài 24: Viết chương trình tạo ra 1 list có n phần tử, n nhập từ bàn phím,
            các phần tử là số ngẫu nhiên từ (1,100)

             */

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập và sô lượng phần tử n: ");
            int n = int.Parse(Console.ReadLine());
            List<int> ds = new List<int>();//khai báo list
            Random random = new Random();//tao ra số ngẫu nhiên
            for (int i = 0; i < n; i++)
            {
                ds.Add(random.Next(1, 101));
            }
            Console.WriteLine("Danh sách ngẫu nhiên vừa tạo ra là: ");
            foreach (int i in ds)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
