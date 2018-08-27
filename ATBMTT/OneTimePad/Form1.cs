using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OneTimePad
{
    public partial class Form1 : Form
    {
        // Bang chu cai
        char[] bangChuCai = new char[]
        {
            'a', 'b', 'c', 'd', 'e', 'f', 'g','h', 'i', 'j',
            'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',
            'u', 'v', 'w', 'x', 'y','z', ' ', '1', '2', '3', '4',
            '5', '6', '7', '8', '9', '0', '@', '#', '$', '%', '^',
            '&', '*', '(', ')','_','-', '=', '+','>', '<', '?','/',
            '\\','{', '}','[',']','ê', 'â', 'ơ', 'ư','ô','ă'
        };

        char[,] bangTra;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Khoi tao bang tra
            bangTra = new char[bangChuCai.Length, bangChuCai.Length];
            for (int i = 0; i < bangChuCai.Length; i++)
            {
                for (int j = 0; j < bangChuCai.Length; j++)
                {
                    bangTra[i, j] = bangChuCai[(i + j) % bangChuCai.Length];
                }
            }
        }

        private void btMaHoa_Click(object sender, EventArgs e)
        {
            String khoa = "";
            // Sinh khoa ngau nhien co do dai bang do dai cua du lieu can ma hoa tu bang chu cai
            // - Nhặt ngẫu nhiên các ký tự từ bảng chữ cái và cho vào khóa cho đến khi chiều dài của
            // khóa bằng chiều dài của dữ liệu cần mã hóa.
            //for(int i = 0; i < tbDuLieuCanMaHoa.Text.Length; i++)
            //{
            //    Random r = new Random();
            //    khoa += bangChuCai[r.Next(bangChuCai.Length - 1)];
            //}
            Random r = new Random();
            while (khoa.Length < tbDuLieuCanMaHoa.Text.Length)
            {                
                khoa += bangChuCai[r.Next(bangChuCai.Length - 1)];
            }
            int doDaiKhoa = tbDuLieuCanMaHoa.Text.Length;            

            // Mã hóa dữ liệu
            String duLieuCanMaHoa = tbDuLieuCanMaHoa.Text;
            String ketQuaMaHoa = "";
            for (int i = 0; i < duLieuCanMaHoa.Length; i++)
            {
                Char kyTuCanMa = duLieuCanMaHoa[i];
                Char kyTuKhoa = khoa[i];
                // Quy tac ma hoa: kyTuCanMa dung de tra theo cot, kyTuKhoa: dung de tra theo hang
                int viTriKyTu = -1, viTriKhoa = -1;
                // Tim vi tri cua ky tu can ma va ky tu khoa trong bang chu cai
                for (int j = 0; j < bangChuCai.Length; j++)
                {
                    if (bangChuCai[j].Equals(kyTuCanMa))
                    {
                        viTriKyTu = j;
                        break;
                    }
                }
                for (int j = 0; j < bangChuCai.Length; j++)
                {
                    if (bangChuCai[j].Equals(kyTuKhoa))
                    {
                        viTriKhoa = j;
                        break;
                    }
                }
                if (viTriKyTu != -1 && viTriKhoa != -1)
                {
                    ketQuaMaHoa += bangTra[viTriKhoa, viTriKyTu];
                }
                else
                    ketQuaMaHoa += kyTuCanMa;
            }
            String ketQuaHienThi = "";
            for(int i = 0; i < ketQuaMaHoa.Length; i++)
            {
                ketQuaHienThi += ketQuaMaHoa[i].ToString() + khoa[i].ToString();
            }
            tbDuLieuMaHoaDuoc.Text = ketQuaHienThi;
        }
    }
}
