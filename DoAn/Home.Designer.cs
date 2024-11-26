namespace DoAn
{
    partial class Home
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
            this.cbo_ChucNang = new System.Windows.Forms.ComboBox();
            this.User = new System.Windows.Forms.GroupBox();
            this.label_user = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.User.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(829, 267);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhóm 3";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(411, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(395, 90);
            this.label2.TabIndex = 1;
            this.label2.Text = "Home Menu";
            // 
            // cbo_ChucNang
            // 
            this.cbo_ChucNang.FormattingEnabled = true;
            this.cbo_ChucNang.Location = new System.Drawing.Point(27, 26);
            this.cbo_ChucNang.Name = "cbo_ChucNang";
            this.cbo_ChucNang.Size = new System.Drawing.Size(200, 33);
            this.cbo_ChucNang.TabIndex = 2;
            this.cbo_ChucNang.Text = "Chọn chức năng";
            this.cbo_ChucNang.SelectedIndexChanged += new System.EventHandler(this.cbo_ChucNang_SelectedIndexChanged);
            // 
            // User
            // 
            this.User.Controls.Add(this.label_user);
            this.User.Location = new System.Drawing.Point(812, 12);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(235, 76);
            this.User.TabIndex = 40;
            this.User.TabStop = false;
            this.User.Text = "User";
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Location = new System.Drawing.Point(17, 27);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(0, 25);
            this.label_user.TabIndex = 0;
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(1053, 26);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(144, 63);
            this.btn_Logout.TabIndex = 42;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 654);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.User);
            this.Controls.Add(this.cbo_ChucNang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.Text = "Home";
            this.User.ResumeLayout(false);
            this.User.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_ChucNang;
        private System.Windows.Forms.GroupBox User;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Button btn_Logout;
    }
}