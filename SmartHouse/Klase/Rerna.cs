using SmartHouse.Interfejsi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse.Klase
{
    public class Rerna : Uredjaj, IUredjaj
    {

        private Double Temperatura {  get; set; }

        private MjernaJedinica MjernaJedinica { get; set; }
        void IUredjaj.podesi(Double t)
        {
            if (MjernaJedinica.Equals(MjernaJedinica.F))
            {
                Double FTemperatura =  (Temperatura-32)*5/9;
                Temperatura = t;
                Console.WriteLine(Naziv + " ima temperaturu od " + Temperatura + " farenhajta odnosno " + );
            }
            else
            {

            }
            
        }
    }
}
