using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VisualStudioCover
{
    [TestClass]
    public class UnitTest4
    {
        public Kombinasi combine = new Kombinasi();
        [TestMethod]
        public void OutputBintang_42_Test()
        {
            // Karena yang akan diuji adalah Coverage
            // Untuk Void Function hanya perlu dipanggil
            // Tanpa Memberi nilai kembalian

            // Masuk ke Else
            combine.OutputBintang_42(0);
            // Masuk ke If
            combine.OutputBintang_42(2);
        }

        [TestMethod]
        public void isBilPrima_43_Test()
        {
            // Path Coverage gak Full Harusnya terdapat 4 IndPath
            // Saat dieksekusi 1 Path saja yang memenuhi
            bool result;
            /*
            // Tidak masuk ke If (If bernilai False)
            result = combine.isBilPrima_43(1);
            Assert.AreEqual(result, false);
            
            // Masuk ke If (If bernilai True)
            // Tidak masuk Loop
            result = combine.isBilPrima_43(2);
            Assert.AreEqual(result, false);
            
            // Masuk ke If (If bernilai True)
            // Masuk Loop
            // If false
            result = combine.isBilPrima_43(3);
            Assert.AreEqual(result, false);
            */

            // Masuk ke If (If bernilai True)
            // Masuk Loop
            // If true
            result = combine.isBilPrima_43(4);
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void pengurutanBilangan_44_Test()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int[] expect = arr;
            int[] actual;

            // If bernilai false
            actual = combine.pengurutanBilangan_44(arr, 0);
            CollectionAssert.AreEqual(expect, actual);

            // Masuk Loop, array sudah terurut ASC
            // Program akan mengembalikan Exception
            // Karena kesalah logika untuk pengurutan
            actual = combine.pengurutanBilangan_44(arr, 5);
            CollectionAssert.AreEqual(expect, actual);

            // Masuk Loop, array belum terurut
            arr = new int[5] { 3, 4, 2, 5, 1};
            actual = combine.pengurutanBilangan_44(arr, 5);
            CollectionAssert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void isAdaBil_45_Test()
        {
            // Program ini tidak akan pernah masuk Loop
            // Kondisi pada If dan Loop bertentangan
            string str;
            int[] bil = { 1, 2, 3, 4, 5 };

            // If bernilai benar (Tidak masuk Loop)
            str = combine.isAdaBil_45(bil, 0, 1);
            Assert.AreEqual("Deretan Bilangan Kosong", str);

            // Masuk Else, Tidak masuk Loop
            str = combine.isAdaBil_45(bil, 5, 7);
            Assert.AreEqual("tidak ketemu", str);

            // Masuk Else, Masuk Loop, Bilangan ditemukan
            str = combine.isAdaBil_45(bil, 5, 3);
            Assert.AreEqual("bilangan ketemu", str);
        }

        [TestMethod]
        public void calPangkatDua_46_47_Test()
        {
            float actual;

            // Masuk If awal
            actual = combine.calPangkatDua_46_47(0, 1);
            Assert.AreEqual(0, actual);

            // Masuk ke Else if (pangkat > 0)
            actual = combine.calPangkatDua_46_47(1, 1);
            Assert.AreEqual(1, actual);

            // Masuk ke Else if (pangkat < 0)
            // Bilang != 0
            // Kondisi tidak akan pernah tercapai
            // Karena kondisi i < pangkat, i = 0
            // Sedangkan pangkat harus -1 untuk masuk else if
            // Akan saya perbaiki di Program
            actual = combine.calPangkatDua_46_47(1, -1);
            Assert.AreEqual(1, actual);

            // Masuk ke Else if (pangkat < 0)
            // Bilang == 0
            actual = combine.calPangkatDua_46_47(0, -2);
            Assert.AreEqual(-99999, actual);

            // Masuk ke Else (Pangkat == 0)
            // Bilangan != 0
            actual = combine.calPangkatDua_46_47(2, 0);
            Assert.AreEqual(1, actual);

            // Masuk ke Else (Pangkat == 0)
            // Bilangan == 0
            actual = combine.calPangkatDua_46_47(0, 0);
            Assert.AreEqual(-99999, actual);
        }

        [TestMethod]
        public void desimalToBiner_48_Test()
        {
            int[] expected = new int[10] { 0,0,0,0,0,0,0,0,0,0 };
            int[] actual;

            // Bilangan == 0
            actual = combine.desimalToBiner_48(0);
            CollectionAssert.AreEqual(expected, actual);

            // Bilangan > 0
            actual = combine.desimalToBiner_48(2);
            expected[8] = 1;
            CollectionAssert.AreEqual(expected, actual);
            expected[8] = 0;

            // Bilangan < 0
            actual = combine.desimalToBiner_48(-1);
            expected = new int [10]{ 0, -1, -1, -1, -1, -1, -1, -1, -1, -1};
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetIndexByElemen_49_Test()
        {
            int actual;
            int[] bilangan = new int[6] { 25, 9, 34, 17, 7 , -1};

            // Tidak masuk If (Array dianggap Kosong)
            actual = combine.GetIndexByElemen_49(bilangan, 0, 25);
            Assert.AreEqual(0, actual);

            // N > 0 dan cari <= 0
            actual = combine.GetIndexByElemen_49(bilangan, 6, -1);
            Assert.AreEqual(-1, actual);

            // N > 0 dan cari > 0 bilangan tidak ditemukan
            actual = combine.GetIndexByElemen_49(bilangan, 6, 8);
            Assert.AreEqual(-2, actual);

            // N > 0 dan cari > 0 bilangan ditemukan
            actual = combine.GetIndexByElemen_49(bilangan, 6, 25);
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void GetElemenTerbesar_50_Test()
        {
            // Program ini tidak akan pernah masuk Loop
            // Kondisi pada If dan Loop bertentangan
            int actual;
            int[] bilangan = new int[6] { 25, 9, 34, 17, 7, -1 };

            // N == 0
            actual = combine.GetElemenTerbesar_50(bilangan, 0);
            Assert.AreEqual(0, actual);

            // N < 0
            actual = combine.GetElemenTerbesar_50(bilangan, -1);
            Assert.AreEqual(-1, actual);

            // N > 0 array bernilai 0 seluruhnya
            int[] x = new int[5] { 0, 0, 0, 0, 0 };
            actual = combine.GetElemenTerbesar_50(x, 5);
            Assert.AreEqual(0, actual);

            // N > 0 array bervariasi nilainya
            actual = combine.GetElemenTerbesar_50(bilangan, 6);
            Assert.AreEqual(34, actual);
        }
    }
}
