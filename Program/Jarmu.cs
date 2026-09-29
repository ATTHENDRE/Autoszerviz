using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Jarmu
    {
        private string Rendszam;

        private int Kor;

        private int KilometerOra;

        private int UzemanyagSzint;

        private bool szervizSzukseges;

        public Jarmu(string rendszam, int kor, int kilometerOra, int uzemanyagSzint, bool szervizSzukseges)
        {
            Rendszam = rendszam;
            Kor = kor;
            KilometerOra = kilometerOra;
            UzemanyagSzint = uzemanyagSzint;
            this.szervizSzukseges = szervizSzukseges;
        }

        public string Rendszam1
        {
            get => Rendszam;

            set
            {
                if (value == null && value == "")
                {
                    value = "ISMERETLEN";
                }
            }

        }

        public int Kor1
        {
            get => Kor;

            set
            {
                if (value > 50)
                {
                    value = 50;
                }
                else if (value < 0)
                {
                    value = 0;
                }
            }
        }

        public int KilometerOra1
        {
            get => KilometerOra;
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
            }
        }
        public int UzemanyagSzint1
        {
            get => UzemanyagSzint;
            set
            {
                if (value > 100)
                {
                    value = 100;
                }
                else if (value < 0)
                {
                    value = 0;
                }
            }
        }
        public bool SzervizSzukseges
        {
            get => szervizSzukseges;
            set
            {
                if (KilometerOra > 200000)
                {
                    value = true;
                }
            }

        }




        public void InformaciotAd()
        {
            Console.WriteLine($"{Rendszam} - {Kor} éves jármű, {KilometerOra} km-rel");
        }



        public void Szervizel(int dij)
        {
             if(dij > 100000)
            {
                KilometerOra -= 10000;
                UzemanyagSzint -= 10;
                Console.WriteLine("jármű szervizelése megtörtént!");
            }
        }


    }
}
