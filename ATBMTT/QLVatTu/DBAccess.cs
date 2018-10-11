using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLVatTu
{
    public class DBAccess
    {
        String chuoiKN = "Data Source=.\\MSSQL; Initial Catalog = MaHoaDB; User Id=udemo; Password=12345678;";

        public DataTable Doc(String cauLenh)
        {
            DataTable tb = new DataTable();
            SqlConnection con = new SqlConnection(chuoiKN);
            SqlCommand cmd = new SqlCommand(cauLenh, con);

            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                tb.Load(dr, LoadOption.OverwriteChanges);
                con.Close();
                if (tb != null && tb.Rows.Count > 0)
                    return tb;
                else
                    return null;
            }
            catch
            {
                return null;
            }
        }

        public int Ghi(String cauLenh)
        {
            SqlConnection con = new SqlConnection(chuoiKN);
            SqlCommand cmd = new SqlCommand(cauLenh, con);

            try
            {
                con.Open();
                int dem = cmd.ExecuteNonQuery();
                con.Close();
                return dem;
            }
            catch
            {
                return -1;
            }
        }

        public int Insert(byte[] ten, byte[] anh, String ngayNhap, byte dangSuDung, String maCode, String giaNhap, int donViSuDungID)
        {
            String cauLenh = "Insert into tbVatTu(Ten, NgayNhap, DangSuDung, MaCode, GiaNhap, Anh, DonViSuDungID) Values("
                + "@Ten, '" 
                + ngayNhap + "'," 
                + dangSuDung + ", '" 
                + maCode + "', " 
                + giaNhap 
                + ", @Anh, " 
                + donViSuDungID 
                + ")";
            SqlConnection con = new SqlConnection(chuoiKN);
            SqlCommand cmd = new SqlCommand(cauLenh, con);
            cmd.Parameters.Add("@Ten", SqlDbType.Binary).Value = ten;
            cmd.Parameters.Add("@Anh", SqlDbType.Image).Value = anh;

            try
            {
                con.Open();
                int dem = cmd.ExecuteNonQuery();
                con.Close();
                return dem;
            }
            catch
            {
                return -1;
            }
        }

        public int Update(byte[] ten, byte[] anh, String ngayNhap, byte dangSuDung, String maCode, String giaNhap, int donViSuDungID, int id)
        {
            String cauLenh = "Update tbVatTu Set Ten="
                + "@Ten, NgayNhap= '"
                + ngayNhap + "', DangSuDung="
                + dangSuDung + ", MaCode='"
                + maCode + "', GiaNhap="
                + giaNhap
                + ", Anh = @Anh, DonViSuDungID="
                + donViSuDungID
                + " Where ID=" + id;
            SqlConnection con = new SqlConnection(chuoiKN);
            SqlCommand cmd = new SqlCommand(cauLenh, con);
            cmd.Parameters.Add("@Ten", SqlDbType.Binary).Value = ten;
            cmd.Parameters.Add("@Anh", SqlDbType.Image).Value = anh;

            try
            {
                con.Open();
                int dem = cmd.ExecuteNonQuery();
                con.Close();
                return dem;
            }
            catch
            {
                return -1;
            }
        }

    }
}
