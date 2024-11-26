namespace DoAn
{
    partial class MaHoaDoiXung
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
            this.datagridview1 = new System.Windows.Forms.DataGridView();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.checkbox_Nhan = new System.Windows.Forms.CheckBox();
            this.checkbox_Cong = new System.Windows.Forms.CheckBox();
            this.btn_GiaiMa = new System.Windows.Forms.Button();
            this.btn_MaHoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Key = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview1)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridview1
            // 
            this.datagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview1.Location = new System.Drawing.Point(25, 92);
            this.datagridview1.Name = "datagridview1";
            this.datagridview1.RowHeadersWidth = 82;
            this.datagridview1.RowTemplate.Height = 33;
            this.datagridview1.Size = new System.Drawing.Size(1125, 316);
            this.datagridview1.TabIndex = 3;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(179, 22);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(148, 64);
            this.btn_Close.TabIndex = 38;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(25, 22);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(148, 64);
            this.btn_Back.TabIndex = 39;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // checkbox_Nhan
            // 
            this.checkbox_Nhan.AutoSize = true;
            this.checkbox_Nhan.Location = new System.Drawing.Point(25, 437);
            this.checkbox_Nhan.Name = "checkbox_Nhan";
            this.checkbox_Nhan.Size = new System.Drawing.Size(95, 29);
            this.checkbox_Nhan.TabIndex = 40;
            this.checkbox_Nhan.Text = "Nhân";
            this.checkbox_Nhan.UseVisualStyleBackColor = true;
            this.checkbox_Nhan.CheckedChanged += new System.EventHandler(this.checkbox_Nhan_CheckedChanged);
            // 
            // checkbox_Cong
            // 
            this.checkbox_Cong.AutoSize = true;
            this.checkbox_Cong.Location = new System.Drawing.Point(126, 437);
            this.checkbox_Cong.Name = "checkbox_Cong";
            this.checkbox_Cong.Size = new System.Drawing.Size(95, 29);
            this.checkbox_Cong.TabIndex = 41;
            this.checkbox_Cong.Text = "Cộng";
            this.checkbox_Cong.UseVisualStyleBackColor = true;
            this.checkbox_Cong.CheckedChanged += new System.EventHandler(this.checkbox_Cong_CheckedChanged);
            // 
            // btn_GiaiMa
            // 
            this.btn_GiaiMa.Location = new System.Drawing.Point(618, 493);
            this.btn_GiaiMa.Name = "btn_GiaiMa";
            this.btn_GiaiMa.Size = new System.Drawing.Size(261, 78);
            this.btn_GiaiMa.TabIndex = 42;
            this.btn_GiaiMa.Text = "Giải Mã";
            this.btn_GiaiMa.UseVisualStyleBackColor = true;
            this.btn_GiaiMa.Click += new System.EventHandler(this.btn_GiaiMa_Click);
            // 
            // btn_MaHoa
            // 
            this.btn_MaHoa.Location = new System.Drawing.Point(276, 493);
            this.btn_MaHoa.Name = "btn_MaHoa";
            this.btn_MaHoa.Size = new System.Drawing.Size(261, 78);
            this.btn_MaHoa.TabIndex = 43;
            this.btn_MaHoa.Text = "Mã Hóa";
            this.btn_MaHoa.UseVisualStyleBackColor = true;
            this.btn_MaHoa.Click += new System.EventHandler(this.btn_MaHoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 493);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 44;
            this.label1.Text = "Key";
            // 
            // txt_Key
            // 
            this.txt_Key.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Key.Location = new System.Drawing.Point(25, 521);
            this.txt_Key.Multiline = true;
            this.txt_Key.Name = "txt_Key";
            this.txt_Key.Size = new System.Drawing.Size(148, 57);
            this.txt_Key.TabIndex = 45;
            // 
            // MaHoaDoiXung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 657);
            this.Controls.Add(this.txt_Key);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_MaHoa);
            this.Controls.Add(this.btn_GiaiMa);
            this.Controls.Add(this.checkbox_Cong);
            this.Controls.Add(this.checkbox_Nhan);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.datagridview1);
            this.Name = "MaHoaDoiXung";
            this.Text = "MaHoaDoiXung";
            ((System.ComponentModel.ISupportInitialize)(this.datagridview1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridview1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.CheckBox checkbox_Nhan;
        private System.Windows.Forms.CheckBox checkbox_Cong;
        private System.Windows.Forms.Button btn_GiaiMa;
        private System.Windows.Forms.Button btn_MaHoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Key;
    }
}