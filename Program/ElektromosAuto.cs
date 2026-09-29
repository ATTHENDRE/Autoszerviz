using System;

namespace Autoszerviz
{
    public class ElektromosAuto : Jarmu
    {
        private int akkumulatorSzint;

        public ElektromosAuto(string rendszam,int kor, int kilometerOra, int uzemanyagSzint, int akkumulatorSzint) : base(rendszam, kor, kilometerOra, uzemanyagSzint)
        {
            AkkumulatorSzint = akkumulatorSzint;
            UzemanyagSzint = 0;
        }

        public int AkkumulatorSzint
        {
            get => akkumulatorSzint;

            set
            {
                if (value < 0)
                {
                    akkumulatorSzint = 0;
                }
                else if (value > 100)
                {
                    akkumulatorSzint = 100;
                }
                else
                {
                    akkumulatorSzint = value;
                }
            }
        }

        public override void InformaciotAd()
        {
            Console.WriteLine($"{Rendszam} - {Kor} éves elektromos autó, {KilometerOra} km-rel");
        }

        public override void Szervizel(int dij)
        {
            if (dij > 100000)
            {
                KilometerOra -= 10000;
            }

            AkkumulatorSzint += 20;

            Console.WriteLine("jármű szervizelése megtörtént!");
        }
    }
}
