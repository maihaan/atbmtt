using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MaHoaDonBang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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

        char[] khoa;

        private void btMaHoa_Click(object sender, EventArgs e)
        {
            // Kiem tra du lieu can ma hoa
            if(tbDuLieuCanMaHoa.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập dữ liệu cần mã hóa");
                tbDuLieuCanMaHoa.Focus();
                return;
            }

            // Duyet tung ky tu trong doan van ban can ma hoa
            String duLieuCanMaHoa = tbDuLieuCanMaHoa.Text;
            String ketQuaMaHoa = "";
            for(int i = 0; i < duLieuCanMaHoa.Length; i++)
            {
                char kyTuCanMa = duLieuCanMaHoa[i];
                // Ma hoa tung ky tu duoc duyet
                // - Tim vi tri cua ky tu trong bang chu cai
                int viTri = -1;
                for(int j = 0; j < bangChuCai.Length; j++)
                {
                    if(bangChuCai[j].Equals(kyTuCanMa))
                    {
                        viTri = j;
                        break;
                    }
                }
                // - Tra bang neu tim thay, khong tim thay thi giu nguyen
                if(viTri == -1)
                {
                    ketQuaMaHoa += kyTuCanMa;
                }
                else
                {
                    ketQuaMaHoa += khoa[viTri];
                }
            }
            // Hien thi ket qua ma hoa
            tbDuLieuMaHoaDuoc.Text = ketQuaMaHoa;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Sinh khoa bang cach lay ngau nhien cac phan tu tu bang chu cai vao khoa
            khoa = new char[bangChuCai.Length];
            ArrayList ds = new ArrayList();
            for (int i = 0; i < bangChuCai.Length; i++)
                ds.Add(bangChuCai[i]);
            Random rd = new Random();
            int dem = 0;
            while(ds.Count > 0)
            {
                int viTri = rd.Next(ds.Count - 1);
                khoa[dem] = ds[viTri].ToString()[0];
                ds.RemoveAt(viTri);
                dem++;
            }
        }

        private void btGiaiMa_Click(object sender, EventArgs e)
        {
            // Kiem tra du lieu can ma hoa
            if (tbDuLieuMaHoaDuoc.Text.Length == 0)
            {
                MessageBox.Show("Chưa có gì để giải mã");
                tbDuLieuCanMaHoa.Focus();
                return;
            }

            // Duyet tung ky tu trong doan van ban can ma hoa
            String duLieuCanGiaiMa = tbDuLieuMaHoaDuoc.Text;
            String ketQuaGiaiMa = "";
            for (int i = 0; i < tbDuLieuMaHoaDuoc.Text.Length; i++)
            {
                char kyTuCanMa = duLieuCanGiaiMa[i];
                // Ma hoa tung ky tu duoc duyet
                // - Tim vi tri cua ky tu trong khoa
                int viTri = -1;
                for (int j = 0; j < khoa.Length; j++)
                {
                    if (khoa[j].Equals(kyTuCanMa))
                    {
                        viTri = j;
                        break;
                    }
                }
                // - Tra bang chu cai neu tim thay, khong tim thay thi giu nguyen
                if (viTri == -1)
                {
                    ketQuaGiaiMa += kyTuCanMa;
                }
                else
                {
                    ketQuaGiaiMa += bangChuCai[viTri];
                }
            }
            // Hien thi ket qua ma hoa
            tbDuLieuGiaiMaDuoc.Text = ketQuaGiaiMa;
        }
    }
}
