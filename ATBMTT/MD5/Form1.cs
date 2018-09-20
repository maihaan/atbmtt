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

namespace MD5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btMaHoa_Click(object sender, EventArgs e)
        {
            // Lay mat khau thong qua MD5
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] keys = md5.ComputeHash(Encoding.UTF8.GetBytes(tbMatKhau.Text));

            // Tao bo cai dat ma hoa
            TripleDESCryptoServiceProvider trip = new TripleDESCryptoServiceProvider();
            trip.Key = keys;
            trip.Mode = CipherMode.ECB;
            trip.Padding = PaddingMode.PKCS7;

            // Tao bo ma hoa va ma hoa
            ICryptoTransform tranform;
            tranform = trip.CreateEncryptor();
            byte[] dlCanMa = Encoding.UTF8.GetBytes(tbDuLieuCanMaHoa.Text);
            byte[] kqMaHoa = tranform.TransformFinalBlock(dlCanMa, 0, dlCanMa.Length);
            tbDuLieuMaHoaDuoc.Text = Encoding.UTF8.GetString(kqMaHoa);
        }

        private void btGiaiMa_Click(object sender, EventArgs e)
        {
            // Lay mat khau thong qua MD5
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] keys = md5.ComputeHash(Encoding.UTF8.GetBytes(tbMatKhau.Text));

            // Tao bo cai dat ma hoa
            TripleDESCryptoServiceProvider trip = new TripleDESCryptoServiceProvider();
            trip.Key = keys;
            trip.Mode = CipherMode.ECB;
            trip.Padding = PaddingMode.PKCS7;

            // Tao bo ma hoa va ma hoa
            ICryptoTransform tranform;
            tranform = trip.CreateDecryptor();
            byte[] dlCanMa = Encoding.UTF8.GetBytes(tbDuLieuMaHoaDuoc.Text);
            byte[] kqMaHoa = tranform.TransformFinalBlock(dlCanMa, 0, dlCanMa.Length);
            tbDuLieuGiaiMaDuoc.Text = Encoding.UTF8.GetString(kqMaHoa);
        }
    }
}
