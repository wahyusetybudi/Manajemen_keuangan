using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using manajemen_keuangan.Controllers;
using manajemen_keuangan.Models;

namespace manajemen_keuangan
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }
        public void LoadDataGrid()
        {
            try
            {
                var list = TransaksiModel.GetAll();
                dataGridView1.DataSource = list;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;
                dataGridView1.ReadOnly = false; // Aktifkan edit langsung
                dataGridView1.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                var hasil = TransaksiModel.Delete(id);
                if (hasil)
                {
                    MessageBox.Show("Data berhasil dihapus.");
                    LoadDataGrid();
                }
                else
                {
                    MessageBox.Show("Gagal menghapus data.");
                }
            }
            else
            {
                MessageBox.Show("Pilih satu baris untuk dihapus.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    var transaksi = new Transaksi
                    {
                        Id = Convert.ToInt32(row.Cells["Id"].Value),
                        Username = row.Cells["Username"].Value.ToString(),
                        JenisTransaksi = row.Cells["JenisTransaksi"].Value.ToString(),
                        Tanggal = Convert.ToDateTime(row.Cells["Tanggal"].Value),
                        Nominal = Convert.ToDecimal(row.Cells["Nominal"].Value)
                    };

                    TransaksiModel.Update(transaksi);
                }

                MessageBox.Show("Perubahan berhasil disimpan.");
                LoadDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan perubahan: " + ex.Message);
            }
        }
    }
}
