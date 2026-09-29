using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class ElektromosAuto : Jarmu
    {
        private int AkkumulatorSzint;

        public ElektromosAuto(string rendszam, int kor, int kilometerOra, int uzemanyagSzint, bool szervizSzukseges, int akkumulatorSzint) : base(rendszam, kor, kilometerOra, uzemanyagSzint, szervizSzukseges)
        {
            AkkumulatorSzint = akkumulatorSzint;
            uzemanyagSzint = 0;
        }

        public int AkkumulatorSzint1
        {
            get => AkkumulatorSzint;
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                else if (value > 100)
                {
                    value = 100;
                }
            }
        }


        public void InformaciotAd()
        {
            Console.WriteLine($"{Rendszam1} - {Kor1} éves elektromos autó, {KilometerOra1} km-rel");
        }

        public void Szervizel(int dij)
        {
            if (dij > 100000)
            {
                KilometerOra1 -= 10000;
                AkkumulatorSzint -= 20;
                Console.WriteLine("jármű szervizelése megtörtént!");
            }
        }


    }
}
