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
        public FormPurchasingHistory()
        {
            InitializeComponent();
        }

        private void FormPurchasingHistory_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrystalReportAllPurchasing rep = new CrystalReportAllPurchasing();
            crystalReportViewer1.ReportSource = rep;

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
