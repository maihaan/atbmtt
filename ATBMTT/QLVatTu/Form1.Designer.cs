namespace QLVatTu
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.tbNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.cbDangSD = new System.Windows.Forms.CheckBox();
            this.tbMaCode = new System.Windows.Forms.TextBox();
            this.tbGiaNhap = new System.Windows.Forms.TextBox();
            this.cbDonVi = new System.Windows.Forms.ComboBox();
            this.pbAnh = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.btThemMoi = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên";
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(93, 10);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(352, 20);
            this.tbTen.TabIndex = 1;
            // 
            // tbNgayNhap
            // 
            this.tbNgayNhap.CustomFormat = "dd/MM/yyyy";
            this.tbNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tbNgayNhap.Location = new System.Drawing.Point(93, 37);
            this.tbNgayNhap.Name = "tbNgayNhap";
            this.tbNgayNhap.Size = new System.Drawing.Size(110, 20);
            this.tbNgayNhap.TabIndex = 2;
            // 
            // cbDangSD
            // 
            this.cbDangSD.AutoSize = true;
            this.cbDangSD.Location = new System.Drawing.Point(93, 64);
            this.cbDangSD.Name = "cbDangSD";
            this.cbDangSD.Size = new System.Drawing.Size(93, 17);
            this.cbDangSD.TabIndex = 3;
            this.cbDangSD.Text = "Đang sử dụng";
            this.cbDangSD.UseVisualStyleBackColor = true;
            // 
            // tbMaCode
            // 
            this.tbMaCode.Location = new System.Drawing.Point(93, 88);
            this.tbMaCode.Name = "tbMaCode";
            this.tbMaCode.Size = new System.Drawing.Size(200, 20);
            this.tbMaCode.TabIndex = 4;
            // 
            // tbGiaNhap
            // 
            this.tbGiaNhap.Location = new System.Drawing.Point(93, 115);
            this.tbGiaNhap.Name = "tbGiaNhap";
            this.tbGiaNhap.Size = new System.Drawing.Size(121, 20);
            this.tbGiaNhap.TabIndex = 5;
            // 
            // cbDonVi
            // 
            this.cbDonVi.FormattingEnabled = true;
            this.cbDonVi.Location = new System.Drawing.Point(93, 142);
            this.cbDonVi.Name = "cbDonVi";
            this.cbDonVi.Size = new System.Drawing.Size(352, 21);
            this.cbDonVi.TabIndex = 6;
            // 
            // pbAnh
            // 
            this.pbAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAnh.Location = new System.Drawing.Point(463, 10);
            this.pbAnh.Name = "pbAnh";
            this.pbAnh.Size = new System.Drawing.Size(215, 153);
            this.pbAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnh.TabIndex = 7;
            this.pbAnh.TabStop = false;
            this.pbAnh.Click += new System.EventHandler(this.pbAnh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ngày nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mã code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Giá nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Đơn vị sử dụng";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AllowUserToAddRows = false;
            this.dgvDanhSach.AllowUserToDeleteRows = false;
            this.dgvDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Location = new System.Drawing.Point(13, 217);
            this.dgvDanhSach.MultiSelect = false;
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.ReadOnly = true;
            this.dgvDanhSach.RowHeadersVisible = false;
            this.dgvDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSach.Size = new System.Drawing.Size(665, 259);
            this.dgvDanhSach.TabIndex = 12;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);
            // 
            // btThemMoi
            // 
            this.btThemMoi.Location = new System.Drawing.Point(93, 170);
            this.btThemMoi.Name = "btThemMoi";
            this.btThemMoi.Size = new System.Drawing.Size(75, 23);
            this.btThemMoi.TabIndex = 13;
            this.btThemMoi.Text = "Thêm mới";
            this.btThemMoi.UseVisualStyleBackColor = true;
            this.btThemMoi.Click += new System.EventHandler(this.btThemMoi_Click);
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(175, 170);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(75, 23);
            this.btLuu.TabIndex = 14;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(257, 170);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 15;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 488);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btThemMoi);
            this.Controls.Add(this.dgvDanhSach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbAnh);
            this.Controls.Add(this.cbDonVi);
            this.Controls.Add(this.tbGiaNhap);
            this.Controls.Add(this.tbMaCode);
            this.Controls.Add(this.cbDangSD);
            this.Controls.Add(this.tbNgayNhap);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Chương trình quản lý Vật tư";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.DateTimePicker tbNgayNhap;
        private System.Windows.Forms.CheckBox cbDangSD;
        private System.Windows.Forms.TextBox tbMaCode;
        private System.Windows.Forms.TextBox tbGiaNhap;
        private System.Windows.Forms.ComboBox cbDonVi;
        private System.Windows.Forms.PictureBox pbAnh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.Button btThemMoi;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btXoa;
    }
}

