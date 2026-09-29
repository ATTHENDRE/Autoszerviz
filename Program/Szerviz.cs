using System;
using System.Collections.Generic;
using System.Text;

namespace Autoszerviz
{
    public class Szerviz
    {
        private List<Jarmu> Jarmuvek = new List<Jarmu>();


        public void JarmuFelvetele(Jarmu jarmu)
        {
            Jarmuvek.Add(jarmu);
            Console.WriteLine("A jármű megérkezett a szervizbe!");
        }

        public void InformaciokListazasa()
        {
            foreach (var item in Jarmuvek)
            {
                Console.WriteLine($"{item.Rendszam} - Rendszám, {item.Kor} - Kor, {item.KilometerOra} - Km, {item.UzemanyagSzint} - Uzemanyag színt ");
            }
        }

        public void CsoportosSzerviz(int dij)
        {
            foreach (var item in Jarmuvek)
            {
                if (item.SzervizSzukseges == true)
                {
                    item.Szervizel(dij);
                }
                else 
                {
                    Console.WriteLine($"A {item.Rendszam} szervizelése jelenleg nem szükséges.");
                }
            }
        }

    }
}
