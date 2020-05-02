using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_WithExample
{
    class Perwalian
    {
        private FormulirDaftar formulirDaftar;
        private Dosen dosen;

        public FormulirDaftar FormulirDaftar { get { return this.formulirDaftar; }
            set { this.formulirDaftar = value; } }
        public Dosen Dosen { get { return this.dosen; } set { this.dosen = value; } }

        public Perwalian(FormulirDaftar form, Dosen _dosen)
        {
            this.formulirDaftar = form;
            this.dosen = _dosen;
        }

        #region Fungsi
        public void TampilkanInformasi()
        {
            Console.WriteLine("");
            Console.WriteLine("INFORMASI PERWALIAN");
            Console.WriteLine("Mahasiswa atas nama: " + formulirDaftar.Pendaftar.Nama); // ini adalah cara mengakses nama
                                                                                        // dari class formulirdaftar.pendaftar
            Console.WriteLine("Dosen Wali: " + dosen.Nama);
        }
        #endregion
    }
}
