using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FileEncrypt
{
    public partial class Form1 : Form
    {
        byte[] bangChuCai;
        byte[,] bangTra;

        public Form1()
        {
            InitializeComponent();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            rbMaHoa.Checked = true;
            // Khoi tao bang chu cai
            bangChuCai = new byte[256];
            for (int i = 0; i < 256; i++)
                bangChuCai[i] = Convert.ToByte(i);

            // Khoi tao bang tra
            bangTra = new byte[256, 256];
            for(int i = 0; i < 256; i++)
                for(int j = 0; j < 256; j++)
                {
                    bangTra[i, j] = bangChuCai[(i + j) % 256];
                }
        }

        private void rbMaHoa_CheckedChanged(object sender, EventArgs e)
        {
            if(rbMaHoa.Checked)
            {
                rbGiaiMa.Checked = false;
            }
        }

        private void rbGiaiMa_CheckedChanged(object sender, EventArgs e)
        {
            if(rbGiaiMa.Checked)
            {
                rbMaHoa.Checked = false;
            }
        }

        private void btThucHien_Click(object sender, EventArgs e)
        {
            // Kiem tra xem tep tin nguoi dung chon co ton tai hay ko
            if(!File.Exists(tbDuongDan.Text))
            {
                MessageBox.Show("Tệp tin không tồn tại. Bạn hãy chọn lại tệp tin.");
                return;
            }

            // Kiem tra xem nguoi dung da nhap mat khau hay chua
            if(tbMatKhau.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu.");
                return;
            }

            // Chuan bi du lieu de ma hoa hoac giai ma
            try
            {
                // Doc noi dung tep tin
                byte[] noiDungTepTin = File.ReadAllBytes(tbDuongDan.Text);
                // Sinh khoa tu mat khau
                byte[] matKhauByte = Encoding.ASCII.GetBytes(tbMatKhau.Text);
                byte[] khoa = new byte[noiDungTepTin.Length];
                for (int i = 0; i < khoa.Length; i++)
                    khoa[i] = matKhauByte[i % matKhauByte.Length];

                // Thuc hien cong viec
                byte[] ketQua = new byte[noiDungTepTin.Length];
                if(rbMaHoa.Checked)
                {
                    // Ma hoa tep tin
                    for(int i = 0; i < noiDungTepTin.Length; i++)
                    {
                        byte kyTuCanMa = noiDungTepTin[i];
                        byte kyTuKhoa = khoa[i];
                        int viTriKyTuCanMa = -1, viTriKyTuKhoa = -1;
                        for(int j = 0; j < 256; j++)
                            if(bangChuCai[j] == kyTuCanMa)
                            {
                                viTriKyTuCanMa = j;
                                break;
                            }
                        for(int j = 0; j < 256; j++)
                            if(bangChuCai[j] == kyTuKhoa)
                            {
                                viTriKyTuKhoa = j;
                                break;
                            }
                        ketQua[i] = bangTra[viTriKyTuKhoa, viTriKyTuCanMa];
                    }
                    // Luu ket qua vao tep tin
                    String ext = Path.GetExtension(tbDuongDan.Text);
                    SaveFileDialog sd = new SaveFileDialog();
                    sd.Filter = "File type (*" + ext + ") | *" + ext;
                    if(sd.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllBytes(sd.FileName, ketQua);
                    }
                }
                else
                {
                    // Giai ma tep tin
                    for (int i = 0; i < noiDungTepTin.Length; i++)
                    {
                        byte kyTuCanMa = noiDungTepTin[i];
                        byte kyTuKhoa = khoa[i];
                        int viTriKyTuCanMa = -1, viTriKyTuKhoa = -1;                        
                        for (int j = 0; j < 256; j++)
                            if (bangChuCai[j] == kyTuKhoa)
                            {
                                viTriKyTuKhoa = j;
                                break;
                            }
                        for (int j = 0; j < 256; j++)
                            if (bangTra[viTriKyTuKhoa, j] == kyTuCanMa)
                            {
                                viTriKyTuCanMa = j;
                                break;
                            }
                        ketQua[i] = bangChuCai[viTriKyTuCanMa];
                    }
                    // Luu ket qua vao tep tin
                    String ext = Path.GetExtension(tbDuongDan.Text);
                    SaveFileDialog sd = new SaveFileDialog();
                    sd.Filter = "File type (*" + ext + ") | *" + ext;
                    if (sd.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllBytes(sd.FileName, ketQua);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Tệp tin đang được sử dụng bởi chương trình khác, hãy đóng chương trình đang sử dụng tệp tin và thử lại.");
                return;
            }
        }
    }
}
