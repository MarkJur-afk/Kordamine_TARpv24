using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_TARpv24
{
    class AnalüüsiArve
    {
        public static Tuple<double, double, double> AnalüsiArve(double[] arvud)
        {
            double summa = 0;
            double korrutis = 1;

            foreach (double arv in arvud)
            {
                summa += arv;
                korrutis *= arv;
            }

            double keskmine = summa / arvud.Length;
            return Tuple.Create(summa, keskmine, korrutis);
        }
        


    }
}
