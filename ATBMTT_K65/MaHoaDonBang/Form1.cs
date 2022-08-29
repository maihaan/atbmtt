using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaHoaDonBang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btMaHoa_Click(object sender, EventArgs e)
        {
            // Kiem soat du lieu dau vao
            if(String.IsNullOrEmpty(tbGiaTriCanMaHoa.Text))
            {
                MessageBox.Show("Bạn phải nhập giá trị cần mã hóa");
                tbGiaTriCanMaHoa.Focus();
                return;
            }

            // Ma hoa va hien thi ket qua
            DonBangED d = new DonBangED();
            tbKetQuaMaHoa.Text = d.MaHoa(tbGiaTriCanMaHoa.Text);
            String khoa = d.Khoa;
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Text file (*.txt) | *.txt";
            if(sd.ShowDialog() == DialogResult.OK)
            {
                String duongDan = sd.FileName;
                File.WriteAllText(duongDan, khoa);
            }    
        }

        private void btGiaiMa_Click(object sender, EventArgs e)
        {
            // Kiem soat du lieu dau vao
            if (String.IsNullOrEmpty(tbKetQuaMaHoa.Text))
            {
                MessageBox.Show("Bạn phải nhập giá trị cần giải mã");
                tbGiaTriCanMaHoa.Focus();
                return;
            }

            // Giải mã
            String khoa = "";
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Text file (*.txt) | *.txt";
            if(od.ShowDialog() == DialogResult.OK)
            {
                khoa = File.ReadAllText(od.FileName);
            }    

            if(khoa.Length == tbKetQuaMaHoa.Text.Length)
            {
                DonBangED d = new DonBangED();
                d.Khoa = khoa;
                String ketQua = d.GiaiMa(tbKetQuaMaHoa.Text);
                tbKetQuaGiaiMa.Text = ketQua;
            }   
            else
            {
                MessageBox.Show("Khóa không hợp lệ");
                return;
            }    
        }
    }
}
