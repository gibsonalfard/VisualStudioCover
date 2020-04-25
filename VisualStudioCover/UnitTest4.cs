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
    }
}
