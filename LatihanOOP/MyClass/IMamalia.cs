using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOOP.MyClass
{
    public interface IMamalia
    {
        string GetJenis();
        string GetKecepatanJalan();
        void Lari();
    }

    public interface IBird
    {
        string GetSayap();
        void Terbang();
    }

    public class Binatang : IMamalia,IBird
    {
        public int sayap { get; set; }
        public int kaki { get; set; }

        public string GetJenis()
        {
            return "Jenis";
        }

        public string GetKecepatanJalan()
        {
            return "Kecepatan jalan";
        }

        public string GetSayap()
        {
            return "Get Sayap";
        }

        public void Lari()
        {
            kaki = 4;
        }

        public void Terbang()
        {
            sayap = 2;
        }
    }
}
