using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            var bilet1 = new BiletDoKina();
            bilet1.UstawCene(24.50);
            bilet1.UstawFilm3D(true);
            bilet1.UstawPremiera(true);
            bilet1.WyswietlCene();
            var bilet2 = new BiletDoKina(false,false,12.40);
            bilet2.WyswietlCene();

            var bilet3 = new BiletNaBasen(20,70);
            bilet3.WyswietlCene();

            Console.ReadLine();
        }
    }
}
