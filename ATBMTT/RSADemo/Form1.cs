using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace RSADemo
{
    public partial class Form1 : Form
    {
        RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
        String publicKey = "";
        String privateKey = "";

        public Form1()
        {
            InitializeComponent();
            publicKey = rsa.ToXmlString(false).ToString();
            privateKey = rsa.ToXmlString(true).ToString();
        }

        private void btMaHoa_Click(object sender, EventArgs e)
        {
            // Chuyen gia tri can ma hoa thanh mang byte
            byte[] dlCanMa = Encoding.UTF8.GetBytes(tbDuLieuCanMaHoa.Text);

            // Ma hoa ra mot mang byte khac
            byte[] kqMaHoa = rsa.Encrypt(dlCanMa, true);

            // Chuyen ket qua ma hoa ve dang text va hien thi
            tbDuLieuMaHoaDuoc.Text = Encoding.UTF8.GetString(kqMaHoa);
        }

        private void btGiaiMa_Click(object sender, EventArgs e)
        {
            byte[] dlCanMa = Encoding.UTF8.GetBytes(tbDuLieuCanMaHoa.Text);

            // Ma hoa ra mot mang byte khac
            byte[] kqMaHoa = rsa.Encrypt(dlCanMa, true);

            // Giai ma
            byte[] kqGiaiMa = rsa.Decrypt(kqMaHoa, true);

            // Chuyen ket qua ma hoa ve dang text va hien thi
            tbDuLieuGiaiMaDuoc.Text = Encoding.UTF8.GetString(kqGiaiMa);
        }
    }
}
