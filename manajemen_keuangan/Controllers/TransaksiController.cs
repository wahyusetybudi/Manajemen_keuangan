using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using manajemen_keuangan.Models;

namespace manajemen_keuangan.Controllers
{
    public class TransaksiController
    {
        public static List<Transaksi> AmbilSemuaTransaksi()
        {
            return TransaksiModel.GetAll();
        }

        public static bool TambahTransaksi(string username, string jenis, DateTime tanggal, string nominalStr, out string pesan)
        {
            pesan = "";
            if (string.IsNullOrWhiteSpace(username)) { pesan = "Username tidak boleh kosong."; return false; }
            if (!decimal.TryParse(nominalStr, out decimal nominal)) { pesan = "Nominal harus berupa angka."; return false; }

            var transaksi = new Transaksi
            {
                Username = username,
                JenisTransaksi = jenis,
                Tanggal = tanggal,
                Nominal = nominal
            };

            bool sukses = TransaksiModel.Insert(transaksi);
            pesan = sukses ? "Data berhasil disimpan." : "Gagal menyimpan data.";
            return sukses;
        }

        public static bool UpdateTransaksi(int id, string username, string jenis, DateTime tanggal, string nominalStr, out string pesan)
        {
            pesan = "";
            if (id == -1) { pesan = "ID transaksi tidak valid."; return false; }
            if (string.IsNullOrWhiteSpace(username)) { pesan = "Username tidak boleh kosong."; return false; }
            if (!decimal.TryParse(nominalStr, out decimal nominal)) { pesan = "Nominal harus berupa angka."; return false; }

            var transaksi = new Transaksi
            {
                Id = id,
                Username = username,
                JenisTransaksi = jenis,
                Tanggal = tanggal,
                Nominal = nominal
            };

            bool sukses = TransaksiModel.Update(transaksi);
            pesan = sukses ? "Data berhasil diupdate." : "Gagal mengupdate data.";
            return sukses;
        }

        public static bool HapusTransaksi(int id, out string pesan)
        {
            pesan = "";
            if (id == -1) { pesan = "ID transaksi tidak valid."; return false; }
            bool sukses = TransaksiModel.Delete(id);
            pesan = sukses ? "Data berhasil dihapus." : "Gagal menghapus data.";
            return sukses;
        }
    }
}
