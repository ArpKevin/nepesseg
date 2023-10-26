using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nepesseg
{
    class Orszag
    {
        public string Orszagnev { get; private set; }
        public int Terulet { get; private set; }
        public int Nepesseg { get; private set; }
        public string Fovaros { get; private set; }
        public int FovarosNepesseg { get; private set; }
        public bool FovarosbanKoncentralt => FovarosNepesseg * 1000 >= Nepesseg * 0.3;

        public Orszag(string sor)
        {
            var o = sor.Split(';');
            Orszagnev = o[0];
            Terulet = int.Parse(o[1]);
            Nepesseg = int.Parse(o[2].Replace("g", "0000"));
            Fovaros = o[3];
            FovarosNepesseg = int.Parse(o[4]);
        }

        public int Nepsuruseg => Nepesseg / Terulet;

        public override string ToString()
        {
            return "";
        }
    }

}
