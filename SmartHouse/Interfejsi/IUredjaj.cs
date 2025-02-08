using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse.Interfejsi
{
    interface IUredjaj
    {
        void podesi(int broj);
        void povecaj(int broj);

        void smanji(int broj);
    }
}
