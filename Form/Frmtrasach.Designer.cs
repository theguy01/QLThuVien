namespace quanly.frm
{
    partial class FrmTraSach
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTenDocGia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIDDocGia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaDocGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbHinhThucMuon = new System.Windows.Forms.ComboBox();
            this.txtSLMuon = new System.Windows.Forms.TextBox();
            this.txtThoiHanTra = new System.Windows.Forms.TextBox();
            this.txtMaTaiLieu = new System.Windows.Forms.TextBox();
            this.txtNgayMuon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.chkSachHong = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.txtPhieuMuon = new System.Windows.Forms.TextBox();
            this.txtTenTaiLieu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIDTaiLieu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grbPhieuMuon = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblQuaHan = new System.Windows.Forms.Label();
            this.btnGiaHan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grbPhieuMuon.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtTenDocGia);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtIDDocGia);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtMaDocGia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(8, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin độc giả";
            // 
            // txtTenDocGia
            // 
            this.txtTenDocGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenDocGia.Location = new System.Drawing.Point(79, 71);
            this.txtTenDocGia.Name = "txtTenDocGia";
            this.txtTenDocGia.ReadOnly = true;
            this.txtTenDocGia.Size = new System.Drawing.Size(130, 20);
            this.txtTenDocGia.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Họ Tên";
            // 
            // txtIDDocGia
            // 
            this.txtIDDocGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDDocGia.Location = new System.Drawing.Point(79, 20);
            this.txtIDDocGia.Name = "txtIDDocGia";
            this.txtIDDocGia.ReadOnly = true;
            this.txtIDDocGia.Size = new System.Drawing.Size(43, 20);
            this.txtIDDocGia.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "ID";
            // 
            // txtMaDocGia
            // 
            this.txtMaDocGia.Location = new System.Drawing.Point(79, 46);
            this.txtMaDocGia.Name = "txtMaDocGia";
            this.txtMaDocGia.ReadOnly = true;
            this.txtMaDocGia.Size = new System.Drawing.Size(73, 20);
            this.txtMaDocGia.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã độc giả";
            // 
            // cbHinhThucMuon
            // 
            this.cbHinhThucMuon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHinhThucMuon.FormattingEnabled = true;
            this.cbHinhThucMuon.Items.AddRange(new object[] {
            "Mượn tại chỗ",
            "Mượn về nhà",
            "Mượn giáo trình"});
            this.cbHinhThucMuon.Location = new System.Drawing.Point(88, 23);
            this.cbHinhThucMuon.Name = "cbHinhThucMuon";
            this.cbHinhThucMuon.Size = new System.Drawing.Size(121, 21);
            this.cbHinhThucMuon.TabIndex = 2;
            // 
            // txtSLMuon
            // 
            this.txtSLMuon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSLMuon.Location = new System.Drawing.Point(65, 72);
            this.txtSLMuon.Name = "txtSLMuon";
            this.txtSLMuon.ReadOnly = true;
            this.txtSLMuon.Size = new System.Drawing.Size(43, 20);
            this.txtSLMuon.TabIndex = 1;
            // 
            // txtThoiHanTra
            // 
            this.txtThoiHanTra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThoiHanTra.Location = new System.Drawing.Point(300, 21);
            this.txtThoiHanTra.Name = "txtThoiHanTra";
            this.txtThoiHanTra.ReadOnly = true;
            this.txtThoiHanTra.Size = new System.Drawing.Size(84, 20);
            this.txtThoiHanTra.TabIndex = 1;
            // 
            // txtMaTaiLieu
            // 
            this.txtMaTaiLieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaTaiLieu.Location = new System.Drawing.Point(168, 19);
            this.txtMaTaiLieu.Name = "txtMaTaiLieu";
            this.txtMaTaiLieu.ReadOnly = true;
            this.txtMaTaiLieu.Size = new System.Drawing.Size(92, 20);
            this.txtMaTaiLieu.TabIndex = 1;
            // 
            // txtNgayMuon
            // 
            this.txtNgayMuon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNgayMuon.Location = new System.Drawing.Point(88, 50);
            this.txtNgayMuon.Name = "txtNgayMuon";
            this.txtNgayMuon.ReadOnly = true;
            this.txtNgayMuon.Size = new System.Drawing.Size(120, 20);
            this.txtNgayMuon.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã tài liệu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "SL mượn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thời hạn trả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Thể thức mượn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày mượn";
            // 
            // btnTraSach
            // 
            this.btnTraSach.BackColor = System.Drawing.Color.Transparent;
            this.btnTraSach.ForeColor = System.Drawing.Color.Black;
            this.btnTraSach.Location = new System.Drawing.Point(335, 272);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(73, 23);
            this.btnTraSach.TabIndex = 4;
            this.btnTraSach.Text = "Trả sách";
            this.btnTraSach.UseVisualStyleBackColor = false;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // btthoat
            // 
            this.btthoat.BackColor = System.Drawing.Color.Transparent;
            this.btthoat.ForeColor = System.Drawing.Color.Black;
            this.btthoat.Location = new System.Drawing.Point(417, 272);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(73, 23);
            this.btthoat.TabIndex = 7;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = false;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // chkSachHong
            // 
            this.chkSachHong.AutoSize = true;
            this.chkSachHong.BackColor = System.Drawing.Color.Transparent;
            this.chkSachHong.ForeColor = System.Drawing.Color.Black;
            this.chkSachHong.Location = new System.Drawing.Point(8, 273);
            this.chkSachHong.Name = "chkSachHong";
            this.chkSachHong.Size = new System.Drawing.Size(78, 17);
            this.chkSachHong.TabIndex = 6;
            this.chkSachHong.Text = "Sách hỏng";
            this.chkSachHong.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnKiemTra);
            this.groupBox2.Controls.Add(this.txtPhieuMuon);
            this.groupBox2.Location = new System.Drawing.Point(8, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 47);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập mã phiếu mượn";
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.BackColor = System.Drawing.Color.Transparent;
            this.btnKiemTra.ForeColor = System.Drawing.Color.Black;
            this.btnKiemTra.Location = new System.Drawing.Point(130, 16);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(78, 23);
            this.btnKiemTra.TabIndex = 6;
            this.btnKiemTra.Text = "Kiểm tra";
            this.btnKiemTra.UseVisualStyleBackColor = false;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // txtPhieuMuon
            // 
            this.txtPhieuMuon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhieuMuon.Location = new System.Drawing.Point(9, 19);
            this.txtPhieuMuon.Name = "txtPhieuMuon";
            this.txtPhieuMuon.Size = new System.Drawing.Size(115, 20);
            this.txtPhieuMuon.TabIndex = 2;
            // 
            // txtTenTaiLieu
            // 
            this.txtTenTaiLieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenTaiLieu.Location = new System.Drawing.Point(65, 46);
            this.txtTenTaiLieu.Name = "txtTenTaiLieu";
            this.txtTenTaiLieu.ReadOnly = true;
            this.txtTenTaiLieu.Size = new System.Drawing.Size(195, 20);
            this.txtTenTaiLieu.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tên tài liệu";
            // 
            // txtIDTaiLieu
            // 
            this.txtIDTaiLieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDTaiLieu.Location = new System.Drawing.Point(65, 19);
            this.txtIDTaiLieu.Name = "txtIDTaiLieu";
            this.txtIDTaiLieu.ReadOnly = true;
            this.txtIDTaiLieu.Size = new System.Drawing.Size(43, 20);
            this.txtIDTaiLieu.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "ID";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txtIDTaiLieu);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtMaTaiLieu);
            this.groupBox3.Controls.Add(this.txtTenTaiLieu);
            this.groupBox3.Controls.Add(this.txtSLMuon);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(249, 62);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 110);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin tài liệu";
            // 
            // grbPhieuMuon
            // 
            this.grbPhieuMuon.BackColor = System.Drawing.Color.Transparent;
            this.grbPhieuMuon.Controls.Add(this.label11);
            this.grbPhieuMuon.Controls.Add(this.txtNote);
            this.grbPhieuMuon.Controls.Add(this.lblQuaHan);
            this.grbPhieuMuon.Controls.Add(this.txtThoiHanTra);
            this.grbPhieuMuon.Controls.Add(this.cbHinhThucMuon);
            this.grbPhieuMuon.Controls.Add(this.txtNgayMuon);
            this.grbPhieuMuon.Controls.Add(this.label4);
            this.grbPhieuMuon.Controls.Add(this.label3);
            this.grbPhieuMuon.Controls.Add(this.label5);
            this.grbPhieuMuon.Location = new System.Drawing.Point(8, 178);
            this.grbPhieuMuon.Name = "grbPhieuMuon";
            this.grbPhieuMuon.Size = new System.Drawing.Size(506, 88);
            this.grbPhieuMuon.TabIndex = 10;
            this.grbPhieuMuon.TabStop = false;
            this.grbPhieuMuon.Text = "Thông tin phiếu mượn";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(245, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Ghi chú";
            // 
            // txtNote
            // 
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNote.Location = new System.Drawing.Point(300, 47);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(200, 23);
            this.txtNote.TabIndex = 4;
            // 
            // lblQuaHan
            // 
            this.lblQuaHan.AutoSize = true;
            this.lblQuaHan.ForeColor = System.Drawing.Color.Red;
            this.lblQuaHan.Location = new System.Drawing.Point(390, 26);
            this.lblQuaHan.Name = "lblQuaHan";
            this.lblQuaHan.Size = new System.Drawing.Size(0, 13);
            this.lblQuaHan.TabIndex = 3;
            // 
            // btnGiaHan
            // 
            this.btnGiaHan.BackColor = System.Drawing.Color.Transparent;
            this.btnGiaHan.Enabled = false;
            this.btnGiaHan.ForeColor = System.Drawing.Color.Black;
            this.btnGiaHan.Location = new System.Drawing.Point(249, 272);
            this.btnGiaHan.Name = "btnGiaHan";
            this.btnGiaHan.Size = new System.Drawing.Size(73, 23);
            this.btnGiaHan.TabIndex = 11;
            this.btnGiaHan.Text = "Gia hạn";
            this.btnGiaHan.UseVisualStyleBackColor = false;
            this.btnGiaHan.Click += new System.EventHandler(this.btnGiaHan_Click);
            // 
            // FrmTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::QuanLyThuVien.Properties.Resources.blue_backgroud;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(520, 302);
            this.Controls.Add(this.btnGiaHan);
            this.Controls.Add(this.grbPhieuMuon);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chkSachHong);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btnTraSach);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmTraSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thực hiện  trả sách";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmTraSach_FormClosed);
            this.Load += new System.EventHandler(this.FrmTraSach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grbPhieuMuon.ResumeLayout(false);
            this.grbPhieuMuon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtThoiHanTra;
        private System.Windows.Forms.TextBox txtMaTaiLieu;
        private System.Windows.Forms.TextBox txtNgayMuon;
        private System.Windows.Forms.TextBox txtMaDocGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.ComboBox cbHinhThucMuon;
        private System.Windows.Forms.TextBox txtSLMuon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkSachHong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.TextBox txtPhieuMuon;
        private System.Windows.Forms.TextBox txtIDTaiLieu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTenTaiLieu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenDocGia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIDDocGia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox grbPhieuMuon;
        private System.Windows.Forms.Label lblQuaHan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnGiaHan;
    }
}