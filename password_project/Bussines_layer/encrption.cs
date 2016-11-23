using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace password_project.Bussines_layer
{
    class encrption
    {
        public string EncodeHex(string stre)
        {
        string    cres = "";
            foreach (char t in stre)
            {
                Int32 t1 = Convert.ToInt32(t);
                string hexValue = t1.ToString("X");
                cres = cres + hexValue;

            }

            return cres;
        }
        public string DecodeHex(string strd)
        {
           string  cres = "";
            string txt;
            try
            {
                for (int i = 0; i < strd.Length; i += 2)
                {
                    txt = (strd.Substring(i, 2));
                    int num = int.Parse(txt, System.Globalization.NumberStyles.HexNumber);
                    char txt1 = Convert.ToChar(num);
                    cres = cres + txt1;
                }


                return cres;
            }
            catch (System.Exception)
            {
                cres = "Error: txt is not in hex format";
                return cres;
            }
        }

        

    }
}
