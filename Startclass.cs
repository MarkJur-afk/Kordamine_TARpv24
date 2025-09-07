//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

using System.Reflection.Metadata.Ecma335;

namespace Kordamine_TARpv24
{
    internal class Startclass
    {
        public static void Main(string[] args)
        {
            //1.
            Console.WriteLine("Mis on sinu nimi");
            string nimi = Console.ReadLine();
            if (nimi.ToLower() == "juku")
            {
                Console.WriteLine("Kui vana sa oled");
                int vanus = int.Parse(Console.ReadLine());
                string hinn = Osa1_funktsioonid.Kino(vanus);
                Console.WriteLine($"Sinu pilet on {hinn}");
            }
            else
            {
                Console.WriteLine("Mina pean Jukuga kino minna");
            }



            //2.
            Console.WriteLine("Mis on sinu nimi");
            string nimi1 = Console.ReadLine();
            Console.WriteLine("Aga mis on sinu nimi?");
            string nimi2 = Console.ReadLine();
            if (nimi1 == "Mark" || nimi2 == "Marek")
            {
                Console.WriteLine("Te olete pinginaabrid");
            }
            else
            {
                Console.WriteLine("te ei olete pinginaabrid");
            }


            //3.
            Console.Write("Sisesta ruumi pikkus: ");
            int pikkus = int.Parse(Console.ReadLine());

            Console.Write("Sisesta ruumi laius: ");
            int laius = int.Parse(Console.ReadLine());

            int pindala = Osa1_funktsioonid.Remont(pikkus, laius);

            Console.WriteLine($"Põranda pindala on {pindala} ruutmeetrit.");

            Console.WriteLine("Okei kas sina tahad remonti teha?");
            string vastus = Console.ReadLine();
            if (vastus.ToLower() == "jah")
            {
                Console.WriteLine("Mis on 1m hind");
                float hind = float.Parse(Console.ReadLine());
                float summa = pindala * hind;
                Console.WriteLine($"Sinnu summa kokku on {summa:F2}: eurot remontiga");
            }
            else
            {
                Console.WriteLine("Sis ei ole remonti"); 
            }



            //4.
            Console.WriteLine("Tere mis oli allahindlu hind?");
            float allahind = float.Parse(Console.ReadLine());
            Console.WriteLine("Okei kohe vattan mis on algus hind?");
            float algus = (float)(allahind / 0.7);
            Console.WriteLine($"Sinu algus hind on {algus} eurot/centi");


            //5
            Console.WriteLine("Mis on temperatuur ruumis");
            int temp = int.Parse(Console.ReadLine());
            string grad = Osa1_funktsioonid.Temperature(temp);
            Console.WriteLine($"{grad}");

            
            


            //Console.WriteLine("Kui vana sa oled");
            //int vanus = int.Parse(Console.ReadLine());
            //string pilet = Osa1_funktsioonid.Kino(vanus);
            //string hinn = Osa1_funktsioonid.Kino(vanus);
            //Console.WriteLine($"Sinu pilet on {hinn}");




            //Random rnd = new Random();
            //string Kinoo = Osa1_funktsioonid.Kino(vanus);
            //Console.WriteLine("Kirjuta sinu vanus");
            //int.Parse(Console.ReadLine());











            //2. Osa valikud
            //int kuu_number = rnd.Next(1, 12);
            //string nimetus = Osa1_funktsioonid.Kuu_nimetus(kuu_number);
            //Console.WriteLine($"Nr: {kuu_number} - {nimetus}");
            //Console.WriteLine("Kas tahad dekodeerida arv->nimetusse?");
            //string vastus = Console.ReadLine();
            //if (vastus.ToLower() != "jah")
            //{
            //    Console.WriteLine("Ei taha");
            //}
            //else
            //{
            //    try
            //    {
            //        Console.Write("Nr: ");
            //        kuu_number = int.Parse(Console.ReadLine());
            //        Console.WriteLine(Osa1_funktsioonid.Hooaeg(kuu_number));
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e);
            //    }
            //}
        }
    }
}
        














//            Console.OutputEncoding = Encoding.UTF8;
//            Console.BackgroundColor = ConsoleColor.Red;
//            Console.ForegroundColor = ConsoleColor.Green;

//            Console.WriteLine("Tere Tulemast!, Mis on sinu nimi?");
//            string tekst = Console.ReadLine();
//            Console.WriteLine($"{tekst}, Rõõm näha!");
//            int a = 10;
//            char taht = 'A'; //üks täht
//            Console.Write($"Esimene arv on {a}, sisesta b = ....");
//            int b = int.Parse(Console.ReadLine());
//            Console.WriteLine($"Vastus on = {a + b}");
//            Console.WriteLine("Ujukomaarv");
//            double d = double.Parse(Console.ReadLine());
//            Console.WriteLine(d);
//            float f = float.Parse(Console.ReadLine());
//            Console.WriteLine(f);
//            bool g = false;

//            a = rnd.Next(-100, 200);
//            Console.WriteLine(a);

//            float vastus = Osa1_funktsioonid.Kalkulaator(f, a);
//            Console.WriteLine($"Kalkulaatori tulemus: {vastus}");

//        }
//    }
//}



//2. osa valikud


