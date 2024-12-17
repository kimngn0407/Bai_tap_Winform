namespace BAI_TAP_VE_NHA
{
    partial class f_phuongtrinhbac1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lb_giaiPT = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_soA = new TextBox();
            txt_soB = new TextBox();
            txt_ketQua = new TextBox();
            txt_nghiemPT = new TextBox();
            btn_giaiPT = new Button();
            btn_thoat = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // lb_giaiPT
            // 
            lb_giaiPT.AutoSize = true;
            lb_giaiPT.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_giaiPT.ForeColor = Color.FromArgb(0, 64, 64);
            lb_giaiPT.Location = new Point(50, 9);
            lb_giaiPT.Name = "lb_giaiPT";
            lb_giaiPT.Size = new Size(0, 38);
            lb_giaiPT.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 70);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(113, 25);
            label1.TabIndex = 0;
            label1.Text = "Hệ số của A:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 110);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 0;
            label2.Text = "Hệ số của B:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 158);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 0;
            label3.Text = "Kết quả:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 208);
            label4.Name = "label4";
            label4.Size = new Size(230, 25);
            label4.TabIndex = 0;
            label4.Text = "Nghiệm của phương trình:";
            // 
            // txt_soA
            // 
            txt_soA.BackColor = Color.LemonChiffon;
            txt_soA.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_soA.Location = new Point(257, 71);
            txt_soA.Name = "txt_soA";
            txt_soA.Size = new Size(220, 30);
            txt_soA.TabIndex = 1;
            txt_soA.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_soB
            // 
            txt_soB.BackColor = Color.LemonChiffon;
            txt_soB.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_soB.Location = new Point(257, 111);
            txt_soB.Name = "txt_soB";
            txt_soB.Size = new Size(220, 30);
            txt_soB.TabIndex = 2;
            txt_soB.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_ketQua
            // 
            txt_ketQua.BackColor = Color.Wheat;
            txt_ketQua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_ketQua.Location = new Point(257, 159);
            txt_ketQua.Name = "txt_ketQua";
            txt_ketQua.Size = new Size(220, 34);
            txt_ketQua.TabIndex = 3;
            txt_ketQua.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_nghiemPT
            // 
            txt_nghiemPT.BackColor = Color.Moccasin;
            txt_nghiemPT.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_nghiemPT.Location = new Point(257, 209);
            txt_nghiemPT.Name = "txt_nghiemPT";
            txt_nghiemPT.Size = new Size(220, 34);
            txt_nghiemPT.TabIndex = 4;
            txt_nghiemPT.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_giaiPT
            // 
            btn_giaiPT.BackColor = Color.Salmon;
            btn_giaiPT.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_giaiPT.Location = new Point(59, 257);
            btn_giaiPT.Name = "btn_giaiPT";
            btn_giaiPT.Size = new Size(106, 31);
            btn_giaiPT.TabIndex = 5;
            btn_giaiPT.Text = "Giải PT";
            btn_giaiPT.UseVisualStyleBackColor = false;
            btn_giaiPT.Click += btn_giaiPT_Click;
            // 
            // btn_thoat
            // 
            btn_thoat.BackColor = Color.Salmon;
            btn_thoat.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_thoat.Location = new Point(310, 257);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(106, 31);
            btn_thoat.TabIndex = 6;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = false;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(41, 14);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(446, 31);
            label5.TabIndex = 0;
            label5.Text = "TÍNH PHƯƠNG TRÌNH BẬC 1 AX + B = 0";
            // 
            // f_phuongtrinhbac1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 302);
            Controls.Add(label5);
            Controls.Add(btn_thoat);
            Controls.Add(btn_giaiPT);
            Controls.Add(txt_nghiemPT);
            Controls.Add(txt_ketQua);
            Controls.Add(txt_soB);
            Controls.Add(txt_soA);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lb_giaiPT);
            Name = "f_phuongtrinhbac1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phương trình bậc 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_giaiPT;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_soA;
        private TextBox txt_soB;
        private TextBox txt_ketQua;
        private TextBox txt_nghiemPT;
        private Button btn_giaiPT;
        private Button btn_thoat;
        private Label label5;
    }
}
