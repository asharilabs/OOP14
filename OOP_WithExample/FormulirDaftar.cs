using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_WithExample
{
    class FormulirDaftar
    {
        #region Atribut
        private Mahasiswa _mhsPendaftar;
        private string noPendaftaran;
        private string asalSekolah;
        private List<ProgramStudi> pilihanProdi; 
        #endregion

        #region Properties
        public Mahasiswa Pendaftar
        {
            get { return this._mhsPendaftar; }
            set { this._mhsPendaftar = value; }
        }
        public string NoPendaftaran
        {
            get { return this.noPendaftaran; }
            set { this.noPendaftaran = value; }
        }
        public string AsalSekolah
        {
            get { return this.asalSekolah; }
            set { this.asalSekolah = value; }
        }
        public List<ProgramStudi> _ProgramStudi
        {
            get { return this.pilihanProdi; }
            set { this.pilihanProdi = value; }
        }
        #endregion

        #region Constructor
        public FormulirDaftar(Mahasiswa mahasiswa, string asalSekolah, List<ProgramStudi> _pilihan)
        {
            this._mhsPendaftar = mahasiswa;
            this.asalSekolah = asalSekolah;
            this.pilihanProdi = _pilihan;
        }
        #endregion

        #region Fungsi
        public void TampilkanInformasi()
        {
            Console.WriteLine("");
            Console.WriteLine("NO KTP\t\t: " + this._mhsPendaftar.NoKTP);
            Console.WriteLine("NAMA\t\t: " + this._mhsPendaftar.Nama);
            Console.WriteLine("ALAMAT\t\t: " + this._mhsPendaftar.Alamat);
            Console.WriteLine("NO HP\t\t: " + this._mhsPendaftar.NoHP);
            Console.WriteLine("EMAIL\t\t: " + this._mhsPendaftar.Email);
            Console.WriteLine("NPM\t\t: " + this._mhsPendaftar.NPM);
            Console.WriteLine("ASAL SEKOLAH\t: " + this.asalSekolah);
            Console.WriteLine("Prodi yang didaftarkan:");
            for (int i = 0; i < this.pilihanProdi.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + this.pilihanProdi[i].Nama);
            }
        }
        #endregion
    }
}