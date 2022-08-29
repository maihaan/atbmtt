using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaHoaTepDonBang
{
    public class DonBangED
    {
        byte[] BCC;
        byte[,] bangTra;
        byte[] Khoa;
        public String MatKhau { get; set; }
        public DonBangED()
        {
            // Khởi tạo bảng chữ cái
            BCC = new byte[256];
            for (int i = 0; i < 256; i++)
                BCC[i] = (byte)i;

            // Khởi tạo bảng tra
            int kichThuoc = BCC.Length;
            bangTra = new byte[kichThuoc,kichThuoc];
            for (int x = 0; x < kichThuoc; x++)
                for (int y = 0; y < kichThuoc; y++)
                    bangTra[x, y] = BCC[(x + y) % kichThuoc];
        }

        private void SinhKhoa(int doDai)
        {
            byte[] bMatKhau = Encoding.UTF8.GetBytes(MatKhau);
            Khoa = new byte[doDai];
            for (int i = 0; i < doDai; i++)
                Khoa[i] = bMatKhau[i % bMatKhau.Length];
        }

        private byte TraCuuXuoi(byte tuMa, byte tuKhoa)
        {
            // Tim vi tri của tuMa trong BCC
            int viTriTuMa = 0;
            for(int i = 0; i < BCC.Length; i++)
                if(BCC[i].Equals(tuMa))
                {
                    viTriTuMa = i;
                    break;
                }

            // Tim xem tuKhoa xuat hien o vi tri nao trong cot viTriTuMa cua bang tra
            int viTriTuKhoa = 0;
            for(int i = 0; i < BCC.Length; i++)
                if(bangTra[i, viTriTuMa].Equals(tuKhoa))
                {
                    viTriTuKhoa = i;
                    break;
                }

            // Tra ve ket qua
            return BCC[viTriTuKhoa];
        }

        private byte TraCuuNguoc(byte tuMa, byte tuKhoa)
        {
            // Tim vi tri của tuMa trong BCC
            int viTriTuMa = 0;
            for (int i = 0; i < BCC.Length; i++)
                if (BCC[i].Equals(tuMa))
                {
                    viTriTuMa = i;
                    break;
                }

            // Tim xem tuKhoa xuat hien o vi tri nao trong cot viTriTuMa cua bang tra
            int viTriTuKhoa = 0;
            for (int i = 0; i < BCC.Length; i++)
                if (bangTra[viTriTuMa, i].Equals(tuKhoa))
                {
                    viTriTuKhoa = i;
                    break;
                }

            // Tra ve ket qua
            return BCC[viTriTuKhoa];
        }

        public byte[] MaHoa(byte[] giaTriCanMaHoa, String matKhau)
        {
            MatKhau = matKhau;
            SinhKhoa(giaTriCanMaHoa.Length);
            List<byte> ketQua = new List<byte>();
            for(int i = 0; i < giaTriCanMaHoa.Length; i++)
            {
                ketQua.Add(TraCuuXuoi(giaTriCanMaHoa[i], Khoa[i]));
            }
            return ketQua.ToArray();
        }

        public byte[] GiaiMa(byte[] giaTriCanGiaiMa, String matKhau)
        {
            MatKhau = matKhau;
            SinhKhoa(giaTriCanGiaiMa.Length);
            List<byte> ketQua = new List<byte>();
            for (int i = 0; i < giaTriCanGiaiMa.Length; i++)
            {
                ketQua.Add(TraCuuXuoi(giaTriCanGiaiMa[i], Khoa[i]));
            }
            return ketQua.ToArray();
        }
    }
}
