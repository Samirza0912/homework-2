using System;

namespace task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2 dene eded verilib. I eded 4 reqemli II eded 7 reqemlidir.
I ededin 4%-ni tap.
Sonra II ededin 9% ni tap.
Sonra Cavalari toplayib 10 %ni tap.
             */
            double a = 1234;
            double b = 1234567;
            if (!(a >= 1000 && a < 10000))
            {
                Console.WriteLine($"{a}-dord reqemli deyil");
                return;
            }
            if (!(b >= 1000000 && b < 10000000))
            {
                Console.WriteLine($"{b}-yeddi reqemli deyil");
                return;
            }
            a = a * 4 / 100.0;
            b = b * 9 / 100.0;
            double sum = a + b;
            sum = sum * 10 / 100.0;
            Console.WriteLine(sum);
        }
    }
}
