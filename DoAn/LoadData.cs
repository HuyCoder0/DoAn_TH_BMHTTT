using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class LoadData : Form
    {
        private string username;
        // Cập nhật constructor để nhận username
        public LoadData(string username)
        {
            InitializeComponent();
            this.username = username;
            label_user.Text = username; // Hiển thị username trên label
            LoadTable();
        }
        private void LoadTable()
        {
            string query = "SELECT * FROM GiaHuy_DoAn.SANPHAM";
            DataTable dataTable = Database.GetDataTable(query);

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                datagridview1.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("Không có dữ liệu trong bảng.");
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            // Mở lại form Login
            Login loginForm = new Login();
            loginForm.Show();

            // Đóng form hiện tại
            this.Close();
        }

        private void User_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Home Form = new Home(username);
            Form.Show();

            this.Close();
        }
    }
}
