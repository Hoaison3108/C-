using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_21_TryCatch
{
    internal class Program
    {
        static void ngoaiLe()
        {
            try
            {
                Console.WriteLine("Mời nhập vào ngày tháng năm sinh: ");
                string input = Console.ReadLine();
                DateTime birthday = DateTime.Parse(input);
                Console.WriteLine("Ngày sinh của bạn là: " + birthday.ToString("dd/MM/yyyy"));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Kết thúc chương trình.");
            }

        }

        static void ngoaiLe2()
        {
            Console.WriteLine("Mời nâọ vào tử số: ");
            int tuSo = int.Parse(Console.ReadLine());
            Console.WriteLine("Mời nhập vào mẫu số: ");
            int mauSo = int.Parse(Console.ReadLine());

            if(mauSo == 0)
            throw new ArithmeticException("Mẫu số không được bằng 0");
            else
            {
                double ketQua = (double)tuSo / mauSo;
                Console.WriteLine("Kết quả là: " + ketQua);
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
           // ngoaiLe();  
           try
            {
                ngoaiLe2();
            }

            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }





                Console.ReadKey();
        }
    }
}
