using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai19_FontDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChonFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true;    // Hiển thị bảng Color
            if(fontDialog.ShowDialog() == DialogResult.OK)
            {
                txtText.Font = fontDialog.Font; // Lấy font đã chọn từ hộp thoại font
                txtText.ForeColor = fontDialog.Color;   // Lấy màu đã chọn từ bảng color
            }    
        }
    }
}
