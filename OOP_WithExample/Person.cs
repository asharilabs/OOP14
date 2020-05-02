using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_WithExample
{
    /// <summary>
    /// class ini sebagai parent untuk class Mahasiswa, Karyawan, dan Dosen.
    /// Digunakan untuk handle data-data yang berhubungan dengan Person. Tidak
    /// ada fungsi yang menyertainya disini.
    /// </summary>
    class Person
    {
        private string noKTP;
        private string nama;
        private string alamat;
        private string noHP;
        private string email;

        public string NoKTP { get { return this.noKTP; } set { this.noKTP = value; } }
        public string Nama { get { return this.nama; } set { this.nama = value; } }
        public string Alamat { get { return this.alamat; } set { this.alamat = value; } }
        public string NoHP { get { return this.noHP; } set { this.noHP = value; } }
        public string Email { get { return this.email; } set { this.email = value; } }
    }
}