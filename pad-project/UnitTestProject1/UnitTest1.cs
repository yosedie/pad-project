using Microsoft.VisualStudio.TestTools.UnitTesting;
using pad_project;
using System;
using System.Windows.Forms;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private Form1 form1;

        [TestInitialize]
        public void Setup()
        {
            form1 = new Form1();
        }

        [TestMethod]
        public void InitializeDataGridView_ShouldSetDataGridViewProperties()
        {
            form1.InitializeDataGridView();

            Assert.IsTrue(form1.dataGridView1.AutoGenerateColumns);
            Assert.AreEqual(DataGridViewAutoSizeColumnsMode.AllCells, form1.dataGridView1.AutoSizeColumnsMode);
        }

        [TestMethod]
        public void ClearDataGridView_ShouldClearDataGridView()
        {
            form1.ClearDataGridView();

            Assert.IsNull(form1.dataGridView1.DataSource);
            Assert.AreEqual(0, form1.dataGridView1.Columns.Count);
        }

        [TestMethod]
        public void BtnClearClick_ShouldClearDataGridViewAndResetSelectedIndex()
        {
            form1.dataGridView1.Rows.Add();
            form1.selectedRowIndex = 0;

            form1.btnClear_Click(null, null);

            Assert.IsNull(form1.dataGridView1.DataSource);
            Assert.AreEqual(-1, form1.selectedRowIndex);
        }

        [TestMethod]
        public void BtnGenerateTransactionClick_ShouldFilterDataAndSetDataSource()
        {
            form1.btnGenerateTransaction_Click_1(null, null);
        }

        [TestMethod]
        public void BtnGenerateReportClick_ShouldOpenFormReportMenu()
        {
            form1.btnGenerateReport_Click(null, null);
        }
    }
}
