using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bia15_Winform
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        //#1. BackgroundWorker
        /*
         - Sử dụng khi có những tác vụ tốn thời gian, 
        không thể chạy trên UI thread
         - Dùng tương tác và hiển thị tiến trình xử lý công việc nào đó
         - Ngoài ra ta có thể can thiệp dừng tiến trình khi đang chạy dở

         
         */
        //#2. ProgressBar
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
