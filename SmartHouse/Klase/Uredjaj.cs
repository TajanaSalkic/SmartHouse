using SmartHouse.Interfejsi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse.Klase
{
    public class Uredjaj
    {
        private String Naziv { get; set; }
        private String MjestoUKuci { get; set; }
        private Int64 Kolicina { get; set; }

        private bool ukljucen {  get; set; }
        private VrstaKonekcije VrstaKonekcije { get; set; }

        public void ukljuci()
        {
            ukljucen = true;
            Console.WriteLine(this.Naziv + " je ukljucen/ukljucena!");
        }

        public void iskljuci()
        {
            ukljucen = false;
            Console.WriteLine(this.Naziv + " je iskljucen/iskljucena!");
        }
    }
}
