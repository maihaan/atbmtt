using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace RSA
{
    public class RSAED
    {
        RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

        public String KhoaCongKhai
        {
            get
            {
                return rsa.ToXmlString(false);
            }
        }

        public String KhoaBiMat
        {
            get
            {
                return rsa.ToXmlString(true);
            }
        }

        public byte[] MaHoa(byte[] duLieu, String khoaCongKhai)
        {
            rsa.FromXmlString(khoaCongKhai);
            return rsa.Encrypt(duLieu, true);
        }

        public byte[] GiaiMa(byte[] duLieu, String khoaBiMat)
        {
            rsa.FromXmlString(khoaBiMat);
            return rsa.Decrypt(duLieu, true);
        }

        public String MaHoa(String duLieu, String khoaCongKhai)
        {
            byte[] boDem = Encoding.UTF8.GetBytes(duLieu);
            byte[] ketQua = MaHoa(boDem, khoaCongKhai);
            return Convert.ToBase64String(ketQua);
        }

        public String GiaiMa(String duLieu, String khoaBiMat)
        {
            byte[] boDem = Convert.FromBase64String(duLieu);
            byte[] ketQua = GiaiMa(boDem, khoaBiMat);
            return Encoding.UTF8.GetString(ketQua);
        }
    }
}
