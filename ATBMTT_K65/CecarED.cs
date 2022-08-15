using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cecar
{
    public class CecarED
    {
        public String[] BCC = new string[] { "a", "d", "b", "h", "m", "i", "z", "c", "e", "o" };

        public String Encrypt(String value, int k)
        {
            String result = "";
            foreach(Char s in value)
            {
                int viTri = -1;
                for(int i = 0; i < BCC.Length; i++)
                {
                    if(BCC[i].Equals(s.ToString()))
                    {
                        viTri = i;
                        break;
                    }    
                }
                if (viTri == -1)
                    result += s;
                else
                {
                    viTri = (viTri + k) % BCC.Length;
                    result += BCC[viTri];
                }    
            }
            return result;
        }

        public String Decrypt(String value, int k)
        {
            String result = "";
            foreach (Char s in value)
            {
                int viTri = -1;
                for (int i = 0; i < BCC.Length; i++)
                {
                    if (BCC[i].Equals(s.ToString()))
                    {
                        viTri = i;
                        break;
                    }
                }
                if (viTri == -1)
                    result += s;
                else
                {
                    viTri = (viTri - k);
                    if (viTri < 0)
                        viTri = viTri + BCC.Length;
                    result += BCC[viTri];
                }
            }
            return result;
        }
    }
}
