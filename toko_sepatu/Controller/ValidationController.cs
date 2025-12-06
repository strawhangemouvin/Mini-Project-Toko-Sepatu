using System;
using System.Windows.Forms;
using System.Drawing; 

namespace toko_sepatu.Controller
{
    internal class ValidationController
    {
        // 1. VALIDASI TEKS (NAMA)
        public bool ValidateNama(string nama)
        {
            if (string.IsNullOrWhiteSpace(nama))
            {
                MessageBox.Show("Nama Sepatu tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // 2. VALIDASI ANGKA (HARGA, STOK, UKURAN)
        public bool ValidateAngka(string angka, string namaField)
        {
            if (string.IsNullOrWhiteSpace(angka))
            {
                MessageBox.Show(namaField + " tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            foreach (char c in angka)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show(namaField + " harus berisi angka saja!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        // 3. VALIDASI COMBOBOX (MERK)
        public bool ValidateComboBox(ComboBox cb)
        {
            if (cb.SelectedIndex == -1 || string.IsNullOrEmpty(cb.Text))
            {
                MessageBox.Show("Silakan pilih Merk Sepatu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // 4. VALIDASI FOTO (GAMBAR)
        public bool ValidateFoto(PictureBox pb)
        {
            if (pb.Image == null)
            {
                MessageBox.Show("Harap upload foto sepatu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}