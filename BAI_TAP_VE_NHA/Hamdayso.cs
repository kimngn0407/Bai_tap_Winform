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
    public partial class f_Hamdayso : Form
    {
        public f_Hamdayso()
        {
            InitializeComponent();
        }
        static ulong TongS(uint M, uint N)
        {
            // Đảm bảo M luôn nhỏ hơn hoặc bằng N
            if (M > N)
            {
                uint temp = M;
                M = N;
                N = temp;
            }

            // Tính tổng từ M đến N bằng công thức toán học
            ulong tong = ((ulong)(N - M + 1) * (M + N)) / 2;
            return tong;
        }

        private void txt_ketQua_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_tinh_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ TextBox
                uint M = uint.Parse(txt_soM.Text);
                uint N = uint.Parse(txt_soN.Text);

                // Tính tổng dãy số
                ulong tong = TongS(M, N);

                // Hiển thị kết quả
                txt_ketQua.Text = tong.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số nguyên dương hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ẩn Form hiện tại
            f_Songuyento nguyento = new f_Songuyento();
            nguyento.FormClosed += (s, args) => this.Show(); // Hiển thị lại form hiện tại khi form mới đóng
            nguyento.Show();
        }
    }
}
