
namespace QL_ban_tinh_dau
{
    partial class BCThongKeForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.dpTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dpFrom = new System.Windows.Forms.DateTimePicker();
            this.lwNhanVien = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.bntTKNhanVien = new System.Windows.Forms.Button();
            this.bntTKKhachHang = new System.Windows.Forms.Button();
            this.bntTKLoaiChauCay = new System.Windows.Forms.Button();
            this.bntTKChauCay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F);
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 32);
            this.label3.TabIndex = 44;
            this.label3.Text = "Báo cáo thống kê";
            // 
            // dpTo
            // 
            this.dpTo.Location = new System.Drawing.Point(509, 68);
            this.dpTo.Name = "dpTo";
            this.dpTo.Size = new System.Drawing.Size(200, 20);
            this.dpTo.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(454, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(65, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Dữ liệu lấy từ ngày :";
            // 
            // dpFrom
            // 
            this.dpFrom.Location = new System.Drawing.Point(221, 69);
            this.dpFrom.Name = "dpFrom";
            this.dpFrom.Size = new System.Drawing.Size(200, 20);
            this.dpFrom.TabIndex = 40;
            // 
            // lwNhanVien
            // 
            this.lwNhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.lwNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lwNhanVien.HideSelection = false;
            this.lwNhanVien.Location = new System.Drawing.Point(21, 114);
            this.lwNhanVien.Name = "lwNhanVien";
            this.lwNhanVien.Size = new System.Drawing.Size(688, 318);
            this.lwNhanVien.TabIndex = 52;
            this.lwNhanVien.UseCompatibleStateImageBehavior = false;
            this.lwNhanVien.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã NV";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tên nhân viên";
            this.columnHeader6.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tên tài khoản";
            this.columnHeader8.Width = 150;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Số hóa đơn";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Số lượng";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader10.Width = 80;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Tổng thành tiền";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader11.Width = 143;
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBackToMain.Location = new System.Drawing.Point(1015, 12);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(108, 38);
            this.btnBackToMain.TabIndex = 53;
            this.btnBackToMain.Text = "Quay lại";
            this.btnBackToMain.UseVisualStyleBackColor = true;
            // 
            // bntTKNhanVien
            // 
            this.bntTKNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bntTKNhanVien.Location = new System.Drawing.Point(760, 345);
            this.bntTKNhanVien.Name = "bntTKNhanVien";
            this.bntTKNhanVien.Size = new System.Drawing.Size(345, 60);
            this.bntTKNhanVien.TabIndex = 57;
            this.bntTKNhanVien.Text = "Thống kê nhân viên bán hàng";
            this.bntTKNhanVien.UseVisualStyleBackColor = true;
            // 
            // bntTKKhachHang
            // 
            this.bntTKKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bntTKKhachHang.Location = new System.Drawing.Point(759, 268);
            this.bntTKKhachHang.Name = "bntTKKhachHang";
            this.bntTKKhachHang.Size = new System.Drawing.Size(345, 58);
            this.bntTKKhachHang.TabIndex = 56;
            this.bntTKKhachHang.Text = "Thống kê khách hàng mua";
            this.bntTKKhachHang.UseVisualStyleBackColor = true;
            // 
            // bntTKLoaiChauCay
            // 
            this.bntTKLoaiChauCay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bntTKLoaiChauCay.Location = new System.Drawing.Point(759, 190);
            this.bntTKLoaiChauCay.Name = "bntTKLoaiChauCay";
            this.bntTKLoaiChauCay.Size = new System.Drawing.Size(346, 58);
            this.bntTKLoaiChauCay.TabIndex = 55;
            this.bntTKLoaiChauCay.Text = "Thống kê loại chậu cây bán được";
            this.bntTKLoaiChauCay.UseVisualStyleBackColor = true;
            // 
            // bntTKChauCay
            // 
            this.bntTKChauCay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bntTKChauCay.Location = new System.Drawing.Point(759, 114);
            this.bntTKChauCay.Name = "bntTKChauCay";
            this.bntTKChauCay.Size = new System.Drawing.Size(346, 60);
            this.bntTKChauCay.TabIndex = 54;
            this.bntTKChauCay.Text = "Thống kê chậu cây bán được";
            this.bntTKChauCay.UseVisualStyleBackColor = true;
            // 
            // BCThongKeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 464);
            this.Controls.Add(this.bntTKNhanVien);
            this.Controls.Add(this.bntTKKhachHang);
            this.Controls.Add(this.bntTKLoaiChauCay);
            this.Controls.Add(this.bntTKChauCay);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.lwNhanVien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dpTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dpFrom);
            this.Name = "BCThongKeForm";
            this.Text = "BCThongKeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dpTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dpFrom;
        private System.Windows.Forms.ListView lwNhanVien;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button btnBackToMain;
        private System.Windows.Forms.Button bntTKNhanVien;
        private System.Windows.Forms.Button bntTKKhachHang;
        private System.Windows.Forms.Button bntTKLoaiChauCay;
        private System.Windows.Forms.Button bntTKChauCay;
    }
}