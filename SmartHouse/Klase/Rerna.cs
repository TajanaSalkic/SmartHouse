using SmartHouse.Interfejsi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace SmartHouse.Klase
{
    public class Rerna : Uredjaj, IUredjaj
    {

        private Int64 Temperatura {  get; set; }

        private MjernaJedinica MjernaJedinica { get; set; }


        public Rerna(string n, string ml , bool u, VrstaKonekcije vkm, Int64 t, MjernaJedinica m )
        {
            Naziv = n;
            MjestoUKuci = ml;
            ukljucen = u;
            VrstaKonekcije = vkm;
            Temperatura = t;
            MjernaJedinica = m;
          


        }
        public void podesi(int t)
        {
            if (MjernaJedinica.Equals(MjernaJedinica.F))
            {

                Double CTemperatura =  (Temperatura-32)*5/9;
                Temperatura = t;
                Console.WriteLine(Naziv + " ima temperaturu od "+ Temperatura + " farenhajta");

            }
            else
            {
                double FTemperatura = (t - 32) * 5 / 9.0;
                Temperatura = t;

                Console.WriteLine($"{Naziv} ima temperaturu od {t}°C ({FTemperatura}°F).");

            }

        }

        public void povecaj(int broj)
        {
            if (ukljucen)
            {

                Temperatura += broj;

                Console.WriteLine("Uredjaju " + Naziv + " je povecana temperatura za " + broj + " i sada iznosi: " + Temperatura + " " + MjernaJedinica.ToString());
            }
            else
            {
                Console.WriteLine(Naziv + " je trenutno ugasen");
            }


        }

        public void smanji(int broj)
        {
            if (ukljucen) { 
            Temperatura -= broj;

            Console.WriteLine("Uredjaju " + Naziv + " je smanjena temperatura za " + broj + " i sada iznosi: " + Temperatura + " " + MjernaJedinica.ToString());
        }
            else
            {
                Console.WriteLine(Naziv + " je trenutno ugasen");
            }

}

        public override void prikazDetalja()
        {
            if (ukljucen == false)
            {
                Temperatura = 0;
                Console.WriteLine("Uredjaj " + Naziv + " se nalazi u/na " + MjestoUKuci + " povezana putem " + VrstaKonekcije.ToString() + ".\n Trenutno je " + (ukljucen ? "ukljucen/a" : "ikljucen/a") + " i ima temperaturu od " + Temperatura + " " + MjernaJedinica.ToString());

            }
            else
            {
                Console.WriteLine("Uredjaj " + Naziv + " se nalazi u/na " + MjestoUKuci + " povezana putem " + VrstaKonekcije.ToString() + ".\n Trenutno je " + (ukljucen ? "ukljucen/a" : "ikljucen/a") + " i ima temperaturu od " + Temperatura + " " + MjernaJedinica.ToString());
            }
            }

       
    }
}
