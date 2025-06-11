using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai8_Winform_VanDung2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        /*
         1. Tạo class SinhVien chứa 2 thuộc tính mã và tên\
         2. Button lưu để thêm phần tử vào listbox
         3. Button xóa để xóa phần tử trong listbox
         */
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
