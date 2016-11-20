using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie
{
    public class BiletNaBasen : Bilet
    {
        public BiletNaBasen()
        {

        }
        public BiletNaBasen(double ulga, double cenaPodstawowa)
            : base(cenaPodstawowa)
        {
            this.ulga = ulga;
        }
        private double ulga { get; set; }

        public void ObliczCeneNaBasen()
        {
            Console.WriteLine(string.Format("Cena z ulgą: {0:C}",(cenaPodstawowa-ulga)));
        }

        public override void WyswietlCene()
        {
            ObliczCeneNaBasen();
        }
    }
}
