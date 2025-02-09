
using SmartHouse.Klase;

class Program
{

    static Int64 meni()
    {
        Console.WriteLine("---------------- MENI ----------------");
        Console.WriteLine("1. Prikazi automatksi sve funkcionalnosti bez unosa");
        Console.WriteLine("2. Dodaj rernu");
        Console.WriteLine("3. Podesi temperaturu");
        Console.WriteLine("4. Povecaj temperaturu");
        Console.WriteLine("5. Smanji temperaturu");
        Console.WriteLine("6. Dodaj TV");
        Console.WriteLine("7. Podesi glasnocu");
        Console.WriteLine("8. Povecaj glasnocu");
        Console.WriteLine("9. Smanji glsanocu");
        Console.WriteLine("10. Podesi kanal");
        Console.WriteLine("11. Ukljuci uredjaj");
        Console.WriteLine("12. Iskljuci uredjaj");
        Console.WriteLine("13. Lista uredjaja");
        Console.WriteLine("14. Izadji iz programa");

        Int64 opcija;
        string unos;
        do
        {
            Console.WriteLine("Izaberite opciju: ");
            unos = Console.ReadLine();

        } while (!Int64.TryParse(unos, out opcija));

        return opcija;

    }
    static void Main(string[] args)
    {
        Rerna rerna = new Rerna("Rerna Panasonic","Kuhinja", false, VrstaKonekcije.Bluetooth, 0, MjernaJedinica.C);
        TV tv = new TV("Samsung SmartTV", "Dnevna", false, VrstaKonekcije.WiFi, 1, 0, NacinRada.Standardno, Izvor.HDMI);
        List<Uredjaj> uredjaji = new List<Uredjaj>();

        uredjaji.Add(rerna);
        uredjaji.Add(tv);




        while (true)
        {
            switch (meni())
            {
                case 1:
                    Console.WriteLine("Prikaz funkcija nad rernom");

                    Console.WriteLine("\nPrikaz detalja\n");

                    rerna.prikazDetalja();
                    Console.WriteLine("\nUkljucivanje rerne\n");

                    rerna.ukljuci();
                    Console.WriteLine("\nPrikaz detalja\n");

                    rerna.prikazDetalja();

                    Console.WriteLine("\nPodesavanje temperature rerne\n");

                    rerna.podesi(200);

                    Console.WriteLine("\nPovecavanje temperature rerne\n");

                    rerna.povecaj(2);

                    Console.WriteLine("\nSmanjivanje temperature rerne\n");

                    rerna.smanji(1);

                    Console.WriteLine("\nIskljucivanje rerne\n");

                    rerna.iskljuci();

                    Console.WriteLine("\nPrikaz detalja\n");

                    rerna.prikazDetalja();


                    Console.WriteLine("\nPrikaz funkcija nad TV-om\n");

                    Console.WriteLine("\nPrikaz detalja\n");

                    tv.prikazDetalja();
                    Console.WriteLine("\nUkljucivanje TV-a\n");

                    tv.ukljuci();
                    Console.WriteLine("\nPrikaz detalja\n");

                    tv.prikazDetalja();

                    Console.WriteLine("\nPodesavanje glasnoce TV\n");

                    tv.podesi(20);

                    Console.WriteLine("\nPovecavanje glasnoce TV\n");

                    tv.povecaj(5);

                    Console.WriteLine("\nSmanjivanje glasnoce TV\n");

                    tv.smanji(1);

                    Console.WriteLine("\nPodesavanje kanal\n");

                    tv.podesiKanal(4);

                    Console.WriteLine("\nPromjena nacina rada na Kino\n");

                    tv.promjeniNacinRada(NacinRada.Kino);

                    Console.WriteLine("\nPromjena izvora na Youtube\n");

                    tv.promjeniIzor(Izvor.YouTube);

                    Console.WriteLine("\nIskljucivanje TV-a\n");

                    tv.iskljuci();

                    Console.WriteLine("\nPrikaz detalja\n");

                    tv.prikazDetalja();
                    break;

                    case 2:
                        Console.WriteLine("Dodavanje nove rerne");

                        Console.Write("Unesite naziv rerne: ");
                        string naziv = Console.ReadLine();

                        Console.Write("Unesite mjesto u kući: ");
                        string mjesto = Console.ReadLine();

                        Console.Write("Da li je uređaj uključen? (true/false): ");
                        bool ukljucen;
                        while (!bool.TryParse(Console.ReadLine(), out ukljucen))
                        {
                            Console.WriteLine("Pogrešan unos! Molimo unesite 'true' ili 'false'.");
                        }

                        VrstaKonekcije konekcija = VrstaKonekcije.WiFi;
                        long opcija;
                        string unos;
                        do
                        {
                        Console.WriteLine("Odaberite vrstu konekcije (1 - WiFi, 2 - Bluetooth): ");
                        unos = Console.ReadLine();

                        } while (!Int64.TryParse(unos, out opcija) || opcija<1 || opcija>2);

                        switch (opcija)
                        {
                            case 1:
                                konekcija = VrstaKonekcije.WiFi;
                                break;
                            case 2:
                                konekcija = VrstaKonekcije.Bluetooth;
                                break;
                        }

                    long temperatura=0;
                    string unos1;
                    if (ukljucen)
                    {
                        
                        do
                        {
                            Console.WriteLine("Unesite temperaturu rerne: ");
                            unos1 = Console.ReadLine();

                        } while (!Int64.TryParse(unos1, out temperatura) || temperatura < 0);


                        Console.WriteLine();
                    }
                        

                        Console.WriteLine("Odaberite mjernu jedinicu (1 - Celzijus, 2 - Farenhajt):  ");
                        MjernaJedinica mjera = MjernaJedinica.C;
                        long mjerna;
                        string unos2;
                        do
                        {
                            Console.WriteLine("Izaberite opciju: ");
                            unos2 = Console.ReadLine();

                        } while (!Int64.TryParse(unos2, out mjerna) || mjerna < 1 || mjerna > 2);

                        switch (mjerna)
                        {
                            case 1:
                                mjera = MjernaJedinica.C;
                                break;
                            case 2:
                                mjera = MjernaJedinica.F;
                                break;
                        }

                        Rerna novaRerna = new Rerna(naziv, mjesto, ukljucen, konekcija,temperatura, mjera);

                        uredjaji.Add(novaRerna);

                        break;

                    case 3:

                    int brojac = 0;
                    List<Uredjaj> rerne = new List<Uredjaj>();

                    foreach (Uredjaj uredjaj in uredjaji)
                    {
                        if(uredjaj.GetType() == typeof(Rerna))
                        {
                            Console.Write((brojac+1) + " ");
                            uredjaj.prikazDetalja();
                            rerne.Add(uredjaj);
                            brojac++;
                        }
                        
                    }

                    if (rerne.Count == 0)
                    {
                        Console.WriteLine("Nema dostupnih rerni.");
                        return;
                    }

                    Console.WriteLine("Odaberite rernu: ");

                    long broj;
                    string unosR;
                    do
                    {
                        Console.WriteLine("Izaberite opciju: ");
                        unosR = Console.ReadLine();

                    } while (!Int64.TryParse(unosR, out broj) || broj < 1 || broj> brojac);

                    Rerna odabranaRerna = (Rerna)rerne[(int)broj - 1];

                    odabranaRerna.ukljuci();

                    Int64 temperaturaRerne;
                    string unosT;
                    do
                    {
                        Console.WriteLine("Unesite temperaturu rerne: ");
                        unosT = Console.ReadLine();

                    } while (!Int64.TryParse(unosT, out temperaturaRerne) || temperaturaRerne < 0);

                    odabranaRerna.podesi((int)temperaturaRerne);
                    
                    break;

                case 4:

                     int brojac1 = 0;
                    List<Uredjaj> rerne1 = new List<Uredjaj>();

                    foreach (Uredjaj uredjaj in uredjaji)
                    {
                        if(uredjaj.GetType() == typeof(Rerna))
                        {
                            Console.Write((brojac1+1) + " ");
                            uredjaj.prikazDetalja();
                            rerne1.Add(uredjaj);
                            brojac1++;
                        }
                        
                    }

                    if (rerne1.Count == 0)
                    {
                        Console.WriteLine("Nema dostupnih rerni.");
                        return;
                    }

                    Console.WriteLine("Odaberite rernu: ");

                    long broj1;
                    string unosR1;
                    do
                    {
                        Console.WriteLine("Izaberite opciju: ");
                        unosR1 = Console.ReadLine();

                    } while (!Int64.TryParse(unosR1, out broj1) || broj1 < 1 || broj1> brojac1);

                    Rerna odabranaRerna1 = (Rerna)rerne1[(int)broj1 - 1];

                    odabranaRerna1.ukljuci();
                    Int64 temperaturaRerne1;
                    string unosT1;
                    do
                    {
                        Console.WriteLine("Unesite temperaturu rerne za koju zelite povecati temperaturu: ");
                        unosT1 = Console.ReadLine();

                    } while (!Int64.TryParse(unosT1, out temperaturaRerne1) || temperaturaRerne1 < 0);

                    odabranaRerna1.povecaj((int)temperaturaRerne1);
                    
                    break;

                case 5:

                    int brojac2 = 0;
                    List<Uredjaj> rerne2 = new List<Uredjaj>();

                    foreach (Uredjaj uredjaj in uredjaji)
                    {
                        if (uredjaj.GetType() == typeof(Rerna))
                        {
                            Console.Write((brojac2 + 1) + " ");
                            uredjaj.prikazDetalja();
                            rerne2.Add(uredjaj);
                            brojac2++;
                        }

                    }

                    if (rerne2.Count == 0)
                    {
                        Console.WriteLine("Nema dostupnih rerni.");
                        return;
                    }

                    Console.WriteLine("Odaberite rernu: ");

                    long broj2;
                    string unosR2;
                    do
                    {
                        Console.WriteLine("Izaberite opciju: ");
                        unosR2 = Console.ReadLine();

                    } while (!Int64.TryParse(unosR2, out broj2) || broj2 < 1 || broj2 > brojac2);

                    Rerna odabranaRerna2 = (Rerna)rerne2[(int)broj2 - 1];

                    odabranaRerna2.ukljuci();
                    Int64 temperaturaRerne2;
                    string unosT2;
                    do
                    {
                        Console.WriteLine("Unesite temperaturu rerne za koju zelite smanjiti temperaturu: ");
                        unosT2 = Console.ReadLine();

                    } while (!Int64.TryParse(unosT2, out temperaturaRerne2) || temperaturaRerne2 < 0);

                    odabranaRerna2.smanji((int)temperaturaRerne2);

                    
                    break;
                case 6:
                    Console.WriteLine("Dodavanje novog TV-a");

                    Console.Write("Unesite naziv TV-a: ");
                    string nazivTV = Console.ReadLine();

                    Console.Write("Unesite mjesto u kući: ");
                    string mjestoTV = Console.ReadLine();

                    Console.Write("Da li je uređaj uključen? (true/false): ");
                    bool ukljucenTV;
                    while (!bool.TryParse(Console.ReadLine(), out ukljucenTV))
                    {
                        Console.WriteLine("Pogrešan unos! Molimo unesite 'true' ili 'false'.");
                    }
                    VrstaKonekcije konekcijaTV = VrstaKonekcije.WiFi;
                    NacinRada nacin = NacinRada.Standardno;
                    Izvor izvor = Izvor.HDMI;
                    long glasnoca=0;
                    long kanal=0;


                    if (!ukljucenTV)
                    {


                        Console.WriteLine("Odaberite vrstu konekcije (1 - WiFi, 2 - Bluetooth): ");
                        long opcijaTV;
                        string unosTV;
                        do
                        {
                            Console.WriteLine("Izaberite opciju: ");
                            unosTV = Console.ReadLine();

                        } while (!Int64.TryParse(unosTV, out opcijaTV) || opcijaTV < 1 || opcijaTV > 2);

                        switch (opcijaTV)
                        {
                            case 1:
                                konekcijaTV = VrstaKonekcije.WiFi;
                                break;
                            case 2:
                                konekcijaTV = VrstaKonekcije.Bluetooth;
                                break;
                        }

                        
                        string unosG;
                        do
                        {
                            Console.WriteLine("Unesite glasnocu TV-a: ");
                            unosG = Console.ReadLine();

                        } while (!Int64.TryParse(unosG, out glasnoca) || glasnoca < 0);


                        string unosk;
                        do
                        {
                            Console.WriteLine("Unesite kanal TV-a: ");
                            unosk = Console.ReadLine();

                        } while (!Int64.TryParse(unosk, out kanal) || kanal < 0);


                        Console.WriteLine();

                        long nacinB;
                        string unosN;
                        do
                        {
                            Console.WriteLine("Odaberite nacin rada (1 - Standardno, 2 - Malo, 3-Kino):  ");
                            unosN = Console.ReadLine();

                        } while (!Int64.TryParse(unosN, out nacinB) || nacinB < 1 || nacinB > 2);

                        switch (nacinB)
                        {
                            case 1:
                                nacin = NacinRada.Standardno;
                                break;
                            case 2:
                                nacin = NacinRada.Malo;
                                break;
                            case 3:
                                nacin = NacinRada.Kino;
                                break;
                        }

                        Console.WriteLine();

                        long brojI;
                        string unosI;
                        do
                        {
                            Console.WriteLine("Odaberite nacin rada (1 - HDMI, 2 - DVD, 3-YouTube):  ");
                            unosI = Console.ReadLine();

                        } while (!Int64.TryParse(unosI, out brojI) || brojI < 1 || brojI > 2);

                        switch (brojI)
                        {
                            case 1:
                                izvor = Izvor.HDMI;
                                break;
                            case 2:
                                izvor = Izvor.DVD;
                                break;
                            case 3:
                                izvor = Izvor.YouTube;
                                break;
                        }
                    }
                    TV noviTV = new TV(nazivTV,mjestoTV,ukljucenTV,konekcijaTV, kanal,glasnoca,nacin,izvor);

                    uredjaji.Add(noviTV);

                    break;
                    
                case 7:
                    int brojacT = 0;
                    List<Uredjaj> TVs = new List<Uredjaj>();

                    foreach (Uredjaj uredjaj in uredjaji)
                    {
                        if (uredjaj.GetType() == typeof(TV))
                        {
                            Console.Write((brojacT + 1) + " ");
                            uredjaj.prikazDetalja();
                            TVs.Add(uredjaj);
                            brojacT++;
                        }

                    }

                    if (TVs.Count == 0)
                    {
                        Console.WriteLine("Nema dostupnih TV-a.");
                        return;
                    }

                    Console.WriteLine("Odaberite TV: ");

                    long brojT;
                    string unosTV1;
                    do
                    {
                        Console.WriteLine("Izaberite opciju: ");
                        unosTV1 = Console.ReadLine();

                    } while (!Int64.TryParse(unosTV1, out brojT) || brojT < 1 || brojT > brojacT);

                    TV odabraniTV = (TV)TVs[(int)brojT - 1];

                    Int64 temperaturaTV;
                    string unosTV2;
                    do
                    {
                        Console.WriteLine("Unesite temperaturu rerne: ");
                        unosTV2 = Console.ReadLine();

                    } while (!Int64.TryParse(unosTV2, out temperaturaTV) || temperaturaTV < 0);

                    odabraniTV.podesi((int)temperaturaTV);

                    break;
                case 8:
                    int brojacT2 = 0;
                    List<Uredjaj> TVs2 = new List<Uredjaj>();

                    foreach (Uredjaj uredjaj in uredjaji)
                    {
                        if (uredjaj.GetType() == typeof(TV))
                        {
                            Console.Write((brojacT2 + 1) + " ");
                            uredjaj.prikazDetalja();
                            TVs2.Add(uredjaj);
                            brojacT2++;
                        }

                    }

                    if (TVs2.Count == 0)
                    {
                        Console.WriteLine("Nema dostupnih TV-a.");
                        return;
                    }

                    Console.WriteLine("Odaberite TV: ");

                    long brojT2;
                    string unosTV4;
                    do
                    {
                        Console.WriteLine("Izaberite opciju: ");
                        unosTV4 = Console.ReadLine();

                    } while (!Int64.TryParse(unosTV4, out brojT2) || brojT2 < 1 || brojT2 > brojacT2);

                    TV odabraniTV2 = (TV)TVs2[(int)brojT2 - 1];

                    Int64 glasnocaTV2;
                    string unosTV3;
                    do
                    {
                        Console.WriteLine("Unesite glasnocu TV-a za povecati: ");
                        unosTV3 = Console.ReadLine();

                    } while (!Int64.TryParse(unosTV3, out glasnocaTV2) || glasnocaTV2 < 0);

                    odabraniTV2.povecaj((int)glasnocaTV2);
                    break;
                case 9:
                    int brojacT3 = 0;
                    List<Uredjaj> TVs3 = new List<Uredjaj>();

                    foreach (Uredjaj uredjaj in uredjaji)
                    {
                        if (uredjaj.GetType() == typeof(TV))
                        {
                            Console.Write((brojacT3 + 1) + " ");
                            uredjaj.prikazDetalja();
                            TVs3.Add(uredjaj);
                            brojacT3++;
                        }

                    }

                    if (TVs3.Count == 0)
                    {
                        Console.WriteLine("Nema dostupnih TV-a.");
                        return;
                    }

                    Console.WriteLine("Odaberite TV: ");

                    long brojT3;
                    string unosTV5;
                    do
                    {
                        Console.WriteLine("Izaberite opciju: ");
                        unosTV5 = Console.ReadLine();

                    } while (!Int64.TryParse(unosTV5, out brojT3) || brojT3 < 1 || brojT3 > brojacT3);

                    TV odabraniTV3 = (TV)TVs3[(int)brojT3 - 1];

                    Int64 glasnocaTV3;
                    string unosTV6;
                    do
                    {
                        Console.WriteLine("Unesite glasnocu TV-a za smanjiti: ");
                        unosTV6 = Console.ReadLine();

                    } while (!Int64.TryParse(unosTV6, out glasnocaTV3) || glasnocaTV3 < 0);

                    odabraniTV3.smanji((int)glasnocaTV3);
                    break;
                case 10:
                    int brojacT4 = 0;
                    List<Uredjaj> TVs4 = new List<Uredjaj>();

                    foreach (Uredjaj uredjaj in uredjaji)
                    {
                        if (uredjaj.GetType() == typeof(TV))
                        {
                            Console.Write((brojacT4 + 1) + " ");
                            uredjaj.prikazDetalja();
                            TVs4.Add(uredjaj);
                            brojacT4++;
                        }

                    }

                    if (TVs4.Count == 0)
                    {
                        Console.WriteLine("Nema dostupnih TV-a.");
                        return;
                    }

                    Console.WriteLine("Odaberite TV: ");

                    long brojT4;
                    string unosTV7;
                    do
                    {
                        Console.WriteLine("Izaberite opciju: ");
                        unosTV7 = Console.ReadLine();

                    } while (!Int64.TryParse(unosTV7, out brojT4) || brojT4 < 1 || brojT4 > brojacT4);

                    TV odabraniTV4 = (TV)TVs4[(int)brojT4 - 1];

                    Int64 kanalTV;
                    string unosTV8;
                    do
                    {
                        Console.WriteLine("Unesite kanal TV-a: ");
                        unosTV8 = Console.ReadLine();

                    } while (!Int64.TryParse(unosTV8, out kanalTV) || kanalTV < 0);

                    odabraniTV4.podesiKanal((int)kanalTV);
                    break;
                

                case 11:

                    int brojacUredjaja = 0;
                    foreach (Uredjaj uredjaj in uredjaji)
                    {
                        Console.Write((brojacUredjaja + 1) + " ");
                        uredjaj.prikazDetalja();
                        brojacUredjaja++;
                    }

                    if (uredjaji.Count == 0)
                    {
                        Console.WriteLine("Nema dostupnih uredjaja.");
                        return;
                    }

                    Console.WriteLine("Odaberite uredjaj za ukljucivanje: ");

                    long brojUredjaja;
                    string unosU;
                    do
                    {
                        Console.WriteLine("Izaberite opciju: ");
                        unosU = Console.ReadLine();

                    } while (!Int64.TryParse(unosU, out brojUredjaja) || brojUredjaja < 1 || brojUredjaja > brojacUredjaja);

                    Uredjaj odabraniUredjaj = uredjaji[(int)brojUredjaja - 1];
                    odabraniUredjaj.ukljuci();
                    break;

                case 12:

                    int brojacUredjaja1 = 0;
                    foreach (Uredjaj uredjaj in uredjaji)
                    {
                        Console.Write((brojacUredjaja1 + 1) + " ");
                        uredjaj.prikazDetalja();
                        brojacUredjaja1++;
                    }

                    if (uredjaji.Count == 0)
                    {
                        Console.WriteLine("Nema dostupnih uredjaja.");
                        return;
                    }

                    Console.WriteLine("Odaberite uredjaj za ukljucivanje: ");

                    long brojUredjaja1;
                    string unosU1;
                    do
                    {
                        Console.WriteLine("Izaberite opciju: ");
                        unosU1 = Console.ReadLine();

                    } while (!Int64.TryParse(unosU1, out brojUredjaja1) || brojUredjaja1 < 1 || brojUredjaja1 > brojacUredjaja1);

                    Uredjaj odabraniUredjajZaIskljucivanje = uredjaji[(int)brojUredjaja1 - 1];
                    odabraniUredjajZaIskljucivanje.iskljuci();



                    break;
                case 13:
                    foreach(Uredjaj uredjaj in uredjaji)
                    {
                        uredjaj.prikazDetalja();
                        Console.WriteLine();
                    }
                    break;
                case 14:
                    return;
                default:
                    Console.WriteLine("Pogresan unos!");
                    break;

            }
        }
    }
}