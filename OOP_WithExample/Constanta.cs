using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_WithExample
{
    /// <summary>
    /// Class ini berfungsi sebagai penaruh nilai-nilai konstanta. Tidak
    /// perlu adanya maintain data/informasi disini. Oleh karena itu tipe
    /// dari variable-nya adalah public static. Public agar bisa diakses 
    /// keluar class-nya, dan static agar tidak perlu dibuat objek lagi
    /// si-class Constanta ini.
    /// </summary>
    class Constanta
    {

        #region Variable yang berfungsi hanya sebagai pelengkap data saja
        public static string _NAMAKAMPUS = "Politeknik Praktisi Bandung";
        public static string _ALAMATKAMPUS = "Jalan Merdeka No. 46";
        public static int _BIAYAPERKULIAHAN = 6000000; 
        #endregion

        /// <summary>
        /// variable pilihanProdi untuk menampung daftar prodi yang dapat dipilih
        /// </summary>
        public static List<ProgramStudi> pilihanProdi = new List<ProgramStudi>();
        /// <summary>
        /// variable pilihanDosen untuk menampung daftar dosen-dosen
        /// </summary>
        public static List<Dosen> pilihanDosen = new List<Dosen>();
        /// <summary>
        /// variable pilihanKaryawan untuk menampung daftar karyawan
        /// </summary>
        public static List<Karyawan> pilihanKaryawan = new List<Karyawan>();
    }
}