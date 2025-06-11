using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapVanDung_26
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
          * Bài 26: Viết chương trình trả lời kết quả các phép tính
          * quest = {"2 + 5 + 7=","5*10=","sqrt(16) = ","12%2 = ","5//2="}
          */
            Console.OutputEncoding = Encoding.UTF8; 
            List<string> quest = new List<string>() { "2 + 5 + 7=", "5*10=", "sqrt(16) = ", "12%2 = ", "5//2=" };
             
            for (int i = 0; i < quest.Count; i++) //chạy từ i đến nhỏ hơn số phần tử của quest (count dùng đếm số phần tử)
            {
                Console.Write(quest[i]);
                Console.WriteLine();
                int ans = int.Parse(Console.ReadLine());


            }

            Console.ReadKey();
        }
    }
}
