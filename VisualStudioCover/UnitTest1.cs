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

        [TestMethod]
        public void sisaTukarNominalPec1Kdgn50K10K5K_Test()
        {
            int result = seq.sisaTukarNominalPec1Kdgn50K10K5K(25000);

            Assert.AreEqual(result, 0);
        }
        
        /*
        [TestMethod]
        public void isYearKabisat_Test1()
        {
            // Test untuk Tahun yang Habis dibagi 4, tapi tidak habis dibagi 100 & 400
            bool result = seq.isYearKabisat(4,2016);

            Assert.AreEqual(result, true);
        }

        
        [TestMethod]
        public void isYearKabisat_Test2()
        {
            // Test untuk Tahun yang Habis dibagi 4 dan 100, tapi tidak habis dibagi 400
            bool result = seq.isYearKabisat(4, 1900);

            Assert.AreEqual(result, false);
        }

        // IsKabisat jadi 100% karena Test1 bernilai True dan Test2 bernilai False, sehingga branch nya terpenuhi dua-dua nya
        */
        [TestMethod]
        public void isYearKabisat_Test3()
        {
            // Test untuk Condition Coverage, terdapat 8 Variasi, seluruh condition harus masuk
            // Condition is 
            // ((year % 4 == 0) && (year % 100 > 0)) || (year % 400 == 0)
            bool result;
            
            // ((F && T) || F)
            // result = seq.isYearKabisat(1, 2002);
            // Assert.AreEqual(result, false);

            // ((T && F) || F)
            result = seq.isYearKabisat(1, 1900);
            Assert.AreEqual(result, false);

            // ((T && F) || T)
            // result = seq.isYearKabisat(1, 2000);
            // Assert.AreEqual(result, true);

            // ((T && T) || F)
            // result = seq.isYearKabisat(1, 2012);
            // Assert.AreEqual(result, true);

            // Varias Condition lain sulit dicapai
            // Dengan kondisi yang ada. 
        }

        [TestMethod]
        public void isPointOrigin_Test1()
        {
            // Test Point Origin dengan Return False
            bool result = seq.isPointOrigin(0, 2);

            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void isPointOrigin_Test2()
        {
            // Test Point Origin dengan Return True
            bool result = seq.isPointOrigin(0, 0);

            Assert.AreEqual(result, true);
        }

        /*
        [TestMethod]
        public void isPointOrigin_Test3()
        {
            // Test Point Origin dengan Return True
            bool result = seq.isPointOrigin(2, 0);

            Assert.AreEqual(result, false);
        }
        */
        [TestMethod]
        public void isPointKuadran1_Test1()
        {
            // Test Point Kuadran 1 dengan Return True
            bool result = seq.isPointKuadran1(1, 1);

            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void isPointKuadran1_Test2()
        {
            // Test Point Kuadran 1 dengan Return False 
            // Sumbu X
            bool result = seq.isPointKuadran1(-1, 0);

            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void isPointKuadran2_Test1()
        {
            // Test Point Kuadran 2 dengan Return True
            bool result = seq.isPointKuadran2(-1, 2);

            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void isPointKuadran2_Test2()
        {
            // Test Point Kuadran 2 dengan Return False 
            // Sumbu Y
            bool result = seq.isPointKuadran2(0, 1);

            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void isPointKuadran3_Test1()
        {
            // Test Point Kuadran 3 dengan Return False 
            // Kuadran 4
            bool result = seq.isPointKuadran3(2, -2);

            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void isPointKuadran3_Test2()
        {
            // Test Point Kuadran 3 dengan Return True 
            bool result = seq.isPointKuadran3(-2, -2);

            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void isPointKuadran4_Test1()
        {
            // Test Point Kuadran 4 dengan Return True
            bool result = seq.isPointKuadran4(2, -2);

            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void isPointKuadran4_Test2()
        {
            // Test Point Kuadran 4 dengan Return False
            // Kuadran 2
            bool result = seq.isPointKuadran4(-2, 2);

            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void isPointNotOrigin_Test1()
        {
            // Kondisi (x != 0, y != 0)
            // Test x < 0, y > 0
            bool result = seq.isPointNotOrigin(-2, 2);

            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void isPointNotOrigin_Test2()
        {
            // Kondisi (x != 0, y != 0)
            // Test x == 0, y == 0
            bool result = seq.isPointNotOrigin(0, 0);

            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void isSuhuPadat_Test1()
        {
            // Kondisi (0 <= suhu <= 100)
            // Test suhu 80 (In Range)
            bool result = seq.isSuhuPadat(80);

            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void isSuhuPadat_Test2()
        {
            // Kondisi (0 <= suhu <= 100)
            // Test suhu 0 dan 100 (In Border)
            bool result = seq.isSuhuPadat(0);
            Assert.AreEqual(result, true);

            result = seq.isSuhuPadat(100);
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void isSuhuPadat_Test3()
        {
            // Kondisi (0 <= suhu <= 100)
            // Test suhu -1 dan 101 (Out of Range)
            bool result = seq.isSuhuPadat(-1);
            Assert.AreEqual(result, false);

            result = seq.isSuhuPadat(101);
            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void isSuhuCair_Test1()
        {
            // Kondisi (suhu <= 0)
            // Test suhu -1 (In Range)
            bool result = seq.isSuhuCair(-1);
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void isSuhuCair_Test2()
        {
            // Kondisi (suhu <= 0)
            // Test suhu 0 (In Border)
            bool result = seq.isSuhuCair(0);
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void isSuhuCair_Test3()
        {
            // Kondisi (suhu <= 0)
            // Test suhu 1 (Out of Border)
            bool result = seq.isSuhuCair(2);
            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void isSuhuUap_Test1()
        {
            // Kondisi (suhu >= 100)
            // Test suhu 101 (In Range)
            bool result = seq.isSuhuUap(101);
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void isSuhuUap_Test2()
        {
            // Kondisi (suhu >= 100)
            // Test suhu 100 (In Border)
            bool result = seq.isSuhuUap(100);
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void isSuhuUap_Test3()
        {
            // Kondisi (suhu >= 100)
            // Test suhu 99 (Out of Border)
            bool result = seq.isSuhuUap(99);
            Assert.AreEqual(result, false);
        }
    }
}
