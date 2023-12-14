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
            FormReportMenu menu = new FormReportMenu(); 
            menu.ShowDialog();
            this.Close();
        }

        private void buttonAllVendor_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonPurchasingHistory_Click(object sender, EventArgs e)
        {
            FormPurchasingHistory PurchasingHistory = new FormPurchasingHistory();   
            PurchasingHistory.ShowDialog();
            this.Close();
        }
    }
}
