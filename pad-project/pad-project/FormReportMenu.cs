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
    public partial class FormReportMenu : Form
    {
        public FormReportMenu()
        {
            InitializeComponent();
        }

        internal void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        internal void buttonAllVendor_Click(object sender, EventArgs e)
        {
           FormAllVendor Vendor = new FormAllVendor();   
           Vendor.ShowDialog();
        }

        internal void buttonPurchasingHistory_Click(object sender, EventArgs e)
        {
            FormPurchasingHistory PurchasingHistory = new FormPurchasingHistory();   
            PurchasingHistory.ShowDialog();
        }

        internal void buttonMostExpensivePurchase_Click(object sender, EventArgs e)
        {
            FormMostExpensivePurchase expensivePurchase = new FormMostExpensivePurchase();
            expensivePurchase.ShowDialog();
        }
    }
}
