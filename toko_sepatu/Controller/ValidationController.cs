using System;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;

namespace toko_sepatu.Controller
{
    internal class ValidationController
    {
        // ==============================================================
        // BAGIAN 1: VALIDASI SAAT TOMBOL DIKLIK (SAVE / LOGIN)
        // ==============================================================

        // 1. Cek Username (Login/Signup)
        public bool ValidateUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Username cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // 2. Cek Password Login
        public bool ValidatePasswordLogin(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password cannot be empty!", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Regex.IsMatch(password, "^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Passwords must not contain symbols!", "Password Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // 3. Cek Signup Data
        public bool ValidateSignupData(string password, ComboBox cmbRole)
        {
            if (!ValidatePasswordLogin(password)) return false;

            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters!", "Signup Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbRole.SelectedIndex == -1 || cmbRole.Text == "Pilih Role" || string.IsNullOrWhiteSpace(cmbRole.Text))
            {
                MessageBox.Show("Please select position(Admin / Cashier)!", "Signup Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // 4. Cek Product (Add/Update)
        public bool ValidateProduct(string nama, string ukuranStr, string hargaStr, string stokStr, ComboBox cmbMerk, PictureBox pbGambar)
        {
            if (string.IsNullOrWhiteSpace(nama))
            {
                MessageBox.Show("The name of the shoe is mandatory!", "Product Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!int.TryParse(ukuranStr, out int ukuran))
            {
                MessageBox.Show("Sizes must be numbers!", "Product Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (ukuran <= 0 || ukuran > 50)
            {
                MessageBox.Show("Maximum shoe size 50 cm!", "Product Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!long.TryParse(hargaStr, out long harga) || !int.TryParse(stokStr, out int stok))
            {
                MessageBox.Show("Price and Stock must be valid numbers!", "Product Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (harga < 0 || stok < 0)
            {
                MessageBox.Show("Price and Stock cannot be negativef!", "Product Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbMerk.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cmbMerk.Text))
            {
                MessageBox.Show("Must choose a shoe brand!", "Product Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (pbGambar.Image == null)
            {
                MessageBox.Show("Please upload photos of shoes!", "Product Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // 5. Cek Customer (Add/Update) - VALIDASI FORMAT EMAIL
        public bool ValidateCustomer(string nama, string email, string alamat)
        {
            if (string.IsNullOrWhiteSpace(nama))
            {
                MessageBox.Show("Name is mandatory!", "Customer Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email is mandatory!", "Customer Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(alamat))
            {
                MessageBox.Show("AAddress is mandatory!", "Customer Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Regex Format Email (Harus ada @ dan titik)
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Incorrect Email Format!\nCorrect example: user@gmail.com", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }


        // ==============================================================
        // BAGIAN 2: VALIDASI REAL-TIME (SATPAM KEYBOARD - KeyPress)
        // ==============================================================

        // A. NAMA STRICT (PRODUK & MERK) -> BOLEH ADA ANGKA
        public void FilterNamaStrict(KeyPressEventArgs e, TextBox txt)
        {
            if (char.IsControl(e.KeyChar)) return;

            // Boleh Huruf & Angka (Sepatu Nike 99)
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // Aturan Spasi
            if (char.IsWhiteSpace(e.KeyChar))
            {
                if (txt.SelectionStart == 0) { e.Handled = true; return; }
                if (txt.SelectionStart > 0 && txt.Text[txt.SelectionStart - 1] == ' ') { e.Handled = true; return; }
            }

            // Aturan Kapital
            int posisiKursor = txt.SelectionStart;
            bool isAwalKata = (posisiKursor == 0) || (txt.Text.Length > 0 && char.IsWhiteSpace(txt.Text[posisiKursor - 1]));

            if (char.IsLetter(e.KeyChar))
            {
                if (isAwalKata) { if (char.IsLower(e.KeyChar)) e.Handled = true; }
                else { if (char.IsUpper(e.KeyChar)) e.Handled = true; }
            }
        }

        // B. NAMA CUSTOMER STRICT -> TIDAK BOLEH ANGKA
        public void FilterNamaCustomerStrict(KeyPressEventArgs e, TextBox txt)
        {
            if (char.IsControl(e.KeyChar)) return;

            // HANYA HURUF (Angka Ditolak)
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // Aturan Spasi
            if (char.IsWhiteSpace(e.KeyChar))
            {
                if (txt.SelectionStart == 0) { e.Handled = true; return; }
                if (txt.SelectionStart > 0 && txt.Text[txt.SelectionStart - 1] == ' ') { e.Handled = true; return; }
            }

            // Aturan Kapital
            int posisi = txt.SelectionStart;
            bool isAwalKata = (posisi == 0) || (txt.Text.Length > 0 && char.IsWhiteSpace(txt.Text[posisi - 1]));

            if (char.IsLetter(e.KeyChar))
            {
                if (isAwalKata) { if (char.IsLower(e.KeyChar)) e.Handled = true; }
                else { if (char.IsUpper(e.KeyChar)) e.Handled = true; }
            }
        }

        // C. EMAIL CANGGIH (Auto Lowercase + Magic Shortcut)
        public void FilterEmailStrict(KeyPressEventArgs e, TextBox txt)
        {
            // 1. CEK TOMBOL KONTROL (Backspace boleh lewat)
            if (char.IsControl(e.KeyChar)) return;

            // 2. BLOKIR HURUF BESAR (KAPITAL)
            // Kalau user tekan Shift atau Capslock -> GAK MUNCUL
            if (char.IsUpper(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // 3. FITUR MAGIC (@g -> gmail.com, @y -> yahoo.com)
            // Ini tetap jalan karena trigger-nya huruf kecil 'g', 'y', 'e'
            if (txt.Text.EndsWith("@"))
            {
                if (e.KeyChar == 'g')
                {
                    e.Handled = true; txt.AppendText("gmail.com"); return;
                }
                if (e.KeyChar == 'y')
                {
                    e.Handled = true; txt.AppendText("yahoo.com"); return;
                }
                if (e.KeyChar == 'e')
                {
                    e.Handled = true; txt.AppendText("email.com"); return;
                }
            }

            // 4. DAFTAR YANG DIPERBOLEHKAN (WHITELIST)
            // Cuma boleh: Huruf Kecil, Angka, @, Titik
            bool isAllowed = char.IsLower(e.KeyChar) ||
                             char.IsDigit(e.KeyChar) ||
                             e.KeyChar == '@' ||
                             e.KeyChar == '.';

            // 5. EKSEKUSI BLOKIR
            // Kalau karakter yang diketik BUKAN salah satu dari di atas -> BLOKIR!
            // (Ini otomatis memblokir Spasi, Strip -, Underscore _, Tanda Seru !, dll)
            if (!isAllowed)
            {
                e.Handled = true;
            }
        }

        // D. SIZE STRICT (Max 50)
        public void FilterSizeStrict(KeyPressEventArgs e, TextBox txt)
        {
            if (char.IsControl(e.KeyChar)) return;
            if (!char.IsDigit(e.KeyChar)) { e.Handled = true; return; }

            string textBaru = txt.Text.Insert(txt.SelectionStart, e.KeyChar.ToString());
            if (int.TryParse(textBaru, out int nilaiBaru))
            {
                if (nilaiBaru > 50) e.Handled = true;
            }
        }

        // E. ANGKA BIASA (Harga, Stok)
        public void FilterAngkaOnly(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // F. USERNAME (Login - Huruf Kecil & Angka Saja)
        public void FilterUsernameInput(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLower(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        // ==============================================================
        // G. VALIDASI ID TRANSAKSI (STRICT BLOCKING MODE) 
        // Request: Huruf Kecil -> GAK MUNCUL SAMA SEKALI.
        // Hanya terima: HURUF KAPITAL (A-Z) dan ANGKA (0-9).
        // ==============================================================
        public void FilterIdTransaksi(KeyPressEventArgs e)
        {
            // 1. Boleh Backspace
            if (char.IsControl(e.KeyChar)) return;

            // 2. BLOKIR SPASI
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // 3. BLOKIR HURUF KECIL (Ini yang kamu minta)
            if (char.IsLower(e.KeyChar))
            {
                e.Handled = true; // Langsung tolak, gak muncul apa-apa
                return;
            }

            // 4. WHITELIST: Cuma boleh Huruf Besar & Angka
            // Kalau bukan Huruf Besar DAN bukan Angka -> Blokir (misal simbol)
            if (!char.IsUpper(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // ==============================================================
        // H. VALIDASI PASSWORD (STRICT UNIVERSAL)
        // Request: Awal Kapital, sisanya Kecil/Angka.
        // Kompatibel dengan TextBox Biasa & Guna2TextBox
        // ==============================================================
        public void FilterPasswordStrict(KeyPressEventArgs e, object sender)
        {
            // 1. Boleh Backspace
            if (char.IsControl(e.KeyChar)) return;

            try
            {
                // Gunakan dynamic agar bisa membaca SelectionStart dari objek apa pun (TextBox/Guna2TextBox)
                dynamic txt = sender;
                int posisi = txt.SelectionStart;

                if (posisi == 0)
                {
                    // Huruf Pertama: WAJIB KAPITAL
                    // Kalau user ketik kecil/angka -> Blokir
                    if (!char.IsUpper(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    // Huruf Selanjutnya: WAJIB KECIL atau ANGKA
                    // Kalau user ketik kapital -> Blokir
                    if (char.IsUpper(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                }
            }
            catch
            {
                // Jika casting gagal atau properti tidak ada, abaikan (safety net)
            }
        }
    }
}