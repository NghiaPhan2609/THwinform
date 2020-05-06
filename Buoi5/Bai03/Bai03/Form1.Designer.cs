namespace Bai03
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbMaNV = new System.Windows.Forms.TextBox();
            this.tbTenNV = new System.Windows.Forms.TextBox();
            this.rbtnNVKD = new System.Windows.Forms.RadioButton();
            this.rbtnNVSX = new System.Windows.Forms.RadioButton();
            this.lbSoHopDong = new System.Windows.Forms.Label();
            this.tbSoHopDong = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbSoLuongSanPham = new System.Windows.Forms.Label();
            this.tbSoLuongSanPham = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbLuong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ma Nhan Vien:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ten Nhan Vien:";
            // 
            // tbMaNV
            // 
            this.tbMaNV.Location = new System.Drawing.Point(167, 54);
            this.tbMaNV.Name = "tbMaNV";
            this.tbMaNV.Size = new System.Drawing.Size(146, 20);
            this.tbMaNV.TabIndex = 2;
            // 
            // tbTenNV
            // 
            this.tbTenNV.Location = new System.Drawing.Point(167, 91);
            this.tbTenNV.Name = "tbTenNV";
            this.tbTenNV.Size = new System.Drawing.Size(146, 20);
            this.tbTenNV.TabIndex = 3;
            // 
            // rbtnNVKD
            // 
            this.rbtnNVKD.AutoSize = true;
            this.rbtnNVKD.Location = new System.Drawing.Point(65, 133);
            this.rbtnNVKD.Name = "rbtnNVKD";
            this.rbtnNVKD.Size = new System.Drawing.Size(93, 17);
            this.rbtnNVKD.TabIndex = 4;
            this.rbtnNVKD.TabStop = true;
            this.rbtnNVKD.Text = "NVKinhDoanh";
            this.rbtnNVKD.UseVisualStyleBackColor = true;
            this.rbtnNVKD.CheckedChanged += new System.EventHandler(this.rbtnNVKD_CheckedChanged);
            // 
            // rbtnNVSX
            // 
            this.rbtnNVSX.AutoSize = true;
            this.rbtnNVSX.Location = new System.Drawing.Point(66, 197);
            this.rbtnNVSX.Name = "rbtnNVSX";
            this.rbtnNVSX.Size = new System.Drawing.Size(81, 17);
            this.rbtnNVSX.TabIndex = 5;
            this.rbtnNVSX.TabStop = true;
            this.rbtnNVSX.Text = "NVSanXuat";
            this.rbtnNVSX.UseVisualStyleBackColor = true;
            this.rbtnNVSX.CheckedChanged += new System.EventHandler(this.rbtnNVSX_CheckedChanged);
            // 
            // lbSoHopDong
            // 
            this.lbSoHopDong.AutoSize = true;
            this.lbSoHopDong.Location = new System.Drawing.Point(63, 165);
            this.lbSoHopDong.Name = "lbSoHopDong";
            this.lbSoHopDong.Size = new System.Drawing.Size(103, 13);
            this.lbSoHopDong.TabIndex = 6;
            this.lbSoHopDong.Text = "So hop dong ky ket:";
            this.lbSoHopDong.Visible = false;
            // 
            // tbSoHopDong
            // 
            this.tbSoHopDong.Location = new System.Drawing.Point(167, 162);
            this.tbSoHopDong.Name = "tbSoHopDong";
            this.tbSoHopDong.Size = new System.Drawing.Size(146, 20);
            this.tbSoHopDong.TabIndex = 7;
            this.tbSoHopDong.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Tinh Luong";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Luong nhan vien:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 10;
            // 
            // lbSoLuongSanPham
            // 
            this.lbSoLuongSanPham.AutoSize = true;
            this.lbSoLuongSanPham.Location = new System.Drawing.Point(62, 230);
            this.lbSoLuongSanPham.Name = "lbSoLuongSanPham";
            this.lbSoLuongSanPham.Size = new System.Drawing.Size(101, 13);
            this.lbSoLuongSanPham.TabIndex = 11;
            this.lbSoLuongSanPham.Text = "So luong san pham:";
            this.lbSoLuongSanPham.Visible = false;
            // 
            // tbSoLuongSanPham
            // 
            this.tbSoLuongSanPham.Location = new System.Drawing.Point(167, 223);
            this.tbSoLuongSanPham.Name = "tbSoLuongSanPham";
            this.tbSoLuongSanPham.Size = new System.Drawing.Size(146, 20);
            this.tbSoLuongSanPham.TabIndex = 12;
            this.tbSoLuongSanPham.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(164, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 13;
            // 
            // lbLuong
            // 
            this.lbLuong.AutoSize = true;
            this.lbLuong.Location = new System.Drawing.Point(164, 331);
            this.lbLuong.Name = "lbLuong";
            this.lbLuong.Size = new System.Drawing.Size(0, 13);
            this.lbLuong.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbLuong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbSoLuongSanPham);
            this.Controls.Add(this.lbSoLuongSanPham);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbSoHopDong);
            this.Controls.Add(this.lbSoHopDong);
            this.Controls.Add(this.rbtnNVSX);
            this.Controls.Add(this.rbtnNVKD);
            this.Controls.Add(this.tbTenNV);
            this.Controls.Add(this.tbMaNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMaNV;
        private System.Windows.Forms.TextBox tbTenNV;
        private System.Windows.Forms.RadioButton rbtnNVKD;
        private System.Windows.Forms.RadioButton rbtnNVSX;
        private System.Windows.Forms.Label lbSoHopDong;
        private System.Windows.Forms.TextBox tbSoHopDong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbSoLuongSanPham;
        private System.Windows.Forms.TextBox tbSoLuongSanPham;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbLuong;
    }
}

