using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MD5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        byte[] temp;

        private void btMaHoa_Click(object sender, EventArgs e)
        {
            // Kiem tra du lieu dau vào: mat khau va gia tri can ma hoa

            // Ma hoa
            MD5ED md5 = new MD5ED();
            tbKetQuaMaHoa.Text = md5.MaHoa(tbGiaTriCanMaHoa.Text, tbMatKhau.Text);
            //temp = md5.MaHoa(Encoding.UTF8.GetBytes(tbGiaTriCanMaHoa.Text), Encoding.UTF8.GetBytes(tbMatKhau.Text));
        }

        private void btGiaiMa_Click(object sender, EventArgs e)
        {
            MD5ED md5 = new MD5ED();
            tbKetQuaGiaiMa.Text = md5.GiaiMa(tbKetQuaMaHoa.Text, tbMatKhau.Text);
            //tbKetQuaGiaiMa.Text = Encoding.UTF8.GetString(md5.GiaiMa(temp, Encoding.UTF8.GetBytes(tbMatKhau.Text)));
        }
    }
}
