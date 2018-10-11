using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace MaHoaCSDL
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        String chuoiKN = "Data Source = .\\MSSQL; Initial Catalog = MaHoaDB; User Id = uDemo; Password = @M123456;";

        public DataTable Doc(String cauLenhSQL)
        {
            DataTable tb = new DataTable();
            SqlConnection con = new SqlConnection(chuoiKN);
            SqlCommand cmd = new SqlCommand(cauLenhSQL, con);

            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                tb.Load(dr, LoadOption.OverwriteChanges);
                con.Close();
                return tb;
            }
            catch
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                return null;
            }
        }

        public DataTable DangNhap(byte[] tenDN, byte[] matKhau)
        {
            String cauLenhSQL = "Select Id From tbNguoiDung Where TenDN=@TenDN and MatKhau=@MatKhau";
            DataTable tb = new DataTable();
            SqlConnection con = new SqlConnection(chuoiKN);
            SqlCommand cmd = new SqlCommand(cauLenhSQL, con);
            cmd.Parameters.Add("@TenDN", SqlDbType.Binary).Value = tenDN;
            cmd.Parameters.Add("@MatKhau", SqlDbType.Binary).Value = matKhau;
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                tb.Load(dr, LoadOption.OverwriteChanges);
                con.Close();
                return tb;
            }
            catch
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                return null;
            }
        }

        public int Ghi(String cauLenhSQL)
        {
            SqlConnection con = new SqlConnection(chuoiKN);
            SqlCommand cmd = new SqlCommand(cauLenhSQL, con);

            try
            {
                con.Open();
                int dem = cmd.ExecuteNonQuery();
                con.Close();
                return dem;
            }
            catch
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                return -1;
            }
        }

        public int Them(byte[] tenDN, byte[] matKhau)
        {
            String cauLenhSQL = "Insert into tbNguoiDung(TenDN, MatKhau) Values(@TenDN, @MatKhau)";
            SqlConnection con = new SqlConnection(chuoiKN);
            SqlCommand cmd = new SqlCommand(cauLenhSQL, con);
            cmd.Parameters.Add("@TenDN", SqlDbType.Binary).Value = tenDN;
            cmd.Parameters.Add("@MatKhau", SqlDbType.Binary).Value = matKhau;
            try
            {
                con.Open();
                int dem = cmd.ExecuteNonQuery();
                con.Close();
                return dem;
            }
            catch(SqlException e1)
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                MessageBox.Show(e1.ToString());
                return -1;
            }
        }

        String matKhau = "ksahajshghjasgd231246751261124";

        public byte[] MaHoa(String giaTriCanMa)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] key = md5.ComputeHash(Encoding.ASCII.GetBytes(matKhau));

            TripleDESCryptoServiceProvider trip = new TripleDESCryptoServiceProvider();
            trip.Key = key;
            trip.Mode = CipherMode.ECB;
            trip.Padding = PaddingMode.PKCS7;

            ICryptoTransform trans = trip.CreateEncryptor();
            byte[] ketQua = trans.TransformFinalBlock(Encoding.ASCII.GetBytes(giaTriCanMa), 0, giaTriCanMa.Length);
            return ketQua;
        }

        public String GiaiMa(byte[] giaTriCanMa)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] key = md5.ComputeHash(Encoding.ASCII.GetBytes(matKhau));

            TripleDESCryptoServiceProvider trip = new TripleDESCryptoServiceProvider();
            trip.Key = key;
            trip.Mode = CipherMode.ECB;
            trip.Padding = PaddingMode.PKCS7;

            ICryptoTransform trans = trip.CreateDecryptor();
            byte[] ketQua = trans.TransformFinalBlock(giaTriCanMa, 0, giaTriCanMa.Length);
            return Encoding.ASCII.GetString(ketQua);
        }

        private void btDangKy_Click(object sender, EventArgs e)
        {
            byte[] tenDN = MaHoa(tbTenDN.Text);
            byte[] matKhau = MaHoa(tbMatKhau.Text);
            int dem = Them(tenDN, matKhau);
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            byte[] tenDN = MaHoa(tbUsername.Text);
            byte[] matKhau = MaHoa(tbPassword.Text);
            DataTable tb = DangNhap(tenDN, matKhau);
            if (tb != null && tb.Rows.Count > 0)
                MessageBox.Show("Đăng nhập thành công");
            else
                MessageBox.Show("Đăng nhập thất bại. Bạn hãy kiểm tra lại tên đăng nhập hoặc mật khẩu.");
        }
    }
}
