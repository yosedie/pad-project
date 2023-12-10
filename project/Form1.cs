using project.AdventureWorks2019DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        private AdventureWorks2019DataSet adventureWorksDataSet;
        private TableAdapterManager tableAdapterManager;

        public Form1()
        {
            InitializeComponent();

            adventureWorksDataSet = new AdventureWorks2019DataSet();
            tableAdapterManager = new TableAdapterManager();

            // Inisialisasi adapter dan table
            tableAdapterManager.PurchaseOrderHeaderTableAdapter = new AdventureWorks2019DataSetTableAdapters.PurchaseOrderHeaderTableAdapter();
            tableAdapterManager.VendorTableAdapter = new AdventureWorks2019DataSetTableAdapters.VendorTableAdapter();

            tableAdapterManager.PurchaseOrderHeaderTableAdapter.Fill(adventureWorksDataSet.PurchaseOrderHeader);
            tableAdapterManager.VendorTableAdapter.Fill(adventureWorksDataSet.Vendor);

        }
        private void btnGenerateTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                // Implement logic to generate transaction
                // For example, you can use the DataTable directly
                dataGridView1.DataSource = adventureWorksDataSet.PurchaseOrderHeader;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                // Implement logic to generate report
                // For example, you can use the DataTable directly
                dataGridView1.DataSource = adventureWorksDataSet.Vendor;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
