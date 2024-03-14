using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302223118
{
    public class KodeBuah
    {
        public enum NamaBuah
        {
            Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung
        }

        public string GetKodeBuah(NamaBuah namaBuah)
        {
            String[] kodeBuah =
            {
                "A00", //apel
                "B00", //aprikot
                "C00", //alpukat
                "D00", //Pisang
                "E00", //Paprika
                "F00", //Blackberry
                "H00", //Ceri
                "I00", //kelapa
                "J00", //jagung
            };
            int index = (int)namaBuah;
            if (index >= 0 && index < kodeBuah.Length)
            {
                return kodeBuah[index];
            }
            return "Kode Buah Tidak Ditemukan";
        }
    }
}
