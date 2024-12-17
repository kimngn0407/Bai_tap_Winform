namespace BAI_TAP_VE_NHA
{
    partial class f_Songuyento
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_nhapN = new TextBox();
            btn_lietKe = new Button();
            btn_boQua = new Button();
            btn_Thoát = new Button();
            txt_danhSach = new RichTextBox();
            txt_tongCong = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 0;
            label1.Text = "Nhập N:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 114);
            label2.Name = "label2";
            label2.Size = new Size(249, 25);
            label2.TabIndex = 0;
            label2.Text = "Danh sách các số nguyên tố: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(402, 385);
            label3.Name = "label3";
            label3.Size = new Size(103, 25);
            label3.TabIndex = 0;
            label3.Text = "Tổng cộng";
            // 
            // txt_nhapN
            // 
            txt_nhapN.BackColor = Color.PaleGoldenrod;
            txt_nhapN.Location = new Point(12, 48);
            txt_nhapN.Name = "txt_nhapN";
            txt_nhapN.Size = new Size(198, 27);
            txt_nhapN.TabIndex = 1;
            txt_nhapN.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_lietKe
            // 
            btn_lietKe.BackColor = Color.FromArgb(192, 255, 192);
            btn_lietKe.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_lietKe.Location = new Point(258, 48);
            btn_lietKe.Name = "btn_lietKe";
            btn_lietKe.Size = new Size(94, 32);
            btn_lietKe.TabIndex = 2;
            btn_lietKe.Text = "Liệt kê";
            btn_lietKe.UseVisualStyleBackColor = false;
            btn_lietKe.Click += btn_lietKe_Click;
            // 
            // btn_boQua
            // 
            btn_boQua.BackColor = Color.FromArgb(192, 255, 192);
            btn_boQua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_boQua.Location = new Point(387, 48);
            btn_boQua.Name = "btn_boQua";
            btn_boQua.Size = new Size(94, 32);
            btn_boQua.TabIndex = 3;
            btn_boQua.Text = "Bỏ qua";
            btn_boQua.UseVisualStyleBackColor = false;
            btn_boQua.Click += btn_boQua_Click;
            // 
            // btn_Thoát
            // 
            btn_Thoát.BackColor = Color.FromArgb(192, 255, 192);
            btn_Thoát.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Thoát.Location = new Point(511, 48);
            btn_Thoát.Name = "btn_Thoát";
            btn_Thoát.Size = new Size(94, 32);
            btn_Thoát.TabIndex = 4;
            btn_Thoát.Text = "Thoát";
            btn_Thoát.UseVisualStyleBackColor = false;
            btn_Thoát.Click += btn_Thoát_Click;
            // 
            // txt_danhSach
            // 
            txt_danhSach.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_danhSach.Location = new Point(12, 153);
            txt_danhSach.Name = "txt_danhSach";
            txt_danhSach.Size = new Size(644, 223);
            txt_danhSach.TabIndex = 5;
            txt_danhSach.Text = "";
            // 
            // txt_tongCong
            // 
            txt_tongCong.BackColor = Color.FromArgb(192, 192, 255);
            txt_tongCong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_tongCong.ForeColor = Color.Maroon;
            txt_tongCong.Location = new Point(511, 385);
            txt_tongCong.Name = "txt_tongCong";
            txt_tongCong.Size = new Size(145, 34);
            txt_tongCong.TabIndex = 6;
            txt_tongCong.TextAlign = HorizontalAlignment.Center;
            // 
            // f_Songuyento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 424);
            Controls.Add(txt_tongCong);
            Controls.Add(txt_danhSach);
            Controls.Add(btn_Thoát);
            Controls.Add(btn_boQua);
            Controls.Add(btn_lietKe);
            Controls.Add(txt_nhapN);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "f_Songuyento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dãy số nguyên tố";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_nhapN;
        private Button btn_lietKe;
        private Button btn_boQua;
        private Button btn_Thoát;
        private RichTextBox txt_danhSach;
        private TextBox txt_tongCong;
    }
}