using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapVanDung_29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Viết chương trình sử dụng dict chứa 5 user name và password
           #1: nếu uer name không có trong dict, báo user không tồn tại
           #2: Nếu ueser name đúng mà pass sai thì báo sai pass    
           #3: Nếu usêr, pass đúng thì báo login thành công
            */
            Console.OutputEncoding = Encoding.UTF8; 
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("admin", "123456");
            dic.Add("admin1", "123456");
            dic.Add("admin2", "123456");
            dic.Add("admin3", "123456");
            dic.Add("admin4", "123456");

            //duyệt dic
            foreach (KeyValuePair<string, string> pair in dic)
            {
                Console.WriteLine(pair);
            }
            //#1: viết chuong trình nhập và user và pass
            Console.WriteLine("mới nhập vào username");
            string user = Console.ReadLine();
            Console.WriteLine("Mời nhập vào mật khẩu");
            string passWord = Console.ReadLine();
           
            //Check username có tồn tại không
            if (dic.ContainsKey(user) == false)
                Console.WriteLine("user không tồn tại!");
            else
            {
                if (dic[user] == passWord) //dic tại usêr sẽ xuất ra value của user
                {
                    Console.WriteLine("Đăng nhập thành công");
                }
                else
                {
                    Console.WriteLine("Sai mật khẩu");
                }
            }




            Console.ReadKey();
        }
    }
}
