using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        /* task 1
         4 reqemli eded verilib.
        Bu ededin eveline 7 reqemini ,
        axirinada 8 reqemini artir.
        Example1: 333= 73338
         */
        {
            int a = 124;
            if (!(a >= 1000 && a < 10000))
            {
                Console.WriteLine($"{a}-dord reqemli deyil");
                return;
            }
            a = a + 70000;
            a = a * 10 + 8;
            Console.WriteLine(a);

        }
    }
}
