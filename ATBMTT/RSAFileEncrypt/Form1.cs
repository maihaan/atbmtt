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

namespace RSAFileEncrypt
{
    public partial class Form1 : Form
    {
        String rsaPublicKeyFile = "";
        String rsaPrivateKeyFile = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btEn_Click(object sender, EventArgs e)
        {
            String[] gui = File.ReadAllLines("Interface.txt");
            rbMaHoa.Text = gui[0].Split('\t')[1].ToString();
            rbGiaiMa.Text = gui[1].Split('\t')[1].ToString();
            lbChonTepTin.Text = gui[2].Split('\t')[1].ToString();
            btTim.Text = gui[3].Split('\t')[1].ToString();
            btThucHien.Text = gui[4].Split('\t')[1].ToString();
        }

        private void btVi_Click(object sender, EventArgs e)
        {
            String[] gui = File.ReadAllLines("Interface.txt");
            rbMaHoa.Text = gui[0].Split('\t')[0].ToString();
            rbGiaiMa.Text = gui[1].Split('\t')[0].ToString();
            lbChonTepTin.Text = gui[2].Split('\t')[0].ToString();
            btTim.Text = gui[3].Split('\t')[0].ToString();
            btThucHien.Text = gui[4].Split('\t')[0].ToString();
        }

        private void rbMaHoa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMaHoa.Checked)
                rbGiaiMa.Checked = false;
        }

        private void rbGiaiMa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGiaiMa.Checked)
                rbMaHoa.Checked = false;
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Multiselect = false;
            if(od.ShowDialog() == DialogResult.OK)
            {
                tbDuongDan.Text = od.FileName;

                OpenFileDialog od1 = new OpenFileDialog();
                od1.Multiselect = false;
                if (rbMaHoa.Checked)
                    od1.Filter = "RSA public key file (*.rsapl) | *.rsapl";
                if(rbGiaiMa.Checked)
                    od1.Filter = "RSA private key file (*.rsapv) | *.rsapv";
                if (od1.ShowDialog() == DialogResult.OK)
                {
                    if(rbMaHoa.Checked)
                        rsaPublicKeyFile = od1.FileName;
                    if (rbGiaiMa.Checked)
                        rsaPrivateKeyFile = od1.FileName;
                }
            }
        }
    }
}
