using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* task 2
             3 reqemli eded verilib.
            Bu ededin axirina hemin ededdin ozunu yapishdir.
            example: 333= 333333;
             */
            int a = 1234;
            if (!(a > 99 && a < 1000))
            {
                Console.WriteLine($"{a}-uc reqemli deyil");
                return;
            }
            a = a * 1000 + a;
            Console.WriteLine(a);
        }
    }
}
