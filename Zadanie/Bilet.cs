using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie
{
    public class Bilet
    {
        public Bilet()
        {

        }
        public Bilet(double cenaPodstawowa)
        {
            this.cenaPodstawowa = cenaPodstawowa;
        }
        protected double cenaPodstawowa { get; set; }

        public void UstawCene(double cena)
        {
            cenaPodstawowa = cena;
        }

        public virtual void WyswietlCene()
        {
            Console.WriteLine(string.Format("Cena biletu wynosi: {0:C}",cenaPodstawowa));
        }
    }
}
