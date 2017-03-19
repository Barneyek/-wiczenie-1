using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia1
{
    class Program
    {




        static void Main(string[] args)
        {
            //////////////////////Zadanie 1//////////////////////////////
            /*
                    List<Samochod> Samochodziki = new List<Samochod>();
                    Samochod toyka = new Samochod(4, 120.00f);
                    Samochodziki.Add(toyka);
                        Samochod lanos = new Samochod(4, 70.50f, "srebrny", 2002);
                        Samochodziki.Add(lanos);
                        Samochod subaru = new Samochod(4, 100.52f, "biały", 2007);
                        Samochodziki.Add(subaru);
                            foreach( Samochod fura in Samochodziki)
                        {
                            fura.Jedz(fura.predkosc);
                            fura.Hamuj(fura.predkosc);
                        }
            */
            //////////////////////Zadanie 2//////////////////////////////
            /*
            List<KontoBankowe> KontaBankowe = new List<KontoBankowe>();
            KontoBankowe jeden = new KontoBankowe("jaś", "kowalski", 555323, 3505.55);
            KontaBankowe.Add(jeden);
            KontoBankowe dwa = new KontoBankowe("Krzyś", "jakubowski", 2554233, 7505.55);
            KontaBankowe.Add(dwa);
            KontoBankowe trzy = new KontoBankowe("Leszek", "Romanowski", 1234567, 23505.55);
            KontaBankowe.Add(trzy);

            foreach (KontoBankowe konto in KontaBankowe)
            {
                Console.WriteLine("Konto : "+konto.imie + " " + konto.nazwisko + " jest " + konto.statusKonta);
            }

            Console.WriteLine("Wybierz numer konta 1-3 : ");
            int wybierzKonto = Convert.ToInt32(Console.ReadLine());
            int wybierz = 1;
            
            try
            {
                KontoBankowe wybraneKonto = KontaBankowe[wybierzKonto - 1];
                while (wybierz != 0)
                {
                   
                    Console.WriteLine("Wybrałes :" + wybraneKonto.imie + " " + wybraneKonto.nazwisko + " a twój fundusz to : " + wybraneKonto.fundusze + ".  KONTO jest " + wybraneKonto.statusKonta);
                    Console.WriteLine("Wybierz coo chcesz zrobic:");
                    Console.WriteLine("1. Wpłać");
                    Console.WriteLine("2. Zmień ilość pieniędzy dzięki odsetkom");
                    Console.WriteLine("3. Usuń Konto");
                    Console.WriteLine("0. Wyjdź");
                    wybierz = Convert.ToInt32(Console.ReadLine());

                    switch (wybierz)
                    {
                        case 1:
                            {
                                Console.WriteLine("Ile Chcesz wpłacic ");
                                double hajs = Convert.ToDouble(Console.ReadLine());
                                wybraneKonto.dodajPieniadze(hajs);
                            }
                            break;

                        case 2:
                            {
                                Console.WriteLine("Podaj procent odsetek o jaki chcesz zwiekszyc stan konta");
                                double procent = Convert.ToDouble(Console.ReadLine());
                                wybraneKonto.dodajPieniadze((wybraneKonto.fundusze * (procent / 100)) - wybraneKonto.fundusze);
                            }
                            break;

                        case 3:
                            {
                                Console.WriteLine("Czy jesteś pewien? TAK/NIE");
                                string decyzja = "";
                                decyzja = Console.ReadLine();
                                if (decyzja == "TAK")
                                {
                                    wybraneKonto.ustawKonto("Nieaktywne");

                                }

                            }
                            break;

                        default:
                         
                            break;
                    }
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Podałeś zły numer konta.", e); // bez obsługi wyjątków  się wiesza.
            }
            */
            //////////////////////Zadanie 3//////////////////////////////
            List<StandardowyCzłowiek> ludzie = new List<StandardowyCzłowiek>();
            StandardowyCzłowiek typ1 = new StandardowyCzłowiek("Damian", 24, "Olsztyn");
            ludzie.Add(typ1);
            StandardowyCzłowiek typ2 = new StandardowyCzłowiek("Adam", 35, "Warszawa");
            ludzie.Add(typ2);
            StandardowyCzłowiek typiara1 = new StandardowyCzłowiek("Anna", 18, "Warszawa");
            ludzie.Add(typiara1);
            StandardowyCzłowiek typiara2 = new StandardowyCzłowiek("Kasia", 28, "Opole");
            ludzie.Add(typiara2);


            
                int wybierz = -1;
                while (wybierz != 0)
                {
                    Console.WriteLine("Wybierz coo chcesz zrobic:");
                    Console.WriteLine("1. Wyliczać średnią wieku wszystkich");
                    Console.WriteLine("2. Wypisać wszystkie imiona");
                    Console.WriteLine("3. Podać informację o uniwersalnych danych standardowego człowieka");
                    Console.WriteLine("4. Wypisać najczęściej występujące miejsce pochodzenia");
                    Console.WriteLine("0. Wyjdź");
                    wybierz = Convert.ToInt32(Console.ReadLine());
                    switch (wybierz)
                    {
                        case 1:
                            {
                                int suma = 0;
                                double srednia=0;
                                foreach (StandardowyCzłowiek typy in ludzie)
                                {

                                    int wiek = typy.podajWiek();
                                    suma = suma + wiek;
                                    srednia = suma / ludzie.Count;
                                }
                            Console.WriteLine("Średnia wieku: {0}", srednia);
                         }
                            break;
                        case 2:
                            {
                               
                                foreach (StandardowyCzłowiek typy in ludzie)
                                {
                                    Console.WriteLine("Nazywam się " +typy.podajImie());
                                }
                                
                            }
                            break;
                        case 3:
                            {
                         Console.WriteLine("Czlowiek ma "+StandardowyCzłowiek.iloscKosciSzkieletowych + " kości oraz "+ StandardowyCzłowiek.iloscChromosomow+" chromosomów");
                             }
                            break;
                        case 4:
                            {
                            Dictionary<string, int> pomSlownik = new Dictionary<string, int>();
                            string miejscePochodzenia = "";
                            foreach (StandardowyCzłowiek typy in ludzie)
                            {
                                miejscePochodzenia = typy.skadJestes();
                                if (pomSlownik.Keys.Contains(miejscePochodzenia))
                                    pomSlownik[miejscePochodzenia]++;
                                else
                                {
                                    pomSlownik.Add(miejscePochodzenia, 1);
                                }
                            }
                            Console.WriteLine(pomSlownik.Aggregate((l, r) => l.Value > r.Value ? l : r).Key);
                        
                }

                            break;
                          default:
                            Console.WriteLine("Błąd ni ma numeru.");
                            break;
                    }

                }
            }
          
       }
    }
