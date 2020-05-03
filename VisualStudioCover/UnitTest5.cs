using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VisualStudioCover
{
    [TestClass]
    public class UnitTest5
    {
        public int intA, intB, intC, intD;
        public float flA, flB, flC, flD;
        public double dblA, dblB, dblC, dblD;
        public char chA, chB, chC, chD;
        public string strA, strB, strC, strD;
        public Faktorial Fak = new Faktorial();
/*==================================================================================*/
        [TestMethod]
        public void factorial_Test1()
        {
            intA = -1;
            int result = Fak.factorial(intA);
            Assert.AreEqual(result, -1);
        }
/*==================================================================================*/
        [TestMethod]
        public void factorial_Test2()
        {
            intA = 1;
            int result = Fak.factorial(intA);
            Assert.AreEqual(result, 1);
        }
/*==================================================================================*/
    }
}
