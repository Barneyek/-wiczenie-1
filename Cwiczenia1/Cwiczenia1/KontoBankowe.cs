using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia1
{
    class KontoBankowe
    {
        public string imie,nazwisko;
        private int numerKontaBankowego;
        public double fundusze;
        private int idKonta=0;
        public string statusKonta;
        static int nr = 0;
        //private int hasloAdmina;

        public KontoBankowe(string imie, string nazwisko, int numerKontaBankowego, double fundusze,string statusKonta="aktywne")
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.numerKontaBankowego = numerKontaBankowego;
            this.fundusze = fundusze;
            this.idKonta = nr;
            this.statusKonta = statusKonta;
            nr++; 
        }
        public void dodajPieniadze(double hajs)
        {
            // this.fundusze = this.fundusze + hajs;
            zmieńFundusz(this.fundusze + hajs);
        }
        private void zmieńFundusz(double fundusze)
        {
            this.fundusze = fundusze;
        }
        public void zmienIloscPieniedzy(double fundusze)
        {

        }
        public void ustawKonto(string statusKonta)
        {
            this.statusKonta = "Nieaktywne";
        }
    }
}
