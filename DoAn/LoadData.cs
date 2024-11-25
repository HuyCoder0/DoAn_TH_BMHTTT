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

        // Cập nhật constructor để nhận username
        public LoadData(string username)
        {
            InitializeComponent();
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
    }
}
