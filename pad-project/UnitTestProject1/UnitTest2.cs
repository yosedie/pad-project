using Microsoft.VisualStudio.TestTools.UnitTesting;
using pad_project;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {
        private Form2 form2;

        [TestInitialize]
        public void Setup()
        {
            form2 = new Form2();
        }

        [TestMethod]
        public void BtnSaveClick_ShouldSaveChanges()
        {
            form2.txtPurchaseOrderID.Text = "1";
            form2.txtVendorID.Text = "1";

            form2.btnSave_Click_1(null, null);

        }

        [TestMethod]
        public void BtnCancelClick_ShouldCloseForm()
        {
            form2.btnCancel_Click_1(null, null);

        }
    }
}
