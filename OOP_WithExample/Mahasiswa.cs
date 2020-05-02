using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_WithExample
{
    class Mahasiswa : Person
    {
        private string npm;
        public string NPM { get { return this.npm; } set { this.npm = value; } }

        public Mahasiswa(string _noKTP, string _nama, string _alamat, string _noHP, string _email, string _npm)
        {
            #region Berasal dari class Parent ---> Person
            this.NoKTP = _noKTP;
            this.Nama = _nama;
            this.Alamat = _alamat;
            this.NoHP = _noHP;
            this.Email = _email; 
            #endregion

            this.npm = _npm;
        }

        #region Fungsi
        
        #endregion
    }
}
