﻿using System;
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
        public void countHoles_Test2()
        {
            strA = "K";
            ValHol.countHoles(strA);
        }
 /*==================================================================================*/
        [TestMethod]
        public void countHoles_Test3()
        {
            strA = "";
            ValHol.countHoles(strA);
        }
/*==================================================================================*/
        [TestMethod]
        public void countHoles_Test4()
        {
            strA = "AKB";
            ValHol.countHoles(strA);
        }
/*==================================================================================*/
       [TestMethod]
        public void getJumlahLubang_Test()
        {
            // getJumlahLubang berfungsi untuk mengambil nilai jumlahLubang
            int result = ValHol.getJumlahLubang();
            Console.WriteLine(result);
            Assert.AreEqual(result, 0);
        }
/*==================================================================================*/

    }
}
