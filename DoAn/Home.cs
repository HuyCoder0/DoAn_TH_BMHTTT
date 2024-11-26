using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DoAn
{
    public partial class Home : Form
    {
        public string username; // Lưu trữ username cho form
        public Home(string username)
        {
            InitializeComponent();
            this.username = username;
            label_user.Text = username; // Hiển thị username trên form


            // Load danh sách các form vào ComboBox khi mở form Home
            LoadFormsToComboBox();



        }

        // Phương thức để thêm danh sách các form vào ComboBox
        private void LoadFormsToComboBox()
        {
            // Thêm tên các form vào ComboBox
            cbo_ChucNang.Items.Add("LoadData");
            cbo_ChucNang.Items.Add("Mã Hóa Lai");
            cbo_ChucNang.Items.Add("Mã Hóa Đối Xứng");

        }
        // Sự kiện khi người dùng chọn một form từ ComboBox
        private void cbo_ChucNang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedForm = cbo_ChucNang.SelectedItem.ToString(); // Lấy form được chọn

            // Chuyển sang form được chọn
            OpenSelectedForm(selectedForm);
        }

        // Phương thức để mở form tương ứng
        private void OpenSelectedForm(string formName)
        {
            Form newForm = null;

            switch (formName)
            {
                case "LoadData":
                    newForm = new LoadData(username); // Truyền username vào form LoadData
                    break;

                case "Mã Hóa Đối Xứng":
                    newForm = new MaHoaDoiXung(username); // Khởi tạo Form2
                    break;

                case "Mã Hóa Lai":
                    newForm = new MaHoaLaiSanPham(username); // Khởi tạo Form3
                    break;

                default:
                    MessageBox.Show("Form không tồn tại!");
                    return;
            }

            // Hiển thị form mới
            if (newForm != null)
            {
                newForm.Show();
                this.Hide(); // Ẩn form Home
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            // Mở lại form Login
            Login loginForm = new Login();
            loginForm.Show();

            // Đóng form hiện tại
            this.Close();
        }
    }
}
