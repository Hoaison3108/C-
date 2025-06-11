using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai16_Mang1Chieu
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
          1) Khái niệm: Mảng là một tập hợp các đối tượng có cùng kiểu dữ liệu, chúng có kích thước cố định và không thể thay đổi
          2) Tại sao phri dùng mảng: Gom mhóm các đối tượng có chung tính chất lại với nhua giúp code gọn hơn
          3) Khai báo mảng: 
            - Kiểu dữ liệu[] <tên mảng>;
            - Ví dụ: int[] soNguyen; // Khai báo mảng 
          4) Khởi tạo mảng:
            - Kiểu dữ liệu[] <tên mảng> = new Kiểu dữ liệu[số phần tử];
            - Ví dụ: int[] soNguyen = new int[5]; // Khởi tạo mảng có 5 phần tử
          5) Khởi tạo và gán giá trị cho mảng
            - Kiểu dữ liệu[] <tên mảng> = new Kiểu dữ liệu[số phần tử] { giá trị 1, giá trị 2, ... };
            - Ví dụ: int[] soNguyen = new int[5] { 1, 2, 3, 4, 5 }; // Khởi tạo mảng có 5 phần tử và gán giá trị cho mảng
         6) Khởi tạo mảng ngẫu nhiên
           Random r = new Random();
            int[] mang = {r.Next(51), r.Next(60)};
         7) Length: trả về số phần tử của mảng 
            int doDai = mang4.Length;
            console.WriteLine("Độ dài của mảng là: " + doDai);
         8) Truy xuất phần tử qua index
            - Ví dụ: int a = soNguyen[0]; // Truy xuất phần tử đầu tiên của mảng
         9) Thay đổi giá trị phần tử của màng bằng cách gọi index
            - Ví dụ: soNguyen[0] = 10; // Thay đổi giá trị phần tử đầu tiên của mảng thành 10
         10) duyệt mảng sử dụng vòng lặp for
            - Ví dụ: 
                for (int i = 0; i < soNguyen.Length; i++)
                {
                    Console.Write(soNguyen[i] + " ");
                }
          11) duyệt mảng dùng foreach
            - Ví dụ: 
                foreach (int i in soNguyen)
                {
                    Console.Write(i + " ");
                }
          12) Phép gán mảng
            * Gán mảng mới = mảng đã tồn tại ( tham chiếu cùng vùng nhớ)
            * chú ý: khi thay đổi giá trị của 1 mảng, thì mảng còn lại cũng thay đổi theo, 
            * do mảng là kiêu tham chiếu nó sẽ tham chiếu đến cùng 1 vùng nhớ
            - Ví dụ: 
                int[] mang1 = { 1, 2, 3, 4, 5 };
                int[] mang2 = mang1; // Gán mảng 1 cho mảng 2
                mang2[0] = 100; // Thay đổi giá trị phần tử đầu tiên của mảng 2 thành 100
                foreach (int i in mang1)
                {
                    Console.Write(i + " ");
                }
            13) CopyTo (copy ra mảng mới trên vùng nhớ mới)
                Array_nguon.CopyTo(Array_dich,int_index);

            14) Copy(Array_nguon, Array_dich, int32);
               copy ra mảng mới trên vùng nhớ mới
            int32: số phần tử cần copy tính từ int_index 0

            15) Clone (tạo ra mảng mới trên vùng nhớ mới)
                - Clone: tạo ra 1 mảng mới trên vùng nhớ mới, clone sẽ copy toàn bộ phần tử của mảng
                - Ví dụ: 
                    int[] mang1 = { 1, 2, 3, 4, 5 };
                    int[] mang2 = (int[])mang1.Clone(); // Gán mảng 1 cho mảng 2
                    mang2[0] = 100; // Thay đổi giá trị phần tử đầu tiên của mảng 2 thành 100
                    foreach (int i in mang1)
                    {
                        Console.Write(i + " ");
                    }
            16) Array.Reverse: đảo ngược mảng
                - Ví dụ: 
                    int[] mang1 = { 1, 2, 3, 4, 5 };
                    Array.Reverse(mang1); // Đảo ngược mảng
                    foreach (int i in mang1)
                    {
                        Console.Write(i + " ");
                    }
            17) Array.Sort: sắp xếp mảng

          */
            Console.OutputEncoding = Encoding.UTF8;
            //1) Khai báo mảng
            int[] stt;
            char[] ch;
            string[] ten;

            //2) Khởi tạo mảng
            stt = new int[5]; // Khởi tạo mảng có 5 phần tử
            foreach (int i in stt)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();//xuống dòng
            Console.WriteLine( "Mảng Stt2 là: ");
            int[] stt2 = new int[7];
            foreach (int i in stt2)
            {
                Console.Write(i + " ");
            }

            //3) Khởi tạo và gán giá trị cho mảng
            int[] mang2 = { 1, 2, 3, 4, 5 }; // Khởi tạo mảng có 5 phần tử và gán giá trị cho mảng
            Console.WriteLine();//xuống dòng
            Console.WriteLine("Mảng2 là: ");
            foreach (int i in mang2)
            {
                Console.Write(i + " ");
            }

            //4) Khởi tạo mảng ngẫu nhiên
            Random r = new Random();
            int[] mang3 = {r.Next(51), r.Next(60)};
            Console.WriteLine();//xuống dòng
            Console.WriteLine("Mảng3 là: ");
            foreach (int i in mang3)
            {
                Console.Write(i + " ");
            }

            //7. Length: trả về số phần tử của mảng
            Console.WriteLine();
            int doDai = mang3.Length;
            Console.WriteLine("Chiều dài mảng 3 là : " + doDai);

            //8. Truy xuất phần tử qua index
            int[] mang4 = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Vị trí index đầu tiên: " + mang4[0]);
            Console.WriteLine("Vị trí index cuối cùng: " + mang4[mang4.Length-1]);

            //9. Thay đổi giá trị phần tử của màng bằng cách gọi index
            int[] mang5 = { 1, 2, 3, 4, 5, 9 , 10 };
            mang5[0] = 100; // Thay đổi giá trị phần tử đầu tiên của mảng thành 10
            foreach (int i in mang5)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //10. duyệt mảng sử dụng vòng lặp for
            int[] mang6 = { 1, 2, 3, 4, 5, 8 };
            for (int i = 0; i < mang6.Length; i++)
            {
                Console.Write(mang6[i] + " ");
            }
            Console.WriteLine();

            //12. phép gán mảng
            int[] mang8 = { 1, 2, 3, 4, 5, 9 };
            int[] mang9 = mang8; // Gán mảng 9 cho mảng 8
            Console.WriteLine(mang8[0]);
            mang8[0] = 100; // Thay đổi giá trị phần tử đầu tiên của mảng 8 thành 100
            Console.WriteLine("Mảng 8 sau khi thay đổi " + mang8[0]);
            Console.WriteLine("Mảng 9 sau khi thay đổi " + mang9[0]);

            //13. CopyTo (copy ra mảng mới trên vùng nhớ mới)
            int[] mang10 = { 100, 200, 300, 400 };
            int[] mang11 = {1, 8, 9, 4, 5, 6, 7};
            mang10.CopyTo(mang11, 2); // Copy mảng 10 vào mảng 11 vào index 2

            Console.WriteLine("mảng 11 sau khi thay đổi giá trị: ");
            foreach (int i in mang11)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //14. Copy(Array_nguon, Array_dich, int32);
            int[] mang12 = { 100, 200, 300, 400 };
            int[] mang13 = new int[4];
            Array.Copy(mang12, mang13, 3); // Copy mảng 12 vào mảng 13 lấy 4 phần tử
            Console.WriteLine("mảng 13 sau khi copy giá trị: ");
            foreach (int i in mang13)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //15. Clone (tạo ra mảng mới trên vùng nhớ mới)
            int[] mang14 = { 1, 2, 3, 4, 5 };
            int[] mang15 = (int[])mang14.Clone(); // Gán mảng 14 cho mảng 15
            Console.WriteLine("Mảng 15 sau khi clone: ");
            foreach (int i in mang15)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //16. Array.Reverse: đảo ngược mảng
            int[] mang16 = { 1, 2, 3, 4, 5 };
            Array.Reverse(mang16); // Đảo ngược mảng
            Console.WriteLine("Mảng 16 sau khi đảo ngược: ");
            foreach (int i in mang16)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //17. Array.Sort: sắp xếp mảng
            int[] mang17 = { 15, 410, 31, 200, 1 };
            Array.Sort(mang17); // Sắp xếp mảng
            Console.WriteLine("Mảng 17 sau khi sắp xếp: ");
            foreach (int i in mang17)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
