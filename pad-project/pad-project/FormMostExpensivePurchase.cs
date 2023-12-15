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
    public partial class FormMostExpensivePurchase : Form
    {
        public FormMostExpensivePurchase()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormReportMenu menu = new FormReportMenu();
            menu.Show(this);
            this.Close();
        }

        private void buttonCreateReport_Click(object sender, EventArgs e)
        {
            CachedCrystalReportMostExpenxivePurchasing rep = new CachedCrystalReportMostExpenxivePurchasing();
            crystalReportViewer1.ReportSource = rep;
        }

        private void FormMostExpensivePurchase_Load(object sender, EventArgs e)
        {
            
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
