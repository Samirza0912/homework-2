using System;

namespace task_13
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 5 dene eded verilib. 
             * Bunlardan 3 denesi 5 reqemli. 
             * 2 denesi ise 3 reqemlidir. 
             * 5 reqemli ededlerin 5% tap ,
             * neticeleri vur bir birine.
            Sonra 3 reqemli ededlerin 3% tap ,
            neticeleri topla.
            Sonra yekunda alinan iki cavalarin her birinin 10%-ni tapib topla.
             */
            double a = 10000;
            double b = 10000;
            double c = 10000;
            double d = 500;
            double e = 500;
            if (!(a >= 10000 && a < 100000))
            {
                Console.WriteLine($"{a}-5 reqemli deyil");
                return;
            }
            if (!(b >= 10000 && b < 100000))
            {
                Console.WriteLine($"{b}-5 reqemli deyil");
                return;
            }
            if (!(c >= 10000 && c < 100000))
            {
                Console.WriteLine($"{c}-5 reqemli deyil");
                return;
            }
            if (!(d > 99 && d < 1000))
            {
                Console.WriteLine($"{d}-uc reqemli deyil");
                return;
            }
            if (!(e > 99 && e < 1000))
            {
                Console.WriteLine($"{e}-uc reqemli deyil");
                return;
            }
            a = a * 5 / 100.0;
            b = b * 5 / 100.0;
            c = c * 5 / 100.0;
            double multi = a * b * c;
            d = d * 3 / 100.0;
            e = e * 3 / 100.0;
            double sum = d + e;
            multi = multi * 10 / 100.0;
            sum = sum * 10 / 100.0;
            double sum1 = sum + multi;
            Console.WriteLine(sum1);
        }
    }
}
