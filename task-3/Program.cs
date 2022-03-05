using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             5 reqemli eded verilib.
            Bu ededin evvel 18 %
            sonra ise 3 % tap.
             version1*/
           double a = 12345;
            
            if (!(a > 9999 && a < 100000))
            {
                Console.WriteLine($"{a}-5 reqemli deyil");
                return;
            }
            a = a * 18 / 100.0;
            a = a * 3 / 100.0;
            Console.WriteLine(a);
            // version 2
            double a1 = 12345;
            double b = a1 * 18 / 100;
            double c = a1 * 3 / 100;
            Console.WriteLine($"{b}-{c}");
             
        }
    }
}
