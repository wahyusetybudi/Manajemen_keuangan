using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using manajemen_keuangan;
using manajemen_keuangan.Controllers;

namespace manajemen_keuangan
{
    public partial class Form1 : Form
    {
        private Form2 form2Instance;

        // Untuk menyimpan id transaksi yang sedang dipilih di DataGridView
        private int selectedId = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClearInputs();
        }

        
        private void ClearInputs()
        {
            textBoxUsername.Clear();
            textBoxNominal.Clear();
            radioButtonTUNAI.Checked = false;
            radioButtonNONTUNAI.Checked = false;
            dateTimePickerTanggal.Value = DateTime.Today;
            selectedId = -1;
        }

        private void button1_Click(object sender, EventArgs e) // SAVE
        {
            string jenis = radioButtonTUNAI.Checked ? "Peminjaman" : radioButtonNONTUNAI.Checked ? "Pembayaran" : "";
            string pesan;

            bool hasil = TransaksiController.TambahTransaksi(
                textBoxUsername.Text, jenis, dateTimePickerTanggal.Value, textBoxNominal.Text, out pesan
            );

            MessageBox.Show(pesan);
            if (hasil) ClearInputs();
        }

        private void button3_Click(object sender, EventArgs e) // UPDATE
        {
            
        }

        private void button4_Click(object sender, EventArgs e) // DELETE
        {
            
        }

        private void button2_Click(object sender, EventArgs e) // ADD (Clear form untuk input baru)
        {
            ClearInputs();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textBoxUsername.Text))
            {
                MessageBox.Show("Username tidak boleh kosong.");
                return false;
            }

            if (!decimal.TryParse(textBoxNominal.Text, out decimal nominal))
            {
                MessageBox.Show("Nominal harus berupa angka.");
                return false;
            }

            if (!radioButtonTUNAI.Checked && !radioButtonNONTUNAI.Checked)
            {
                MessageBox.Show("Pilih jenis transaksi.");
                return false;
            }

            return true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        // Event kosong agar designer tidak error (boleh dikosongkan)
        private void label1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }

        private void radioButtonTUNAI_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

    }
}
