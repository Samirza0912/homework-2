using System;

namespace task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3 dene 6 reqemli eded verilib. 
             * Her birinin 10 faizini tapib 
             * neticeleri topla. 
             * Alinan cavabin 10% tap.
             */
            double a = 123456;
            double b = 654321;
            double c = 999999;
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
            a = a * 10 / 100.0;
            b = b * 10 / 100.0;
            c = c * 10 / 100.0;
            double sum = a + b + c;
            sum = sum * 10 / 100.0;
            Console.WriteLine(sum);
        }
    }
}
