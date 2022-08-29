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

namespace MaHoaTepDonBang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbMaHoa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMaHoa.Checked)
            {
                rbGiaiMa.Checked = false;
                tbDuongDan.Text = "";
            }   
        }

        private void rbGiaiMa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGiaiMa.Checked)
            {
                rbMaHoa.Checked = false;
                tbDuongDan.Text = "";
            }
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Multiselect = false;
            // od.Filter = "Word documents (*.doc, *.docx) | *.doc,*.docx";
            if(od.ShowDialog() == DialogResult.OK)
            {
                tbDuongDan.Text = od.FileName;
            }
        }

        private void btThucHien_Click(object sender, EventArgs e)
        {
            // Kiem tra du lieu dau vao
            if (String.IsNullOrEmpty(tbDuongDan.Text))
            {
                MessageBox.Show("Bạn phải chọn tệp tin");
                btTim.Focus();
                return;
            }

            if (String.IsNullOrEmpty(tbMatKhau.Text))
            {
                MessageBox.Show("Bạn phải nhập Mật khẩu");
                tbMatKhau.Focus();
                return;
            }

            // Thuc hien cong viec
            try
            {
                byte[] noiDungTep = File.ReadAllBytes(tbDuongDan.Text);
                DonBangED ed = new DonBangED();
                byte[] ketQua;
                if (rbMaHoa.Checked)
                    ketQua = ed.MaHoa(noiDungTep, tbMatKhau.Text.Trim());
                else
                    ketQua = ed.GiaiMa(noiDungTep, tbMatKhau.Text.Trim());

                // Lưu kết quả
                SaveFileDialog sd = new SaveFileDialog();
                String ext = Path.GetExtension(tbDuongDan.Text);
                sd.Filter = "*" + ext + " | *" + ext;
                if(sd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(sd.FileName, ketQua);
                }    
            }
            catch
            {
                MessageBox.Show("Không đọc được tệp tin do tệp đang được chương trình khác sử dụng.");
                return;
            }
        }
    }
}
