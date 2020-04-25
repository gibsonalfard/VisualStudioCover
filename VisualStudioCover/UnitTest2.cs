using System;
using System.Security.Permissions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VisualStudioCover
{
    [TestClass]
    public class UnitTest2
    {
        public int intA, intB, intC, intD;
        public float flA, flB, flC, flD;
        public double dblA, dblB, dblC, dblD;
        public Selection sel = new Selection();
        int result;

        [TestMethod]
        public void cariMax3Bil_05_Test()
        {
            intA = 1;
            intB = 0;
            intC = -1;
            int result = sel.cariMax3Bil_05(intA, intB, intC);

            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void hitNilaiMutu_06_Test() /* belum beres, belum tau equal untuk output char */
        {
            dblA = 100;
            dblB = 100;
            dblC = 100;
            intA = 14;

            char result = sel.hitNilaiMutu06(dblA, dblB, dblC, intA);

            Assert.AreEqual(result, );
        }

        [TestMethod]
        public void getUpah_063_Test()
        {
            intA = 7;
            intB = 8;

            int result = sel.hitNilaiMutu06(intA, intB);

            Assert.AreEqual(result, 2000);
        }

        [TestMethod]
        public void menentukanBilGanjil_064_Test()
        {
            intA = 3;

            /*belum selesai, tidak tahu bagaimana output untuk console.writeline */
        }

        [TestMethod]
        public void getDayFromNumber07_Test()
        {
            intA = 7;

            /*belum selesai, tidak tahu bagaimana output untuk string*/
        }

        [TestMethod]
    }
}
