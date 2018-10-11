using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace QLVatTu
{
    public class MD5
    {
        String pass = "@123Abc#qek$769";

        public byte[] MaHoa(String value)
        {
            byte[] bValue = Encoding.UTF8.GetBytes(value);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] khoa = md5.ComputeHash(Encoding.ASCII.GetBytes(pass));
            TripleDESCryptoServiceProvider trip = new TripleDESCryptoServiceProvider();
            trip.Key = khoa;
            trip.Mode = CipherMode.ECB;
            trip.Padding = PaddingMode.PKCS7;
            ICryptoTransform trans = trip.CreateEncryptor();
            byte[] ketQua = trans.TransformFinalBlock(bValue, 0, bValue.Length);
            return ketQua;
        }
        public String GiaiMa(byte[] bValue)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] khoa = md5.ComputeHash(Encoding.ASCII.GetBytes(pass));
            TripleDESCryptoServiceProvider trip = new TripleDESCryptoServiceProvider();
            trip.Key = khoa;
            trip.Mode = CipherMode.ECB;
            trip.Padding = PaddingMode.PKCS7;
            ICryptoTransform trans = trip.CreateDecryptor();
            byte[] ketQua = trans.TransformFinalBlock(bValue, 0, bValue.Length);
            return Encoding.UTF8.GetString(ketQua);
        }
    }
}
