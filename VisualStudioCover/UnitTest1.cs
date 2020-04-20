using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VisualStudioCover
{
    [TestClass]
    public class UnitTest1
    {
        public int varA, varB;
        public Sequence seq = new Sequence();

        [TestMethod]
        public void TestSeq1()
        {
            varA = 6;
            int result = seq.seq1(varA);

            Assert.AreEqual(result, 13);
        }

        [TestMethod]
        public void TestSeq2()
        {
            varA = 4; varB = 3;
            int result = seq.seq2(varA, varB);

            Assert.AreEqual(result, 48);
        }

        [TestMethod]
        public void TestSeq3()
        {
            varA = 2; varB = 5;
            bool result = seq.seq3(varA, varB);

            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void TestSeq4()
        {
            varA = 3; varB = 4;
            bool result = seq.seq4(varA, varB);

            Assert.AreEqual(result, false);
        }
    }
}
