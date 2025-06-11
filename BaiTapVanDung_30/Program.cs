using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapVanDung_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Dictionary<string, int> dic = new Dictionary<string, int>()
            { {"A",1},{"B",2},{ "C",3},{ "D",2},{ "E",1},{ "F",4},{ "G",2},
            { "H",4},{ "I",1},{ "J",8},{ "K",5},{ "L",1},{ "M",3},{ "N",1},{ "O",1},
            { "P",3},{ "Q",10},{ "R",1},{ "S",1},{ "T",1},{ "U",1},{ "V",4},{ "W",4},
            { "X",8},{ "Y",4},{ "Z",10} };

            1: Tách số và chữ , hiển thị lên màn hình	
            2: tính tổng các số
            3: chuyển đổi chuỗi : "University of Technology and Education" sang số
            */

            Console.OutputEncoding = Encoding.UTF8;
            Dictionary<string, int> dic = new Dictionary<string, int>()
            { {"A",1},{"B",2},{ "C",3},{ "D",2},{ "E",1},{ "F",4},{ "G",2},
            { "H",4},{ "I",1},{ "J",8},{ "K",5},{ "L",1},{ "M",3},{ "N",1},{ "O",1},
            { "P",3},{ "Q",10},{ "R",1},{ "S",1},{ "T",1},{ "U",1},{ "V",4},{ "W",4},
            { "X",8},{ "Y",4},{ "Z",10} };

            //duyệt dic
            foreach (KeyValuePair <string, int> kvp in dic )
            {
                Console.Write(kvp);
            }

            //tach chữ: Tolist();
            List<string> ds = new List<string>();
            ds = dic.Keys.ToList(); //chuyển key thành list
            Console.WriteLine("\nList chữ cái sau khi tách là: ");
            foreach (string key in ds)
            {
                Console.Write(key.PadRight(3));
            }

            //tach số: ToList();
            List<int> ds2 = new List<int>();
            ds2 = dic.Values.ToList(); //chuyển value thành list
            //Console.WriteLine("\nList chữ số sau khi tách là: ");
            Console.WriteLine();
            foreach (int value in ds2)
            {
                Console.Write(value.ToString().PadRight(3));
            }

            //Tính tổng các chữ số
            int tong = ds2.Sum();
            Console.WriteLine("\nTổng : " + tong);

            //Chuyển đổi chuỗi: University of Technology and Education" sang số
            string s = "University of Technology and Education";
            string upcase = s.ToUpper(); //chuyển thành chữ hoa

            //Chuyển chữ hoa sang số
            string strSo = "";
            foreach (char c in upcase)
            {
                if (c == ' ')
                    strSo += c;
                else
                {
                    strSo += dic[c.ToString()]; //lấy giá trị của key
                }
            }
            Console.WriteLine(upcase);
            Console.WriteLine(strSo);
            Console.ReadKey();  
        }
    }
}
