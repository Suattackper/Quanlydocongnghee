namespace DoAn1_QuanLyPhanMemBanPKDT.View
{
    partial class FormNhapHang
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgrvHienThiListSP = new System.Windows.Forms.DataGridView();
            this.clMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHangSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTheloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clXuatXu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vbButton1 = new CustomButton.VBButton();
            this.vbButton2 = new CustomButton.VBButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvHienThiListSP)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgrvHienThiListSP);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(0, 65);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1163, 607);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các sản phẩm";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dtgrvHienThiListSP
            // 
            this.dtgrvHienThiListSP.AllowUserToResizeColumns = false;
            this.dtgrvHienThiListSP.AllowUserToResizeRows = false;
            this.dtgrvHienThiListSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrvHienThiListSP.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgrvHienThiListSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgrvHienThiListSP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtgrvHienThiListSP.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtgrvHienThiListSP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
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
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrvHienThiListSP.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgrvHienThiListSP.Dock = System.Windows.Forms.DockStyle.Top;
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
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            this.dtgrvHienThiListSP.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgrvHienThiListSP.RowTemplate.Height = 28;
            this.dtgrvHienThiListSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrvHienThiListSP.Size = new System.Drawing.Size(1157, 442);
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
            // txtSoluong
            // 
            this.txtSoluong.ForeColor = System.Drawing.Color.Gray;
            this.txtSoluong.Location = new System.Drawing.Point(664, 574);
            this.txtSoluong.Multiline = true;
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(159, 33);
            this.txtSoluong.TabIndex = 10;
            this.txtSoluong.Text = "Số lượng";
            this.txtSoluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSoluong.Enter += new System.EventHandler(this.txtSoluong_Enter);
            this.txtSoluong.Leave += new System.EventHandler(this.txtSoluong_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.vbButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1163, 48);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // vbButton1
            // 
            this.vbButton1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vbButton1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vbButton1.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.vbButton1.BorderRadius = 0;
            this.vbButton1.BorderSize = 1;
            this.vbButton1.FlatAppearance.BorderSize = 0;
            this.vbButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton1.ForeColor = System.Drawing.Color.White;
            this.vbButton1.Image = global::DoAn1_QuanLyPhanMemBanPKDT.Properties.Resources.close__1_;
            this.vbButton1.Location = new System.Drawing.Point(1096, 3);
            this.vbButton1.Name = "vbButton1";
            this.vbButton1.Size = new System.Drawing.Size(64, 39);
            this.vbButton1.TabIndex = 0;
            this.vbButton1.TextColor = System.Drawing.Color.White;
            this.vbButton1.UseVisualStyleBackColor = false;
            this.vbButton1.Click += new System.EventHandler(this.vbButton1_Click);
            // 
            // vbButton2
            // 
            this.vbButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.vbButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.vbButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton2.BorderRadius = 15;
            this.vbButton2.BorderSize = 0;
            this.vbButton2.FlatAppearance.BorderSize = 0;
            this.vbButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton2.ForeColor = System.Drawing.Color.White;
            this.vbButton2.Location = new System.Drawing.Point(873, 565);
            this.vbButton2.Name = "vbButton2";
            this.vbButton2.Size = new System.Drawing.Size(172, 50);
            this.vbButton2.TabIndex = 11;
            this.vbButton2.Text = "Nhập";
            this.vbButton2.TextColor = System.Drawing.Color.White;
            this.vbButton2.UseVisualStyleBackColor = false;
            this.vbButton2.Click += new System.EventHandler(this.vbButton2_Click);
            // 
            // FormNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 672);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.vbButton2);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormNhapHang";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormNhapHang_FormClosed);
            this.Load += new System.EventHandler(this.FormNhapHang_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvHienThiListSP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomButton.VBButton vbButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgrvHienThiListSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHangSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTheloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn clXuatXu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGiaBan;
        private System.Windows.Forms.TextBox txtSoluong;
        private CustomButton.VBButton vbButton2;
        private System.Windows.Forms.Panel panel1;
    }
}