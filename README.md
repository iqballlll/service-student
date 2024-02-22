# SERVICE STUDENT ATR UNIVERSITY

Simpel API untuk mahasiswa Universitas ATR

## Instalasi

Panduan instalasi dan pengaturan proyek. Pastikan untuk menyertakan prasyarat sistem, langkah-langkah instalasi, dan konfigurasi yang diperlukan.

### Prasyarat

- Daftar prasyarat atau dependensi yang diperlukan untuk menjalankan proyek, seperti:
  - PostgreSQL 16
  - .NET 8

### Instalasi

1. Hubungkan database postgresql dengan project

2. Sesuaikan dengan appsettings.json yang ada di folder project
    
3. Masuk ke direktori program, kemudian jalan perintah berikut pada terminal
    ```sh
    dotnet ef database update
    ```
4. Jangan lupa untuk cek apakah database sudah sukses untuk diperbarui
5. Silakan running program .NET
    

## Penggunaan

API tersedia secara online dengan URL :

```sh
http://103.245.38.201/v1/students
```

POST http://103.245.38.201/v1/students
Content-Type: application/json

{
  "name": "John Doe",
  "age": 18,
  "address": "123 Main Street",
  "gender": "male"
}



## Kontak

Jika Anda memiliki pertanyaan atau masalah terkait proyek, silakan hubungi [Muhammad Iqbal A] di [https://wa.me/6285559059632].
