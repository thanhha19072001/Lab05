﻿namespace Lab05_Winform
{
	partial class frmNhapThongTinSV
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
            this.components = new System.ComponentModel.Container();
            this.ctMenuLcbMonHoc = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemThemMonHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemXoaMonHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvDanhSachSV = new System.Windows.Forms.ListView();
            this.colMSSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenLot = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCMND = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMonHocDK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctListViewMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemXoaSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMacDinh = new System.Windows.Forms.Button();
            this.btnHienThiSV = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.clbMonHocDangKy = new System.Windows.Forms.CheckedListBox();
            this.txtSDT = new System.Windows.Forms.MaskedTextBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.txtSoCMND = new System.Windows.Forms.MaskedTextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMSSV = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ctMenuLcbMonHoc.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ctListViewMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctMenuLcbMonHoc
            // 
            this.ctMenuLcbMonHoc.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctMenuLcbMonHoc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemThemMonHoc,
            this.menuItemXoaMonHoc});
            this.ctMenuLcbMonHoc.Name = "ctMenuLcbMonHoc";
            this.ctMenuLcbMonHoc.Size = new System.Drawing.Size(233, 52);
            // 
            // menuItemThemMonHoc
            // 
            this.menuItemThemMonHoc.Name = "menuItemThemMonHoc";
            this.menuItemThemMonHoc.Size = new System.Drawing.Size(232, 24);
            this.menuItemThemMonHoc.Text = "Thêm môn học";
            this.menuItemThemMonHoc.Click += new System.EventHandler(this.menuItemThemMonHoc_Click);
            // 
            // menuItemXoaMonHoc
            // 
            this.menuItemXoaMonHoc.Name = "menuItemXoaMonHoc";
            this.menuItemXoaMonHoc.Size = new System.Drawing.Size(232, 24);
            this.menuItemXoaMonHoc.Text = "Xóa môn học đánh dấu";
            this.menuItemXoaMonHoc.Click += new System.EventHandler(this.menuItemXoaMonHoc_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.MediumPurple;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimKiem.Location = new System.Drawing.Point(306, 369);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(122, 43);
            this.btnTimKiem.TabIndex = 15;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.MediumPurple;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Location = new System.Drawing.Point(578, 367);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(135, 43);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.MediumPurple;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCapNhat.Location = new System.Drawing.Point(726, 367);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(133, 43);
            this.btnCapNhat.TabIndex = 14;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.MediumPurple;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.Location = new System.Drawing.Point(867, 367);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 43);
            this.btnThoat.TabIndex = 18;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvDanhSachSV);
            this.groupBox1.Location = new System.Drawing.Point(40, 433);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(941, 427);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sinh viên";
            // 
            // lvDanhSachSV
            // 
            this.lvDanhSachSV.CheckBoxes = true;
            this.lvDanhSachSV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMSSV,
            this.colTenLot,
            this.colTen,
            this.colNgaySinh,
            this.colLop,
            this.colCMND,
            this.colSDT,
            this.colDiaChi,
            this.colGioiTinh,
            this.colMonHocDK});
            this.lvDanhSachSV.ContextMenuStrip = this.ctListViewMenu;
            this.lvDanhSachSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDanhSachSV.FullRowSelect = true;
            this.lvDanhSachSV.GridLines = true;
            this.lvDanhSachSV.HideSelection = false;
            this.lvDanhSachSV.Location = new System.Drawing.Point(4, 19);
            this.lvDanhSachSV.Margin = new System.Windows.Forms.Padding(4);
            this.lvDanhSachSV.Name = "lvDanhSachSV";
            this.lvDanhSachSV.Size = new System.Drawing.Size(933, 404);
            this.lvDanhSachSV.TabIndex = 19;
            this.lvDanhSachSV.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachSV.View = System.Windows.Forms.View.Details;
            this.lvDanhSachSV.SelectedIndexChanged += new System.EventHandler(this.lvDanhSachSV_SelectedIndexChanged);
            // 
            // colMSSV
            // 
            this.colMSSV.Text = "MSSV";
            this.colMSSV.Width = 70;
            // 
            // colTenLot
            // 
            this.colTenLot.Text = "Họ và tên lót";
            this.colTenLot.Width = 150;
            // 
            // colTen
            // 
            this.colTen.Text = "Tên";
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.Text = "Ngày sinh";
            this.colNgaySinh.Width = 120;
            // 
            // colLop
            // 
            this.colLop.Text = "Lớp";
            // 
            // colCMND
            // 
            this.colCMND.Text = "Số CMND";
            // 
            // colSDT
            // 
            this.colSDT.Text = "Số điện thoại";
            // 
            // colDiaChi
            // 
            this.colDiaChi.Text = "Địa chỉ liên lạc";
            this.colDiaChi.Width = 180;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.Text = "Giới tính";
            // 
            // colMonHocDK
            // 
            this.colMonHocDK.Text = "Môn học đăng ký";
            this.colMonHocDK.Width = 200;
            // 
            // ctListViewMenu
            // 
            this.ctListViewMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctListViewMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemXoaSinhVien});
            this.ctListViewMenu.Name = "ctListViewMenu";
            this.ctListViewMenu.Size = new System.Drawing.Size(253, 28);
            // 
            // menuItemXoaSinhVien
            // 
            this.menuItemXoaSinhVien.Name = "menuItemXoaSinhVien";
            this.menuItemXoaSinhVien.Size = new System.Drawing.Size(252, 24);
            this.menuItemXoaSinhVien.Text = "Xóa sinh viên đã đánh dấu";
            this.menuItemXoaSinhVien.Click += new System.EventHandler(this.menuItemXoaSinhVien_Click);
            // 
            // btnMacDinh
            // 
            this.btnMacDinh.BackColor = System.Drawing.Color.MediumPurple;
            this.btnMacDinh.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMacDinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMacDinh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMacDinh.Location = new System.Drawing.Point(178, 369);
            this.btnMacDinh.Margin = new System.Windows.Forms.Padding(4);
            this.btnMacDinh.Name = "btnMacDinh";
            this.btnMacDinh.Size = new System.Drawing.Size(120, 43);
            this.btnMacDinh.TabIndex = 17;
            this.btnMacDinh.Text = "Mặc định";
            this.btnMacDinh.UseVisualStyleBackColor = false;
            this.btnMacDinh.Click += new System.EventHandler(this.btnMacDinh_Click);
            // 
            // btnHienThiSV
            // 
            this.btnHienThiSV.BackColor = System.Drawing.Color.MediumPurple;
            this.btnHienThiSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThiSV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHienThiSV.Location = new System.Drawing.Point(39, 369);
            this.btnHienThiSV.Margin = new System.Windows.Forms.Padding(4);
            this.btnHienThiSV.Name = "btnHienThiSV";
            this.btnHienThiSV.Size = new System.Drawing.Size(131, 43);
            this.btnHienThiSV.TabIndex = 16;
            this.btnHienThiSV.Text = "Tất cả SV";
            this.btnHienThiSV.UseVisualStyleBackColor = false;
            this.btnHienThiSV.Click += new System.EventHandler(this.btnHienThiSV_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(197, 226);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(779, 22);
            this.txtDiaChi.TabIndex = 53;
            // 
            // clbMonHocDangKy
            // 
            this.clbMonHocDangKy.CheckOnClick = true;
            this.clbMonHocDangKy.ColumnWidth = 260;
            this.clbMonHocDangKy.ContextMenuStrip = this.ctMenuLcbMonHoc;
            this.clbMonHocDangKy.FormattingEnabled = true;
            this.clbMonHocDangKy.Location = new System.Drawing.Point(193, 270);
            this.clbMonHocDangKy.Margin = new System.Windows.Forms.Padding(4);
            this.clbMonHocDangKy.MultiColumn = true;
            this.clbMonHocDangKy.Name = "clbMonHocDangKy";
            this.clbMonHocDangKy.Size = new System.Drawing.Size(783, 89);
            this.clbMonHocDangKy.TabIndex = 54;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(709, 175);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Mask = "0000.000.000";
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(256, 22);
            this.txtSDT.TabIndex = 52;
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Items.AddRange(new object[] {
            "CTK38",
            "CTK39",
            "CTK40",
            "CTK41",
            "CTK42",
            "CTK43"});
            this.cboLop.Location = new System.Drawing.Point(709, 122);
            this.cboLop.Margin = new System.Windows.Forms.Padding(4);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(256, 24);
            this.cboLop.TabIndex = 48;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(709, 78);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(256, 22);
            this.txtTen.TabIndex = 45;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNu.Location = new System.Drawing.Point(867, 33);
            this.rdNu.Margin = new System.Windows.Forms.Padding(4);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(50, 24);
            this.rdNu.TabIndex = 39;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNam.Location = new System.Drawing.Point(762, 33);
            this.rdNam.Margin = new System.Windows.Forms.Padding(4);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(70, 24);
            this.rdNam.TabIndex = 37;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // txtSoCMND
            // 
            this.txtSoCMND.Location = new System.Drawing.Point(199, 179);
            this.txtSoCMND.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoCMND.Mask = "000000000";
            this.txtSoCMND.Name = "txtSoCMND";
            this.txtSoCMND.Size = new System.Drawing.Size(277, 22);
            this.txtSoCMND.TabIndex = 51;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(199, 126);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(277, 22);
            this.dtpNgaySinh.TabIndex = 46;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(199, 74);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(277, 22);
            this.txtHoTen.TabIndex = 43;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(199, 27);
            this.txtMSSV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMSSV.Mask = "0000000";
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(277, 22);
            this.txtMSSV.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(623, 126);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 20);
            this.label10.TabIndex = 50;
            this.label10.Text = "Lớp";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(623, 176);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 49;
            this.label9.Text = "Số ĐT:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(623, 78);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 47;
            this.label8.Text = "Tên:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(623, 37);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "Giới tính:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 270);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "Môn học đăng ký:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 229);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Địa chỉ liên lạc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Số CMND:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Ngày sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Họ và tên lót:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "MSSV:";
            // 
            // frmNhapThongTinSV
            // 
            this.AcceptButton = this.btnThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.CancelButton = this.btnMacDinh;
            this.ClientSize = new System.Drawing.Size(1012, 875);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.clbMonHocDangKy);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.txtSoCMND);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHienThiSV);
            this.Controls.Add(this.btnMacDinh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTimKiem);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmNhapThongTinSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập thông tin sinh viên";
            this.Load += new System.EventHandler(this.frmNhapThongTinSV_Load);
            this.ctMenuLcbMonHoc.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ctListViewMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnTimKiem;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnCapNhat;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListView lvDanhSachSV;
		private System.Windows.Forms.ColumnHeader colMSSV;
		private System.Windows.Forms.ColumnHeader colTenLot;
		private System.Windows.Forms.ColumnHeader colTen;
		private System.Windows.Forms.ColumnHeader colNgaySinh;
		private System.Windows.Forms.ColumnHeader colLop;
		private System.Windows.Forms.ColumnHeader colCMND;
		private System.Windows.Forms.ColumnHeader colSDT;
		private System.Windows.Forms.ColumnHeader colDiaChi;
		private System.Windows.Forms.ColumnHeader colGioiTinh;
		private System.Windows.Forms.ColumnHeader colMonHocDK;
		private System.Windows.Forms.ContextMenuStrip ctListViewMenu;
		private System.Windows.Forms.ToolStripMenuItem menuItemXoaSinhVien;
		private System.Windows.Forms.ContextMenuStrip ctMenuLcbMonHoc;
		private System.Windows.Forms.ToolStripMenuItem menuItemThemMonHoc;
		private System.Windows.Forms.ToolStripMenuItem menuItemXoaMonHoc;
		private System.Windows.Forms.Button btnMacDinh;
		private System.Windows.Forms.Button btnHienThiSV;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.CheckedListBox clbMonHocDangKy;
        private System.Windows.Forms.MaskedTextBox txtSDT;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.MaskedTextBox txtSoCMND;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.MaskedTextBox txtMSSV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

