using System;

namespace task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4 dene 5 reqemli eded verilib. 
             * Her I ededin ustune III ededi gel . 
             * II ededin usutune IV eeddi gel.
               Sonra cavablari vur birbirine.
            Alinan neticeden III ededin 3%-ni cix.
             */
            double a = 12345;
            double b = 54321;
            double c = 11111;
            double d = 99999;
            if (!(a >= 10000 && a < 100000))
            {
                Console.WriteLine($"{a}-5 reqemli deyil");
                return;
            }
            if (!(a >= 10000 && a < 100000))
            {
                Console.WriteLine($"{a}-5 reqemli deyil");
                return;
            }
            if (!(a >= 10000 && a < 100000))
            {
                Console.WriteLine($"{a}-5 reqemli deyil");
                return;
            }
            if (!(a >= 10000 && a < 100000))
            {
                Console.WriteLine($"{a}-5 reqemli deyil");
                return;
            }
            double sum = a + c;
            double sum1 = b + d;
            double multiply = sum * sum1;
            double e = multiply - c * 3 / 100;
            Console.WriteLine(e);


        }
    }
}
