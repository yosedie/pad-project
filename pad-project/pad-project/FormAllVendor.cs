using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pad_project
{
    public partial class FormAllVendor : Form
    {
        public FormAllVendor()
        {
            InitializeComponent();
        }

        private void FormAllVendor_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonCreateReport_Click(object sender, EventArgs e)
        {
            CrystalReport1 vend = new CrystalReport1();
            vend.SetDatabaseLogon("", "", ".", " AdventureWorks2019DataSet");
            crystalReportViewer1.ReportSource = vend;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormReportMenu menu = new FormReportMenu();
            menu.Show(this);
            this.Close();
        }
    }
}
