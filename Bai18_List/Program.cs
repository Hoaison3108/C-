using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai18_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
             */
            Console.OutputEncoding = Encoding.UTF8;

            //9. bool <ds>.Contains(<value>);
            // Kiểm tra có tồn tại trong list ko 
            // Có trả về true, không trả về false
            List<int> ds10 = new List<int>() { 100, 200};
            bool kq = ds10.Contains(100);
            Console.WriteLine(kq);

            //10. GetRange (int index, int count);
            //Trả về 1 list con, lấy từ index và count ký tự của list nguồn
            List<int> ds11 = new List<int>() { 100, 200 , 1, 5, 7 ,8 ,102};
            List<int> ds12 = ds11.GetRange(1, 3); //Lấy từ vị trí 1, lấy 3 phần tử
            foreach (int i in ds12)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //11. IndexOf(<value>);
            //Trả về vị trí index giá trị tìm thấy, nếu không thấy trả về -1
            List<int> ds13 = new List<int>() { 100, 200, 1, 5, 7, 8, 99 };
            int checkIndex = ds13.IndexOf(8);
            Console.WriteLine(checkIndex);

            //12. Insert(int index, <value>);
            //Chèn thêm value vào vị trí index chỉ định
            List<int> ds14 = new List<int>() { 100, 200, 1, 5, 7, 8, 99 };
            ds14.Insert(5, 1000); //Chèn 1000 vào vị trí 5
            foreach (int i in ds14)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //13. InsertRange(int index, <List>);
            //Chèn thêm 1 list vào vị trí index chỉ định của list gốc
            List<int> ds15 = new List<int>() { 101, 204, 1, 5, 7, 8, 99 };
            List<int> ds16 = new List<int>() { 1000, 2000, 3000 };
            ds15.InsertRange(2, ds16); //Chèn ds16 vào vị trí 2 của ds15
            foreach (int i in ds15)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //14. RemoveAt(<int index>);
            //Xóa phần tử tại vị trí index chỉ định
            List<int> ds17 = new List<int>() { 101, 204, 1, 5, 7, 8, 99 };
            ds17.RemoveAt(2); //Xóa phần tử tại vị trí 2
            Console.WriteLine("Danh sách 17 sau khi xóa: ");
            foreach (int i in ds17)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //15. RemoveRange(<int Index, int count>);
            //Xóa từ vị trí index chỉ định và xóa count phần tử
            List<int> ds18 = new List<int>() { 101, 204, 1, 5, 7, 8, 99 };
            ds18.RemoveRange(2, 3); //Xóa từ vị trí 2 và xóa 3 phần tử
            Console.WriteLine("Danh sách 18 sau khi xóa: ");
            foreach (int i in ds18)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //16. Reverse(); đao ngược thứ tự các phần tử trong list
            List<int> ds19 = new List<int>() { 101, 204, 1, 5, 7, 8, 99 };
            ds19.Reverse(); //Đảo ngược thứ tự các phần tử trong list
            Console.WriteLine("Danh sách 19 sau khi đảo: ");
            foreach (int i in ds19)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //17. Sort(); Sắp xếp thứ tự các phần tử trong list
            List<int> ds20 = new List<int>() { 101, 204, 1, 5, 7, 8, 99 };
            ds20.Sort(); //Sắp xếp thứ tự các phần tử trong list
            Console.WriteLine("Danh sách 20 sau khi sắp xếp: ");
            foreach (int i in ds20)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //18. BinarySearch(<value>); tim kiếm nhị phân
            int kq2 = ds20.BinarySearch(7); //Tìm kiếm nhị phân
            Console.WriteLine(kq2);
            
            //19. Max, min
            int kq3 = ds20.Max(); //Tìm giá trị lớn nhất
            int kq4 = ds20.Min(); //Tìm giá trị nhỏ nhất
            Console.WriteLine(" Giá trị lớn nhất là : "+ kq3);
            Console.WriteLine(" Giá trị bé nhất là : "+ kq4);

            Console.ReadKey();
        }
    }
}
