using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_20_Ham
{
    internal class Program
    {

        /// <summary>
        /// Hàm tính tổng 3 số nguyên
        /// </summary>
        /// <param name="a">Nhập số nguyên</param>
        /// <param name="b">Nhập số nguyên</param>
        /// <param name="c">Nhập số nguyên</param>
        /// <returns>Tong 3 số nguyên</returns>
        //Hàm tính tổng 3 số nguyên
        static int Tong(int a, int b, int c)
        {
            return a + b + c;
        }

        //Hàm tính giai thừa 
        static int TinhGiaiThua(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return n * TinhGiaiThua(n - 1);
        }

        //Ví dụ static void
        static void Xinchao (string m)
        {
            if (m == "Nam")
            {
                Console.WriteLine("mình là Boy");
            }
            if (m == "Nữ")
            {
                Console.WriteLine("Mình là Girl");
            }
        }





        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int kq = Tong(1, 2, 3);
            Console.WriteLine("Kết quả là: " + kq);

            //Xuất giai thừa
            int k = 3;
            int giaiThua = TinhGiaiThua(k);
            Console.WriteLine(giaiThua);

            Xinchao("Nam");
            Xinchao("Nữ");
            int kq3 = Tong(1, 2, 3);
            Console.ReadKey();
        }
    }
}
