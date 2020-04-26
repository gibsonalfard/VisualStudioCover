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
        public char chA, chB, chC, chD;
        public string strA, strB, strC, strD;
        public Selection sel = new Selection();
        int result;
/*==================================================================================*/
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
        public void cariMax3Bil_05_Test1()
        {
            intA = 0;
            intB = 1;
            intC = -1;

            int result = sel.cariMax3Bil_05(intA, intB, intC);

            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void cariMax3Bil_05_Test2()
        {
            intA = 0;
            intB = -1;
            intC = 1;

            int result = sel.cariMax3Bil_05(intA, intB, intC);

            Assert.AreEqual(result, 1);
        }
/*==================================================================================*/
        [TestMethod]
        public void hitNilaiMutu_06_Test()
        {
            dblA = 100;
            dblB = 100;
            dblC = 100;
            intA = 14;

            char result = sel.hitNilaiMutu_06(dblA, dblB, dblC, intA);

            Assert.AreEqual(result,'A');
        }

        [TestMethod]
        public void hitNilaiMutu_06_Test1()
        {
            dblA = 70;
            dblB = 70;
            dblC = 70;
            intA = 14;

            char result = sel.hitNilaiMutu_06(dblA, dblB, dblC, intA);

            Assert.AreEqual(result, 'B');
        }

        [TestMethod]
        public void hitNilaiMutu_06_Test2()
        {
            dblA = 55;
            dblB = 55;
            dblC = 55;
            intA = 9;

            char result = sel.hitNilaiMutu_06(dblA, dblB, dblC, intA);

            Assert.AreEqual(result, 'C');
        }

        [TestMethod]
        public void hitNilaiMutu_06_Test3()
        {
            dblA = 40;
            dblB = 40;
            dblC = 40;
            intA = 6;

            char result = sel.hitNilaiMutu_06(dblA, dblB, dblC, intA);

            Assert.AreEqual(result, 'D');
        }

        [TestMethod]
        public void hitNilaiMutu_06_Test3()
        {
            dblA = 0;
            dblB = 0;
            dblC = 0;
            intA = 0;

            char result = sel.hitNilaiMutu_06(dblA, dblB, dblC, intA);

            Assert.AreEqual(result, 'E');
        }
/*==================================================================================*/
        [TestMethod]
        public void getUpah_063_Test()
        {
            intA = 7;
            intB = 8;

            int result = sel.getUpah_063(intA, intB);

            Assert.AreEqual(result, 2000);
        }

        [TestMethod]
        public void getUpah_063_Test1()
        {
            intA = 8;
            intB = 7;

            int result = sel.getUpah_063(intA, intB);

            Assert.AreEqual(result, 6500);
        }


        [TestMethod]
        public void getUpah_063_Test2()
        {
            intA = 7;
            intB = 7;

            int result = sel.getUpah_063(intA, intB);

            Assert.AreEqual(result, 2000);
        }
/*==================================================================================*/
        [TestMethod]
        public void menentukanBilGanjil_064_Test()
        {
            intA = 3;

            sel.menentukanBilGanjil_064(intA);
        }

        [TestMethod]
        public void menentukanBilGanjil_064_Test()
        {
            intA = 2;

            sel.menentukanBilGanjil_064(intA);
        }
/*==================================================================================*/
        [TestMethod]
        public void getDayFromNumber07_Test()
        {
            intA = 7;

            int result = sel.getDayFromNumber07(intA);

            Assert.AreEqual(result, "Minggu");
        }

        [TestMethod]
        public void getDayFromNumber07_Test1()
        {
            intA = 1;

            int result = sel.getDayFromNumber07(intA);

            Assert.AreEqual(result, "Senin");
        }

        [TestMethod]
        public void getDayFromNumber07_Test2()
        {
            intA = 2;

            int result = sel.getDayFromNumber07(intA);

            Assert.AreEqual(result, "Selasa");
        }

        [TestMethod]
        public void getDayFromNumber07_Test3()
        {
            intA = 3;

            int result = sel.getDayFromNumber07(intA);

            Assert.AreEqual(result, "Rabu");
        }

        [TestMethod]
        public void getDayFromNumber07_Test4()
        {
            intA = 1;

            int result = sel.getDayFromNumber07(intA);

            Assert.AreEqual(result, "Kamis");
        }

        [TestMethod]
        public void getDayFromNumber07_Test5()
        {
            intA = 1;

            int result = sel.getDayFromNumber07(intA);

            Assert.AreEqual(result, "Jumat");
        }

        [TestMethod]
        public void getDayFromNumber07_Test6()
        {
            intA = 1;

            int result = sel.getDayFromNumber07(intA);

            Assert.AreEqual(result, "Sabtu");
        }
/*==================================================================================*/
        [TestMethod]
        public void tukarNominalUang_08_Test()
        {
            intA = 100000;
            intB = 90000;

            sel.tukarNominal_08(intA, intB);
        }
/*==================================================================================*/
        [TestMethod]
        public void getKuadran_09_Test()
        {
            intA = 0;
            intB = 0;

            int result = sel.getKuadran_09(intA, intB);
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void getKuadran_09_Test1()
        {
            intA = 1;
            intB = 1;

            int result = sel.getKuadran_09(intA, intB);
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void getKuadran_09_Test2()
        {
            intA = -1;
            intB = 1;

            int result = sel.getKuadran_09(intA, intB);
            Assert.AreEqual(result, 2);
        }

        [TestMethod]
        public void getKuadran_09_Test3()
        {
            intA = -1;
            intB = -1;

            int result = sel.getKuadran_09(intA, intB);
            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void getKuadran_09_Test4()
        {
            intA = 1;
            intB = -1;

            int result = sel.getKuadran_09(intA, intB);
            Assert.AreEqual(result, 4);
        }
/*==================================================================================*/
        [TestMethod]
        public void tampilSuhu_10_Test()
        {
            intA = 100;

            int result = sel.tampilSuhu_10(intA);

            Assert.AreEqual(result, "Padat");
        }

        [TestMethod]
        public void tampilSuhu_10_Test1()
        {
            intA = -1;

            int result = sel.tampilSuhu_10(intA);

            Assert.AreEqual(result, "Cair");
        }

        [TestMethod]
        public void tampilSuhu_10_Test2()
        {
            intA = 101;

            int result = sel.tampilSuhu_10(intA);

            Assert.AreEqual(result, "Gas");
        }
/*==================================================================================*/
        [TestMethod]
        public void getNumberDayMonth2_10_Test()
        {
            intA = 1;
            intB = 1;

            int result = sel.getNumberDayMonth2_10(intA, intB);
            Assert.AreEqual(result, 31);
        }

        [TestMethod]
        public void getNumberDayMonth2_10_Test1()
        {
            intA = 4;
            intB = 1;

            int result = sel.getNumberDayMonth2_10(intA, intB);
            Assert.AreEqual(result, 30);
        }

        [TestMethod]
        public void getNumberDayMonth2_10_Test2()
        {
            intA = 2;
            intB = 400;

            int result = sel.getNumberDayMonth2_10(intA, intB);
            Assert.AreEqual(result, 29);
        }

        [TestMethod]
        public void getNumberDayMonth2_10_Test3()
        {
            intA = 2;
            intB = 401;

            int result = sel.getNumberDayMonth2_10(intA, intB);
            Assert.AreEqual(result, 28);
        }
/*==================================================================================*/
        [TestMethod]
        public void getSizeKaos_12_Test()
        {
            intA = 171;
            intB = 61;

            int result = sel.getSizeKaos_12(intA, intB);

            Assert.AreEqual(result, 'X');
        }

        [TestMethod]
        public void getSizeKaos_12_Test1()
        {
            intA = 170;
            intB = 80;

            int result = sel.getSizeKaos_12(intA, intB);

            Assert.AreEqual(result, 'L'); 
        }

        [TestMethod]
        public void getSizeKaos_12_Test2()
        {
            intA = 150;
            intB = 80;

            int result = sel.getSizeKaos_12(intA, intB);

            Assert.AreEqual(result, 'M');
        }
/*==================================================================================*/
        [TestMethod] //Test method belum selesai
        public void calCulateGajih_17_Test()
        {
            chA = 'A';
            intA = 41;

            int result = sel.calCulateGajih_17(chA, intA);
            Assert.AreEqual(result, 615000);
        }

        [TestMethod]
        public void calCulateGajih_17_Test1()
        {
            chA = 'B';
            intA = 41;

            int result = sel.calCulateGajih_17(chA, intA);
            Assert.AreEqual(result, 471500);
        }

        [TestMethod]
        public void calCulateGajih_17_Test1()
        {
            chA = 'C';
            intA = 41;

            int result = sel.calCulateGajih_17(chA, intA);
            Assert.AreEqual(result, 328000);
        }

        [TestMethod]
        public void calCulateGajih_17_Test1()
        {
            chA = 'D';
            intA = 41;

            int result = sel.calCulateGajih_17(chA, intA);
            Assert.AreEqual(result, 184500);
        }
/*==================================================================================*/
        [TestMethod]
        public void getNumberDayMonth_18_Test()
        {
            intA = 1;
            intB = 1;

            int result = sel.getNumberDayMonth_18(intA, intB);
            Assert.AreEqual(result, 31);
        }

        [TestMethod]
        public void getNumberDayMonth_18_Test1()
        {
            intA = 4;
            intB = 1;

            int result = sel.getNumberDayMonth_18(intA, intB);
            Assert.AreEqual(result, 30);
        }

        [TestMethod]
        public void getNumberDayMonth_18_Test2()
        {
            intA = 2;
            intB = 400;

            int result = sel.getNumberDayMonth_18(intA, intB);
            Assert.AreEqual(result, 29);
        }

        [TestMethod]
        public void getNumberDayMonth_18_Test3()
        {
            intA = 2;
            intB = 401;

            int result = sel.getNumberDayMonth_18(intA, intB);
            Assert.AreEqual(result, 28);
        }

        [TestMethod]
        public void getNumberDayMonth_18_Test4()
        {
            intA = 0;
            intB = 0;

            int result = sel.getNumberDayMonth_18(intA, intB);
            Assert.AreEqual(result, 0);
        }
/*==================================================================================*/
        [TestMethod]
        public void OutputOperasiPilihan_19_Test()
        {
            chA = 'A';
            intA = 3;

            sel.OutputOperasiPilihan_19_Test(chA, intA);
        }

        [TestMethod]
        public void OutputOperasiPilihan_19_Test1()
        {
            chA = 'A';
            intA = 2;

            sel.OutputOperasiPilihan_19_Test(chA, intA);
        }

        [TestMethod]
        public void OutputOperasiPilihan_19_Test2()
        {
            chA = 'B';
            intA = 0;

            sel.OutputOperasiPilihan_19_Test(chA, intA);
        }

        [TestMethod]
        public void OutputOperasiPilihan_19_Test3()
        {
            chA = 'B';
            intA = 0;

            sel.OutputOperasiPilihan_19_Test(chA, intA);
        }

        [TestMethod]
        public void OutputOperasiPilihan_19_Test4()
        {
            chA = 'B';
            intA = 1;

            sel.OutputOperasiPilihan_19_Test(chA, intA);
        }

        [TestMethod]
        public void OutputOperasiPilihan_19_Test5()
        {
            chA = 'B';
            intA = -1;

            sel.OutputOperasiPilihan_19_Test(chA, intA);
        }

        [TestMethod]
        public void OutputOperasiPilihan_19_Test6()
        {
            chA = 'C';
            intA = 1;

            sel.OutputOperasiPilihan_19_Test(chA, intA);
        }

        [TestMethod]
        public void OutputOperasiPilihan_19_Test7()
        {
            chA = 'D';
            intA = -1;

            sel.OutputOperasiPilihan_19_Test(chA, intA);
        }

        [TestMethod]
        public void OutputOperasiPilihan_19_Test8()
        {
            chA = 'E';
            intA = 0;

            sel.OutputOperasiPilihan_19_Test(chA, intA);
        }

        [TestMethod]
        public void OutputOperasiPilihan_19_Test9() //default
        {
            chA = 'F';
            intA = 0;

            sel.OutputOperasiPilihan_19_Test(chA, intA);
        }
/*==================================================================================*/
        [TestMethod]
        public void OutputSwitchSwitch_20_Test()
        {
            chA = 'A';
            intA = 1;

            sel.OutputSwitchSwitch_20(chA, intA);
        }

        [TestMethod]
        public void OutputSwitchSwitch_20_Test1()
        {
            chA = 'A';
            intA = 2;

            sel.OutputSwitchSwitch_20(chA, intA);
        }

        [TestMethod]
        public void OutputSwitchSwitch_20_Test2()
        {
            chA = 'A';
            intA = 3;

            sel.OutputSwitchSwitch_20(chA, intA);
        }

        [TestMethod]
        public void OutputSwitchSwitch_20_Test3()
        {
            chA = 'A';
            intA = 4;

            sel.OutputSwitchSwitch_20(chA, intA);
        }

        [TestMethod]
        public void OutputSwitchSwitch_20_Test4()
        {
            chA = 'A';
            intA = 5;

            sel.OutputSwitchSwitch_20(chA, intA);
        }

        [TestMethod]
        public void OutputSwitchSwitch_20_Test5()
        {
            chA = 'A';
            intA = 6;

            sel.OutputSwitchSwitch_20(chA, intA);
        }

        [TestMethod]
        public void OutputSwitchSwitch_20_Test6()
        {
            chA = 'B';
            intA = 1;

            sel.OutputSwitchSwitch_20(chA, intA);
        }

        [TestMethod]
        public void OutputSwitchSwitch_20_Test7()
        {
            chA = 'B';
            intA = 2;

            sel.OutputSwitchSwitch_20(chA, intA);
        }

        [TestMethod]
        public void OutputSwitchSwitch_20_Test8()
        {
            chA = 'B';
            intA = 3;

            sel.OutputSwitchSwitch_20(chA, intA);
        }

        [TestMethod]
        public void OutputSwitchSwitch_20_Test9()
        {
            chA = 'B';
            intA = 4;

            sel.OutputSwitchSwitch_20(chA, intA);
        }

        [TestMethod]
        public void OutputSwitchSwitch_20_Test10()
        {
            chA = 'B';
            intA = 5;

            sel.OutputSwitchSwitch_20(chA, intA);
        }

        [TestMethod]
        public void OutputSwitchSwitch_20_Test11()
        {
            chA = 'B';
            intA = 6;

            sel.OutputSwitchSwitch_20(chA, intA);
        }

        [TestMethod]
        public void OutputSwitchSwitch_20_Test12()
        {
            chA = 'C';
            intA = 1;

            sel.OutputSwitchSwitch_20(chA, intA);
        }

        [TestMethod]
        public void OutputSwitchSwitch_20_Test13()
        {
            chA = 'C';
            intA = 2;

            sel.OutputSwitchSwitch_20(chA, intA);
        }

        [TestMethod]
        public void OutputSwitchSwitch_20_Test14()
        {
            chA = 'C';
            intA = 3;

            sel.OutputSwitchSwitch_20(chA, intA);
        }

        [TestMethod]
        public void OutputSwitchSwitch_20_Test15()
        {
            chA = 'C';
            intA = 4;

            sel.OutputSwitchSwitch_20(chA, intA);
        }

        [TestMethod]
        public void OutputSwitchSwitch_20_Test16()
        {
            chA = 'C';
            intA = 5;

            sel.OutputSwitchSwitch_20(chA, intA);
        }

        [TestMethod]
        public void OutputSwitchSwitch_20_Test17()
        {
            chA = 'C';
            intA = 6;

            sel.OutputSwitchSwitch_20(chA, intA);
        }

        [TestMethod]
        public void OutputSwitchSwitch_20_Test18()
        {
            chA = 'D';
            intA = 1;

            sel.OutputSwitchSwitch_20(chA, intA);
        }

        [TestMethod]
        public void OutputSwitchSwitch_20_Test19()
        {
            chA = 'D';
            intA = 2;

            sel.OutputSwitchSwitch_20(chA, intA);
        }

        [TestMethod]
        public void OutputSwitchSwitch_20_Test20()
        {
            chA = 'D';
            intA = 3;

            sel.OutputSwitchSwitch_20(chA, intA);
        }

        [TestMethod]
        public void OutputSwitchSwitch_20_Test21()
        {
            chA = 'D';
            intA = 4;

            sel.OutputSwitchSwitch_20(chA, intA);
        }

        [TestMethod]
        public void OutputSwitchSwitch_20_Test22()
        {
            chA = 'D';
            intA = 5;

            sel.OutputSwitchSwitch_20(chA, intA);
        }

        [TestMethod]
        public void OutputSwitchSwitch_20_Test23()
        {
            chA = 'D';
            intA = 6;

            sel.OutputSwitchSwitch_20(chA, intA);
        }

        [TestMethod]
        public void OutputSwitchSwitch_20_Test24()
        {
            chA = 'E';
            intA = 1;

            sel.OutputSwitchSwitch_20(chA, intA);
        }

        [TestMethod]
        public void OutputSwitchSwitch_20_Test25()
        {
            chA = 'E';
            intA = 2;

            sel.OutputSwitchSwitch_20(chA, intA);
        }

        [TestMethod]
        public void OutputSwitchSwitch_20_Test26()
        {
            chA = 'E';
            intA = 3;

            sel.OutputSwitchSwitch_20(chA, intA);
        }

        [TestMethod]
        public void OutputSwitchSwitch_20_Test27()
        {
            chA = 'E';
            intA = 4;

            sel.OutputSwitchSwitch_20(chA, intA);
        }

        [TestMethod]
        public void OutputSwitchSwitch_20_Test28()
        {
            chA = 'E';
            intA = 5;

            sel.OutputSwitchSwitch_20(chA, intA);
        }

        [TestMethod]
        public void OutputSwitchSwitch_20_Test29()
        {
            chA = 'E';
            intA = 6;

            sel.OutputSwitchSwitch_20(chA, intA);
        }
/*==================================================================================*/
        [TestMethod]
        public void OutputSwitchSwich_20_1_Test()
        {
            chA = 'A';
            intA = 1;

            sel.OutputSwitchSwitch_20_1(chA, intA);
        }

        [TestMethod]
        public void OutputSwitchSwich_20_1_Test1()
        {
            chA = 'A';
            intA = 2;

            sel.OutputSwitchSwitch_20_1(chA, intA);
        }

        [TestMethod]
        public void OutputSwitchSwich_20_1_Test2()
        {
            chA = 'A';
            intA = 3;

            sel.OutputSwitchSwitch_20_1(chA, intA);
        }

        [TestMethod]
        public void OutputSwitchSwich_20_1_Test3()
        {
            chA = 'A';
            intA = 4;

            sel.OutputSwitchSwitch_20_1(chA, intA);
        }

        [TestMethod]
        public void OutputSwitchSwich_20_1_Test4()
        {
            chA = 'B';
            intA = 1;

            sel.OutputSwitchSwitch_20_1(chA, intA);
        }

        [TestMethod]
        public void OutputSwitchSwich_20_1_Test5()
        {
            chA = 'B';
            intA = 2;

            sel.OutputSwitchSwitch_20_1(chA, intA);
        }

        [TestMethod]
        public void OutputSwitchSwich_20_1_Test6()
        {
            chA = 'B';
            intA = 3;

            sel.OutputSwitchSwitch_20_1(chA, intA);
        }

        [TestMethod]
        public void OutputSwitchSwich_20_1_Test7()
        {
            chA = 'C';
            intA = 0;

            sel.OutputSwitchSwitch_20_1(chA, intA);
        }

        [TestMethod]
        public void OutputSwitchSwich_20_1_Test8()
        {
            chA = 'D';
            intA = 0;

            sel.OutputSwitchSwitch_20_1(chA, intA);
        }

        [TestMethod]
        public void OutputSwitchSwich_20_1_Test9()
        {
            chA = 'E';
            intA = 0;

            sel.OutputSwitchSwitch_20_1(chA, intA);
        }
/*==================================================================================*/
        public void nilaiTerbilang_Test()
        {
            intA = -1;

            int result = sel.nilaiTerbilang(intA);

            Assert.AreEqual(result,"(negatif) ");
        }

        public void nilaiTerbilang_Test1()
        {
            intA = 0;

            int result = sel.nilaiTerbilang(intA);

            Assert.AreEqual(result, "nol");
        }

        public void nilaiTerbilang_Test2()
        {
            intA = 1111;

            int result = sel.nilaiTerbilang(intA);

            Assert.AreEqual(result, "seribuseratussebelas");
        }

        public void nilaiTerbilang_Test3()
        {
            intA = 2222;

            int result = sel.nilaiTerbilang(intA);

            Assert.AreEqual(result, "dua ribudua ratusdua puluhdua");
        }

        public void nilaiTerbilang_Test4()
        {
            intA = 1120;

            int result = sel.nilaiTerbilang(intA);

            Assert.AreEqual(result, "seribuseratusdua puluh");
        }

        public void nilaiTerbilang_Test5()
        {
            intA = 1112;

            int result = sel.nilaiTerbilang(intA);

            Assert.AreEqual(result, "seribuseratusdua belas");
        }
/*==================================================================================*/
    }
}
