
using SmartHouse.Klase;

class Program
{
    static void main(string[] args)
    {
        Rerna rerna = new Rerna("Rerna Panasonic","Kuhinja", false, VrstaKonekcije.WiFi, 0, MjernaJedinica.C);

        rerna.ukljuci();
        rerna.podesi(200);
        rerna.povecaj(2);
        rerna.smanji(2);
        rerna.PostaviTajemr(1);
        rerna.iskljuci();
    }
}