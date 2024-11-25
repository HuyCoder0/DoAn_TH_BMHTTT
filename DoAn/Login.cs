using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
namespace DoAn
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.txt_pass.PasswordChar = '*'; // Ẩn mật khẩu
        }

        bool Check_TextBox(string user, string pass)
        {
            
            if (user == "")
            {
                MessageBox.Show("Chưa điền thông tin vào User");
                txt_user.Focus();
                return false;
            }
            else if (pass == "")
            {
                MessageBox.Show("Chưa điền thông tin vào Pass");
                txt_pass.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            
            string user = txt_user.Text;
            string pass = txt_pass.Text;
            if (Check_TextBox(user, pass))
            {
                Database.Set_Database(user, pass);

                //old
                //Hiện thông báo đăng nhập thành công
                //if (Database.Connect())
                //{
                //    OracleConnection c = Database.Get_Connect();
                //    MessageBox.Show("Đăng nhập thành công" + c.ServerVersion);
                //}
                //else
                //{
                //    MessageBox.Show("Đăng nhập thất bại");
                //}



                //New
                if (Database.Connect())
                {
                    MessageBox.Show("Đăng nhập thành công");

                    // Chuyển qua form LoadTable
                    //LoadData loadTableForm = new LoadData(user);
                    //loadTableForm.Show();
                    //this.Hide();

                    MaHoaLaiSanPham loadTableForm = new MaHoaLaiSanPham();
                    loadTableForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_showPassword_Click(object sender, EventArgs e)
        {
            // Chuyển đổi giữa ẩn và hiện mật khẩu
            if (txt_pass.PasswordChar == '\0') // Nếu mật khẩu đang hiển thị
            {
                txt_pass.PasswordChar = '*'; // Ẩn mật khẩu
                btn_showPassword.Text = "🙈"; // Thay đổi icon thành mắt kín

            }
            else // Nếu mật khẩu đang ẩn
            {
                txt_pass.PasswordChar = '\0'; // Hiện mật khẩu
                btn_showPassword.Text = "👁"; // Thay đổi lại icon về mắt

            }
        }
    }
}
