using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOOP.MyClass
{
    public abstract class Kucing
    {
        public string Jenis { get; set; }
        public string Nama { get; set; }

        public string GetInfo()
        {
            return "Jenis: " + Jenis + " Nama: " + Nama;
        }

        public abstract string CekJenis();
        public abstract string GetSuara(string jenis);
    }

    public class KucingPersia : Kucing
    {
        public override string CekJenis()
        {
            return "Jenisnya : " + Jenis;
        }

        public override string GetSuara(string jenis)
        {
            return "Jenis " + jenis + " suara myawww";
        }
    }
}
