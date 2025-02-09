using SmartHouse.Interfejsi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SmartHouse.Klase
{
    public class TV : Uredjaj, IUredjaj
    {
        private Int64 Kanal { get; set; }
        private Int64 Glasnoca { get; set; }

        private NacinRada NacinRada { get; set; }

        private Izvor Izvor { get; set; }

        public TV(string n, string ml, bool u, VrstaKonekcije vkm, Int64 k, Int64 g, NacinRada nr, Izvor i)
        {

            Naziv = n;
            MjestoUKuci = ml;
            ukljucen = u;
            VrstaKonekcije = vkm;
            Kanal = k;
            Glasnoca = g;
            NacinRada = nr;
            Izvor = i;

        }
        public void podesi(int t)
        {
            if (ukljucen)
            {

                Glasnoca = t;
                Console.WriteLine(Naziv + " ima glasnocu zvuka: " + Glasnoca);
            }
            else
            {
                Console.WriteLine(Naziv + " je trenutno ugasen");
            }


        }

        public void podesiKanal(int t)
        {
            if (ukljucen)
            {


                Kanal = t;
                Console.WriteLine(Naziv + " je trenutno na kanalu:  " + Kanal);
            }
            else
            {
                Console.WriteLine(Naziv + " je trenutno ugasen");

            }


        }

        public void povecaj(int broj)
        {
            if (ukljucen)
            {
                Glasnoca += broj;

                Console.WriteLine("Uredjaju " + Naziv + " je povecana glasnoca zvuka za " + broj + " i sada iznosi: " + Glasnoca);
            }
            else
            {
                Console.WriteLine(Naziv + " je trenutno ugasen");
            }


        }

        public void smanji(int broj)
        {
            if (ukljucen)
            {
                Glasnoca -= broj;

                Console.WriteLine("Uredjaju " + Naziv + " je smanjena glasnoca zvuka za " + broj + " i sada iznosi: " + Glasnoca);
            }
            else
            {
                Console.WriteLine(Naziv + " je trenutno ugasen");
            }
        }

        public void promjeniNacinRada(NacinRada n)
        {
            if (ukljucen)
            {
                NacinRada = n;
            }
            else
            {
                Console.WriteLine(Naziv + " je trenutno ugasen");
            }
        }

        public void promjeniIzor(Izvor i)
        {
            if (ukljucen)
            {
                Izvor = i;
            }
            else
            {
                Console.WriteLine(Naziv + " je trenutno ugasen");
            }
        }

        public override void prikazDetalja()
        {
            if (ukljucen)
            {


                Console.WriteLine("Uredjaj " + Naziv + " se nalazi u/na " + MjestoUKuci + " povezana putem " + VrstaKonekcije.ToString() + ".\n Trenutno je " + (ukljucen ? "ukljucen/a" : "iskljucen/a") + " i ima glasnocu zvuka od " + Glasnoca + ". Odabran je kanal " + Kanal + " u nacinu rada " + NacinRada.ToString() + ",\n a izvor koji se koristi je " + Izvor.ToString());


            }
            else
            {
                Console.WriteLine("Uredjaj " + Naziv + " se nalazi u/na " + MjestoUKuci + " povezana putem " + VrstaKonekcije.ToString() + ".\n Trenutno je " + (ukljucen ? "ukljucen/a" : "iskljucen/a") + ". Zadnji odabran kanal je bio " + Kanal + " u nacinu rada " + NacinRada.ToString() + ",\n a izvor koji se koristio je " + Izvor.ToString());

            }

        }
    }
}
