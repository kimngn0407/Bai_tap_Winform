namespace BAI_TAP_VE_NHA
{
    partial class f_Hamdayso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_ketQua = new TextBox();
            label4 = new Label();
            btn_thoat = new Button();
            btn_tinh = new Button();
            txt_soM = new TextBox();
            txt_soN = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txt_ketQua
            // 
            txt_ketQua.BackColor = Color.SkyBlue;
            txt_ketQua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_ketQua.Location = new Point(136, 171);
            txt_ketQua.Name = "txt_ketQua";
            txt_ketQua.Size = new Size(215, 34);
            txt_ketQua.TabIndex = 3;
            txt_ketQua.TextAlign = HorizontalAlignment.Center;
            txt_ketQua.TextChanged += txt_ketQua_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 173);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 0;
            label4.Text = "Kết quả:";
            // 
            // btn_thoat
            // 
            btn_thoat.BackColor = Color.Aquamarine;
            btn_thoat.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_thoat.Location = new Point(257, 224);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(94, 29);
            btn_thoat.TabIndex = 5;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = false;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // btn_tinh
            // 
            btn_tinh.BackColor = Color.Aquamarine;
            btn_tinh.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_tinh.Location = new Point(37, 224);
            btn_tinh.Name = "btn_tinh";
            btn_tinh.Size = new Size(94, 29);
            btn_tinh.TabIndex = 4;
            btn_tinh.Text = "Tính";
            btn_tinh.UseVisualStyleBackColor = false;
            btn_tinh.Click += btn_tinh_Click;
            // 
            // txt_soM
            // 
            txt_soM.BackColor = SystemColors.GradientActiveCaption;
            txt_soM.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_soM.Location = new Point(136, 120);
            txt_soM.Name = "txt_soM";
            txt_soM.Size = new Size(215, 30);
            txt_soM.TabIndex = 2;
            txt_soM.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_soN
            // 
            txt_soN.BackColor = SystemColors.GradientActiveCaption;
            txt_soN.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_soN.Location = new Point(136, 69);
            txt_soN.Name = "txt_soN";
            txt_soN.Size = new Size(215, 30);
            txt_soN.TabIndex = 1;
            txt_soN.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 122);
            label3.Name = "label3";
            label3.Size = new Size(50, 25);
            label3.TabIndex = 0;
            label3.Text = "Đến:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 69);
            label2.Name = "label2";
            label2.Size = new Size(37, 25);
            label2.TabIndex = 0;
            label2.Text = "Từ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 9);
            label1.Name = "label1";
            label1.Size = new Size(289, 31);
            label1.TabIndex = 0;
            label1.Text = "HÀM TÍNH TỔNG DÃY SỐ";
            // 
            // f_Hamdayso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 278);
            Controls.Add(txt_ketQua);
            Controls.Add(label4);
            Controls.Add(btn_thoat);
            Controls.Add(btn_tinh);
            Controls.Add(txt_soM);
            Controls.Add(txt_soN);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "f_Hamdayso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hàm tính tổng dãy số";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_ketQua;
        private Label label4;
        private Button btn_thoat;
        private Button btn_tinh;
        private TextBox txt_soM;
        private TextBox txt_soN;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}