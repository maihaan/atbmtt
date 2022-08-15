using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cecar
{
    public partial class Form1 : Form
    {
        


        public Form1()
        {
            InitializeComponent();
        }

        private void btMaHoa_Click(object sender, EventArgs e)
        {
            // Kiem tra du lieu dau vao
            if(String.IsNullOrEmpty(tbGiaTriCanMaHoa.Text))
            {
                MessageBox.Show("Bạn phải nhập dữ liệu cần mã hóa", "Thông báo");
                return;
            }
            String giaTriCanMa = tbGiaTriCanMaHoa.Text.Trim();
            int hsK = (int)nudHeSoK.Value;

            // Ma hoa
            CecarED c = new CecarED();
            String ketQua = c.Encrypt(giaTriCanMa, hsK);

            // Hien thi ket qua
            tbKetQuaMaHoa.Text = ketQua;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CecarED c = new CecarED();
            nudHeSoK.Maximum = c.BCC.Length - 1;
        }
    }
}
