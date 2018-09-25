using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace MD5App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbMaHoa_CheckedChanged(object sender, EventArgs e)
        {
            if(rbMaHoa.Checked)
                rbGiaiMa.Checked = false;
        }

        private void rbGiaiMa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGiaiMa.Checked)
                rbMaHoa.Checked = false;
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Multiselect = false;
            if(od.ShowDialog() == DialogResult.OK)
            {
                tbDuongDan.Text = od.FileName;
            }
        }

        private void btThucHien_Click(object sender, EventArgs e)
        {
            if(tbMatKhau.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu để mã hóa");
                tbMatKhau.Focus();
                return;
            }

            // Doc noi dung tep tin vao mot mang byte
            byte[] noiDungTep = System.IO.File.ReadAllBytes(tbDuongDan.Text);

            // Doc mat khau vao mang byte thong qua MD5
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] khoa = md5.ComputeHash(Encoding.ASCII.GetBytes(tbMatKhau.Text.Trim()));

            // Tao bo cai dat ma hoa
            TripleDESCryptoServiceProvider trip = new TripleDESCryptoServiceProvider();
            trip.Key = khoa;
            trip.Mode = CipherMode.ECB;
            trip.Padding = PaddingMode.PKCS7;

            // Ma hoa hoac giai ma
            if(rbMaHoa.Checked)
            {
                // Ma hoa
                ICryptoTransform trans = trip.CreateEncryptor();
                byte[] ketQua = trans.TransformFinalBlock(noiDungTep, 0, noiDungTep.Length);
                String ext = System.IO.Path.GetExtension(tbDuongDan.Text);
                SaveFileDialog sd = new SaveFileDialog();
                sd.Filter = ext + " files (*" + ext + ") | *" + ext;
                if(sd.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllBytes(sd.FileName, ketQua);
                }
            }
            else
            {
                // Giai ma
                try
                {
                    ICryptoTransform trans = trip.CreateDecryptor();
                    byte[] ketQua = trans.TransformFinalBlock(noiDungTep, 0, noiDungTep.Length);
                    String ext = System.IO.Path.GetExtension(tbDuongDan.Text);
                    SaveFileDialog sd = new SaveFileDialog();
                    sd.Filter = ext + " files (*" + ext + ") | *" + ext;
                    if (sd.ShowDialog() == DialogResult.OK)
                    {
                        System.IO.File.WriteAllBytes(sd.FileName, ketQua);
                    }
                }
                catch
                {
                    MessageBox.Show("Mật khẩu không đúng");
                    tbMatKhau.Focus();
                    return;
                }
            }
        }
    }
}
