using Microsoft.VisualStudio.TestTools.UnitTesting;
using pad_project;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest4
    {
        private FormMostExpensivePurchase formMostExpensivePurchase;

        [TestInitialize]
        public void Setup()
        {
            formMostExpensivePurchase = new FormMostExpensivePurchase();
        }

        [TestMethod]
        public void ButtonCreateReportClick_ShouldCreateReport()
        {
            formMostExpensivePurchase.buttonCreateReport_Click(null, null);
        }

        [TestMethod]
        public void ButtonBackClick_ShouldOpenFormReportMenu()
        {
            formMostExpensivePurchase.buttonBack_Click(null, null);
        }
    }
}
