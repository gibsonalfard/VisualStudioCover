using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VisualStudioCover
{
    [TestClass]
    public class UnitTest1
    {
        public int intA, intB, intC, intD;
        public float flA, flB;
        public Sequence seq = new Sequence();

        [TestMethod]
        public void luasLimas_Test()
        {
            flA = 6;
            flB = 4;
            float result = seq.luasLimas(flA, flB);

            Assert.AreEqual(result, 84);
        }

        [TestMethod]
        public void persamaanLinear_Test()
        {
            intA = 7;
            int result = seq.persamaanLinear(intA);

            Assert.AreEqual(result, 17);
        }

        [TestMethod]
        public void addDetikWithJam_Test()
        {
            intA = 60;
            int result = seq.addDetikWithJam(intA, 1, 30, 30);

            Assert.AreEqual(result, 5490);
        }
    }
}
