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
            int doDaiMatKhau = tbDuLieuCanMaHoa.Text.Length;
            for (int i = 0; i < doDaiMatKhau; i++)
                khoa += matKhau[i % doDaiMatKhau];

            // 
        }

        private void btGiaiMa_Click(object sender, EventArgs e)
        {

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
