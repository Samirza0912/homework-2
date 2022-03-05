using System;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4 reqemli eded verilib. 
             * Bu ededin evvelin 4 reqemi , 
             * axirina ise 44 ededini artir. 
             * Alinan cavabin 44 % tap.
             */
            double a = 1234;
            if (!(a >= 1000 && a < 10000))
            {
                Console.WriteLine($"{a}-dord reqemli deyil");
                return;
            }
            a = a + 40000;
            a = a * 100 + 44;
            a = a * 44 / 100.0;
            Console.WriteLine(a);
        }
    }
}
