using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bia15_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // Đang thực hiện một công việc nào đó
            int sum = 0;
            for (int i = 0; i <= 100; i++)
            {
                // Giả lập công việc tốn thời gian
                Thread.Sleep(50);
                
                // Thực hiện công việc
                sum += i;

                //gọi sự kiện ProgressChanged
                backgroundWorker1.ReportProgress(i);

                //Kiểm tra xem có yêu cầu hủy không
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true; // Đánh dấu là đã hủy
                    backgroundWorker1.ReportProgress(0); // Đưa ra thông báo hủy
                    return; // Thoát khỏi vòng lặp
                }
            }
            e.Result = sum; // Trả về kết quả
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //Câp nhật tiến trình %
            progressBar1.Value = e.ProgressPercentage; // Cập nhật giá trị cho ProgressBar
            label1.Text = e.ProgressPercentage.ToString() + "%"; // Cập nhật giá trị cho Label1
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Công việc đã hoàn tất
            if (e.Cancelled)
            {
                label2.Text = "Đã hủy tiến trình"; // Cập nhật giá trị cho Label1
            }
            else if (e.Error != null)
            {
                label2.Text = e.Error.Message; // Cập nhật giá trị cho Label1
            }
            else
            {
                label2.Text = "Tổng là: " + e.Result.ToString(); // Cập nhật giá trị cho Label1
            }    
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            label2.Text = ""; // Cập nhật giá trị cho Label1
            // Bắt đầu chạy BackgroundWorker
            //Kiểm tra có bận hay không trước khi chạy
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();             
            }
            else
            {
                MessageBox.Show("Đang chạy, vui lòng đợi");
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Yêu cầu hủy tiến trình
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync(); // Yêu cầu hủy
                label2.Text = "Đang hủy tiến trình..."; // Cập nhật giá trị cho Label1
            }
            else
            {
                MessageBox.Show("Không có tiến trình nào đang chạy");
                return;
            }
        }
    }
}
