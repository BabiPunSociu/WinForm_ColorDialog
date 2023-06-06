using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai18_ColorDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChonMau_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();    // Tạo hộp thoại hộp màu (có thể dùng kéo thả)
            colorDialog.FullOpen = true;    // Hiển thị toàn bộ hộp thoại Color
            // Hiển thị phần Define Custom Colors
            colorDialog.SolidColorOnly = false;

            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                grbBackColor.BackColor = colorDialog.Color /* Get giá trị màu của colorDialog */;

        }
    }
}
