using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI_TAP_VE_NHA
{
    public partial class f_Songuyento : Form
    {
        public f_Songuyento()
        {
            InitializeComponent();
        }

        // Hàm kiểm tra số nguyên tố
        private bool KiemTraSoNguyenTo(int n)
        {
            if (n < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        // Hàm liệt kê số nguyên tố và tính tổng
        private void LietKeSNT(int n)
        {
            StringBuilder danhSach = new StringBuilder();
            ulong tongCong = 0;

            for (int i = 2; i <= n; i++)
            {
                if (KiemTraSoNguyenTo(i))
                {
                    danhSach.Append(i + " ");
                    tongCong += (ulong)i;
                }
            }

            // Hiển thị danh sách số nguyên tố
            txt_danhSach.Text = danhSach.ToString();

            // Hiển thị tổng các số nguyên tố
            txt_tongCong.Text = tongCong.ToString();
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_lietKe_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ TextBox
                int n = int.Parse(txt_nhapN.Text);

                // Liệt kê các số nguyên tố và tính tổng
                LietKeSNT(n);
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_boQua_Click(object sender, EventArgs e)
        {
            // Xóa dữ liệu trong các TextBox
            txt_nhapN.Clear();
            txt_danhSach.Clear();
            txt_tongCong.Clear();
        }

        private void btn_Thoát_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
