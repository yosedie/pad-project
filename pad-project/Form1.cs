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
    public partial class Form1 : Form
    {
        private AdventureWorks2019DataSet adventureWorksDataSet;
        private TableAdapterManager tableAdapterManager;
        private int selectedRowIndex = -1;

        public Form1()
        {
            InitializeComponent();

            adventureWorksDataSet = new AdventureWorks2019DataSet();
            tableAdapterManager = new TableAdapterManager();

            // Inisialisasi adapter dan table
            tableAdapterManager.PurchaseOrderHeaderTableAdapter = new AdventureWorks2019DataSetTableAdapters.PurchaseOrderHeaderTableAdapter();
            tableAdapterManager.VendorTableAdapter = new AdventureWorks2019DataSetTableAdapters.VendorTableAdapter();

            // Mengisi data ke dataset
            tableAdapterManager.PurchaseOrderHeaderTableAdapter.Fill(adventureWorksDataSet.PurchaseOrderHeader);
            tableAdapterManager.VendorTableAdapter.Fill(adventureWorksDataSet.Vendor);

            // Tambahkan event handler untuk tombol "Clear"
            btnClear.Click += btnClear_Click;

            // Panggil metode untuk menginisialisasi DataGridView
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            // DataGridView properties
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Tambahkan event handler untuk menangani klik sel pada DataGridView
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void ClearDataGridView()
        {
            // Membersihkan DataGridView sebelum menampilkan data baru
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Menyimpan indeks baris terpilih
            selectedRowIndex = e.RowIndex;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();

        }
        private void RefreshData()
        {
            // Mengisi data ke dataset
            tableAdapterManager.PurchaseOrderHeaderTableAdapter.Fill(adventureWorksDataSet.PurchaseOrderHeader);
            tableAdapterManager.VendorTableAdapter.Fill(adventureWorksDataSet.Vendor);
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Bersihkan DataGridView
            ClearDataGridView();

            // Reset indeks baris terpilih
            selectedRowIndex = -1;
        }
        private void btnGenerateTransaction_Click_1(object sender, EventArgs e)
        {
            try
            {
                string filter = txtTransactionFilter.Text;

                // Gunakan DataView untuk menerapkan filter pada DataTable
                DataView dataView = new DataView(adventureWorksDataSet.PurchaseOrderHeader);
                dataView.RowFilter = $"VendorID = {filter}";

                ClearDataGridView();
                dataGridView1.DataSource = dataView.ToTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating transaction: " + ex.Message + " Masukan VendorID, Contoh:1492");
            }
            RefreshData();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            FormReportMenu report = new FormReportMenu();
            report.ShowDialog();
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // Memeriksa apakah ada baris terpilih
                if (selectedRowIndex >= 0 && selectedRowIndex < dataGridView1.Rows.Count)
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                    // Ambil nilai dari kolom-kolom yang diperlukan
                    int purchaseOrderID = Convert.ToInt32(selectedRow.Cells["PurchaseOrderID"].Value.ToString());
                    int vendorID = Convert.ToInt32(selectedRow.Cells["VendorID"].Value.ToString());

                    // Implementasi logika edit di sini
                    // Misalnya, membuka jendela edit atau mengaktifkan kontrol untuk mengedit
                    // Membuka formulir pengeditan dan mengirimkan data yang akan diedit
                    Form2 form2 = new Form2();
                    form2.SetData(purchaseOrderID, vendorID);
                    form2.ShowDialog();

                    // Bersihkan indeks baris terpilih setelah pengeditan
                    selectedRowIndex = -1;
                }
                else
                {
                    MessageBox.Show("Pilih baris yang akan diedit.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            RefreshData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if there is a selected row
                // Mendapatkan baris terpilih
                DataRowView selectedRow = dataGridView1.SelectedRows[0].DataBoundItem as DataRowView;

                // Memeriksa apakah ada baris terpilih
                if (selectedRow != null)
                {
                    // Implementasi logika hapus di sini
                    selectedRow.Row.Delete();
                    // Simpan perubahan ke database
                    tableAdapterManager.PurchaseOrderHeaderTableAdapter.Update(adventureWorksDataSet.PurchaseOrderHeader);
                }
                else
                {
                    MessageBox.Show("Pilih baris yang akan dihapus.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            RefreshData();
        }
        private void DeletePurchaseOrderDetails(int purchaseOrderID)
        {
            // Update PurchaseOrderDetail records to remove references to the specified PurchaseOrderID
            foreach (var detailRow in adventureWorksDataSet.PurchaseOrderDetail.Where(d => d.PurchaseOrderID == purchaseOrderID))
            {
                detailRow.PurchaseOrderID = 0; // Assign the default value for int (assuming it's an int)
            }

            // Optionally, save changes to the "PurchaseOrderDetail" table
            tableAdapterManager.UpdateAll(adventureWorksDataSet);
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Simpan perubahan ke database
                tableAdapterManager.PurchaseOrderHeaderTableAdapter.Update(adventureWorksDataSet.PurchaseOrderHeader);
                MessageBox.Show("Data berhasil disimpan.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            RefreshData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Mengaktifkan tombol edit dan hapus ketika baris terpilih
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Mengaktifkan tombol edit dan hapus ketika baris terpilih
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit(); // Keluar dari aplikasi
            }
        }

        private void txtTransactionFilter_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {

        }

        private void btnGenerateTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                string filter = txtTransactionFilter.Text;

                // Gunakan DataView untuk menerapkan filter pada DataTable
                DataView dataView = new DataView(adventureWorksDataSet.PurchaseOrderHeader);
                dataView.RowFilter = $"VendorID = {filter}";

                ClearDataGridView();
                dataGridView1.DataSource = dataView.ToTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating transaction: " + ex.Message + " Masukan VendorID, Contoh:1492");
            }
            RefreshData();
        }
    }
}
