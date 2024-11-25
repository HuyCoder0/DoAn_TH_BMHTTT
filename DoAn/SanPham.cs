using Oracle.ManagedDataAccess.Client;
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
    public partial class SanPham : Form
    {
        public SanPham()
        {
            InitializeComponent();
            rdoMucCoSoDuLieu.Checked = true;
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ TextBox
                string tenSanPham = txtTenSanPham.Text;
                int soLuong = int.Parse(txtSoLuong.Text);
                decimal gia = decimal.Parse(txtGia.Text);
                decimal khuyenMai = decimal.Parse(txtKhuyenMai.Text);
                string trangThai = txtTrangThai.Text;

                // Mã hóa dữ liệu
                string encryptedTenSanPham = EncryptionHelper.Encrypt(tenSanPham);
                string encryptedTrangThai = EncryptionHelper.Encrypt(trangThai);

                // Lấy ID_SANPHAM lớn nhất hiện tại
                string maxIdQuery = "SELECT MAX(ID_SANPHAM) FROM SANPHAM";
                OracleCommand maxIdCommand = new OracleCommand(maxIdQuery, Database.Get_Connect());
                object maxIdResult = maxIdCommand.ExecuteScalar();
                int newIdSanPham = (maxIdResult != DBNull.Value) ? Convert.ToInt32(maxIdResult) + 1 : 1;

                // Thực hiện truy vấn SQL để thêm sản phẩm vào cơ sở dữ liệu
                string query = $"INSERT INTO SANPHAM (ID_SANPHAM, TENSANPHAM, SOLUONG, GIA, KHUYENMAI, TRANGTHAI) " +
                               $"VALUES ({newIdSanPham}, '{encryptedTenSanPham}', {soLuong}, {gia}, {khuyenMai}, '{encryptedTrangThai}')";

                // Thực thi câu lệnh SQL
                using (OracleCommand command = new OracleCommand(query, Database.Get_Connect()))
                {
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Sản phẩm đã được thêm!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }

        private void btnLoadSanPham_Click(object sender, EventArgs e)
        {
            try
            {
                // Truy vấn để lấy dữ liệu sản phẩm
                string query = "SELECT * FROM SANPHAM";
                DataTable data = Database.GetDataTable(query);

                // Kiểm tra nếu có dữ liệu trả về
                if (data.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu sản phẩm!");
                    return;
                }

                // Xóa các cột cũ nếu có
                dataGridViewSanPham.Columns.Clear();

                // Thêm cột vào DataGridView
                dataGridViewSanPham.Columns.Add("ID_SANPHAM", "ID Sản Phẩm");
                dataGridViewSanPham.Columns.Add("TENSANPHAM", "Tên Sản Phẩm");
                dataGridViewSanPham.Columns.Add("SOLUONG", "Số Lượng");
                dataGridViewSanPham.Columns.Add("GIA", "Giá");
                dataGridViewSanPham.Columns.Add("KHUYENMAI", "Khuyến Mãi");
                dataGridViewSanPham.Columns.Add("TRANGTHAI", "Trạng Thái");

                // Hiển thị dữ liệu trong DataGridView
                foreach (DataRow row in data.Rows)
                {
                    string tenSanPhamEncrypted = row["TENSANPHAM"].ToString();
                    string trangThaiEncrypted = row["TRANGTHAI"].ToString();

                    // Giải mã dữ liệu
                    string tenSanPham = EncryptionHelper.Decrypt(tenSanPhamEncrypted);
                    string trangThai = EncryptionHelper.Decrypt(trangThaiEncrypted);

                    // Thêm vào DataGridView
                    dataGridViewSanPham.Rows.Add(row["ID_SANPHAM"], tenSanPham, row["SOLUONG"], row["GIA"], row["KHUYENMAI"], trangThai);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
