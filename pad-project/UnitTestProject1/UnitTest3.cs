using Microsoft.VisualStudio.TestTools.UnitTesting;
using pad_project;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest3
    {
        private FormAllVendor formAllVendor;

        [TestInitialize]
        public void Setup()
        {
            formAllVendor = new FormAllVendor();
        }

        [TestMethod]
        public void ButtonCreateReportClick_ShouldCreateReport()
        {
            formAllVendor.buttonCreateReport_Click(null, null);

        }

        [TestMethod]
        public void ButtonBackClick_ShouldOpenFormReportMenu()
        {
            formAllVendor.buttonBack_Click(null, null);

        }
    }
}
