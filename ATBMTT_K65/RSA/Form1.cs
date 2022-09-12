using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RSA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btTaoKhoaCongKhai_Click(object sender, EventArgs e)
        {
            RSAED rsa = new RSAED();
            String khoaCongKhai = rsa.KhoaCongKhai;
            String khoaBiMat = rsa.KhoaBiMat;
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Khóa công khai RSA (*.rsack) | *.rsack";
            sd.Title = "Lưu khóa công khai của bạn";
            if(sd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sd.FileName, khoaCongKhai);
            }

            sd = new SaveFileDialog();
            sd.Filter = "Khóa bí mật RSA (*.rsabm) | *.rsabm";
            sd.Title = "Lưu khóa bí mật của bạn";
            if (sd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sd.FileName, khoaBiMat);
            }
        }

        private void btMaHoa_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Khóa công khai RSA (*.rsack) | *.rsack";
            od.Title = "Chọn khóa RSA công khai của bạn để mã hóa";
            od.Multiselect = false;
            if(od.ShowDialog() == DialogResult.OK)
            {
                String khoaCongKhai = File.ReadAllText(od.FileName);
                RSAED rsa = new RSAED();
                tbKetQuaMaHoa.Text = rsa.MaHoa(tbGiaTriCanMaHoa.Text, khoaCongKhai);
            }    
        }

        private void btGiaiMa_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Khóa bí mật RSA (*.rsabm) | *.rsabm";
            od.Title = "Chọn khóa RSA bí mật của bạn để giải mã";
            od.Multiselect = false;
            if (od.ShowDialog() == DialogResult.OK)
            {
                String khoaBiMat = File.ReadAllText(od.FileName);
                RSAED rsa = new RSAED();
                tbKetQuaGiaiMa.Text = rsa.GiaiMa(tbKetQuaMaHoa.Text, khoaBiMat);
            }
        }
    }
}
