namespace VuDangHoangTien_6551071080_VP104_LTTQ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtLuongCoBan = new TextBox();
            txtTenNV = new TextBox();
            txtMaNV = new TextBox();
            groupBox2 = new GroupBox();
            btnXoa = new Button();
            btnSua = new Button();
            btnThoat = new Button();
            btnThem = new Button();
            groupBox3 = new GroupBox();
            dgvNhanVien = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtLuongCoBan);
            groupBox1.Controls.Add(txtTenNV);
            groupBox1.Controls.Add(txtMaNV);
            groupBox1.Location = new Point(27, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(453, 192);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 149);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 5;
            label3.Text = "Lương cơ bản :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 102);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 4;
            label2.Text = "Tên nhân viên :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 46);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 3;
            label1.Text = "Mã nhân viên :";
            // 
            // txtLuongCoBan
            // 
            txtLuongCoBan.Location = new Point(224, 149);
            txtLuongCoBan.Name = "txtLuongCoBan";
            txtLuongCoBan.Size = new Size(191, 27);
            txtLuongCoBan.TabIndex = 2;
            txtLuongCoBan.TextChanged += txtLuongCoBan_TextChanged;
            txtLuongCoBan.KeyPress += txtLuongCoBan_KeyPress;
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(224, 102);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(191, 27);
            txtTenNV.TabIndex = 1;
            txtTenNV.TextChanged += textBox2_TextChanged;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(224, 46);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(191, 27);
            txtMaNV.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnThoat);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Location = new Point(498, 31);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(290, 192);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "thao tác";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(178, 113);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 41);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(41, 113);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 41);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(178, 46);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 40);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(41, 46);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 40);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvNhanVien);
            groupBox3.Location = new Point(27, 264);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(761, 174);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách nhân viên";
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Location = new Point(29, 26);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.Size = new Size(714, 148);
            dgvNhanVien.TabIndex = 0;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtLuongCoBan;
        private TextBox txtTenNV;
        private TextBox txtMaNV;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThoat;
        private Button btnThem;
        private GroupBox groupBox3;
        private DataGridView dgvNhanVien;
    }
}
