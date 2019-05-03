using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrog2289
{
    class Karyawan
    {
        public Karyawan() { }
        public Karyawan(string nik, string nama, int gajibulanan)
        {
            if (GajiBulanan < 0)
            {
                Console.WriteLine("Nilai harus di atas 0!");
            }
            else
            {
                NIK = nik;
                Nama = nama;
                GajiBulanan = gajibulanan;
            }
        }
        public string NIK { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }
    }
}
