using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace MaHoaCSDL
{
    public class MD5
    {
        String pass = "@123Abc#qek$769";

        public String MaHoa(String value)
        {
            byte[] bValue = Encoding.ASCII.GetBytes(value);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] khoa = md5.ComputeHash(Encoding.ASCII.GetBytes(pass));
            TripleDESCryptoServiceProvider trip = new TripleDESCryptoServiceProvider();
            trip.Key = khoa;
            trip.Mode = CipherMode.ECB;
            trip.Padding = PaddingMode.PKCS7;
            ICryptoTransform trans = trip.CreateEncryptor();
            byte[] ketQua = trans.TransformFinalBlock(bValue, 0, bValue.Length);
            return Encoding.ASCII.GetString(ketQua);
        }

        public String GiaiMa(String value)
        {
            byte[] bValue = Encoding.ASCII.GetBytes(value);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] khoa = md5.ComputeHash(Encoding.ASCII.GetBytes(pass));
            TripleDESCryptoServiceProvider trip = new TripleDESCryptoServiceProvider();
            trip.Key = khoa;
            trip.Mode = CipherMode.ECB;
            trip.Padding = PaddingMode.PKCS7;
            ICryptoTransform trans = trip.CreateDecryptor();
            byte[] ketQua = trans.TransformFinalBlock(bValue, 0, bValue.Length);
            return Encoding.ASCII.GetString(ketQua);
        }
    }
}
