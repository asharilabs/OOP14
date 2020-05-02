using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_WithExample
{
    class Karyawan : Person
    {
        private string nik;
        public string NIK { get { return this.nik; } set { this.nik = value; } }

        #region Constructor
        public Karyawan(string _ktp, string _nama, string _alamat, string _noHP, string _email, string _nik)
        {
            this.NoKTP = _ktp;
            this.Nama = _nama;
            this.Alamat = _alamat;
            this.NoHP = _noHP;
            this.Email = _email;
            this.nik = _nik;
        }
        #endregion
    }
}
