using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaHoaTepDonBang
{
    public class MaHoaGiaiMa
    {
        char[] BCC = new char[] {'a', 'h', 'm', 't', 'n', 'o', 'l', 'i', 'u', 'c', 's'
        , 'd', 'b', 'q', 'y', 'v', 'k', 'j', 'x', 'z', '1', '3', '5', '7', '9', '0', '2'
        , '4', '6', '8', '&', '@', '*', '-', '_', '=', 'A', 'H', 'N', 'M', 'P', 'O', 'E', 'e', 'f', 'K'
        , 'Y', 'B', 'D', 'C', 'V', 'X', 'S', 'Q', 'G', 'g'};

        char[,] bangTra;
        public String Khoa { get; set; }

        public MaHoaGiaiMa()
        {
            int kichThuoc = BCC.Length;
            bangTra = new char[kichThuoc, kichThuoc];
            for (int x = 0; x < kichThuoc; x++)
                for (int y = 0; y < kichThuoc; y++)
                    bangTra[x, y] = BCC[(x + y) % kichThuoc];
        }

        private String SinhKhoa(int doDai)
        {
            Random r = new Random();
            String khoa = "";
            for (int i = 0; i < doDai; i++)
                khoa += BCC[r.Next(BCC.Length - 1)];
            return khoa;
        }

        private char TraCuuXuoi(char tuMa, char tuKhoa)
        {
            if (!BCC.Contains(tuMa))
                return tuMa;

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
                if (bangTra[i, viTriTuMa].Equals(tuKhoa))
                {
                    viTriTuKhoa = i;
                    break;
                }

            // Tra ve ket qua
            return BCC[viTriTuKhoa];
        }

        private char TraCuuNguoc(char tuMa, char tuKhoa)
        {
            if (!BCC.Contains(tuMa))
                return tuMa;

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

        public String MaHoa(String giaTriCanMaHoa)
        {
            Khoa = SinhKhoa(giaTriCanMaHoa.Length);
            String ketQua = "";
            for (int i = 0; i < giaTriCanMaHoa.Length; i++)
            {
                ketQua += TraCuuXuoi(giaTriCanMaHoa[i], Khoa[i]);
            }
            return ketQua;
        }

        public String GiaiMa(String giaTriCanGiaiMa)
        {
            if (Khoa.Length != giaTriCanGiaiMa.Length)
                return null;

            String ketQua = "";
            for (int i = 0; i < giaTriCanGiaiMa.Length; i++)
            {
                ketQua += TraCuuXuoi(giaTriCanGiaiMa[i], Khoa[i]);
            }
            return ketQua;
        }
    }
}
