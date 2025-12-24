#Moonikers System - Shoe Store Management
Moonikers System adalah aplikasi manajemen inventaris 
dan transaksi penjualan toko sepatu berbasis desktop. 
Aplikasi ini dirancang untuk memberikan kemudahan bagi Admin dan Kasir dalam mengelola data stok, pelanggan, hingga laporan transaksi secara efisien.

##Fitur Utama
- Sistem Autentikasi: Mendukung multi-user (Admin dan Kasir) dengan hak akses yang berbeda.
- Manajemen Produk (CRUD): Kelola data sepatu lengkap dengan ukuran, harga, stok, dan kategori merk.
- Manajemen Pelanggan: Pendataan informasi pelanggan untuk kebutuhan riwayat transaksi.
- Otomatisasi Stok: Menggunakan Database Trigger untuk mengurangi stok produk secara otomatis setelah transaksi penjualan berhasil.
- UI Modern: Antarmuka pengguna yang bersih dan interaktif menggunakan framework Guna.UI2.

##🛠️ Tech Stack
- Bahasa Pemrograman: C# (.NET Framework)
- Framework Tampilan: Guna.UI2 WinForms
- Database: MySQ
- Library: SQL Connector

##📊 Struktur Database (ERD)
- Aplikasi ini dibangun dengan relasi database yang solid untuk menjaga integritas data transaksi:
- Tabel Admin: Menyimpan data akun dan role.
- Tabel Product & Category: Mengelola inventaris sepatu.
- Tabel Penjualan & Detail: Mencatat setiap transaksi yang terjadi.
