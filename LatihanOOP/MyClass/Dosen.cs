using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOOP.MyClass
{
    public class Dosen
    {
        public string Nik { get; set; }
        public string Nama { get; set; }
        public string Email { get; set; }

        public virtual string GetIdentitas()
        {
            return Nik + " " + Nama + " " + Email;
        }
    }

    public class DosenTerbang : Dosen
    {
        public string TiketPesawat { get; set; }

        public override string GetIdentitas()
        {
            return Nik + " " + Nama + " " + TiketPesawat;
        }
    }

    public class DosenTamu : Dosen
    {
        public string Asal { get; set; }

        public override string GetIdentitas()
        {
            return Nik + " " + Nama + " " + Asal;
        }
    }
}
