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
    public partial class f_Tongdayso : Form
    {
        public f_Tongdayso()
        {
            InitializeComponent();
        }

        private void btn_tinh_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ TextBox
                int n = int.Parse(txt_soN.Text);
                int m = int.Parse(txt_soM.Text);

                // Kiểm tra điều kiện N <= M
                if (n > m)
                {
                    MessageBox.Show("Vui lòng đảm bảo N <= M!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tính tổng dãy số
                int tong = TinhTongDaySo(n, m);

                // Hiển thị kết quả
                txt_ketQua.Text = tong.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số nguyên!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int TinhTongDaySo(int n, int m)
        {
            int tong = 0;
            for (int i = n; i <= m; i++)
            {
                tong += i;
            }
            return tong;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ẩn Form hiện tại
            f_Timsodao sodao = new f_Timsodao();
            sodao.FormClosed += (s, args) => this.Show(); // Hiển thị lại form hiện tại khi form mới đóng
            sodao.Show();
        }
    }
}
