using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public static class EncryptionHelper
    {
        private static readonly string key = "your_secret_key"; // Thay thế bằng khóa bí mật của bạn

        // Hàm Mã hóa dữ liệu
        public static string Encrypt(string plainText)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(key.PadRight(32)); // Đảm bảo chiều dài khóa đúng 32 bytes
                aesAlg.IV = new byte[16]; // Khởi tạo IV mặc định (có thể thay đổi theo yêu cầu)

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (var msEncrypt = new MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (var swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                    }
                    return Convert.ToBase64String(msEncrypt.ToArray()); // Mã hóa dữ liệu và chuyển thành chuỗi Base64
                }
            }
        }

        // Hàm Giải mã dữ liệu
        public static string Decrypt(string encryptedText)
        {
            try
            {
                // Kiểm tra dữ liệu có phải là Base64 hợp lệ không
                if (!IsBase64String(encryptedText))
                {
                    throw new FormatException("Chuỗi không phải là Base64 hợp lệ.");
                }

                byte[] cipherBytes = Convert.FromBase64String(encryptedText);
                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = Encoding.UTF8.GetBytes(key.PadRight(32)); // Đảm bảo chiều dài khóa đúng 32 bytes
                    aesAlg.IV = new byte[16]; // Khởi tạo IV mặc định

                    ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                    using (var msDecrypt = new MemoryStream(cipherBytes))
                    {
                        using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (var srDecrypt = new StreamReader(csDecrypt))
                            {
                                return srDecrypt.ReadToEnd();
                            }
                        }
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Lỗi giải mã Base64: " + ex.Message);
                return string.Empty;
            }
        }

        // Kiểm tra nếu chuỗi là Base64 hợp lệ
        public static bool IsBase64String(string value)
        {
            if (value.Length % 4 == 0)
            {
                try
                {
                    Convert.FromBase64String(value);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }
    }
}
