﻿namespace GUI
{
    partial class FrmNhapThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhapThuoc));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgv_PhieuNhap = new System.Windows.Forms.DataGridView();
            this.pn_TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_HamLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_Lo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgv_Thuoc = new System.Windows.Forms.DataGridView();
            this.TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HamLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbb_LoaiThuoc = new System.Windows.Forms.ComboBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_TenThuoc = new Demo.Controls.TextBox_NTT();
            this.txt_DonGia = new Demo.Controls.TextBox_NTT();
            this.txt_Lo = new Demo.Controls.TextBox_NTT();
            this.txt_HamLuong = new Demo.Controls.TextBox_NTT();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.date_NgayNhap = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtn_ThemPhieuNhap = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtn_Refresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtn_Thoat = new System.Windows.Forms.ToolStripButton();
            this.txt_TongTien = new Demo.Controls.TextBox_NTT();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_DonViTinh = new Demo.Controls.TextBox_NTT();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_PhieuNhap)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Thuoc)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgv_PhieuNhap);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 630);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1417, 323);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhập thuốc";
            // 
            // dtgv_PhieuNhap
            // 
            this.dtgv_PhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_PhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_PhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pn_TenThuoc,
            this.pn_DonGia,
            this.pn_HamLuong,
            this.pn_SoLuong,
            this.pn_Lo,
            this.NgayNhap,
            this.pn_DonViTinh});
            this.dtgv_PhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_PhieuNhap.Location = new System.Drawing.Point(3, 23);
            this.dtgv_PhieuNhap.Name = "dtgv_PhieuNhap";
            this.dtgv_PhieuNhap.RowHeadersWidth = 51;
            this.dtgv_PhieuNhap.RowTemplate.Height = 29;
            this.dtgv_PhieuNhap.Size = new System.Drawing.Size(1411, 297);
            this.dtgv_PhieuNhap.TabIndex = 1;
            // 
            // pn_TenThuoc
            // 
            this.pn_TenThuoc.HeaderText = "Tên thuốc";
            this.pn_TenThuoc.MinimumWidth = 6;
            this.pn_TenThuoc.Name = "pn_TenThuoc";
            // 
            // pn_DonGia
            // 
            this.pn_DonGia.HeaderText = "Đơn giá (VND)";
            this.pn_DonGia.MinimumWidth = 6;
            this.pn_DonGia.Name = "pn_DonGia";
            // 
            // pn_HamLuong
            // 
            this.pn_HamLuong.HeaderText = "Hàm lượng";
            this.pn_HamLuong.MinimumWidth = 6;
            this.pn_HamLuong.Name = "pn_HamLuong";
            // 
            // pn_SoLuong
            // 
            this.pn_SoLuong.HeaderText = "Số lượng";
            this.pn_SoLuong.MinimumWidth = 6;
            this.pn_SoLuong.Name = "pn_SoLuong";
            // 
            // pn_Lo
            // 
            this.pn_Lo.HeaderText = "Lô";
            this.pn_Lo.MinimumWidth = 6;
            this.pn_Lo.Name = "pn_Lo";
            // 
            // NgayNhap
            // 
            this.NgayNhap.HeaderText = "Ngày nhập";
            this.NgayNhap.MinimumWidth = 6;
            this.NgayNhap.Name = "NgayNhap";
            // 
            // pn_DonViTinh
            // 
            this.pn_DonViTinh.HeaderText = "Đơn vị tính";
            this.pn_DonViTinh.MinimumWidth = 6;
            this.pn_DonViTinh.Name = "pn_DonViTinh";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtgv_Thuoc);
            this.groupBox1.Controls.Add(this.cbb_LoaiThuoc);
            this.groupBox1.Location = new System.Drawing.Point(3, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1405, 269);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh mục thuốc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Loại thuốc";
            // 
            // dtgv_Thuoc
            // 
            this.dtgv_Thuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_Thuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Thuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenThuoc,
            this.DonGia,
            this.HamLuong,
            this.DonViTinh});
            this.dtgv_Thuoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgv_Thuoc.Location = new System.Drawing.Point(3, 64);
            this.dtgv_Thuoc.Name = "dtgv_Thuoc";
            this.dtgv_Thuoc.ReadOnly = true;
            this.dtgv_Thuoc.RowHeadersWidth = 51;
            this.dtgv_Thuoc.RowTemplate.Height = 29;
            this.dtgv_Thuoc.Size = new System.Drawing.Size(1399, 202);
            this.dtgv_Thuoc.TabIndex = 3;
            this.dtgv_Thuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Thuoc_CellClick);
            // 
            // TenThuoc
            // 
            this.TenThuoc.HeaderText = "Tên thuốc";
            this.TenThuoc.MinimumWidth = 6;
            this.TenThuoc.Name = "TenThuoc";
            this.TenThuoc.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn giá (VND)";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // HamLuong
            // 
            this.HamLuong.HeaderText = "Hàm lượng";
            this.HamLuong.MinimumWidth = 6;
            this.HamLuong.Name = "HamLuong";
            this.HamLuong.ReadOnly = true;
            // 
            // DonViTinh
            // 
            this.DonViTinh.HeaderText = "Đơn vị tính";
            this.DonViTinh.MinimumWidth = 6;
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.ReadOnly = true;
            // 
            // cbb_LoaiThuoc
            // 
            this.cbb_LoaiThuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_LoaiThuoc.FormattingEnabled = true;
            this.cbb_LoaiThuoc.Location = new System.Drawing.Point(111, 26);
            this.cbb_LoaiThuoc.Name = "cbb_LoaiThuoc";
            this.cbb_LoaiThuoc.Size = new System.Drawing.Size(280, 28);
            this.cbb_LoaiThuoc.TabIndex = 1;
            this.cbb_LoaiThuoc.SelectedIndexChanged += new System.EventHandler(this.cbb_LoaiThuoc_SelectedIndexChanged);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(438, 554);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(200, 39);
            this.btn_Them.TabIndex = 4;
            this.btn_Them.Text = "Thêm danh sách nhập";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_TenThuoc
            // 
            this.txt_TenThuoc.BackColor = System.Drawing.SystemColors.Window;
            this.txt_TenThuoc.BorderColor = System.Drawing.Color.Black;
            this.txt_TenThuoc.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_TenThuoc.BorderRadius = 5;
            this.txt_TenThuoc.BorderSize = 1;
            this.txt_TenThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TenThuoc.Location = new System.Drawing.Point(123, 402);
            this.txt_TenThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenThuoc.Multiline = true;
            this.txt_TenThuoc.Name = "txt_TenThuoc";
            this.txt_TenThuoc.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_TenThuoc.PasswordChar = false;
            this.txt_TenThuoc.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_TenThuoc.PlaceholderText = "";
            this.txt_TenThuoc.Size = new System.Drawing.Size(200, 35);
            this.txt_TenThuoc.TabIndex = 8;
            this.txt_TenThuoc.UnderlinedStyle = false;
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.BackColor = System.Drawing.SystemColors.Window;
            this.txt_DonGia.BorderColor = System.Drawing.Color.Black;
            this.txt_DonGia.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_DonGia.BorderRadius = 5;
            this.txt_DonGia.BorderSize = 1;
            this.txt_DonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_DonGia.Location = new System.Drawing.Point(123, 449);
            this.txt_DonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DonGia.Multiline = true;
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_DonGia.PasswordChar = false;
            this.txt_DonGia.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_DonGia.PlaceholderText = "";
            this.txt_DonGia.Size = new System.Drawing.Size(200, 35);
            this.txt_DonGia.TabIndex = 9;
            this.txt_DonGia.UnderlinedStyle = false;
            // 
            // txt_Lo
            // 
            this.txt_Lo.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Lo.BorderColor = System.Drawing.Color.Black;
            this.txt_Lo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_Lo.BorderRadius = 5;
            this.txt_Lo.BorderSize = 1;
            this.txt_Lo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Lo.Location = new System.Drawing.Point(438, 402);
            this.txt_Lo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Lo.Multiline = true;
            this.txt_Lo.Name = "txt_Lo";
            this.txt_Lo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_Lo.PasswordChar = false;
            this.txt_Lo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Lo.PlaceholderText = "";
            this.txt_Lo.Size = new System.Drawing.Size(200, 35);
            this.txt_Lo.TabIndex = 11;
            this.txt_Lo.UnderlinedStyle = false;
            // 
            // txt_HamLuong
            // 
            this.txt_HamLuong.BackColor = System.Drawing.SystemColors.Window;
            this.txt_HamLuong.BorderColor = System.Drawing.Color.Black;
            this.txt_HamLuong.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_HamLuong.BorderRadius = 5;
            this.txt_HamLuong.BorderSize = 1;
            this.txt_HamLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_HamLuong.Location = new System.Drawing.Point(123, 504);
            this.txt_HamLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_HamLuong.Multiline = true;
            this.txt_HamLuong.Name = "txt_HamLuong";
            this.txt_HamLuong.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_HamLuong.PasswordChar = false;
            this.txt_HamLuong.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_HamLuong.PlaceholderText = "";
            this.txt_HamLuong.Size = new System.Drawing.Size(200, 35);
            this.txt_HamLuong.TabIndex = 10;
            this.txt_HamLuong.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên thuốc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Đơn giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 512);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Hàm lượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(349, 507);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Số lượng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 465);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ngày nhập:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(393, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Lô:";
            // 
            // date_NgayNhap
            // 
            this.date_NgayNhap.Location = new System.Drawing.Point(438, 460);
            this.date_NgayNhap.Name = "date_NgayNhap";
            this.date_NgayNhap.Size = new System.Drawing.Size(200, 27);
            this.date_NgayNhap.TabIndex = 19;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(220)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtn_ThemPhieuNhap,
            this.toolStripBtn_Refresh,
            this.toolStripBtn_Thoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(1417, 50);
            this.toolStrip1.TabIndex = 20;
            // 
            // toolStripBtn_ThemPhieuNhap
            // 
            this.toolStripBtn_ThemPhieuNhap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripBtn_ThemPhieuNhap.ForeColor = System.Drawing.Color.White;
            this.toolStripBtn_ThemPhieuNhap.Image = global::GUI.Properties.Resources.plus;
            this.toolStripBtn_ThemPhieuNhap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_ThemPhieuNhap.Name = "toolStripBtn_ThemPhieuNhap";
            this.toolStripBtn_ThemPhieuNhap.Size = new System.Drawing.Size(125, 47);
            this.toolStripBtn_ThemPhieuNhap.Text = "Nhập thuốc";
            this.toolStripBtn_ThemPhieuNhap.Click += new System.EventHandler(this.toolStripBtn_ThemPhieuNhap_Click);
            // 
            // toolStripBtn_Refresh
            // 
            this.toolStripBtn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(220)))));
            this.toolStripBtn_Refresh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripBtn_Refresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripBtn_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtn_Refresh.Image")));
            this.toolStripBtn_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_Refresh.Name = "toolStripBtn_Refresh";
            this.toolStripBtn_Refresh.Padding = new System.Windows.Forms.Padding(10);
            this.toolStripBtn_Refresh.Size = new System.Drawing.Size(115, 47);
            this.toolStripBtn_Refresh.Text = " Refresh";
            // 
            // toolStripBtn_Thoat
            // 
            this.toolStripBtn_Thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(220)))));
            this.toolStripBtn_Thoat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripBtn_Thoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripBtn_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtn_Thoat.Image")));
            this.toolStripBtn_Thoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_Thoat.Name = "toolStripBtn_Thoat";
            this.toolStripBtn_Thoat.Padding = new System.Windows.Forms.Padding(10);
            this.toolStripBtn_Thoat.Size = new System.Drawing.Size(103, 47);
            this.toolStripBtn_Thoat.Text = " Thoát";
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.BackColor = System.Drawing.SystemColors.Window;
            this.txt_TongTien.BorderColor = System.Drawing.Color.Black;
            this.txt_TongTien.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_TongTien.BorderRadius = 5;
            this.txt_TongTien.BorderSize = 1;
            this.txt_TongTien.Enabled = false;
            this.txt_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TongTien.Location = new System.Drawing.Point(1165, 576);
            this.txt_TongTien.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TongTien.Multiline = true;
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_TongTien.PasswordChar = false;
            this.txt_TongTien.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_TongTien.PlaceholderText = "";
            this.txt_TongTien.Size = new System.Drawing.Size(200, 35);
            this.txt_TongTien.TabIndex = 21;
            this.txt_TongTien.UnderlinedStyle = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1038, 584);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Tổng tiền (VND):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 559);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Đơn vị tính:";
            // 
            // txt_DonViTinh
            // 
            this.txt_DonViTinh.BackColor = System.Drawing.SystemColors.Window;
            this.txt_DonViTinh.BorderColor = System.Drawing.Color.Black;
            this.txt_DonViTinh.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_DonViTinh.BorderRadius = 5;
            this.txt_DonViTinh.BorderSize = 1;
            this.txt_DonViTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_DonViTinh.Location = new System.Drawing.Point(123, 554);
            this.txt_DonViTinh.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DonViTinh.Multiline = true;
            this.txt_DonViTinh.Name = "txt_DonViTinh";
            this.txt_DonViTinh.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_DonViTinh.PasswordChar = false;
            this.txt_DonViTinh.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_DonViTinh.PlaceholderText = "";
            this.txt_DonViTinh.Size = new System.Drawing.Size(200, 35);
            this.txt_DonViTinh.TabIndex = 23;
            this.txt_DonViTinh.UnderlinedStyle = false;
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(438, 505);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(200, 27);
            this.txt_SoLuong.TabIndex = 25;
            this.txt_SoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoLuong_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(603, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(248, 38);
            this.label10.TabIndex = 61;
            this.label10.Text = "Phiếu nhập thuốc";
            // 
            // FrmNhapThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 953);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_SoLuong);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_DonViTinh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_TongTien);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.date_NgayNhap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_Lo);
            this.Controls.Add(this.txt_HamLuong);
            this.Controls.Add(this.txt_DonGia);
            this.Controls.Add(this.txt_TenThuoc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmNhapThuoc";
            this.Text = "FrmNhapThuoc";
            this.Load += new System.EventHandler(this.FrmNhapThuoc_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_PhieuNhap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Thuoc)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dtgv_PhieuNhap;
        private GroupBox groupBox1;
        private Label label1;
        private Button btn_Them;
        private DataGridView dtgv_Thuoc;
        private ComboBox cbb_LoaiThuoc;
        private Demo.Controls.TextBox_NTT txt_TenThuoc;
        private Demo.Controls.TextBox_NTT txt_DonGia;
        private Demo.Controls.TextBox_NTT txt_Lo;
        private Demo.Controls.TextBox_NTT txt_HamLuong;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker date_NgayNhap;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripBtn_ThemPhieuNhap;
        private ToolStripButton toolStripBtn_Refresh;
        private ToolStripButton toolStripBtn_Thoat;
        private Demo.Controls.TextBox_NTT txt_TongTien;
        private Label label8;
        private Label label9;
        private Demo.Controls.TextBox_NTT txt_DonViTinh;
        private DataGridViewTextBoxColumn Lo;
        private DataGridViewTextBoxColumn pn_TenThuoc;
        private DataGridViewTextBoxColumn pn_DonGia;
        private DataGridViewTextBoxColumn pn_HamLuong;
        private DataGridViewTextBoxColumn pn_SoLuong;
        private DataGridViewTextBoxColumn pn_Lo;
        private DataGridViewTextBoxColumn NgayNhap;
        private DataGridViewTextBoxColumn pn_DonViTinh;
        private DataGridViewTextBoxColumn TenThuoc;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn HamLuong;
        private DataGridViewTextBoxColumn DonViTinh;
        private TextBox txt_SoLuong;
        private Label label10;
    }
}