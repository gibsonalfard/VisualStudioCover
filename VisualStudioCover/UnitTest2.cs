using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VisualStudioCover
{
    [TestClass]
    public class UnitTest2
    {
        public int varA, varB, varC, x;
        public Selection sel = new Selection();
        int result;

        [TestMethod]
        public void TestMethod1()
        {
            varA = 9;
            varB = 25;
            result = sel.select1(varA, varB);
        }

        [TestMethod]
        public void TestMethod2()
        {
            varA = 10;
            varB = 8;
            result = sel.select1(varA, varB);
        }

        [TestMethod]
        public void TestMethod3()
        {
            varA = 10;
            varB = 8;
            double result = sel.select2(varA, varB);
        }
    }
}
