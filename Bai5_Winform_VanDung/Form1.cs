using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5_Winform_VanDung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn thoát không?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Bạn đã chọn không thoát ứng dụng.");
            }    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radRed.Checked = true;
            
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            lblOutput.Text = txtInput.Text; //gán output == input
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radRed.Checked)
            {
                lblOutput.ForeColor = radRed.ForeColor; //color.red
            }
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlue.Checked)
            {
                lblOutput.ForeColor = radBlue.ForeColor; //color.blue
            }
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radGreen.Checked)
            {
                lblOutput.ForeColor = radGreen.ForeColor; //color.green
            }
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {

            if (radBlack.Checked)
            {
                lblOutput.ForeColor = radBlack.ForeColor; //color.blue
            }
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBold.Checked)
            {
                lblOutput.Font = new Font(
                    lblOutput.Font.Name,
                    lblOutput.Font.Size,
                    lblOutput.Font.Style^FontStyle.Bold); //font.bold
            }
            else
            {
                lblOutput.Font = new Font(lblOutput.Font, FontStyle.Regular);
            }
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (chkItalic.Checked)
            {
                lblOutput.Font = new Font(
                    lblOutput.Font.Name,
                    lblOutput.Font.Size,
                    lblOutput.Font.Style ^ FontStyle.Italic); //font.Italic
            }
            else
            {
                lblOutput.Font = new Font(lblOutput.Font, FontStyle.Regular);
            }
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUnderline.Checked)
            {
                lblOutput.Font = new Font(
                   lblOutput.Font.Name,
                   lblOutput.Font.Size,
                   lblOutput.Font.Style ^ FontStyle.Underline); //font.Underline
            }
            else
            {
                lblOutput.Font = new Font(lblOutput.Font, FontStyle.Regular);
            }   
        }
    }
}
