using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_TARpv24
{
    internal class Osa1_funktsioonid
    {
        public static float Kalkulaator(float arv1, float arv2)
        {
            float k = arv1 * arv2;
            return k;

        }
        public static string Kuu_nimetus(int kuu_nr)
        {
            string kuu = "";
            switch (kuu_nr)
            {
                case 1: kuu = "Jaanuar"; break;
                case 2: kuu = "Februar"; break;
                case 3: kuu = "Märts"; break;
                case 4: kuu = "April"; break;
                case 5: kuu = "Mai"; break;
                case 6: kuu = "Juni"; break;
                case 7: kuu = "Juuli"; break;
                case 8: kuu = "August"; break;
                case 9: kuu = "September"; break;
                case 10: kuu = "Oktoober"; break;
                case 11: kuu = "November"; break;
                case 12: kuu = "Detsember"; break;

                default:
                    kuu = "???";
                    break;
            }
            return kuu;
        }
        public static string Hooaeg(int kuu_nr)
        {
            string hoo = "";
            if (kuu_nr == 1 || kuu_nr == 2 || kuu_nr == 12) //&& - and, || - or
            {
                hoo = "Talv";
            }
            else if (kuu_nr > 2 && kuu_nr < 6)
            {
                hoo = "Kevad";
            }
            else if (kuu_nr > 5 && kuu_nr < 9)
            {
                hoo = "Suvi";
            }
            else if (kuu_nr > 8 && kuu_nr < 12)
            {
                hoo = "Sügis";
            }
            else
            {
                hoo = "???";
            }

            return hoo;
        }
        public static string Kino(int vanus)
        
        {
            string hinn = "";
            if (vanus > 0 && vanus < 7)
            {
                hinn = "Tasuta";
            }
            else if (vanus > 6 && vanus < 15)
            {
                hinn = "Lapse pilet";
            }
            else if (vanus > 14 && vanus < 66)
            {
                hinn = "Täis pilet";
            }
            else if (vanus > 65 && vanus < 100)
            {
                hinn = "Pensionäär";
            }
            else if (vanus < 0 && vanus > 100)
            {
                hinn = "Midagi laks valesti";
            }
            return hinn;
        }
        public static string Pinginaaber(string nimi)
        {

            string vastus = "";
            if (nimi == "Mark" || nimi == "Marek")
            {
                vastus = "Te olete pinginaabrid";
            }
            else
            {
                vastus = "Tee ei olete pinginaabrid";
            }
            return vastus;
        }
        public static int Remont(int pikkus, int laius)
        {
            return pikkus * laius;
        }
        public static string Temperature(int temp)
        {
            string grad = "";
            if (temp > 18)
            {
                grad = "Kummem kui 18 graadi";
            }
            else
            {
                grad = "Temperatuur on alla 18 kraadi";
            }
            return grad;
        }
        public static string Pikkumine(int pikus)
        {
            string inim = "";
            if (pikus  < 160)
            {
                inim = "väike";
            }
            else if(pikus > 160 && pikus < 180)
            {
                inim = "keskmine";
            }
            else if (pikus > 180 && pikus < 210)
            {
                inim = "suur";
            }
            else
            {
                inim = "Ei saab olla!";
            }
            return inim;
        }


    }
    }
