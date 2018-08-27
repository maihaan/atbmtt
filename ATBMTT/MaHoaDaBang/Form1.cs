using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MaHoaDaBang
{
    public partial class Form1 : Form
    {
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

        private void btMaHoa_Click(object sender, EventArgs e)
        {
            // Kiem tra du lieu dau vao

            // Sinh khoa tu mat khau
            String matKhau = tbMatKhau.Text.Trim();
            String khoa = "";
            int doDaiKhoa = tbDuLieuCanMaHoa.Text.Length;
            for (int i = 0; i < doDaiKhoa; i++)
                khoa += matKhau[i % matKhau.Length];

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
            tbDuLieuMaHoaDuoc.Text = ketQuaMaHoa;
        }


        private void btGiaiMa_Click(object sender, EventArgs e)
        {
            // Giai ma: KyTuDaMaHoa: dung de tra theo cot, kyTuKhoa: dung de tra theo hang

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Khoi tao bang tra
            bangTra = new char[bangChuCai.Length, bangChuCai.Length];
            for(int i = 0; i < bangChuCai.Length; i++)
            {
                for(int j = 0; j < bangChuCai.Length; j++)
                {
                    bangTra[i, j] = bangChuCai[(i + j) % bangChuCai.Length];
                }
            }
        }
    }
}
