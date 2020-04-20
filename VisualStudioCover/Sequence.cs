using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudioCover
{
    public class Sequence
    {
        public float luasLimas(float sisiAlas, float tinggiMiring)
        {
            /* Case Sequence 1/2*/
            float luas;
            luas = (sisiAlas * sisiAlas) + (4 * (sisiAlas * tinggiMiring / 2));
            return luas;
        }

        public int persamaanLinear(int x)
        {
            /* Case Sequence 1/2*/
            int y;
            y = 3 * x - 4;
            return y;
        }

        public int addDetikWithJam(int detik, int hour, int minute, int second)
        {
            /* Case Sequence 1/2*/
            int s;

            s = (hour * 3600) + (minute * 60) + second;
            detik = detik + s;
            return detik;
        }

        public int sisaTukarNominalPec1Kdgn50K10K5K(int nominalUang)
        {
            int pec50K, pec10K, pec5K, pec1K;

            pec50K = nominalUang / 50000;
            pec10K = (nominalUang % 50000) / 10000;
            pec5K = ((nominalUang % 50000) % 10000) / 5000;
            pec1K = (((nominalUang % 50000) % 10000) % 5000) / 1000;
            return pec1K;
        }

        public boolean isYearKabisat(int idxMonth, int year)
        {
            boolean isKabisat;

            isKabisat = ((year % 4 == 0) && (year % 100 > 0)) || (year % 400 == 0);
            return isKabisat;
        }

        public boolean isPointOrigin(int x, int y)
        {
            boolean isOrigin;

            isOrigin = (x == 0) && (y == 0);
            return isOrigin;
        }

        public boolean isPointKuadran1(int x, int y)
        {
            boolean isKuadran1;

            isKuadran1 = (x > 0) && (y > 0);
            return isKuadran1;
        }

        public boolean isPointKuadran2(int x, int y)
        {
            boolean isKuadran2;

            isKuadran2 = (x < 0) && (y > 0);
            return isKuadran2;
        }

        public boolean isPointKuadran3(int x, int y)
        {
            boolean isKuadran3;

            isKuadran3 = (x < 0) && (y < 0);
            return isKuadran3;
        }

        public boolean isPointKuadran4(int x, int y)
        {
            boolean isPointKuadran4;

            isPointKuadran4 = (x > 0) && !(y >= 0);
            return isPointKuadran4;
        }

        public boolean isPointNotOrigin(int x, int y)
        {
            boolean isNotOrigin;

            isNotOrigin = (x != 0) || (y != 0);
            return isNotOrigin;
        }

        public boolean isSuhuPadat(int suhu)
        {
            boolean isPadat;

            isPadat = (suhu >= 0 && suhu <= 100);
            return isPadat;
        }

        public boolean isSuhuCair(int suhu)
        {
            boolean isCair;

            isCair = (suhu <= 0);
            return isCair;
        }

        public boolean isSuhuUap(int suhu)
        {
            boolean isUap;

            isUap = (suhu >= 100);
            return isUap;
        }
    }
}
