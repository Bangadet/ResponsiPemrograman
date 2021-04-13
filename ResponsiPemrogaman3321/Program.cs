using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrogaman3321
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan("Adetia", "20.11.3321", 6000000);
            Karyawan karyawan2 = new Karyawan("Putra", "20.11.1976", 3000000);

            Console.WriteLine("NO   NIK / NAMA\t\t  Gaji ");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1. {0} {1}\t {2}", karyawan1.NIK, karyawan1.Nama, karyawan1.Gaji);
            Console.WriteLine("2. {0} {1}\t {2}\t", karyawan2.NIK, karyawan2.Nama, karyawan2.Gaji);
            Console.WriteLine();
            Console.WriteLine(" Alhamdulillah Dapat Kenaikan Gaji 10%!!");
            Console.WriteLine();
            Console.WriteLine("NO   NIK / NAMA\t\t  Gaji ");
            Console.WriteLine("---------------------------------");
            Console.WriteLine(" 1. {0} {1}\t {2}", karyawan1.NIK, karyawan1.Nama, karyawan1.Naikgaji);
            Console.WriteLine(" 2. {0} {1}\t {2}\t", karyawan2.NIK, karyawan2.Nama, karyawan2.Naikgaji);
            Console.WriteLine("---------------------------------");

            Console.ReadKey();
        }
    }
}