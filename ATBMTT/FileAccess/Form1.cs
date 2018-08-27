using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FileAccess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] noiDungTep;
            
            OpenFileDialog od = new OpenFileDialog();
            if(od.ShowDialog() == DialogResult.OK)
            {
                // Doc toan bo noi dung tep vao mang byte
                noiDungTep = File.ReadAllBytes(od.FileName);

                // Xu ly ma hoa o day va dua noi dung da ma hoa vao mang noiDungDaMaHoa
                byte[] noiDungDaMaHoa = new byte[noiDungTep.Length];


                // Luu lai mang byte vao tep tin moi
                SaveFileDialog sd = new SaveFileDialog();
                String phanMoRongTepTin = Path.GetExtension(od.FileName);
                sd.Filter = "*" + phanMoRongTepTin + "| *" + phanMoRongTepTin;
                if(sd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(sd.FileName, noiDungDaMaHoa);
                }                
            }
        }
    }
}
