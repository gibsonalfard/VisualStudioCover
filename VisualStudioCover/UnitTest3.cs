using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VisualStudioCover
{
    [TestClass]
    public class UnitTest3
    {
        public Looping loop = new Looping();
        [TestMethod]
        public void OutputBintang_21_Test()
        {
            // Karena yang akan diuji adalah Coverage
            // Untuk Void Function hanya perlu dipanggil
            // Tanpa Memberi nilai kembalian

            // Tidak masuk ke Loop
            loop.OutputBintang_21(0);
            // Masuk ke Loop
            loop.OutputBintang_21(2);
        }

        [TestMethod]
        public void jumBil_22_Test()
        {
            // Terdapat 2 Independent Path
            int result;
            
            // Tidak masuk ke Loop (While bernilai False)
            int n = 5;
            int [] marks = new int[5]  { 99,  98, 92, 97, 95};
            result = loop.jumBil_22(marks, 0);
            Assert.AreEqual(result, 0);

            // Masuk ke Loop (While benilai True)
            result = loop.jumBil_22(marks, n);
            Assert.AreEqual(result, 481);
        }

        [TestMethod]
        public void jumBil_23_Test()
        {
            // Terdapat 2 Independent Path
            int result;

            // Tidak masuk ke Loop (While bernilai False)
            int n = 5;
            int[] marks = new int[5] { 99, 98, 92, 97, 95 };
            result = loop.jumBil_23(0);
            Assert.AreEqual(result,1);

            // Masuk ke Loop (While bernilai Benar)
            result = loop.jumBil_23(5);
            Assert.AreEqual(result, 6);
        }

        [TestMethod]
        public void outputFaktorlBilangan_24_Test()
        {
            // Karena yang akan diuji adalah Coverage
            // Untuk Void Function hanya perlu dipanggil
            // Tanpa Memberi nilai kembalian
            // Terdapat 3 Independent Path
            // Namun if Pasti pernah False dan True
            int result;

            // Tidak masuk ke Loop (For bernilai False)
            loop.outputFaktorlBilangan_24(0);

            // Masuk ke Loop (For bernilai True)
            loop.outputFaktorlBilangan_24(5);
        }

        [TestMethod]
        public void cariBil_25_Test()
        {
            // Terdapat 3 Independent Path
            bool result;
            int[] arr = new int[5] {9, 25, 13, 17, 16};

            // Tidak masuk ke Loop (For bernilai False)
            result = loop.cariBil_25(arr, 0, 12);
            Assert.AreEqual(result, false);

            // Masuk ke Loop (For bernilai True)
            // Bilangan tidak ditemukan (If False)
            result = loop.cariBil_25(arr, 5, 12);
            Assert.AreEqual(result, false);

            // Masuk ke Loop (For bernilai True)
            // Bilangan tidak ditemukan (If False)
            result = loop.cariBil_25(arr, 5, 16);
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void OutputDeretGanjilGenap_27_Test()
        {
            // Karena yang akan diuji adalah Coverage
            // Untuk Void Function hanya perlu dipanggil
            // Tanpa Memberi nilai kembalian
            // Terdapat 6 Independent Path
            // Namun if Pasti pernah False dan True
            // Tidak masuk ke Loop (For bernilai False)
            loop.OutputDeretGanjilGenap_27(0);

            // Masuk ke Loop (For bernilai True)
            loop.OutputDeretGanjilGenap_27(6);
        }

        [TestMethod]
        public void guessNumber_28_Test()
        {
            bool result;
            int[] guess = new int[5] { 9, 25, 13, 17, 16 };
            // Terdapat 6 Independent Path

            // Tidak masuk ke Loop (While bernilai False)
            result = loop.guessNumber_28(guess, 0, 12);
            Assert.AreEqual(result, false);

            // Masuk ke Loop (While bernilai True)
            // Secret lebih kecil dari guess
            result = loop.guessNumber_28(guess, 5, 34);
            Assert.AreEqual(result, false);

            // Masuk ke Loop (While bernilai True)
            // Secret lebih besar dari guess
            result = loop.guessNumber_28(guess, 5, 1);
            Assert.AreEqual(result, false);

            // Masuk ke Loop (While bernilai True)
            // Secret ditemukan
            result = loop.guessNumber_28(guess, 5, 9);
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void OutputPolaXYZ29_Test()
        {
            // Terdapat 6 Independent Path
            // Namun if Pasti pernah False dan True
            // N harus 0 agar tidak Infinite Loop

            // Masuk sekali (While False)
            // Masuk Else
            loop.OutputPolaXYZ29(0,2);

            // Masuk Loop (While True)
            // Masuk If
            loop.OutputPolaXYZ29(0, 1);
        }

        [TestMethod]
        public void OutputCountBilPencacah_30_Test()
        {
            // Parameter ke 3 tidak berpengaruh pada fungsi

            int[] guess = new int[5] { 9, 25, 13, 17, 16 };

            // Tidak masuk Loop
            // loop.OutputCountBilPencacah_30(guess, 0, 0);

            // Masuk Loop
            // Case Selalu Default
            loop.OutputCountBilPencacah_30(guess, 5, 0);

            // Masuk Loop
            // Case 1-5 (Check)
            guess = new int[5] { 1, 2, 3, 4, 5 };
            loop.OutputCountBilPencacah_30(guess, 5, 0);

            // Masuk Loop
            // Case 6-10 (Check)
            guess = new int[5] { 9, 10, 8, 6, 7 };
            loop.OutputCountBilPencacah_30(guess, 5, 0);
        }

        [TestMethod]
        public void OutputCalculateDeretBilBaseOnOp_31_Test()
        {
            int result;
            int[] num = new int[3] { 9, 3, 2};

            // Tidak masuk loop
            result = loop.OutputCalculateDeretBilBaseOnOp_31(num, 0, '+');
            Assert.AreEqual(result, 0);

            // Hanya Case + yang dieksekusi
            result = loop.OutputCalculateDeretBilBaseOnOp_31(num, num.Length, '+');
            Assert.AreEqual(result, 14);

            // Hanya Case - yang dieksekusi
            result = loop.OutputCalculateDeretBilBaseOnOp_31(num, num.Length, '-');
            Assert.AreEqual(result, -14);

            // Hanya Case * yang dieksekusi
            result = loop.OutputCalculateDeretBilBaseOnOp_31(num, num.Length, '*');
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void konversiDesToBiner_32_Test()
        {
            string result;

            // Hanya Case 0 yang dieksekusi
            result = loop.konversiDesToBiner_32(0);
            Assert.AreEqual(result, "0 ");

            // Hanya Case 1 yang dieksekusi
            result = loop.konversiDesToBiner_32(1);
            Assert.AreEqual(result, "1 ");

            // Hanya Case di Eksekusi seluruhnya
            result = loop.konversiDesToBiner_32(2);
            Assert.AreEqual(result, "10 ");
        }

        [TestMethod]
        public void OutputBintangSegiempat_33_Test()
        {
            // Tidak masuk Loop
            loop.OutputBintangSegiempat_33(0);

            // Masuk Loop
            loop.OutputBintangSegiempat_33(1);
        }

        [TestMethod]
        public void OutputBintangSegitiga_34_Test()
        {
            // Tidak masuk Loop
            loop.OutputBintangSegitiga_34(0);

            // Masuk Loop
            loop.OutputBintangSegitiga_34(1);
        }

        [TestMethod]
        public void geserBilKiri_36_Test()
        {
            char[] result;
            char[] text = new char[5] { 'P', 'P', 'L', 'T', 'E' };
            char[] actual = new char[5] {'E', 'P', 'P', 'L', 'T'};
            
            // Tidak masuk Loop
            result = loop.geserBilKiri_36(text, 0, 0);
            Assert.AreEqual(result, text);

            // Masuk Loop 1 Tapi tidak masuk Loop 2
            result = loop.geserBilKiri_36(text, 1, 1);
            Assert.AreEqual(result, text);

            // Masuk Loop 1 dan Loop 2
            result = loop.geserBilKiri_36(text, 5, 1);
            Assert.AreSame(result, text);
        }

        [TestMethod]
        public void OutputBintangSegitigaTerbalik_37_Test()
        {
            // Tidak masuk Loop 1
            loop.OutputBintangSegitigaTerbalik_37(0);

            // Masuk Loop 1
            // Tidak masuk Loop 2
            // Masuk Loop 3
            loop.OutputBintangSegitigaTerbalik_37(1);

            // Masuk Seluruh Loop
            loop.OutputBintangSegitigaTerbalik_37(2);
        }
    }
}
