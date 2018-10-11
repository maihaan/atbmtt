using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLVatTu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DocDanhSachVatTu();
            DocDanhSachDVSD();
        }

        private void DocDanhSachVatTu()
        {
            DBAccess dba = new QLVatTu.DBAccess();
            DataTable tb = dba.Doc("Select * From tbVatTu");
            if (tb != null)
            {
                DataTable tb1 = new DataTable();
                tb1.Columns.Add("ID", typeof(int));
                tb1.Columns.Add("Ten", typeof(String));
                tb1.Columns.Add("NgayNhap", typeof(DateTime));
                tb1.Columns.Add("DangSuDung", typeof(Boolean));
                tb1.Columns.Add("MaCode", typeof(String));
                tb1.Columns.Add("GiaNhap", typeof(float));
                tb1.Columns.Add("Anh", typeof(Image));
                tb1.Columns.Add("DonViSuDungID", typeof(int));

                MD5 md5 = new MD5();
                foreach (DataRow r in tb.Rows)
                {
                    DataRow r1 = tb1.NewRow();
                    r1["ID"] = r["ID"];
                    r1["Ten"] = md5.GiaiMa((byte[])r["Ten"]).Replace("#", " ");
                    r1["NgayNhap"] = r["NgayNhap"];
                    r1["DangSuDung"] = r["DangSuDung"];
                    r1["MaCode"] = r["MaCode"];
                    r1["GiaNhap"] = r["GiaNhap"];
                    r1["Anh"] = Image.FromStream(new System.IO.MemoryStream((byte[])r["Anh"]));
                    r1["DonViSuDungID"] = r["DonViSuDungID"];
                    tb1.Rows.Add(r1);
                }

                dgvDanhSach.DataSource = tb1;
            }
            else
                dgvDanhSach.DataSource = null;

            tbTen.Text = "";
            cbDangSD.Checked = false;
            tbMaCode.Text = "";
            tbGiaNhap.Text = "";
            pbAnh.ImageLocation = "";
            tbTen.Focus();
        }

        private void DocDanhSachDVSD()
        {
            DBAccess dba = new QLVatTu.DBAccess();
            DataTable tb = dba.Doc("Select * From tbDonVi");
            if (tb != null)
            {
                cbDonVi.DataSource = tb;
                cbDonVi.DisplayMember = "Ten";
                cbDonVi.ValueMember = "ID";
            }
            else
                cbDonVi.Items.Clear();
        }

        private void pbAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Image files (*.png; *.jpg; *.bmp; *.gif) | *.png; *.jpg; *.bmp; *.gif";
            if (od.ShowDialog() == DialogResult.OK)
                pbAnh.ImageLocation = od.FileName;
        }

        private void btThemMoi_Click(object sender, EventArgs e)
        {
            // Kiem tra du lieu nhap vao da dung chua

            MD5 md5 = new QLVatTu.MD5();
            String ten = tbTen.Text;
            byte[] bTen = md5.MaHoa(ten.Replace(" ", "#"));

            String ngayNhap = tbNgayNhap.Value.ToShortDateString();

            byte dangSuDung = 0;
            if (cbDangSD.Checked)
                dangSuDung = 1;

            String maCode = tbMaCode.Text.Trim();

            String giaNhap = tbGiaNhap.Text.Trim();

            byte[] anh = System.IO.File.ReadAllBytes(pbAnh.ImageLocation);

            int donViSuDungID = int.Parse(cbDonVi.SelectedValue.ToString());

            DBAccess dba = new DBAccess();
            int dem = dba.Insert(bTen, anh, ngayNhap, dangSuDung, maCode, giaNhap, donViSuDungID);
            if (dem == 1)
                DocDanhSachVatTu();
            else
            {
                MessageBox.Show("Kiểm tra lại thông tin nhập vào");
            }
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvDanhSach.SelectedRows.Count > 0)
            {
                tbTen.Text = dgvDanhSach.SelectedRows[0].Cells["Ten"].Value.ToString();
                if (dgvDanhSach.SelectedRows[0].Cells["DangSuDung"].Value.ToString().ToLower().Equals("true"))
                    cbDangSD.Checked = true;
                else
                    cbDangSD.Checked = false;
                tbNgayNhap.Value = DateTime.Parse(dgvDanhSach.SelectedRows[0].Cells["NgayNhap"].Value.ToString());
                tbMaCode.Text = dgvDanhSach.SelectedRows[0].Cells["MaCode"].Value.ToString();
                tbGiaNhap.Text = dgvDanhSach.SelectedRows[0].Cells["GiaNhap"].Value.ToString();
                cbDonVi.SelectedValue = dgvDanhSach.SelectedRows[0].Cells["DonViSuDungID"].Value.ToString();
                pbAnh.Image = (Image)dgvDanhSach.SelectedRows[0].Cells["Anh"].Value;
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            // Kiem tra du lieu nhap vao da dung chua

            MD5 md5 = new QLVatTu.MD5();
            String ten = tbTen.Text;
            byte[] bTen = md5.MaHoa(ten.Replace(" ", "#"));

            String ngayNhap = tbNgayNhap.Value.ToShortDateString();

            byte dangSuDung = 0;
            if (cbDangSD.Checked)
                dangSuDung = 1;

            String maCode = tbMaCode.Text.Trim();

            String giaNhap = tbGiaNhap.Text.Trim();

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pbAnh.Image.Save(ms, pbAnh.Image.RawFormat);
            byte[] anh = ms.ToArray();

            int donViSuDungID = int.Parse(cbDonVi.SelectedValue.ToString());

            int id = int.Parse(dgvDanhSach.SelectedRows[0].Cells["ID"].Value.ToString());

            DBAccess dba = new DBAccess();

            int dem = dba.Update(bTen, anh, ngayNhap, dangSuDung, maCode, giaNhap, donViSuDungID, id);
            if (dem == 1)
                DocDanhSachVatTu();
            else
            {
                MessageBox.Show("Kiểm tra lại thông tin nhập vào");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvDanhSach.SelectedRows[0].Cells["ID"].Value.ToString());
            DBAccess dba = new QLVatTu.DBAccess();
            dba.Ghi("Delete tbVatTu Where ID = " + id.ToString());
            DocDanhSachVatTu();    
        }
    }
}
