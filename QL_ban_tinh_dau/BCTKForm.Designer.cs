
namespace QL_ban_tinh_dau
{
    partial class BCTKForm
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
            this.dpFrom = new System.Windows.Forms.DateTimePicker();
            this.dpTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lwSanPham = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBack = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPrintStatic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lwLoaiSanPham = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwKhachHang = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwNhanVien = new System.Windows.Forms.ListView();
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bntTKNhanVien = new System.Windows.Forms.Button();
            this.bntTKKhachHang = new System.Windows.Forms.Button();
            this.bntTKLoaiSanPham = new System.Windows.Forms.Button();
            this.bntTKSanPham = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dpFrom
            // 
            this.dpFrom.Location = new System.Drawing.Point(93, 59);
            this.dpFrom.Name = "dpFrom";
            this.dpFrom.Size = new System.Drawing.Size(200, 20);
            this.dpFrom.TabIndex = 1;
            this.dpFrom.ValueChanged += new System.EventHandler(this.dpFrom_ValueChanged);
            // 
            // dpTo
            // 
            this.dpTo.Location = new System.Drawing.Point(347, 57);
            this.dpTo.Name = "dpTo";
            this.dpTo.Size = new System.Drawing.Size(200, 20);
            this.dpTo.TabIndex = 2;
            this.dpTo.ValueChanged += new System.EventHandler(this.dpTo_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Từ ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "đến";
            // 
            // lwSanPham
            // 
            this.lwSanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lwSanPham.HideSelection = false;
            this.lwSanPham.Location = new System.Drawing.Point(46, 119);
            this.lwSanPham.Name = "lwSanPham";
            this.lwSanPham.Size = new System.Drawing.Size(688, 336);
            this.lwSanPham.TabIndex = 5;
            this.lwSanPham.UseCompatibleStateImageBehavior = false;
            this.lwSanPham.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã SP";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên SP";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá bán";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tổng số lượng đã bán";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tổng thành tiền";
            this.columnHeader5.Width = 120;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(984, 36);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(684, 473);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "(vnd)";
            // 
            // lbTongTien
            // 
            this.lbTongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbTongTien.Location = new System.Drawing.Point(461, 469);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(216, 30);
            this.lbTongTien.TabIndex = 50;
            this.lbTongTien.Text = "0";
            this.lbTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(367, 474);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "Tổng cộng :";
            // 
            // btnPrintStatic
            // 
            this.btnPrintStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPrintStatic.Location = new System.Drawing.Point(46, 473);
            this.btnPrintStatic.Name = "btnPrintStatic";
            this.btnPrintStatic.Size = new System.Drawing.Size(170, 35);
            this.btnPrintStatic.TabIndex = 54;
            this.btnPrintStatic.Text = "In báo cáo";
            this.btnPrintStatic.UseVisualStyleBackColor = true;
            this.btnPrintStatic.Click += new System.EventHandler(this.btnPrintStatic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 32);
            this.label1.TabIndex = 55;
            this.label1.Text = "Báo cáo thống kê";
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbTitle.Location = new System.Drawing.Point(51, 82);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(683, 30);
            this.lbTitle.TabIndex = 56;
            // 
            // lwLoaiSanPham
            // 
            this.lwLoaiSanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader10});
            this.lwLoaiSanPham.HideSelection = false;
            this.lwLoaiSanPham.Location = new System.Drawing.Point(46, 119);
            this.lwLoaiSanPham.Name = "lwLoaiSanPham";
            this.lwLoaiSanPham.Size = new System.Drawing.Size(688, 336);
            this.lwLoaiSanPham.TabIndex = 57;
            this.lwLoaiSanPham.UseCompatibleStateImageBehavior = false;
            this.lwLoaiSanPham.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mã Loại SP";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tên Loại SP";
            this.columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tổng số lượng đã bán";
            this.columnHeader8.Width = 120;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Tổng thành tiền";
            this.columnHeader10.Width = 120;
            // 
            // lwKhachHang
            // 
            this.lwKhachHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.lwKhachHang.HideSelection = false;
            this.lwKhachHang.Location = new System.Drawing.Point(46, 118);
            this.lwKhachHang.Name = "lwKhachHang";
            this.lwKhachHang.Size = new System.Drawing.Size(688, 336);
            this.lwKhachHang.TabIndex = 58;
            this.lwKhachHang.UseCompatibleStateImageBehavior = false;
            this.lwKhachHang.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Mã KH";
            this.columnHeader9.Width = 80;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Tên KH";
            this.columnHeader11.Width = 150;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Tổng số lượng mua";
            this.columnHeader12.Width = 120;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Tổng thành tiền";
            this.columnHeader13.Width = 120;
            // 
            // lwNhanVien
            // 
            this.lwNhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17});
            this.lwNhanVien.HideSelection = false;
            this.lwNhanVien.Location = new System.Drawing.Point(46, 118);
            this.lwNhanVien.Name = "lwNhanVien";
            this.lwNhanVien.Size = new System.Drawing.Size(688, 336);
            this.lwNhanVien.TabIndex = 59;
            this.lwNhanVien.UseCompatibleStateImageBehavior = false;
            this.lwNhanVien.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Mã NV";
            this.columnHeader14.Width = 80;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Tên NV";
            this.columnHeader15.Width = 150;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Tổng số lượng đã bán";
            this.columnHeader16.Width = 120;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Tổng thành tiền";
            this.columnHeader17.Width = 120;
            // 
            // bntTKNhanVien
            // 
            this.bntTKNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bntTKNhanVien.Location = new System.Drawing.Point(761, 376);
            this.bntTKNhanVien.Name = "bntTKNhanVien";
            this.bntTKNhanVien.Size = new System.Drawing.Size(359, 51);
            this.bntTKNhanVien.TabIndex = 63;
            this.bntTKNhanVien.Text = "Thống kê nhân viên bán hàng";
            this.bntTKNhanVien.UseVisualStyleBackColor = true;
            this.bntTKNhanVien.Click += new System.EventHandler(this.bntTKNhanVien_Click);
            // 
            // bntTKKhachHang
            // 
            this.bntTKKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bntTKKhachHang.Location = new System.Drawing.Point(761, 296);
            this.bntTKKhachHang.Name = "bntTKKhachHang";
            this.bntTKKhachHang.Size = new System.Drawing.Size(359, 51);
            this.bntTKKhachHang.TabIndex = 62;
            this.bntTKKhachHang.Text = "Thống kê khách hàng mua";
            this.bntTKKhachHang.UseVisualStyleBackColor = true;
            this.bntTKKhachHang.Click += new System.EventHandler(this.bntTKKhachHang_Click);
            // 
            // bntTKLoaiSanPham
            // 
            this.bntTKLoaiSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bntTKLoaiSanPham.Location = new System.Drawing.Point(760, 216);
            this.bntTKLoaiSanPham.Name = "bntTKLoaiSanPham";
            this.bntTKLoaiSanPham.Size = new System.Drawing.Size(359, 51);
            this.bntTKLoaiSanPham.TabIndex = 61;
            this.bntTKLoaiSanPham.Text = "Thống kê loại sản phẩm bán được";
            this.bntTKLoaiSanPham.UseVisualStyleBackColor = true;
            this.bntTKLoaiSanPham.Click += new System.EventHandler(this.bntTKLoaiSanPham_Click);
            // 
            // bntTKSanPham
            // 
            this.bntTKSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bntTKSanPham.Location = new System.Drawing.Point(760, 138);
            this.bntTKSanPham.Name = "bntTKSanPham";
            this.bntTKSanPham.Size = new System.Drawing.Size(359, 51);
            this.bntTKSanPham.TabIndex = 60;
            this.bntTKSanPham.Text = "Thống kê sản phẩm bán được";
            this.bntTKSanPham.UseVisualStyleBackColor = true;
            this.bntTKSanPham.Click += new System.EventHandler(this.bntTKSanPham_Click);
            // 
            // BCTKForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 571);
            this.Controls.Add(this.bntTKNhanVien);
            this.Controls.Add(this.bntTKKhachHang);
            this.Controls.Add(this.bntTKLoaiSanPham);
            this.Controls.Add(this.bntTKSanPham);
            this.Controls.Add(this.lwNhanVien);
            this.Controls.Add(this.lwKhachHang);
            this.Controls.Add(this.lwLoaiSanPham);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrintStatic);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lwSanPham);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dpTo);
            this.Controls.Add(this.dpFrom);
            this.Name = "BCTKForm";
            this.Text = "BCTK";
            this.Load += new System.EventHandler(this.BCTKForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dpFrom;
        private System.Windows.Forms.DateTimePicker dpTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lwSanPham;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPrintStatic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.ListView lwLoaiSanPham;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ListView lwKhachHang;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ListView lwNhanVien;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.Button bntTKNhanVien;
        private System.Windows.Forms.Button bntTKKhachHang;
        private System.Windows.Forms.Button bntTKLoaiSanPham;
        private System.Windows.Forms.Button bntTKSanPham;
    }
}