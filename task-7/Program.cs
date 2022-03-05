using System;

namespace task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2 dene 5 reqemli eded verilib. 
             * Bu ededleri toplayib. 
             * Alinan cavabin evveline ve axirina 5 artir. 
             * Neticenin 5 % tap
             */
            double a = 12345;
            double b = 54321;
            if (!(a > 9999 && a < 100000))
            {
                Console.WriteLine($"{a}-5 reqemli deyil");
                return;
            }
            if (!(b > 9999 && b < 100000))
            {
                Console.WriteLine($"{b}-5 reqemli deyil");
                return;
            }
            
            double sum = a + b;
            if (sum > 9999 && sum < 100000)
            {
                sum = sum + 500000;
                sum = sum * 10 + 5; 
            }
            else if (sum > 99999 && sum < 1000000)
            {
                sum = sum + 5000000;
                sum = sum * 10 + 5;
            }
            
            sum = sum * 5 / 100.0;
            Console.WriteLine(sum);
        }
    }
}
