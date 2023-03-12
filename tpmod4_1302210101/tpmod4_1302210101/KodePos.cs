using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmod4_1302210101
{
    internal class KodePos
    {
        public enum Kelurahan { 
            Batunuggal,
            Kujangsari,
            Mengger,
            Wates,
            Cijaura,
            Jatisari,
            Margasari,
            Sekejati,
            Kebonwareu,
            Maleer,
            Samoja
        }


        public int getKodePos(Kelurahan Kel) {
            int[] Kode = {
            40266,
            40287,
            40267,
            40256,
            40287,
            40286,
            40286,
            40286,
            40272,
            40274,
            40273
            };

            return Kode[(int) Kel];
        }

    }
}
