using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_WithExample
{
    class ProgramStudi
    {
        #region Atribut
        private string nama;
        #endregion

        #region Properties
        public string Nama { get { return this.nama; } set { this.nama = value; } }
        #endregion

        #region Constructor
        public ProgramStudi(string _nama)
        {
            this.nama = _nama;
        }
        #endregion

        #region Fungsi
        
        #endregion
    }
}
