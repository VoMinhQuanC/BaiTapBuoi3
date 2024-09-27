namespace BaiTapBuoi3
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
            btnThem = new Button();
            btnSua = new Button();
            btnDong = new Button();
            btnXoa = new Button();
            dtgvThongTin = new DataGridView();
            MSNV = new DataGridViewTextBoxColumn();
            TênNV = new DataGridViewTextBoxColumn();
            LươngCB = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvThongTin).BeginInit();
            SuspendLayout();
            // 
            // btnThem
            // 
            btnThem.Location = new Point(583, 15);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 29);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(583, 51);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 29);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(583, 124);
            btnDong.Margin = new Padding(3, 4, 3, 4);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(75, 29);
            btnDong.TabIndex = 3;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(583, 88);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 29);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // dtgvThongTin
            // 
            dtgvThongTin.BackgroundColor = SystemColors.ButtonHighlight;
            dtgvThongTin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvThongTin.Columns.AddRange(new DataGridViewColumn[] { MSNV, TênNV, LươngCB });
            dtgvThongTin.Location = new Point(12, 17);
            dtgvThongTin.Margin = new Padding(3, 4, 3, 4);
            dtgvThongTin.Name = "dtgvThongTin";
            dtgvThongTin.RowHeadersWidth = 51;
            dtgvThongTin.RowTemplate.Height = 24;
            dtgvThongTin.Size = new Size(565, 282);
            dtgvThongTin.TabIndex = 4;
            dtgvThongTin.CellContentClick += dtgvThongTin_CellContentClick;
            // 
            // MSNV
            // 
            MSNV.HeaderText = "MSNV";
            MSNV.MinimumWidth = 6;
            MSNV.Name = "MSNV";
            MSNV.Width = 125;
            // 
            // TênNV
            // 
            TênNV.HeaderText = "Tên NV";
            TênNV.MinimumWidth = 6;
            TênNV.Name = "TênNV";
            TênNV.Width = 125;
            // 
            // LươngCB
            // 
            LươngCB.HeaderText = "Lương CB";
            LươngCB.MinimumWidth = 6;
            LươngCB.Name = "LươngCB";
            LươngCB.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 397);
            Controls.Add(dtgvThongTin);
            Controls.Add(btnDong);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "List View";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvThongTin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dtgvThongTin;
        private DataGridViewTextBoxColumn MSNV;
        private DataGridViewTextBoxColumn TênNV;
        private DataGridViewTextBoxColumn LươngCB;
    }
}