using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_TARpv24
{
    internal class Startclass
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Green;
            
            Console.WriteLine("Tere Tulemast!, Mis on sinu nimi?");
            string tekst = Console.ReadLine();
            Console.WriteLine($"{tekst}, Rõõm näha!");
            int a = 10;
            char taht = 'A';
            Console.Write($"Esimene arv on {a}, sisesta b = ....");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Vastus on = {a + b}");
            Console.WriteLine("Ujukomaarv");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine(d);
            float f = float.Parse(Console.ReadLine());
            Console.WriteLine(f);
            bool g = false;

            Random rnd = new Random();
            a = rnd.Next(-100, 200);
            Console.WriteLine(a);

            float vastus = Osa1_funktsioonid.Kalkulaator(f, a);
            Console.WriteLine($"Kalkulaatori tulemus: {vastus}");

        }
    }
}