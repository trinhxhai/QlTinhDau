namespace QL_ban_tinh_dau
{
    partial class QLSanphamForm
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
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lwSanpham = new System.Windows.Forms.ListView();
            this.IdSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.thetich = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Soluongdaban = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Giaban = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Loaisanpham = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbloaisp = new System.Windows.Forms.ComboBox();
            this.bntAddPic = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGiaban = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoluongdaban = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmota = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtthetich = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbMessage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txttenSP = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnHuysearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTimKiem.Location = new System.Drawing.Point(299, 38);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(46, 27);
            this.btnTimKiem.TabIndex = 42;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTimKiem.Location = new System.Drawing.Point(101, 39);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(192, 26);
            this.txtTimKiem.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(26, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 16);
            this.label11.TabIndex = 43;
            this.label11.Text = "Tìm kiếm :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "Quản lý danh mục sản phẩm";
            // 
            // lwSanpham
            // 
            this.lwSanpham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdSP,
            this.tenSP,
            this.thetich,
            this.mota,
            this.Soluongdaban,
            this.Giaban,
            this.Loaisanpham});
            this.lwSanpham.FullRowSelect = true;
            this.lwSanpham.GridLines = true;
            this.lwSanpham.HideSelection = false;
            this.lwSanpham.Location = new System.Drawing.Point(17, 87);
            this.lwSanpham.Name = "lwSanpham";
            this.lwSanpham.Size = new System.Drawing.Size(482, 296);
            this.lwSanpham.TabIndex = 44;
            this.lwSanpham.UseCompatibleStateImageBehavior = false;
            this.lwSanpham.View = System.Windows.Forms.View.Details;
            this.lwSanpham.SelectedIndexChanged += new System.EventHandler(this.lwNhanVien_SelectedIndexChanged);
            // 
            // IdSP
            // 
            this.IdSP.Text = "Mã ";
            this.IdSP.Width = 48;
            // 
            // tenSP
            // 
            this.tenSP.Text = "Tên sản phẩm";
            this.tenSP.Width = 105;
            // 
            // thetich
            // 
            this.thetich.Text = "Thể tích";
            // 
            // mota
            // 
            this.mota.Text = "Mô tả";
            // 
            // Soluongdaban
            // 
            this.Soluongdaban.Text = "Số lượng đã  bán";
            // 
            // Giaban
            // 
            this.Giaban.Text = "Giá bán";
            // 
            // Loaisanpham
            // 
            this.Loaisanpham.Text = "Loại sản phẩm";
            this.Loaisanpham.Width = 83;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbloaisp);
            this.groupBox1.Controls.Add(this.bntAddPic);
            this.groupBox1.Controls.Add(this.picBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtGiaban);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSoluongdaban);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtmota);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtthetich);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbMessage);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txttenSP);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(510, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 306);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // cbloaisp
            // 
            this.cbloaisp.FormattingEnabled = true;
            this.cbloaisp.Location = new System.Drawing.Point(106, 266);
            this.cbloaisp.Name = "cbloaisp";
            this.cbloaisp.Size = new System.Drawing.Size(151, 24);
            this.cbloaisp.TabIndex = 48;
            this.cbloaisp.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bntAddPic
            // 
            this.bntAddPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bntAddPic.Location = new System.Drawing.Point(272, 165);
            this.bntAddPic.Name = "bntAddPic";
            this.bntAddPic.Size = new System.Drawing.Size(150, 30);
            this.bntAddPic.TabIndex = 47;
            this.bntAddPic.Text = "Thêm ảnh";
            this.bntAddPic.UseVisualStyleBackColor = true;
            this.bntAddPic.Click += new System.EventHandler(this.bntAddPic_Click);
            // 
            // picBox
            // 
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox.Location = new System.Drawing.Point(272, 17);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(150, 142);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 46;
            this.picBox.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Loại sản phẩm";
            // 
            // txtGiaban
            // 
            this.txtGiaban.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtGiaban.Location = new System.Drawing.Point(106, 222);
            this.txtGiaban.MaxLength = 30;
            this.txtGiaban.Name = "txtGiaban";
            this.txtGiaban.Size = new System.Drawing.Size(151, 23);
            this.txtGiaban.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Giá  bán:";
            // 
            // txtSoluongdaban
            // 
            this.txtSoluongdaban.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSoluongdaban.Location = new System.Drawing.Point(106, 182);
            this.txtSoluongdaban.MaxLength = 30;
            this.txtSoluongdaban.Name = "txtSoluongdaban";
            this.txtSoluongdaban.Size = new System.Drawing.Size(151, 23);
            this.txtSoluongdaban.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Số lượng:";
            // 
            // txtmota
            // 
            this.txtmota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtmota.Location = new System.Drawing.Point(106, 144);
            this.txtmota.MaxLength = 30;
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(151, 23);
            this.txtmota.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Mô tả:";
            // 
            // txtthetich
            // 
            this.txtthetich.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtthetich.Location = new System.Drawing.Point(106, 105);
            this.txtthetich.MaxLength = 30;
            this.txtthetich.Name = "txtthetich";
            this.txtthetich.Size = new System.Drawing.Size(151, 23);
            this.txtthetich.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Thể tích:";
            // 
            // lbMessage
            // 
            this.lbMessage.Location = new System.Drawing.Point(58, 456);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(449, 64);
            this.lbMessage.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mã sản phẩm:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(55, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Địa chỉ :";
            // 
            // txttenSP
            // 
            this.txttenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txttenSP.Location = new System.Drawing.Point(106, 65);
            this.txttenSP.MaxLength = 30;
            this.txttenSP.Name = "txttenSP";
            this.txttenSP.Size = new System.Drawing.Size(151, 23);
            this.txttenSP.TabIndex = 5;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDiaChi.Location = new System.Drawing.Point(191, 405);
            this.txtDiaChi.MaxLength = 50;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(250, 23);
            this.txtDiaChi.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // txtMa
            // 
            this.txtMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtMa.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtMa.Location = new System.Drawing.Point(106, 29);
            this.txtMa.MaxLength = 3;
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(151, 23);
            this.txtMa.TabIndex = 4;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHuy.Location = new System.Drawing.Point(822, 413);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(60, 30);
            this.btnHuy.TabIndex = 49;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnXoa.Location = new System.Drawing.Point(741, 413);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(60, 30);
            this.btnXoa.TabIndex = 48;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLuu.Location = new System.Drawing.Point(661, 413);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(60, 30);
            this.btnLuu.TabIndex = 47;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnThem.Location = new System.Drawing.Point(584, 413);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(60, 30);
            this.btnThem.TabIndex = 46;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(872, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(79, 30);
            this.btnBack.TabIndex = 50;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnHuysearch
            // 
            this.btnHuysearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHuysearch.Location = new System.Drawing.Point(351, 38);
            this.btnHuysearch.Name = "btnHuysearch";
            this.btnHuysearch.Size = new System.Drawing.Size(46, 27);
            this.btnHuysearch.TabIndex = 51;
            this.btnHuysearch.Text = "Hủy";
            this.btnHuysearch.UseVisualStyleBackColor = true;
            this.btnHuysearch.Click += new System.EventHandler(this.btnHuysearch_Click);
            // 
            // QLSanphamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 470);
            this.Controls.Add(this.btnHuysearch);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lwSanpham);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Name = "QLSanphamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý danh mục sản phẩm";
            this.Load += new System.EventHandler(this.QLSanphamForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lwSanpham;
        private System.Windows.Forms.ColumnHeader IdSP;
        private System.Windows.Forms.ColumnHeader tenSP;
        private System.Windows.Forms.ColumnHeader thetich;
        private System.Windows.Forms.ColumnHeader mota;
        private System.Windows.Forms.ColumnHeader Soluongdaban;
        private System.Windows.Forms.ColumnHeader Giaban;
        private System.Windows.Forms.ColumnHeader Loaisanpham;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bntAddPic;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGiaban;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoluongdaban;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtthetich;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttenSP;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnHuysearch;
        private System.Windows.Forms.ComboBox cbloaisp;
    }
}