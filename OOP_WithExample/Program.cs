using System;
using System.Collections.Generic;

namespace OOP_WithExample
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Pengisian Data Awal: Prodi, Dosen, Karyawan
            // 1. Data Prodi
            // ---- inisiasi objek programstudi
            ProgramStudi p1 = new ProgramStudi("D3 Perpajakan");    
            ProgramStudi p2 = new ProgramStudi("D3 Manajemen Informatika");
            ProgramStudi p3 = new ProgramStudi("D3 Akuntansi");
            // ---- input data programstudi ke list yang ada di class Constanta
            Constanta.pilihanProdi.Add(p1);
            Constanta.pilihanProdi.Add(p2);
            Constanta.pilihanProdi.Add(p3);

            // 2. Dosen
            // ---- inisiasi objek dosen
            Dosen d1 = new Dosen("001-00", "Bapak Dosen", "Bandung", "08122", "bpkdos@gmail.com", "001");
            Dosen d2 = new Dosen("002-00", "Ibu Dosen", "Tasikmalaya", "08132", "ibudos@gmail.com", "002");
            // ---- input data dosen ke list dosen yang ada di class Constanta
            Constanta.pilihanDosen.Add(d1);
            Constanta.pilihanDosen.Add(d2);

            // 3. Karyawan
            // ---- inisiasi objek karyawan
            Karyawan k1 = new Karyawan("02-03", "Bapak Karyawan", "Sukabumi", "0896", "bpkkar@gmail.com", "k01");
            Karyawan k2 = new Karyawan("03-04", "Ibu Karyawan", "Cimahi", "0873", "ibukar@gmail.com", "k02");
            // ---- input data karyawan ke list karyawan yang ada di class Constanta
            Constanta.pilihanKaryawan.Add(k1);
            Constanta.pilihanKaryawan.Add(k2);
            #endregion

            #region Pendaftaran Mahasiswa Baru
            // 1. Mengisi Formulir untuk Daftar
            // ---- membuat objek formulir terlebih dahulu. Class formulirdaftar
            // ---- membutuhkan beberapa parameter, yaitu Mahasiswa (berupa objek),
            // ---- asalsekolah (berupa string), dan pilihanprodi (berupa list<ProgramStudi>)
            // ---> membuat input variable by USER
            #region INPUT INFORMASI UMUM
            Console.Write("No KTP: "); string _ktp = Console.ReadLine();
            Console.Write("NAMA: "); string _nama = Console.ReadLine();
            Console.Write("ALAMAT: "); string _alamat = Console.ReadLine();
            Console.Write("EMAIL: "); string _email = Console.ReadLine();
            Console.Write("HP: "); string _hp = Console.ReadLine();
            Console.Write("NPM: "); string _npm = Console.ReadLine();
            Console.Write("ASAL SEKOLAH: "); string _asalsekolah = Console.ReadLine();
            // buat objek mahasiswa
            Mahasiswa mahasiswa = new Mahasiswa(_ktp, _nama, _alamat, _hp, _email, _npm);
            #endregion
            Console.WriteLine("");
            
            #region INPUT PEMILIHAN DUA PRODI
            Console.WriteLine("Pemilihan Prodi (Pilih 2 Prodi)");
            // buat variable penampung pilihan prodi
            List<ProgramStudi> pilih = new List<ProgramStudi>();
            // buka daftar prodi yang dapat dipilih
            for (int i = 0; i < Constanta.pilihanProdi.Count; i++)
            {
                // tampilkan nama-nama prodi
                Console.WriteLine((i + 1) + ". " + Constanta.pilihanProdi[i].Nama);
            }
            // input nomor prodi untuk pilihan PERTAMA (contoh--> 1 kemudian ENTER)
            Console.Write("Input nomor prodi nya saja (pilihan pertama): ");
            int pilihanProdi = int.Parse(Console.ReadLine());
            pilih.Add(Constanta.pilihanProdi[pilihanProdi - 1]);
            // input nomor prodi untuk pilihan KEDUA (contoh--> 3 kemudian ENTER)
            Console.Write("Input nomor prodi nya saja (pilihan pertama): ");
            pilihanProdi = int.Parse(Console.ReadLine());
            pilih.Add(Constanta.pilihanProdi[pilihanProdi - 1]);

            // tampilkan daftar prodi yang telah dipilih
            Console.WriteLine("anda telah memilih dua prodi: ");
            for (int i = 0; i < pilih.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + pilih[i].Nama);
            }
            #endregion
            
            // ----> Buat formulir
            // -- memerlukan parameter Mahasiswa (sebagai objek), asalsekolah (string), 
            // -- dan daftarProdiDipilih (Sebagai List<ProgramStudi>) ---> variable pilih
            FormulirDaftar formulirDaftar = new FormulirDaftar(mahasiswa, _asalsekolah, pilih);

            // 2. Memberikan Formulir tersebut ke Karyawan untuk disimpan
            // ----> Masukkan formulir ke pendaftaran
            // tujuannya adalah untuk menghitung berapa banyak formulir yang telah didaftarkan
            // lihat di fungsi Pendaftaran.BanyakPendaftar
            Console.WriteLine("");
            Console.WriteLine("berikut nama karyawan yang menerima pendaftaran");
            for (int i = 0; i < Constanta.pilihanKaryawan.Count; i++)
            {
                // tampilkan data karyawan
                Console.WriteLine((i + 1) + ". " + Constanta.pilihanKaryawan[i].Nama);
            }
            // memilih karyawan
            Console.Write("Pilih nomor karyawan yang menerima pendaftaran: ");
            int _nKaryawan = int.Parse(Console.ReadLine());

            // untuk pendaftaran diperlukan parameter
            // - FormulirDaftar (objek)
            // - karyawan (objek) = yang menerima pendaftaran = input By UsER
            Pendaftaran pendaftaran = new Pendaftaran(formulirDaftar, Constanta.pilihanKaryawan[_nKaryawan - 1]);
            // Constanta.pilihanKaryawan[_nKaryawan - 1] ini merupakan pemilihan objek karyawan
            // yang sebelumnya telah diinputkan

            // 3. Mengisi Data Keuangan
            // untuk mengisi data keuangan, digunakan class Keuangan.
            // membutuhkan dua parameter, yaitu berkas pendaftarannya (objek Pendaftaran),
            // dan besar setoran (int) ----> input by user
            Console.WriteLine("");
            Console.WriteLine("Pengisian Data Keuangan");
            Console.WriteLine("Calon mahasiswa atas nama " + formulirDaftar.Pendaftar.Nama);
            Console.Write("Besar setoran: "); int besarSetoran = int.Parse(Console.ReadLine());
            Keuangan keuangan = new Keuangan(formulirDaftar, besarSetoran);

            // 4. Mengisi Data Perwalian
            Console.WriteLine("Berikut daftar dosen untuk dijadikan dosen wali:");
            // tampilkan data dosen
            for (int i = 0; i < Constanta.pilihanDosen.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + Constanta.pilihanDosen[i].Nama);
            }
            Console.Write("pilih nomor dosen (1 - " + Constanta.pilihanDosen.Count + "): ");
            int pilihDosenWali = int.Parse(Console.ReadLine());
            Dosen dosenWali = Constanta.pilihanDosen[pilihDosenWali - 1];   // harus dikurangi satu, agar index nya tepat.
                                                                            // index pada pilihan dimulai dari 1, sedangkan array dari 0
                                                                            // bikin objek perwalian
            Perwalian perwalian = new Perwalian(formulirDaftar, dosenWali);
            #endregion


            #region Tampilkan Info-Info
            Console.WriteLine("Berikut ini adalah Data Mahasiswa Pendaftar");
            Console.WriteLine(Constanta._NAMAKAMPUS);
            Console.WriteLine(Constanta._ALAMATKAMPUS);
            Console.WriteLine("-----------------------------");

            pendaftaran.TampilkanInformasi();
            formulirDaftar.TampilkanInformasi();
            perwalian.TampilkanInformasi();
            keuangan.TampilkanInformasi();
            #endregion

            Console.ReadKey();
        }
    }
}
