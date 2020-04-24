using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudioCover
{
    class ValidasiHoles
    {
        private int jumlahLubang;

        public void countHoles(String sentence)
        {
            int i;
            for (i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == 'A' || sentence[i] == 'D' ||
                  sentence[i] == 'O' || sentence[i] == 'P' ||
                  sentence[i] == 'Q' || sentence[i] == 'R')
                {
                    jumlahLubang = jumlahLubang + 1;
                }
                else if (sentence[i] == 'B')
                {
                    /* lubang di huruf B ada dua, 
                        perlu treatment khusus :) */
                    jumlahLubang = jumlahLubang + 2;
                }
            }
        }

        public int getJumlahLubang()
        {
            return jumlahLubang;
        }
    }
}
