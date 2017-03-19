using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia1
{
    class StandardowyCzłowiek
    {
        private string imie;
        private int wiek;
        private string miejscePochodzenia;
        public static int iloscChromosomow=46 ,iloscKosciSzkieletowych=206;
  
        public StandardowyCzłowiek(string imie, int wiek, string miejscePochodzenia)
        {
            this.imie = imie;
            this.wiek = wiek;
            this.miejscePochodzenia = miejscePochodzenia;
        }
        public int podajWiek()
        {
            return this.wiek;
        }
        public string podajImie()
        {
            return this.imie;
             }
        public string skadJestes()
        {
            return this.miejscePochodzenia;
        }
    }
}
