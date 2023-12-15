using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pad_project
{
    public partial class FormPurchasingHistory : Form
    {
        private DataSet GetYourDataSet()
        {
            // Example: Creating a DataSet with a DataTable
            DataSet dataSet = new DataSet("TableCombo");

            DataTable dataTable = new DataTable("myTable");
            dataTable.Columns.Add("DisplayColumn", typeof(string));
            dataTable.Columns.Add("ValueColumn", typeof(int));

            // Add some sample data
            dataTable.Rows.Add("Option 1", 1);
            dataTable.Rows.Add("Option 2", 2);
            dataTable.Rows.Add("Option 3", 3);

            dataSet.Tables.Add(dataTable);

            return dataSet;
        }
        public FormPurchasingHistory()
        {
            InitializeComponent();
        }

        private void FormPurchasingHistory_Load(object sender, EventArgs e)
        {
            AdventureWorks2019DataSet dataset = new AdventureWorks2019DataSet();

            var employee = from a in dataset.Employee
                           join p in dataset.Person on a.BusinessEntityID equals p.BusinessEntityID
                           select p.FirstName;
            comboBoxEmployee.DataSource = employee.ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrystalReportAllPurchasing PurchasingReport = new CrystalReportAllPurchasing();
            PurchasingReport.SetParameterValue("EmployeeID", comboBoxEmployee.SelectedValue);
            crystalReportViewer1.ReportSource = PurchasingReport;

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormReportMenu menu = new FormReportMenu();
            menu.Show(this);    
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
