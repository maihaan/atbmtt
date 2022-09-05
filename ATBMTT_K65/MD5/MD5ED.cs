using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace MD5
{
    public class MD5ED
    {
        public String MaHoa(String giaTriCanMa, String matKhau)
        {
            byte[] bGiaTriCanma = Encoding.UTF8.GetBytes(giaTriCanMa);
            byte[] bMatKhau = Encoding.UTF8.GetBytes(matKhau);
            byte[] ketQua = MaHoa(bGiaTriCanma, bMatKhau);
            return Convert.ToBase64String(ketQua);
        }

        public String GiaiMa(String giaTriCanGiaiMa, String matKhau)
        {
            byte[] bGiaTriCanGiaiMa = Convert.FromBase64String(giaTriCanGiaiMa);
            byte[] bMatKhau = Encoding.UTF8.GetBytes(matKhau);
            byte[] ketQua = GiaiMa(bGiaTriCanGiaiMa, bMatKhau);
            return Encoding.UTF8.GetString(ketQua);
        }

        public byte[] MaHoa(byte[] giaTriCanMa, byte[] matKhau)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] key = md5.ComputeHash(matKhau);
            TripleDESCryptoServiceProvider trip = new TripleDESCryptoServiceProvider();
            trip.Key = key;
            trip.Mode = CipherMode.ECB;
            trip.Padding = PaddingMode.PKCS7;
            ICryptoTransform trans = trip.CreateEncryptor();
            return trans.TransformFinalBlock(giaTriCanMa, 0, giaTriCanMa.Length);
        }

        public byte[] GiaiMa(byte[] giaTriCanGiaiMa, byte[] matKhau)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] key = md5.ComputeHash(matKhau);
            TripleDESCryptoServiceProvider trip = new TripleDESCryptoServiceProvider();
            trip.Key = key;
            trip.Mode = CipherMode.ECB;
            trip.Padding = PaddingMode.PKCS7;
            ICryptoTransform trans = trip.CreateDecryptor();
            return trans.TransformFinalBlock(giaTriCanGiaiMa, 0, giaTriCanGiaiMa.Length);
        }
    }
}
