using System;

namespace task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3 dene 4 reqemli eded verilib. 
             * I ededin 1%-ni, 
             * II ededin 2% , 
             * III ededin 3 % tap.
               Neticeleri bir birinden cix.
            Alinan cavabin ustune III ededin 7% faizini gel
             */
            double a = 1234;
            double b = 4321;
            double c = 9999;
            if (!(a >= 1000 && a < 10000))
            {
                Console.WriteLine($"{a}-dord reqemli deyil");
                return;
            }
            if (!(b >= 1000 && b < 10000))
            {
                Console.WriteLine($"{a}-dord reqemli deyil");
                return;
            }
            if (!(c >= 1000 && c < 10000))
            {
                Console.WriteLine($"{a}-dord reqemli deyil");
                return;
            }
            a = a * 1 / 100.0;
            b = b * 2 / 100.0;
            c = c * 3 / 100.0;
            double substract = a - b - c;
            substract = substract + c * 7 / 100.0;
            Console.WriteLine(substract);

        }
    }
}
