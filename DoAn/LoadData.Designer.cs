namespace DoAn
{
    partial class LoadData
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
            this.datagridview1 = new System.Windows.Forms.DataGridView();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.User = new System.Windows.Forms.GroupBox();
            this.label_user = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview1)).BeginInit();
            this.User.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bảng Sản Phẩm";
            // 
            // datagridview1
            // 
            this.datagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview1.Location = new System.Drawing.Point(39, 111);
            this.datagridview1.Name = "datagridview1";
            this.datagridview1.RowHeadersWidth = 82;
            this.datagridview1.RowTemplate.Height = 33;
            this.datagridview1.Size = new System.Drawing.Size(1125, 316);
            this.datagridview1.TabIndex = 2;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(880, 17);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(148, 64);
            this.btn_Close.TabIndex = 37;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(1046, 17);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(135, 64);
            this.btn_Logout.TabIndex = 38;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // User
            // 
            this.User.Controls.Add(this.label_user);
            this.User.Location = new System.Drawing.Point(625, 17);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(235, 64);
            this.User.TabIndex = 39;
            this.User.TabStop = false;
            this.User.Text = "User";
            this.User.Enter += new System.EventHandler(this.User_Enter);
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Location = new System.Drawing.Point(17, 27);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(0, 25);
            this.label_user.TabIndex = 0;
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(39, 24);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(117, 64);
            this.btn_Back.TabIndex = 40;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // LoadData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 476);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.User);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datagridview1);
            this.Name = "LoadData";
            this.Text = "LoadData";
            ((System.ComponentModel.ISupportInitialize)(this.datagridview1)).EndInit();
            this.User.ResumeLayout(false);
            this.User.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datagridview1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.GroupBox User;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Button btn_Back;
    }
}