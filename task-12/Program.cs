using System;

namespace task_12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4 dene 6 reqemli eded verilib. 
             * Ededlerin hamisinin 10 faizini tap ve 
             * topla. 
             * Sonra hamisinin 15 faizini tap ve 
             * topla.
 Sonra yekunda alinanlar iki cavabi vur biri birine.
            Alinan neticenin evvel 10% tap sonra ise hemin cavabin 11% tap.*/
            double a = 123456;
            double b = 654321;
            double c = 111111;
            double d = 999999;
            if (!(a >= 100000 && a < 1000000))
            {
                Console.WriteLine($"{a}-6 reqemli deyil");
                return;
            }
            if (!(b >= 100000 && b < 1000000))
            {
                Console.WriteLine($"{b}-6 reqemli deyil");
                return;
            }
            if (!(c >= 100000 && c < 1000000))
            {
                Console.WriteLine($"{c}-6 reqemli deyil");
                return;
            }
            if (!(d >= 100000 && d < 1000000))
            {
                Console.WriteLine($"{d}-6 reqemli deyil");
                return;
            }
            double e = a * 10 / 100.0;
            double f = b * 10 / 100.0;
            double g = c * 10 / 100.0;
            double h = d * 10 / 100.0;
            double sum = e + f + g + h;
            a = a * 15 / 100.0;
            b = b * 15 / 100.0;
            c = c * 15 / 100.0;
            d = d * 15 / 100.0;
            double sum1 = a + b + c + d;
            double multi = sum * sum1;
            multi = multi * 10 / 100.0;
            multi = multi * 11 / 100.0;
            Console.WriteLine(multi);
        }
    }
}
