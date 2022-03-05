using System;

namespace task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4 reqemli eded verilib. 
             * Bu ededin evvel 20%-ni , 
             * sonra ise cavabin 10% tap. 
             * Alinan cavabin kvadratini tap.
             */
            double a = 1234;
            if (!(a >= 1000 && a < 10000))
            {
                Console.WriteLine($"{a}-dord reqemli deyil");
                return;
            }
            a = a * 20 / 100.0;
            a = a * 10 / 100.0;
            a = a * a;
            Console.WriteLine(a);
        }
    }
}
