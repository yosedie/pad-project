using pad_project.AdventureWorks2019DataSetTableAdapters;
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
    public partial class Form2 : Form
    {
        private AdventureWorks2019DataSet adventureWorksDataSet;
        private TableAdapterManager tableAdapterManager;
        private BindingSource purchaseOrderHeaderBindingSource;
        private PurchaseOrderHeaderTableAdapter purchaseOrderHeaderTableAdapter;

        public Form2()
        {
            InitializeComponent();
            InitializeDataSet();
        }
        private void InitializeDataSet()
        {
            // Inisialisasi dataset dan adapter
            adventureWorksDataSet = new AdventureWorks2019DataSet();
            purchaseOrderHeaderTableAdapter = new PurchaseOrderHeaderTableAdapter();

            // Menginisialisasi purchaseOrderHeaderBindingSource
            purchaseOrderHeaderBindingSource = new BindingSource();

            // Tidak perlu menetapkan koneksi secara eksplisit karena sudah terkonfigurasi di dalam TableAdapter
            purchaseOrderHeaderTableAdapter.Fill(adventureWorksDataSet.PurchaseOrderHeader);
            purchaseOrderHeaderBindingSource.DataSource = adventureWorksDataSet.PurchaseOrderHeader;

            // (Anda mungkin perlu menambahkan kode lain di sini, tergantung pada kebutuhan Anda)
        }

        public void SetData(int purchaseOrderID, int vendorID)
        {
            try
            {
                // Gunakan data yang diterima untuk menginisialisasi kontrol di dalam formulir pengeditan
                txtPurchaseOrderID.Text = purchaseOrderID.ToString();
                txtVendorID.Text = vendorID.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            // Penanganan klik tombol Cancel
            MessageBox.Show("Pengeditan dibatalkan.");
            this.Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Implementasi logika penyimpanan perubahan di sini
                int purchaseOrderID = Convert.ToInt32(txtPurchaseOrderID.Text);
                int newVendorID = Convert.ToInt32(txtVendorID.Text);

                // Simpan perubahan ke database atau melakukan operasi penyimpanan lainnya

                MessageBox.Show($"Data PurchaseOrderID {purchaseOrderID} berhasil disimpan.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
