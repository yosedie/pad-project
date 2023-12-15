using Microsoft.VisualStudio.TestTools.UnitTesting;
using pad_project;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest6
    {
        private FormReportMenu formReportMenu;

        [TestInitialize]
        public void Setup()
        {
            formReportMenu = new FormReportMenu();
        }

        [TestMethod]
        public void ButtonBackClick_ShouldCloseForm()
        {
            formReportMenu.buttonBack_Click(null, null);
        }

        [TestMethod]
        public void ButtonAllVendorClick_ShouldOpenFormAllVendor()
        {
            formReportMenu.buttonAllVendor_Click(null, null);
        }

        [TestMethod]
        public void ButtonPurchasingHistoryClick_ShouldOpenFormPurchasingHistory()
        {
            formReportMenu.buttonPurchasingHistory_Click(null, null);
        }

        [TestMethod]
        public void ButtonMostExpensivePurchaseClick_ShouldOpenFormMostExpensivePurchase()
        {
            formReportMenu.buttonMostExpensivePurchase_Click(null, null);
        }
    }
}
