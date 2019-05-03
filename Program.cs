using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrog2289
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan();

            karyawan1.NIK = "18112289";
            karyawan1.Nama = "Dzakiy";
            karyawan1.GajiBulanan = 3125000;

            Karyawan karyawan2 = new Karyawan();
            karyawan2.NIK = "18112299";
            karyawan2.Nama = "Anton";
            karyawan2.GajiBulanan = 3125000;

            Console.WriteLine("No.\tNIK/Nama\t\t\t\tGaji Bulanan");
            Console.WriteLine("==============================================================");
            Console.WriteLine("1. \t{0} {1}\t\t\t{2}", karyawan1.NIK, karyawan1.Nama, karyawan1.GajiBulanan);
            Console.WriteLine("2. \t{0} {1}\t\t\t{2}", karyawan2.NIK, karyawan2.Nama, karyawan2.GajiBulanan);

            Console.WriteLine("\n\n");
            Console.WriteLine("Selamat, Kenaikan Gaji Sebesar 10%");
            Console.WriteLine("\n");
            Console.WriteLine("No.\tNIK/Nama\t\t\t\tGaji Bulanan");
            Console.WriteLine("===============================================================");
            Console.WriteLine("1. \t{0} {1}\t\t\t{2}", karyawan1.NIK, karyawan1.Nama, karyawan1.GajiBulanan + (karyawan1.GajiBulanan * 0.10));
            Console.WriteLine("2. \t{0} {1}\t\t\t{2}", karyawan2.NIK, karyawan2.Nama, karyawan2.GajiBulanan + (karyawan2.GajiBulanan * 0.10));
            Console.ReadKey();
        }
    }
}
