using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrogaman3321
{
    class Karyawan
    {
        public string Nama { get; set; }
        public string NIK { get; set; }
        public int Gaji { get; set; }
        public int Naikgaji { get; set; }

        public Karyawan(string nama, string nik, int gaji)
        {
            this.NIK = nik;
            this.Nama = nama;
            if (gaji < 0)
            {
                this.Gaji = 0;
                Naikgaji = Convert.ToInt32((Gaji * 1.1));
            }
            else
            {
                this.Gaji = gaji;
                Naikgaji = Convert.ToInt32((Gaji * 1.1));
            }
        }
    }
}
