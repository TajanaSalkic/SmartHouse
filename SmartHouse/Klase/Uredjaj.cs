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
        protected String Naziv { get; set; }
        protected String MjestoUKuci { get; set; }
        protected Int64 Kolicina { get; set; }

        protected bool ukljucen {  get; set; }
        protected VrstaKonekcije VrstaKonekcije { get; set; }

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

        public void prikazDetalja();
    }
}
