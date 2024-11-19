using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valutavalto_from_20241119
{
    internal class Valuta
    {
        string nev;
        int ft;
        string devkod;
        double arfolyam;

        public string Nev { get => nev; set => nev = value; }
        public int Ft { get => ft; set => ft = value; }
        public string Devkod { get => devkod; set => devkod = value; }
        public double Arfolyam { get => arfolyam; set => arfolyam = value; }
    
        public Valuta(string row)
        {
            string[] darabok=row.Split(';');
            nev =darabok[0];
            ft = Convert.ToInt32(darabok[1]);
            devkod = darabok[2];
            arfolyam = Convert.ToDouble(darabok[3]);
        }

        public double devizaosszegszamitas()
        {
            return Math.Round(ft / arfolyam,2);
        }
    }
}
