using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ceasar
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

        int k = 5;

        private void btMaHoa_Click(object sender, EventArgs e)
        {
            // Kiem tra du lieu nhap vao
            if(tbDuLieuCanMaHoa.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập dữ liệu cần mã hóa");
                return;
            }

            // Ma hoa
            String duLieuCanMaHoa = tbDuLieuCanMaHoa.Text;
            String ketQuaMaHoa = "";

            // - Duyet tung ky tu trong doan van ban

            for (int i = 0; i < duLieuCanMaHoa.Length; i++)
            {
                char kyTuCanMa = duLieuCanMaHoa[i];
                int viTriKyTuCanMa = -1;
                
                // -- Tim vi tri cua ky tu trong bang chu cai
                for(int j = 0; j < bangChuCai.Length; j++)
                {
                    if(bangChuCai[j].Equals(kyTuCanMa))
                    {
                        viTriKyTuCanMa = j;
                        break;
                    }
                }

                // -- Kiem tra xem ky tu can ma co trong bang chu cai hay khong va ma hoa
                if(viTriKyTuCanMa == -1)
                {
                    ketQuaMaHoa += kyTuCanMa.ToString();
                }
                else
                {
                    int viTriMoi = (viTriKyTuCanMa + k) % bangChuCai.Length;
                    ketQuaMaHoa += bangChuCai[viTriMoi].ToString();
                }
            }

            // Hien thi ket qua ra giao dien
            tbDuLieuMaHoaDuoc.Text = ketQuaMaHoa;
        }
    }
}
