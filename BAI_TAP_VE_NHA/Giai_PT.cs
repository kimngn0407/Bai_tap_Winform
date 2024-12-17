namespace BAI_TAP_VE_NHA
{
    public partial class f_phuongtrinhbac1 : Form
    {
        public f_phuongtrinhbac1()
        {
            InitializeComponent();
        }

        private void btn_giaiPT_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ các TextBox
                double a = double.Parse(txt_soA.Text);
                double b = double.Parse(txt_soB.Text);

                // Xử lý phương trình bậc 1
                if (a == 0)
                {
                    if (b == 0)
                    {
                        txt_ketQua.Text = "";
                        txt_nghiemPT.Text = "Vô số nghiệm";
                    }
                    else
                    {
                        txt_ketQua.Text = "";
                        txt_nghiemPT.Text = "Vô nghiệm";
                    }
                }
                else
                {
                    double x = -b / a;
                    txt_ketQua.Text = $"x = {x:F2}";
                    txt_nghiemPT.Text = "1 nghiệm";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_thoat_Click(object sender, EventArgs e)
        {
            {
                this.Hide(); // Ẩn Form hiện tại
                f_Tongdayso dayso = new f_Tongdayso();
                dayso.FormClosed += (s, args) => this.Show(); // Hiển thị lại form hiện tại khi form mới đóng
                dayso.Show();
            }
        }
    }
}
