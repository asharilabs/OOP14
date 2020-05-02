using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_WithExample
{
    class Dosen : Person
    {
        private string kodeDosen;
        public string KodeDosen { get { return this.kodeDosen; } set { this.kodeDosen = value; } }

        public Dosen(string _ktp, string _nama, string _alamat, string _noHP, string _email, string _kode)
        {
            this.NoKTP = _ktp;
            this.Nama = _nama;
            this.Alamat = _alamat;
            this.NoHP = _noHP;
            this.Email = _email;
            this.kodeDosen = _kode;
        }
    }
}
