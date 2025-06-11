using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai16_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuFileNew_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New File");
        }

        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open File");
        }

        private void btnFileOpen_Click(object sender, EventArgs e)
        {
            mnuFileOpen.PerformClick();
        }

        private void btnFileNew_Click(object sender, EventArgs e)
        {
            mnuFileNew.PerformClick();
        }
    }
}
