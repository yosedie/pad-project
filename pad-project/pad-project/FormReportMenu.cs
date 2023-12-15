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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1(); 
            menu.ShowDialog();
            this.Close();
        }

        private void buttonAllVendor_Click(object sender, EventArgs e)
        {
           FormAllVendor Vendor = new FormAllVendor();   
           Vendor.ShowDialog();
           this.Close();
        }

        private void buttonPurchasingHistory_Click(object sender, EventArgs e)
        {
            FormPurchasingHistory PurchasingHistory = new FormPurchasingHistory();   
            PurchasingHistory.ShowDialog();
            this.Close();
        }

        private void buttonMostExpensivePurchase_Click(object sender, EventArgs e)
        {
            FormMostExpensivePurchase expensivePurchase = new FormMostExpensivePurchase();
            expensivePurchase.ShowDialog(); 
            this.Close();   
        }
    }
}
