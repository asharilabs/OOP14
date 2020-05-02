using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_WithExample
{    
    class Pendaftaran
    {
        #region Atribut
        private List<FormulirDaftar> formulirDaftars = new List<FormulirDaftar>();
        private Karyawan penerimaPendaftaran;
        #endregion

        #region Properties
        public int BanyakPendaftar
        {
            get
            {
                return this.formulirDaftars.Count;
            }
        }
        public List<FormulirDaftar> FormulirDaftars
        {
            get
            { return this.formulirDaftars; }
            set
            { this.formulirDaftars = value; }
        }
        #endregion

        #region Constructor
        public Pendaftaran(FormulirDaftar formulirDaftar, Karyawan _karyawan)
        {
            this.penerimaPendaftaran = _karyawan;
            this.formulirDaftars.Add(formulirDaftar);
        }
        #endregion

        #region Fungsi
        public void TampilkanInformasi()
        {
            Console.WriteLine("");
            Console.WriteLine("INFORMASI PENDAFTARAN");
            Console.WriteLine("Karyawan Penerima Pendaftaran: " + this.penerimaPendaftaran.Nama);
        }
        #endregion
    }
}