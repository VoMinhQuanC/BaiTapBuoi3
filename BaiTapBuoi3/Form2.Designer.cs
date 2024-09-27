namespace BaiTapBuoi3
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txbMSNV = new TextBox();
            txbLuong = new TextBox();
            TXBTen = new TextBox();
            btnDongY = new Button();
            btnBoQua = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 46);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "MSNV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 148);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 1;
            label2.Text = "Lương";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 96);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên";
            // 
            // txbMSNV
            // 
            txbMSNV.Location = new Point(88, 46);
            txbMSNV.Margin = new Padding(3, 4, 3, 4);
            txbMSNV.Name = "txbMSNV";
            txbMSNV.Size = new Size(156, 27);
            txbMSNV.TabIndex = 3;
            txbMSNV.TextChanged += txbMSNV_TextChanged;
            // 
            // txbLuong
            // 
            txbLuong.Location = new Point(88, 148);
            txbLuong.Margin = new Padding(3, 4, 3, 4);
            txbLuong.Name = "txbLuong";
            txbLuong.Size = new Size(156, 27);
            txbLuong.TabIndex = 4;
            txbLuong.TextChanged += txbLuong_TextChanged;
            // 
            // TXBTen
            // 
            TXBTen.Location = new Point(88, 92);
            TXBTen.Margin = new Padding(3, 4, 3, 4);
            TXBTen.Name = "TXBTen";
            TXBTen.Size = new Size(156, 27);
            TXBTen.TabIndex = 5;
            TXBTen.TextChanged += TXBTen_TextChanged;
            // 
            // btnDongY
            // 
            btnDongY.Location = new Point(88, 195);
            btnDongY.Margin = new Padding(3, 4, 3, 4);
            btnDongY.Name = "btnDongY";
            btnDongY.Size = new Size(75, 29);
            btnDongY.TabIndex = 6;
            btnDongY.Text = "Đồng ý";
            btnDongY.UseVisualStyleBackColor = true;
            btnDongY.Click += btnDongY_Click;
            // 
            // btnBoQua
            // 
            btnBoQua.Location = new Point(169, 195);
            btnBoQua.Margin = new Padding(3, 4, 3, 4);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(75, 29);
            btnBoQua.TabIndex = 7;
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += btnBoQua_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 249);
            Controls.Add(btnBoQua);
            Controls.Add(btnDongY);
            Controls.Add(TXBTen);
            Controls.Add(txbLuong);
            Controls.Add(txbMSNV);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Nhân viên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbMSNV;
        private System.Windows.Forms.TextBox txbLuong;
        private System.Windows.Forms.TextBox TXBTen;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Button btnBoQua;
    }
}