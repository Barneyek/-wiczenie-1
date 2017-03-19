using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia1
{
    class Samochod
    {
        private int liczbaKol, rocznik;
        public float predkosc;
        private string marka, kolor;
        public Samochod(int liczbaKol, float predkosc, string marka="Czarny", int rocznik = 2016)
        {
            this.liczbaKol = liczbaKol;
            this.predkosc = predkosc;
            this.marka = marka;
            this.rocznik = rocznik;
        }
        public void Jedz(float predkosc)
        {
            Console.WriteLine(this.kolor+" samochod marki " + this.marka + " jedzie z prędkością " + predkosc);
            Console.WriteLine("Domyślna ilość kół używanych jednocześnie w samochodzie to [" + this.liczbaKol + "]");
        }
        public void Hamuj(float predkosc)
        {
            Console.WriteLine(this.kolor + " Samochod marki " + this.marka + " hamuje z prędkością " + predkosc);
        }
    }
}
