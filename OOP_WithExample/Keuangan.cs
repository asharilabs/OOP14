using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_WithExample
{
    class Keuangan
    {
        #region Atribut
        private FormulirDaftar _formulirPendaftaran;
        private int besarSetoran;        
        #endregion

        #region Properties
        public FormulirDaftar FormulirDaftar { get { return this._formulirPendaftaran; } 
            set { this._formulirPendaftaran = value; } }
        public int BesarSetoran { get { return this.besarSetoran; } set { this.besarSetoran = value; } }
        #endregion

        #region Constructor
        public Keuangan(FormulirDaftar _form, int setoran)
        {
            this._formulirPendaftaran = _form;
            this.besarSetoran = setoran;
        }
        #endregion

        #region Fungsi
        private int GetSisaSetoran() 
        { 
            return Constanta._BIAYAPERKULIAHAN - this.besarSetoran;  
        }

        public void TampilkanInformasi()
        {
            Console.WriteLine("");
            Console.WriteLine("INFORMASI KEUANGAN");
            Console.WriteLine("Pembayaran atas nama " + this.FormulirDaftar.Pendaftar.Nama +
                " sebesar: Rp " + this.besarSetoran);
            Console.WriteLine("Sisa Pembayaran: Rp" + this.GetSisaSetoran());
        }
        #endregion
    }
}
