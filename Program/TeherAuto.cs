using System;
using System.Collections.Generic;
using System.Text;

namespace Autoszerviz
{
    public class TeherAuto : Jarmu
    {
        private int rakomany;

        public TeherAuto(string rendszam, int kor, int kilometerOra, int uzemanyagSzint, int rakomany) : base(rendszam, kor, kilometerOra, uzemanyagSzint)
        {
            this.rakomany = rakomany;
        }

        public int Rakomany
        {
            get => rakomany;
            set
            {
                if (value > 20)
                {
                    rakomany = 20;
                }
                else if (value < 0)
                {
                    rakomany = 0;
                }
                else
                {
                    rakomany = value;
                }
            }
        }

        public override void InformaciotAd()
        {
            Console.WriteLine($"{Rendszam} - {Kor} éves elektromos autó, {KilometerOra} km-rel");
        }



        public override void Szervizel(int dij)
        {
            if(rakomany == 0)
            {
                base.Szervizel(dij);
            }
        }



    }
}
