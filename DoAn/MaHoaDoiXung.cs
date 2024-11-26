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
    public partial class MaHoaDoiXung : Form
    {
        private DataTable nhanVienTable;// Biến toàn cục lưu trữ dữ liệu bảng
        public string username; // Lưu trữ username cho form

        public MaHoaDoiXung(string username)
        {
            InitializeComponent();
            this.username = username;

            // Mặc định chọn checkbox_Cong
            checkbox_Cong.Checked = true;
            
            //Load dữ liệu table
            LoadTable();


        }
        private void LoadTable()
        {
            try
            {
                // Gọi stored procedure để lấy dữ liệu từ cơ sở dữ liệu
                nhanVienTable = Database.ExecuteProcedure("PROC_SELECT_NHANVIEN");

                // Kiểm tra và hiển thị dữ liệu
                if (nhanVienTable != null && nhanVienTable.Rows.Count > 0)
                {
                    datagridview1.DataSource = nhanVienTable;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        //Tìm nghịch đảo của k khi chọn mã hóa nhân
        private int ModularInverse(int a, int m)
        {
            for (int i = 1; i < m; i++)
            {
                if ((a * i) % m == 1)
                {
                    return i;
                }
            }
            throw new Exception("không tìm thấy nghịch đảo của " + a + "tromg modulo" + m);
        }

        //Tìm nguyên tố cùng nhau
        private bool IsCoprime(int a, int m)
        {
            return GCD(a, m) == 1;
        }
        
        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        //Nhân
        private string ModularCipher(string text, int key, bool isEncrypt)
        {
            const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            int N = Alphabet.Length;

            if (!isEncrypt) // Nếu giải mã, dùng nghịch đảo modular của key
            {
                key = ModularInverse(key, N);
            }

            StringBuilder result = new StringBuilder();

            foreach (char c in text.ToUpper())
            {
                int index = Alphabet.IndexOf(c);
                if (index != -1)
                {
                    int newIndex = (index * key) % N; // Phép nhân modular
                    result.Append(Alphabet[newIndex]);
                }
                else
                {
                    result.Append(c); // Giữ nguyên ký tự không nằm trong bảng Alphabet
                }
            }

            return result.ToString();
        }

        //Cộng
        private string AdditiveCipher(string text, int key, bool isEncrypt)
        {
            const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            int N = Alphabet.Length;

            if (!isEncrypt) // Nếu giải mã, đảo chiều key
            {
                key = -key;
            }

            StringBuilder result = new StringBuilder();

            foreach (char c in text.ToUpper())
            {
                int index = Alphabet.IndexOf(c);
                if (index != -1)
                {
                    int newIndex = (index + key + N) % N; // Phép cộng modular
                    result.Append(Alphabet[newIndex]);
                }
                else
                {
                    result.Append(c); // Giữ nguyên ký tự không nằm trong bảng Alphabet
                }
            }

            return result.ToString();
        }



        private void ProcessDataTable(DataTable dataTable, int key, bool isEncrypt, bool isMultiply)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (DataColumn col in dataTable.Columns)
                {
                    if (col.ColumnName.Equals("MATKHAU", StringComparison.OrdinalIgnoreCase) && row[col] != DBNull.Value)
                    {
                        string originalValue = row[col].ToString();

                        // Mã hóa hoặc giải mã dựa trên phép toán
                        if (isMultiply)
                        {
                            row[col] = ModularCipher(originalValue, key, isEncrypt);
                        }
                        else
                        {
                            row[col] = AdditiveCipher(originalValue, key, isEncrypt);
                        }
                    }
                }
            }

            // Làm mới lại DataGridView sau khi cập nhật dữ liệu
            datagridview1.DataSource = dataTable;
        }

        private void btn_MaHoa_Click(object sender, EventArgs e)
        {
            if (nhanVienTable == null || nhanVienTable.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để mã hóa.");
                return;
            }

            if (!int.TryParse(txt_Key.Text, out int key))
            {
                MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ cho khóa.");
                return;
            }

            if (checkbox_Nhan.Checked)
            {
                if (!IsCoprime(key, 36))
                {
                    MessageBox.Show("Khóa phải là số nguyên tố cùng nhau với 36.");
                    return;
                }

                ProcessDataTable(nhanVienTable, key, true, true); // true = mã hóa, true = phép nhân
            }
            else if (checkbox_Cong.Checked)
            {
                if (key < 1 || key > 40)
                {
                    MessageBox.Show("Khóa phải nằm trong khoảng từ 1 đến 40.");
                    return;
                }

                ProcessDataTable(nhanVienTable, key, true, false); // true = mã hóa, false = phép cộng
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phương pháp mã hóa.");
            }
        }

        private void btn_GiaiMa_Click(object sender, EventArgs e)
        {
            if (nhanVienTable == null || nhanVienTable.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để giải mã.");
                return;
            }

            if (!int.TryParse(txt_Key.Text, out int key))
            {
                MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ cho khóa.");
                return;
            }

            if (checkbox_Nhan.Checked)
            {
                if (!IsCoprime(key, 36))
                {
                    MessageBox.Show("Khóa phải là số nguyên tố cùng nhau với 36.");
                    return;
                }

                ProcessDataTable(nhanVienTable, key, false, true); // false = giải mã, true = phép nhân
            }
            else if (checkbox_Cong.Checked)
            {
                if (key < 1 || key > 40)
                {
                    MessageBox.Show("Khóa phải nằm trong khoảng từ 1 đến 40.");
                    return;
                }

                ProcessDataTable(nhanVienTable, key, false, false); // false = giải mã, false = phép cộng
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phương pháp giải mã.");
            }
        }





        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            // Mở lại form Login
            Home Form = new Home(username);
            Form.Show();

            // Đóng form hiện tại
            this.Close();
        }

        private void checkbox_Cong_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_Cong.Checked)
            {
                checkbox_Nhan.Checked = false;
            }
        }

        private void checkbox_Nhan_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_Nhan.Checked)
            {
                checkbox_Cong.Checked = false;
            }
        }
    }
}
