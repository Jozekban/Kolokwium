using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie
{
    public class BiletDoKina : Bilet
    {
        private double doplatapremiera = 7.0;
        private double doplata3D = 3.0;
        public BiletDoKina ()
	    {
            
	    }
        public BiletDoKina(bool trzyD, bool premiera, double cenaPodstawowa)
            : base(cenaPodstawowa)
        {
            this.trzyD = trzyD;
            this.premiera = premiera;
        }
        protected bool premiera { get; set; }
        private bool trzyD { get; set; }

        public void UstawPremiera(bool premiera)
        {
            this.premiera = premiera;
        }
        
        public void UstawFilm3D(bool czy3D)
        {
            trzyD = czy3D;
        }

        double ObliczCeneDoKina()
        {

            var cena = cenaPodstawowa;
            if (premiera)
            {
                cena += doplatapremiera;
            }
            if (trzyD)
            {
                cena += doplata3D;
            }
            return cena;
        }

        public override void WyswietlCene()
        {
            Console.WriteLine(string.Format("Cena biletu do kina wynosi: {0:C}", ObliczCeneDoKina()));
        }
    }
}
