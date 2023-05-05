# CRUD Zakat
Aplikasi ini adalah aplikasi CRUD berbasis C# yang dikembangkan menggunakan Visual Studio 2017 serta xampp dan SQL dengan menggunakan MySQL Connector Net 6.6.4. Aplikasi ini dibuat untuk tugas Ujian Tengah Semester semester 4 mata kuliah PBO dan Praktek PBO.

# Petunjuk Pemakaikan
- Aplikasi dapat diakses tanpa menggunakan xampp secara online dengan menjalankan file bernama basic_crud.exe pada folder Debug (basic_crud\bin\Debug) dengan mendownload file .rar pada seksi "Release" terbaru.
- Database offline dapat diakses dengan menggunakan file SQL yang disediakan dengan Connection String sebagai berikut:
MySqlConnection koneksi = new MySqlConnection("server=localhost;database=date_test;uid=root;pwd=;convert zero datetime=True");
- Halaman admin dapat diakses menggunakan usename dan password (password dan username = admin) dan admin dapat menambahkan akun admin baru lainnya.
- Halaman non admin dapat diakses tanpa menggunakan username dan password tapi hanya dapat sebatas melihat/ membaca data saja.
- Nama database tersebut ialah "date_test" (tanpa tanda kutip).
- NIK bersifat Auto Increment sehingga user tidak perlu memasukkan NIK secara manual.
- Cek total berfungsi untuk menghitung jumlah jiwa * jenis beras * 4,3.



# Anggota Kelompok
Anggota kelompok kami antara lain :
- Ayu Aria Lestari		12110069
- Azrul Maulana Ihsan	12110097
- Jihan Meta 			12110103	
- Restu Cahya Apriyani	12110066
