﻿namespace DoAn
{
    partial class SanPham
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
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtKhuyenMai = new System.Windows.Forms.TextBox();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewSanPham = new System.Windows.Forms.DataGridView();
            this.rdoMucUngDung = new System.Windows.Forms.RadioButton();
            this.rdoMucCoSoDuLieu = new System.Windows.Forms.RadioButton();
            this.btnThemSanPham = new System.Windows.Forms.Button();
            this.btnLoadSanPham = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(185, 77);
            this.txtTenSanPham.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(326, 27);
            this.txtTenSanPham.TabIndex = 0;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(185, 137);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(326, 27);
            this.txtSoLuong.TabIndex = 0;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(731, 71);
            this.txtGia.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(326, 27);
            this.txtGia.TabIndex = 0;
            // 
            // txtKhuyenMai
            // 
            this.txtKhuyenMai.Location = new System.Drawing.Point(731, 127);
            this.txtKhuyenMai.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtKhuyenMai.Name = "txtKhuyenMai";
            this.txtKhuyenMai.Size = new System.Drawing.Size(326, 27);
            this.txtKhuyenMai.TabIndex = 0;
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Location = new System.Drawing.Point(731, 185);
            this.txtTrangThai.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(326, 27);
            this.txtTrangThai.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Sản Phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số lượng ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(574, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(574, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Khuyến Mãi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(574, 197);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Trạng Thái";
            // 
            // dataGridViewSanPham
            // 
            this.dataGridViewSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSanPham.Location = new System.Drawing.Point(97, 327);
            this.dataGridViewSanPham.Name = "dataGridViewSanPham";
            this.dataGridViewSanPham.Size = new System.Drawing.Size(960, 200);
            this.dataGridViewSanPham.TabIndex = 2;
            // 
            // rdoMucUngDung
            // 
            this.rdoMucUngDung.AutoSize = true;
            this.rdoMucUngDung.Location = new System.Drawing.Point(392, 280);
            this.rdoMucUngDung.Name = "rdoMucUngDung";
            this.rdoMucUngDung.Size = new System.Drawing.Size(142, 23);
            this.rdoMucUngDung.TabIndex = 3;
            this.rdoMucUngDung.TabStop = true;
            this.rdoMucUngDung.Text = "Muc Ứng dụng";
            this.rdoMucUngDung.UseVisualStyleBackColor = true;
            // 
            // rdoMucCoSoDuLieu
            // 
            this.rdoMucCoSoDuLieu.AutoSize = true;
            this.rdoMucCoSoDuLieu.Location = new System.Drawing.Point(615, 280);
            this.rdoMucCoSoDuLieu.Name = "rdoMucCoSoDuLieu";
            this.rdoMucCoSoDuLieu.Size = new System.Drawing.Size(106, 23);
            this.rdoMucCoSoDuLieu.TabIndex = 3;
            this.rdoMucCoSoDuLieu.TabStop = true;
            this.rdoMucCoSoDuLieu.Text = "Mức cơ sở";
            this.rdoMucCoSoDuLieu.UseVisualStyleBackColor = true;
            // 
            // btnThemSanPham
            // 
            this.btnThemSanPham.Location = new System.Drawing.Point(828, 255);
            this.btnThemSanPham.Name = "btnThemSanPham";
            this.btnThemSanPham.Size = new System.Drawing.Size(110, 47);
            this.btnThemSanPham.TabIndex = 4;
            this.btnThemSanPham.Text = "Thêm sản phẩm ";
            this.btnThemSanPham.UseVisualStyleBackColor = true;
            this.btnThemSanPham.Click += new System.EventHandler(this.btnThemSanPham_Click);
            // 
            // btnLoadSanPham
            // 
            this.btnLoadSanPham.Location = new System.Drawing.Point(959, 255);
            this.btnLoadSanPham.Name = "btnLoadSanPham";
            this.btnLoadSanPham.Size = new System.Drawing.Size(110, 47);
            this.btnLoadSanPham.TabIndex = 4;
            this.btnLoadSanPham.Text = "Load sản Phẩm";
            this.btnLoadSanPham.UseVisualStyleBackColor = true;
            this.btnLoadSanPham.Click += new System.EventHandler(this.btnLoadSanPham_Click);
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 600);
            this.Controls.Add(this.btnLoadSanPham);
            this.Controls.Add(this.btnThemSanPham);
            this.Controls.Add(this.rdoMucCoSoDuLieu);
            this.Controls.Add(this.rdoMucUngDung);
            this.Controls.Add(this.dataGridViewSanPham);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTrangThai);
            this.Controls.Add(this.txtKhuyenMai);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtTenSanPham);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "SanPham";
            this.Text = "SanPham";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtKhuyenMai;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewSanPham;
        private System.Windows.Forms.RadioButton rdoMucUngDung;
        private System.Windows.Forms.RadioButton rdoMucCoSoDuLieu;
        private System.Windows.Forms.Button btnThemSanPham;
        private System.Windows.Forms.Button btnLoadSanPham;
    }
}