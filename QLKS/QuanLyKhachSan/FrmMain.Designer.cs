﻿namespace QuanLyKhachSan
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSystemButton = new System.Windows.Forms.Panel();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.btnKH = new System.Windows.Forms.Button();
            this.btnChamCong = new System.Windows.Forms.Button();
            this.btnPhong = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnDichVu = new System.Windows.Forms.Button();
            this.btnDoanhThu = new System.Windows.Forms.Button();
            this.btnCSVC = new System.Windows.Forms.Button();
            this.btnLuong = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnMain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlSystemButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.pnlSystemButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 975);
            this.panel1.TabIndex = 2;
            // 
            // pnlSystemButton
            // 
            this.pnlSystemButton.AutoScroll = true;
            this.pnlSystemButton.Controls.Add(this.btnNhanVien);
            this.pnlSystemButton.Controls.Add(this.btnDatPhong);
            this.pnlSystemButton.Controls.Add(this.btnKH);
            this.pnlSystemButton.Controls.Add(this.btnChamCong);
            this.pnlSystemButton.Controls.Add(this.btnPhong);
            this.pnlSystemButton.Controls.Add(this.btnHoaDon);
            this.pnlSystemButton.Controls.Add(this.btnDichVu);
            this.pnlSystemButton.Controls.Add(this.btnDoanhThu);
            this.pnlSystemButton.Controls.Add(this.btnCSVC);
            this.pnlSystemButton.Controls.Add(this.btnLuong);
            this.pnlSystemButton.Location = new System.Drawing.Point(3, 142);
            this.pnlSystemButton.Name = "pnlSystemButton";
            this.pnlSystemButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlSystemButton.Size = new System.Drawing.Size(189, 491);
            this.pnlSystemButton.TabIndex = 0;
            this.pnlSystemButton.Scroll += new System.Windows.Forms.ScrollEventHandler(this.pnlSystemButton_Scroll);
            this.pnlSystemButton.Resize += new System.EventHandler(this.pnlSystemButton_Resize);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.Location = new System.Drawing.Point(2, 2);
            this.btnNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(163, 68);
            this.btnNhanVien.TabIndex = 0;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatPhong.Location = new System.Drawing.Point(2, 208);
            this.btnDatPhong.Margin = new System.Windows.Forms.Padding(2);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(163, 64);
            this.btnDatPhong.TabIndex = 6;
            this.btnDatPhong.Text = "Đặt Phòng";
            this.btnDatPhong.UseVisualStyleBackColor = false;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // btnKH
            // 
            this.btnKH.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKH.Location = new System.Drawing.Point(2, 73);
            this.btnKH.Margin = new System.Windows.Forms.Padding(2);
            this.btnKH.Name = "btnKH";
            this.btnKH.Size = new System.Drawing.Size(163, 64);
            this.btnKH.TabIndex = 1;
            this.btnKH.Text = "Khách Hàng";
            this.btnKH.UseVisualStyleBackColor = false;
            this.btnKH.Click += new System.EventHandler(this.btnKH_Click);
            // 
            // btnChamCong
            // 
            this.btnChamCong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnChamCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamCong.Location = new System.Drawing.Point(2, 613);
            this.btnChamCong.Margin = new System.Windows.Forms.Padding(2);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Size = new System.Drawing.Size(162, 64);
            this.btnChamCong.TabIndex = 11;
            this.btnChamCong.Text = "Chấm Công";
            this.btnChamCong.UseVisualStyleBackColor = false;
            this.btnChamCong.Click += new System.EventHandler(this.btnChamCong_Click);
            // 
            // btnPhong
            // 
            this.btnPhong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhong.Location = new System.Drawing.Point(2, 140);
            this.btnPhong.Margin = new System.Windows.Forms.Padding(2);
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.Size = new System.Drawing.Size(163, 64);
            this.btnPhong.TabIndex = 5;
            this.btnPhong.Text = "Phòng";
            this.btnPhong.UseVisualStyleBackColor = false;
            this.btnPhong.Click += new System.EventHandler(this.btnPhong_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.Location = new System.Drawing.Point(2, 545);
            this.btnHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(162, 64);
            this.btnHoaDon.TabIndex = 11;
            this.btnHoaDon.Text = "Hóa Đơn";
            this.btnHoaDon.UseVisualStyleBackColor = false;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnDichVu
            // 
            this.btnDichVu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDichVu.Location = new System.Drawing.Point(2, 275);
            this.btnDichVu.Margin = new System.Windows.Forms.Padding(2);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Size = new System.Drawing.Size(163, 64);
            this.btnDichVu.TabIndex = 5;
            this.btnDichVu.Text = "Dịch vụ";
            this.btnDichVu.UseVisualStyleBackColor = false;
            this.btnDichVu.Click += new System.EventHandler(this.btnDichVu_Click);
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoanhThu.Location = new System.Drawing.Point(1, 477);
            this.btnDoanhThu.Margin = new System.Windows.Forms.Padding(2);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Size = new System.Drawing.Size(163, 64);
            this.btnDoanhThu.TabIndex = 6;
            this.btnDoanhThu.Text = "Thong Ke";
            this.btnDoanhThu.UseVisualStyleBackColor = false;
            this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);
            // 
            // btnCSVC
            // 
            this.btnCSVC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCSVC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCSVC.Location = new System.Drawing.Point(1, 410);
            this.btnCSVC.Margin = new System.Windows.Forms.Padding(2);
            this.btnCSVC.Name = "btnCSVC";
            this.btnCSVC.Size = new System.Drawing.Size(163, 64);
            this.btnCSVC.TabIndex = 8;
            this.btnCSVC.Text = "Cơ sở vật chất";
            this.btnCSVC.UseVisualStyleBackColor = false;
            this.btnCSVC.Click += new System.EventHandler(this.btnCSVC_Click);
            // 
            // btnLuong
            // 
            this.btnLuong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuong.Location = new System.Drawing.Point(1, 342);
            this.btnLuong.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuong.Name = "btnLuong";
            this.btnLuong.Size = new System.Drawing.Size(163, 64);
            this.btnLuong.TabIndex = 7;
            this.btnLuong.Text = "Lương";
            this.btnLuong.UseVisualStyleBackColor = false;
            this.btnLuong.Click += new System.EventHandler(this.btnLuong_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyKhachSan.Properties.Resources.hotel_overview_16853296561;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pnMain
            // 
            this.pnMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMain.Location = new System.Drawing.Point(199, 0);
            this.pnMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(753, 857);
            this.pnMain.TabIndex = 4;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(954, 857);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.Text = "Quản lý khách sạn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.panel1.ResumeLayout(false);
            this.pnlSystemButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnKH;
        private System.Windows.Forms.Button btnDichVu;
        private System.Windows.Forms.Button btnPhong;
        private System.Windows.Forms.Button btnDoanhThu;
        private System.Windows.Forms.Button btnCSVC;
        private System.Windows.Forms.Button btnLuong;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnDatPhong;
        public System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Button btnChamCong;
        private System.Windows.Forms.Panel pnlSystemButton;
    }
}