using FcrDownloader;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        string f1 = @"C:\Users\MSJ046\OneDrive - Maersk Group\AuditFCR\1748425152072_fcr_hk_15376560.pdf";
        string f2 = @"C:\Users\MSJ046\OneDrive - Maersk Group\AuditFCR\1748425152174_fcr_hk_15376557.pdf";
        string f3 = @"C:\Users\MSJ046\OneDrive - Maersk Group\AuditFCR\1748425152285_fcr_hk_15376555.pdf";
        string f4 = @"C:\Users\MSJ046\OneDrive - Maersk Group\AuditFCR\1748425152418_fcr_hk_15376553.pdf";

        [TestMethod]
        [DataRow(@"C:\Users\MSJ046\OneDrive - Maersk Group\AuditFCR\1748425152072_fcr_hk_15376560.pdf", "CTG0090599")]
        [DataRow(@"C:\Users\MSJ046\OneDrive - Maersk Group\AuditFCR\1748425152174_fcr_hk_15376557.pdf", "CTG0090598")]
        [DataRow(@"C:\Users\MSJ046\OneDrive - Maersk Group\AuditFCR\1748425152285_fcr_hk_15376555.pdf", "CTG0090595")]
        [DataRow(@"C:\Users\MSJ046\OneDrive - Maersk Group\AuditFCR\1748425152418_fcr_hk_15376553.pdf", "CTG0090585")]
        
        public void TestMethod1(string fileName,string expected)
        {
            
            FcrReader fcrReader = new FcrReader();
            var result = fcrReader.Read(fileName);
            var actual=result.Value;
            Assert.AreEqual(expected,actual);
        }
    }
}
