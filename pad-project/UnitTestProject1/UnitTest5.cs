using Microsoft.VisualStudio.TestTools.UnitTesting;
using pad_project;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest5
    {
        private FormPurchasingHistory formPurchasingHistory;

        [TestInitialize]
        public void Setup()
        {
            formPurchasingHistory = new FormPurchasingHistory();
        }

        [TestMethod]
        public void Button1Click_ShouldCreateReport()
        {
            formPurchasingHistory.button1_Click(null, null);
        }

        [TestMethod]
        public void ButtonBackClick_ShouldOpenFormReportMenu()
        {
            formPurchasingHistory.buttonBack_Click(null, null);
        }
    }
}
