using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VisualStudioCover
{
    [TestClass]
    public class UnitTest6
    {
        public int intA, intB, intC, intD;
        public float flA, flB, flC, flD;
        public double dblA, dblB, dblC, dblD;
        public char chA, chB, chC, chD;
        public string strA, strB, strC, strD;
        public ValidasiHoles ValHol = new ValidasiHoles();
/*==================================================================================*/
        [TestMethod]
        public void countHoles_Test()
        {
            strA = "A";
            ValHol.countHoles(strA);
        }
/*==================================================================================*/
        [TestMethod]
        public void countHoles_Test1()
        {
            strA = "B";
            ValHol.countHoles(strA);
        }
/*==================================================================================*/
        [TestMethod]
        public void getJumlahLubang_Test()
        {
            ValHol.jumlahLubang = 1;
            int result = ValHol.getJumlahLubang();
            Assert.AreEqual(result, 1);
        }
/*==================================================================================*/
    }
}
