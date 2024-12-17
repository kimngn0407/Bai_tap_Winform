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
    public partial class f_Timsodao : Form
    {
        public f_Timsodao()
        {
            InitializeComponent();
        }

        private void btn_daoSo_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy số từ TextBox nhập
                int soNhap = int.Parse(txt_nhapSo.Text);

                // Đảo ngược số
                int soDao = DaoSo(soNhap);

                // Hiển thị kết quả
                txt_ketQuaSoDao.Text = soDao.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int DaoSo(int so)
        {
            int soDao = 0;
            while (so != 0)
            {
                int chuSo = so % 10;
                soDao = soDao * 10 + chuSo;
                so /= 10;
            }
            return soDao;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            {
                this.Hide(); // Ẩn Form hiện tại
                f_Hamdayso ham = new f_Hamdayso();
                ham.FormClosed += (s, args) => this.Show(); // Hiển thị lại form hiện tại khi form mới đóng
                ham.Show();

            }
        }
    }
}