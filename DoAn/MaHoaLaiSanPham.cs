using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
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
    public partial class MaHoaLaiSanPham : Form
    {
        public MaHoaLaiSanPham()
        {
            InitializeComponent();
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

                    // Gọi hàm GetMaxIdSanPham để lấy ID lớn nhất hiện tại
                    OracleCommand cmdMaxId = new OracleCommand("GETMAXIDSANPHAM", Database.Get_Connect());
                    cmdMaxId.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số trả về (RETURN_VALUE)
                    OracleParameter returnValueParam = new OracleParameter("RETURN_VALUE", OracleDbType.Int32);
                    returnValueParam.Direction = ParameterDirection.Output;
                    cmdMaxId.Parameters.Add(returnValueParam);

                    // Thực thi và lấy giá trị ID lớn nhất
                    cmdMaxId.ExecuteNonQuery();

                    // Lấy giá trị trả về và chuyển đổi từ OracleDecimal sang int
                    int newIdSanPham = Convert.ToInt32(((OracleDecimal)returnValueParam.Value).ToInt32()) + 1;

                    // Kiểm tra xem ID đã tồn tại chưa
                    OracleCommand checkIdCommand = new OracleCommand("SELECT COUNT(*) FROM SANPHAM WHERE ID_SANPHAM = :idSanPham", Database.Get_Connect());
                    checkIdCommand.Parameters.Add("idSanPham", OracleDbType.Int32).Value = newIdSanPham;
                    int count = Convert.ToInt32(checkIdCommand.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("ID sản phẩm đã tồn tại. Thử lại.");
                        return;
                    }

                    // Gọi Procedure để thêm sản phẩm vào cơ sở dữ liệu
                    OracleCommand cmdInsert = new OracleCommand("THEM_SANPHAM", Database.Get_Connect());
                    cmdInsert.CommandType = CommandType.StoredProcedure;
                    cmdInsert.Parameters.Add("p_tenSanPham", OracleDbType.Varchar2).Value = encryptedTenSanPham;
                    cmdInsert.Parameters.Add("p_soLuong", OracleDbType.Int32).Value = soLuong;
                    cmdInsert.Parameters.Add("p_gia", OracleDbType.Decimal).Value = gia;
                    cmdInsert.Parameters.Add("p_khuyenMai", OracleDbType.Decimal).Value = khuyenMai;
                    cmdInsert.Parameters.Add("p_trangThai", OracleDbType.Varchar2).Value = encryptedTrangThai;

                    // Thực thi câu lệnh để thêm sản phẩm
                    cmdInsert.ExecuteNonQuery();

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
                // Gọi stored procedure GET_SANPHAM_LIST
                OracleCommand cmd = new OracleCommand("GET_SANPHAM_LIST", Database.Get_Connect());
                cmd.CommandType = CommandType.StoredProcedure;

                // Khai báo tham số OUT để nhận kết quả
                OracleParameter outCursor = new OracleParameter("p_cursor", OracleDbType.RefCursor);
                outCursor.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outCursor);

                // Thực thi câu lệnh và lấy kết quả
                OracleDataReader reader = cmd.ExecuteReader();

                // Kiểm tra nếu có dữ liệu trả về
                if (!reader.HasRows)
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
                while (reader.Read())
                {
                    string tenSanPhamEncrypted = reader["TENSANPHAM"].ToString();
                    string trangThaiEncrypted = reader["TRANGTHAI"].ToString();

                    // Giải mã dữ liệu
                    string tenSanPham = EncryptionHelper.Decrypt(tenSanPhamEncrypted);
                    string trangThai = EncryptionHelper.Decrypt(trangThaiEncrypted);

                    // Thêm vào DataGridView
                    dataGridViewSanPham.Rows.Add(reader["ID_SANPHAM"], tenSanPham, reader["SOLUONG"], reader["GIA"], reader["KHUYENMAI"], trangThai);
                }
                // Đảm bảo DataGridView chiếm hết không gian có sẵn
                

                // Tự động điều chỉnh kích thước các cột và dòng
                dataGridViewSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewSanPham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridViewSanPham.Sort(dataGridViewSanPham.Columns["ID_SANPHAM"], ListSortDirection.Ascending);

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }
    }
}
