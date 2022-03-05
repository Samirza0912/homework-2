using System;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3 reqemli eded verilib. 
             * Bu ededin axirina 7 artir. 
             * Sonra cavabin 7% tap;
             */
            double a = 123;
            if (!(a > 99 && a < 1000))
            {
                Console.WriteLine($"{a}-uc reqemli deyil");
                return;
            }
            a = a * 10 + 7;
            a = a * 7 / 100.0;
            Console.WriteLine(a);

        }
    }
}
