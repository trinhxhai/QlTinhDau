namespace QL_ban_tinh_dau
{
    partial class ChiTietHoaDonForm
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
            this.btnThemHoaDon = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lbTong = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnXoaCTHD = new System.Windows.Forms.Button();
            this.lwCTHD = new System.Windows.Forms.ListView();
            this.ma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soluongSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GiaBan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.khuyenMai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.thanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnHuyTimKiem = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lwSanpham = new System.Windows.Forms.ListView();
            this.IdSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.thetich = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Loaisanpham = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtKhuyenMai = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnThemHoaDon
            // 
            this.btnThemHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnThemHoaDon.Location = new System.Drawing.Point(23, 446);
            this.btnThemHoaDon.Name = "btnThemHoaDon";
            this.btnThemHoaDon.Size = new System.Drawing.Size(533, 72);
            this.btnThemHoaDon.TabIndex = 69;
            this.btnThemHoaDon.Text = "Thêm hóa đơn";
            this.btnThemHoaDon.UseVisualStyleBackColor = true;
            this.btnThemHoaDon.Click += new System.EventHandler(this.btnThemHoaDon_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(515, 403);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 20);
            this.label10.TabIndex = 68;
            this.label10.Text = "vnd";
            // 
            // lbTong
            // 
            this.lbTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbTong.Location = new System.Drawing.Point(352, 403);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(158, 23);
            this.lbTong.TabIndex = 67;
            this.lbTong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(293, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 64;
            this.label7.Text = "Tổng :";
            // 
            // btnXoaCTHD
            // 
            this.btnXoaCTHD.Enabled = false;
            this.btnXoaCTHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnXoaCTHD.Location = new System.Drawing.Point(23, 397);
            this.btnXoaCTHD.Name = "btnXoaCTHD";
            this.btnXoaCTHD.Size = new System.Drawing.Size(108, 40);
            this.btnXoaCTHD.TabIndex = 66;
            this.btnXoaCTHD.Text = "Xóa";
            this.btnXoaCTHD.UseVisualStyleBackColor = true;
            this.btnXoaCTHD.Click += new System.EventHandler(this.btnXoaCTHD_Click);
            // 
            // lwCTHD
            // 
            this.lwCTHD.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ma,
            this.tenSP,
            this.soluongSP,
            this.GiaBan,
            this.khuyenMai,
            this.thanhTien});
            this.lwCTHD.FullRowSelect = true;
            this.lwCTHD.GridLines = true;
            this.lwCTHD.HideSelection = false;
            this.lwCTHD.Location = new System.Drawing.Point(23, 58);
            this.lwCTHD.Name = "lwCTHD";
            this.lwCTHD.Size = new System.Drawing.Size(533, 324);
            this.lwCTHD.TabIndex = 65;
            this.lwCTHD.UseCompatibleStateImageBehavior = false;
            this.lwCTHD.View = System.Windows.Forms.View.Details;
            this.lwCTHD.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lwCTHD_ItemSelectionChanged);
            // 
            // ma
            // 
            this.ma.Text = "Mã";
            this.ma.Width = 50;
            // 
            // tenSP
            // 
            this.tenSP.Text = "Tên sản phẩm";
            this.tenSP.Width = 120;
            // 
            // soluongSP
            // 
            this.soluongSP.Text = "Số lượng mua";
            this.soluongSP.Width = 83;
            // 
            // GiaBan
            // 
            this.GiaBan.Text = "Giá bán";
            this.GiaBan.Width = 76;
            // 
            // khuyenMai
            // 
            this.khuyenMai.Text = "Khuyến mại";
            this.khuyenMai.Width = 100;
            // 
            // thanhTien
            // 
            this.thanhTien.Text = "Thành tiền";
            this.thanhTien.Width = 120;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F);
            this.label5.Location = new System.Drawing.Point(17, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 32);
            this.label5.TabIndex = 63;
            this.label5.Text = "Chi tiết hóa đơn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label8.Location = new System.Drawing.Point(568, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 26);
            this.label8.TabIndex = 75;
            this.label8.Text = "Danh sách sản phẩm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTimKiem.Location = new System.Drawing.Point(660, 90);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(252, 26);
            this.txtTimKiem.TabIndex = 70;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(575, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 20);
            this.label11.TabIndex = 74;
            this.label11.Text = "Tìm kiếm :";
            // 
            // btnHuyTimKiem
            // 
            this.btnHuyTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnHuyTimKiem.Location = new System.Drawing.Point(1010, 90);
            this.btnHuyTimKiem.Name = "btnHuyTimKiem";
            this.btnHuyTimKiem.Size = new System.Drawing.Size(85, 27);
            this.btnHuyTimKiem.TabIndex = 72;
            this.btnHuyTimKiem.Text = "Hủy";
            this.btnHuyTimKiem.UseVisualStyleBackColor = true;
            this.btnHuyTimKiem.Click += new System.EventHandler(this.btnHuyTimKiem_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTimKiem.Location = new System.Drawing.Point(928, 90);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(76, 27);
            this.btnTimKiem.TabIndex = 71;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lwSanpham
            // 
            this.lwSanpham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdSP,
            this.columnHeader1,
            this.thetich,
            this.mota,
            this.gb,
            this.Loaisanpham});
            this.lwSanpham.FullRowSelect = true;
            this.lwSanpham.GridLines = true;
            this.lwSanpham.HideSelection = false;
            this.lwSanpham.Location = new System.Drawing.Point(600, 141);
            this.lwSanpham.Name = "lwSanpham";
            this.lwSanpham.Size = new System.Drawing.Size(550, 215);
            this.lwSanpham.TabIndex = 76;
            this.lwSanpham.UseCompatibleStateImageBehavior = false;
            this.lwSanpham.View = System.Windows.Forms.View.Details;
            this.lwSanpham.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lwSanpham_ItemSelectionChanged);
            // 
            // IdSP
            // 
            this.IdSP.Text = "Mã ";
            this.IdSP.Width = 48;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên sản phẩm";
            this.columnHeader1.Width = 105;
            // 
            // thetich
            // 
            this.thetich.Text = "Thể tích";
            this.thetich.Width = 74;
            // 
            // mota
            // 
            this.mota.Text = "Mô tả";
            this.mota.Width = 152;
            // 
            // gb
            // 
            this.gb.Text = "Giá bán";
            this.gb.Width = 80;
            // 
            // Loaisanpham
            // 
            this.Loaisanpham.Text = "Loại sản phẩm";
            this.Loaisanpham.Width = 83;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(796, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 20);
            this.label6.TabIndex = 86;
            this.label6.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(1212, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 25);
            this.label3.TabIndex = 85;
            this.label3.Text = "vnd";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtThanhTien.Location = new System.Drawing.Point(964, 405);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(244, 32);
            this.txtThanhTien.TabIndex = 84;
            this.txtThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(834, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 83;
            this.label1.Text = "Thành tiền :";
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnHuy.Location = new System.Drawing.Point(1062, 472);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(169, 44);
            this.btnHuy.TabIndex = 82;
            this.btnHuy.Text = "Đóng";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.Enabled = false;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnThem.Location = new System.Drawing.Point(592, 472);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(421, 44);
            this.btnThem.TabIndex = 81;
            this.btnThem.Text = "Thêm sản phẩm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtKhuyenMai
            // 
            this.txtKhuyenMai.Enabled = false;
            this.txtKhuyenMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtKhuyenMai.Location = new System.Drawing.Point(691, 423);
            this.txtKhuyenMai.Name = "txtKhuyenMai";
            this.txtKhuyenMai.Size = new System.Drawing.Size(102, 26);
            this.txtKhuyenMai.TabIndex = 80;
            this.txtKhuyenMai.Text = "0";
            this.txtKhuyenMai.TextChanged += new System.EventHandler(this.txtKhuyenMai_TextChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Enabled = false;
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSoLuong.Location = new System.Drawing.Point(691, 382);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(102, 26);
            this.txtSoLuong.TabIndex = 79;
            this.txtSoLuong.Text = "0";
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(574, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 78;
            this.label4.Text = "Số lượng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(575, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 77;
            this.label2.Text = "Khuyến mại :";
            // 
            // ChiTietHoaDonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 563);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtKhuyenMai);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lwSanpham);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnHuyTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnThemHoaDon);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbTong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnXoaCTHD);
            this.Controls.Add(this.lwCTHD);
            this.Controls.Add(this.label5);
            this.Name = "ChiTietHoaDonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.ChiTietHoaDonForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThemHoaDon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbTong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnXoaCTHD;
        private System.Windows.Forms.ListView lwCTHD;
        private System.Windows.Forms.ColumnHeader ma;
        private System.Windows.Forms.ColumnHeader tenSP;
        private System.Windows.Forms.ColumnHeader soluongSP;
        public System.Windows.Forms.ColumnHeader GiaBan;
        private System.Windows.Forms.ColumnHeader khuyenMai;
        private System.Windows.Forms.ColumnHeader thanhTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnHuyTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ListView lwSanpham;
        private System.Windows.Forms.ColumnHeader IdSP;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader thetich;
        private System.Windows.Forms.ColumnHeader mota;
        private System.Windows.Forms.ColumnHeader gb;
        private System.Windows.Forms.ColumnHeader Loaisanpham;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtKhuyenMai;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}