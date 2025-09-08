using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_TARpv24
{
    class ArvuTöötlus
    {
        public static int[] GenereeriRuudud(int min, int max)
        {
            Random rnd = new Random();

            int N = rnd.Next(min, max);
            int M = rnd.Next(min, max);

            Console.WriteLine($"Random numrid {N} ja {M}");

            int esimene = Math.Min(N, M);
            int teine = Math.Max(N, M);

            List<int> result = new List<int>();
            
            for (int i = esimene; i <= teine; i++)
            {
                result.Add(i * i);
                Console.WriteLine($"{i} -> {i * i}");
            }
            return result.ToArray();
        }
    }
        

        }

