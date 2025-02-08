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

        private long Temperatura {  get; set; }

        private MjernaJedinica MjernaJedinica { get; set; }

        private Timer tajmer;

        public Rerna(string n, string m , bool u, VrstaKonekcije vkm, Int64 t, MjernaJedinica m )
        {
            Naziv = n;
            MjestoUKuci = m;
            ukljucen = u;
            VrstaKonekcije = vk;
            Temperatura = t;
            MjernaJedinica = m;
            tajmer = new Timer();
            tajmer.Elapsed += iskljuci;
            tajmer.AutoReset = false;


        }
        public void podesi(int t)
        {
            if (MjernaJedinica.Equals(MjernaJedinica.F))
            {
                Double FTemperatura =  (Temperatura-32)*5/9;
                Temperatura = t;
                Console.WriteLine(Naziv + " ima temperaturu od " + FTemperatura + " farenhajta odnosno " + Temperatura + " celzija");

            }
            else
            {
                double CTemperatura = (t - 32) * 5 / 9.0;
                Console.WriteLine($"{Naziv} ima temperaturu od {t}°F ({CTemperatura}°C).");

            }

        }

        public void povecaj(int broj)
        {
            Temperatura += broj;

            Console.WriteLine("Uredjaju " + Naziv + " je povecana temperatura za " + broj + " i sada iznosi: " + Temperatura + " " + MjernaJedinica.ToString());

        }

        public void smanji(int broj)
        {
            Temperatura -= broj;

            Console.WriteLine("Uredjaju " + Naziv + " je smanjena temperatura za " + broj + " i sada iznosi: " + Temperatura + " " + MjernaJedinica.ToString());

        }

        public override void prikazDetalja()
        {
            Console.WriteLine("Uredjaj " + Naziv + " se nalazi u/na " + MjestoUKuci + " povezana putem " + VrstaKonekcije.ToString() + ". Trenutno je " + ukljucen ? "ukljucen/a" : "ikljucen/a");
        }

        public void PostaviTajemr(int m)
        {
            if (ukljucen)
            {
                tajmer.Interval = m*60*1000;
                tajmer.Start();
                Console.WriteLine("Vrijeme je postavljeno na " + m + "minuta");
            }
            else
            {
                Console.WriteLine("Nemoguce postaviti uredjaj" + Naziv + " na odredjeno virjeme jer nije ukljucen/a");
                return;
            }
        }
    }
}
