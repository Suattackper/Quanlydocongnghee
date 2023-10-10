namespace DoAn1_QuanLyPhanMemBanPKDT.View
{
    partial class FormSanPham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgrvHienThiListSP = new System.Windows.Forms.DataGridView();
            this.clMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHangSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTheloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clXuatXu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddNV = new CustomButton.VBButton();
            this.btnDeleteNV = new CustomButton.VBButton();
            this.btnReplaceNV = new CustomButton.VBButton();
            this.btnReset = new CustomButton.VBButton();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbXuatxu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbTheloai = new System.Windows.Forms.ComboBox();
            this.cbbHangSP = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbNCC = new System.Windows.Forms.ComboBox();
            this.btnTimkiem = new CustomButton.VBButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvHienThiListSP)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgrvHienThiListSP
            // 
            this.dtgrvHienThiListSP.AllowUserToResizeColumns = false;
            this.dtgrvHienThiListSP.AllowUserToResizeRows = false;
            this.dtgrvHienThiListSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrvHienThiListSP.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgrvHienThiListSP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgrvHienThiListSP.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtgrvHienThiListSP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrvHienThiListSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrvHienThiListSP.ColumnHeadersHeight = 33;
            this.dtgrvHienThiListSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgrvHienThiListSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaSP,
            this.clTenNV,
            this.clHangSP,
            this.clTenSP,
            this.clTheloai,
            this.clXuatXu,
            this.clGiaBan});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrvHienThiListSP.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgrvHienThiListSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgrvHienThiListSP.EnableHeadersVisualStyles = false;
            this.dtgrvHienThiListSP.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dtgrvHienThiListSP.Location = new System.Drawing.Point(3, 22);
            this.dtgrvHienThiListSP.Name = "dtgrvHienThiListSP";
            this.dtgrvHienThiListSP.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrvHienThiListSP.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgrvHienThiListSP.RowHeadersVisible = false;
            this.dtgrvHienThiListSP.RowHeadersWidth = 62;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            this.dtgrvHienThiListSP.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgrvHienThiListSP.RowTemplate.Height = 28;
            this.dtgrvHienThiListSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrvHienThiListSP.Size = new System.Drawing.Size(1122, 263);
            this.dtgrvHienThiListSP.TabIndex = 0;
            this.dtgrvHienThiListSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrvHienThiListSP_CellClick);
            this.dtgrvHienThiListSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrvHienThiListSP_CellContentClick);
            this.dtgrvHienThiListSP.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dtgrvHienThiListSP_DataBindingComplete);
            // 
            // clMaSP
            // 
            this.clMaSP.DataPropertyName = "MaSP";
            this.clMaSP.FillWeight = 62.88284F;
            this.clMaSP.HeaderText = "Mã SP";
            this.clMaSP.MinimumWidth = 8;
            this.clMaSP.Name = "clMaSP";
            this.clMaSP.ReadOnly = true;
            // 
            // clTenNV
            // 
            this.clTenNV.DataPropertyName = "MaNCC";
            this.clTenNV.FillWeight = 74.69347F;
            this.clTenNV.HeaderText = "Mã NCC";
            this.clTenNV.MinimumWidth = 8;
            this.clTenNV.Name = "clTenNV";
            this.clTenNV.ReadOnly = true;
            // 
            // clHangSP
            // 
            this.clHangSP.DataPropertyName = "HangSP";
            this.clHangSP.FillWeight = 73.68264F;
            this.clHangSP.HeaderText = "Hãng SP";
            this.clHangSP.MinimumWidth = 8;
            this.clHangSP.Name = "clHangSP";
            this.clHangSP.ReadOnly = true;
            // 
            // clTenSP
            // 
            this.clTenSP.DataPropertyName = "TenSP";
            this.clTenSP.FillWeight = 139.2045F;
            this.clTenSP.HeaderText = "Tên Sản Phẩm";
            this.clTenSP.MinimumWidth = 8;
            this.clTenSP.Name = "clTenSP";
            this.clTenSP.ReadOnly = true;
            // 
            // clTheloai
            // 
            this.clTheloai.DataPropertyName = "TheLoai";
            this.clTheloai.FillWeight = 138.8195F;
            this.clTheloai.HeaderText = "Thể loại";
            this.clTheloai.MinimumWidth = 8;
            this.clTheloai.Name = "clTheloai";
            this.clTheloai.ReadOnly = true;
            // 
            // clXuatXu
            // 
            this.clXuatXu.DataPropertyName = "XuatXu";
            this.clXuatXu.FillWeight = 84.30445F;
            this.clXuatXu.HeaderText = "Xuất Xứ";
            this.clXuatXu.MinimumWidth = 8;
            this.clXuatXu.Name = "clXuatXu";
            this.clXuatXu.ReadOnly = true;
            // 
            // clGiaBan
            // 
            this.clGiaBan.DataPropertyName = "GiaBan";
            this.clGiaBan.FillWeight = 126.4124F;
            this.clGiaBan.HeaderText = "Giá Bán";
            this.clGiaBan.MinimumWidth = 8;
            this.clGiaBan.Name = "clGiaBan";
            this.clGiaBan.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgrvHienThiListSP);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(0, 326);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1128, 288);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các sản phẩm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.White;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.Gray;
            this.txtTimKiem.Location = new System.Drawing.Point(34, 259);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(620, 38);
            this.txtTimKiem.TabIndex = 7;
            this.txtTimKiem.Text = "    Tìm kiếm";
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // txtTenSP
            // 
            this.txtTenSP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenSP.Location = new System.Drawing.Point(34, 189);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(154, 28);
            this.txtTenSP.TabIndex = 12;
            // 
            // txtMaSP
            // 
            this.txtMaSP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaSP.Location = new System.Drawing.Point(34, 94);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(154, 28);
            this.txtMaSP.TabIndex = 7;
            this.txtMaSP.TextChanged += new System.EventHandler(this.txtMaSP_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(30, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã SP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(228, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Thể Loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(453, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hãng Sản Phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(30, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Sản Phẩm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtGiaBan);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbbXuatxu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbbTheloai);
            this.groupBox1.Controls.Add(this.cbbHangSP);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbbNCC);
            this.groupBox1.Controls.Add(this.btnTimkiem);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Controls.Add(this.txtMaSP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.groupBox1.Size = new System.Drawing.Size(1128, 326);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddNV);
            this.panel1.Controls.Add(this.btnDeleteNV);
            this.panel1.Controls.Add(this.btnReplaceNV);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(925, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 282);
            this.panel1.TabIndex = 26;
            // 
            // btnAddNV
            // 
            this.btnAddNV.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddNV.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnAddNV.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddNV.BorderRadius = 14;
            this.btnAddNV.BorderSize = 0;
            this.btnAddNV.FlatAppearance.BorderSize = 0;
            this.btnAddNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNV.ForeColor = System.Drawing.Color.White;
            this.btnAddNV.Image = global::DoAn1_QuanLyPhanMemBanPKDT.Properties.Resources.add_user;
            this.btnAddNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNV.Location = new System.Drawing.Point(3, 38);
            this.btnAddNV.Name = "btnAddNV";
            this.btnAddNV.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAddNV.Size = new System.Drawing.Size(148, 44);
            this.btnAddNV.TabIndex = 14;
            this.btnAddNV.Text = "    Thêm";
            this.btnAddNV.TextColor = System.Drawing.Color.White;
            this.btnAddNV.UseVisualStyleBackColor = false;
            this.btnAddNV.Click += new System.EventHandler(this.btnAddNV_Click);
            // 
            // btnDeleteNV
            // 
            this.btnDeleteNV.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDeleteNV.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnDeleteNV.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDeleteNV.BorderRadius = 14;
            this.btnDeleteNV.BorderSize = 0;
            this.btnDeleteNV.FlatAppearance.BorderSize = 0;
            this.btnDeleteNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteNV.ForeColor = System.Drawing.Color.White;
            this.btnDeleteNV.Image = global::DoAn1_QuanLyPhanMemBanPKDT.Properties.Resources.delete;
            this.btnDeleteNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteNV.Location = new System.Drawing.Point(3, 155);
            this.btnDeleteNV.Name = "btnDeleteNV";
            this.btnDeleteNV.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDeleteNV.Size = new System.Drawing.Size(148, 44);
            this.btnDeleteNV.TabIndex = 15;
            this.btnDeleteNV.Text = "    Xóa";
            this.btnDeleteNV.TextColor = System.Drawing.Color.White;
            this.btnDeleteNV.UseVisualStyleBackColor = false;
            this.btnDeleteNV.Click += new System.EventHandler(this.btnDeleteNV_Click);
            // 
            // btnReplaceNV
            // 
            this.btnReplaceNV.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReplaceNV.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnReplaceNV.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnReplaceNV.BorderRadius = 14;
            this.btnReplaceNV.BorderSize = 0;
            this.btnReplaceNV.FlatAppearance.BorderSize = 0;
            this.btnReplaceNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplaceNV.ForeColor = System.Drawing.Color.White;
            this.btnReplaceNV.Image = global::DoAn1_QuanLyPhanMemBanPKDT.Properties.Resources.wrench;
            this.btnReplaceNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReplaceNV.Location = new System.Drawing.Point(3, 93);
            this.btnReplaceNV.Name = "btnReplaceNV";
            this.btnReplaceNV.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReplaceNV.Size = new System.Drawing.Size(148, 44);
            this.btnReplaceNV.TabIndex = 16;
            this.btnReplaceNV.Text = "    Sửa";
            this.btnReplaceNV.TextColor = System.Drawing.Color.White;
            this.btnReplaceNV.UseVisualStyleBackColor = false;
            this.btnReplaceNV.Click += new System.EventHandler(this.btnReplaceNV_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReset.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnReset.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnReset.BorderRadius = 14;
            this.btnReset.BorderSize = 0;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Image = global::DoAn1_QuanLyPhanMemBanPKDT.Properties.Resources.reset;
            this.btnReset.Location = new System.Drawing.Point(3, 216);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(148, 46);
            this.btnReset.TabIndex = 17;
            this.btnReset.TextColor = System.Drawing.Color.White;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGiaBan.Location = new System.Drawing.Point(692, 94);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(154, 28);
            this.txtGiaBan.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(688, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 22);
            this.label7.TabIndex = 24;
            this.label7.Text = "Giá Bán";
            // 
            // cbbXuatxu
            // 
            this.cbbXuatxu.BackColor = System.Drawing.Color.White;
            this.cbbXuatxu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbXuatxu.ForeColor = System.Drawing.Color.DarkGray;
            this.cbbXuatxu.FormattingEnabled = true;
            this.cbbXuatxu.Items.AddRange(new object[] {
            "Việt Nam",
            "Mĩ",
            "Lào",
            "Campuchia",
            "Thái Lan",
            "Nhật",
            "Đức",
            "Hàn Quốc",
            "Nga"});
            this.cbbXuatxu.Location = new System.Drawing.Point(457, 189);
            this.cbbXuatxu.Name = "cbbXuatxu";
            this.cbbXuatxu.Size = new System.Drawing.Size(197, 28);
            this.cbbXuatxu.TabIndex = 23;
            this.cbbXuatxu.Text = "  Chọn xuất xứ";
            this.cbbXuatxu.SelectedIndexChanged += new System.EventHandler(this.cbbXuatxu_SelectedIndexChanged);
            this.cbbXuatxu.Enter += new System.EventHandler(this.cbbXuatxu_Enter);
            this.cbbXuatxu.Leave += new System.EventHandler(this.cbbXuatxu_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(453, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 22;
            this.label3.Text = "Xuất Xứ";
            // 
            // cbbTheloai
            // 
            this.cbbTheloai.BackColor = System.Drawing.Color.White;
            this.cbbTheloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbTheloai.ForeColor = System.Drawing.Color.DarkGray;
            this.cbbTheloai.FormattingEnabled = true;
            this.cbbTheloai.Items.AddRange(new object[] {
            "Ốp Lứng",
            "Tai Nghe",
            "Cáp Sạc",
            "Củ Sạc",
            "Ốp lưng",
            "Loa Blutooth",
            "Kính cường lực"});
            this.cbbTheloai.Location = new System.Drawing.Point(232, 189);
            this.cbbTheloai.Name = "cbbTheloai";
            this.cbbTheloai.Size = new System.Drawing.Size(188, 28);
            this.cbbTheloai.TabIndex = 21;
            this.cbbTheloai.Text = "  Chọn thể loại";
            this.cbbTheloai.Enter += new System.EventHandler(this.comboBox3_Enter);
            this.cbbTheloai.Leave += new System.EventHandler(this.cbbTheloai_Leave);
            // 
            // cbbHangSP
            // 
            this.cbbHangSP.BackColor = System.Drawing.Color.White;
            this.cbbHangSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbHangSP.ForeColor = System.Drawing.Color.DarkGray;
            this.cbbHangSP.FormattingEnabled = true;
            this.cbbHangSP.ItemHeight = 20;
            this.cbbHangSP.Items.AddRange(new object[] {
            "Apple",
            "Samsung",
            "Intel",
            "Oppo",
            "Xiaomi",
            "Nokia",
            "Sony",
            "Vivo",
            "Huawei",
            ""});
            this.cbbHangSP.Location = new System.Drawing.Point(457, 92);
            this.cbbHangSP.Name = "cbbHangSP";
            this.cbbHangSP.Size = new System.Drawing.Size(197, 28);
            this.cbbHangSP.TabIndex = 20;
            this.cbbHangSP.Text = "  Chọn hãng sản phẩm";
            this.cbbHangSP.SelectedIndexChanged += new System.EventHandler(this.cbbHangSP_SelectedIndexChanged);
            this.cbbHangSP.Enter += new System.EventHandler(this.comboBox2_Enter);
            this.cbbHangSP.Leave += new System.EventHandler(this.cbbHangSP_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(228, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 22);
            this.label6.TabIndex = 19;
            this.label6.Text = "Nhà Cung Cấp";
            // 
            // cbbNCC
            // 
            this.cbbNCC.BackColor = System.Drawing.Color.White;
            this.cbbNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbNCC.ForeColor = System.Drawing.Color.DarkGray;
            this.cbbNCC.FormattingEnabled = true;
            this.cbbNCC.Location = new System.Drawing.Point(232, 92);
            this.cbbNCC.Name = "cbbNCC";
            this.cbbNCC.Size = new System.Drawing.Size(188, 28);
            this.cbbNCC.TabIndex = 18;
            this.cbbNCC.Text = "  Chọn nhà cung cấp";
            this.cbbNCC.Enter += new System.EventHandler(this.cbbNCC_Enter);
            this.cbbNCC.Leave += new System.EventHandler(this.cbbNCC_Leave);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.Color.White;
            this.btnTimkiem.BackgroundColor = System.Drawing.Color.White;
            this.btnTimkiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimkiem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTimkiem.BorderRadius = 0;
            this.btnTimkiem.BorderSize = 0;
            this.btnTimkiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimkiem.FlatAppearance.BorderSize = 0;
            this.btnTimkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimkiem.ForeColor = System.Drawing.Color.White;
            this.btnTimkiem.Image = global::DoAn1_QuanLyPhanMemBanPKDT.Properties.Resources.search__1_3;
            this.btnTimkiem.Location = new System.Drawing.Point(590, 263);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(42, 31);
            this.btnTimkiem.TabIndex = 8;
            this.btnTimkiem.TextColor = System.Drawing.Color.White;
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // FormSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 614);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSanPham";
            this.Text = "FormSanPham";
            this.Load += new System.EventHandler(this.FormSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvHienThiListSP)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgrvHienThiListSP;
        private System.Windows.Forms.GroupBox groupBox2;
        private CustomButton.VBButton btnTimkiem;
        private CustomButton.VBButton btnReset;
        private System.Windows.Forms.TextBox txtTimKiem;
        private CustomButton.VBButton btnReplaceNV;
        private CustomButton.VBButton btnDeleteNV;
        private CustomButton.VBButton btnAddNV;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbNCC;
        private System.Windows.Forms.ComboBox cbbTheloai;
        private System.Windows.Forms.ComboBox cbbXuatxu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbHangSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHangSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTheloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn clXuatXu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGiaBan;
        private System.Windows.Forms.Panel panel1;
    }
}