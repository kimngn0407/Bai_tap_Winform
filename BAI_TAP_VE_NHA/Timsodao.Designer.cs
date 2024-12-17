namespace BAI_TAP_VE_NHA
{
    partial class f_Timsodao
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
            txt_nhapSo = new TextBox();
            txt_ketQuaSoDao = new TextBox();
            btn_daoSo = new Button();
            btn_thoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(160, 9);
            label1.Name = "label1";
            label1.Size = new Size(124, 38);
            label1.TabIndex = 0;
            label1.Text = "SỐ ĐẢO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 71);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 0;
            label2.Text = "Nhập số:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 142);
            label3.Name = "label3";
            label3.Size = new Size(73, 25);
            label3.TabIndex = 0;
            label3.Text = "Số đảo:";
            // 
            // txt_nhapSo
            // 
            txt_nhapSo.BackColor = Color.LightPink;
            txt_nhapSo.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_nhapSo.Location = new Point(160, 71);
            txt_nhapSo.Name = "txt_nhapSo";
            txt_nhapSo.Size = new Size(218, 30);
            txt_nhapSo.TabIndex = 1;
            txt_nhapSo.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_ketQuaSoDao
            // 
            txt_ketQuaSoDao.BackColor = Color.PaleVioletRed;
            txt_ketQuaSoDao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_ketQuaSoDao.ForeColor = SystemColors.Info;
            txt_ketQuaSoDao.Location = new Point(160, 143);
            txt_ketQuaSoDao.Name = "txt_ketQuaSoDao";
            txt_ketQuaSoDao.Size = new Size(218, 34);
            txt_ketQuaSoDao.TabIndex = 2;
            txt_ketQuaSoDao.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_daoSo
            // 
            btn_daoSo.BackColor = Color.LightSalmon;
            btn_daoSo.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_daoSo.Location = new Point(34, 207);
            btn_daoSo.Name = "btn_daoSo";
            btn_daoSo.Size = new Size(94, 29);
            btn_daoSo.TabIndex = 3;
            btn_daoSo.Text = "Đảo số";
            btn_daoSo.UseVisualStyleBackColor = false;
            btn_daoSo.Click += btn_daoSo_Click;
            // 
            // btn_thoat
            // 
            btn_thoat.BackColor = Color.LightSalmon;
            btn_thoat.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_thoat.Location = new Point(316, 207);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(94, 29);
            btn_thoat.TabIndex = 4;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = false;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // f_Timsodao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 262);
            Controls.Add(btn_thoat);
            Controls.Add(btn_daoSo);
            Controls.Add(txt_ketQuaSoDao);
            Controls.Add(txt_nhapSo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "f_Timsodao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tìm số đảo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_nhapSo;
        private TextBox txt_ketQuaSoDao;
        private Button btn_daoSo;
        private Button btn_thoat;
    }
}