using System;

namespace task_14
{
    class Program
    {
        static void Main(string[] args)
        {
            /*6 dene 6 reqemli eded verilib. 
             * Evvel hamisini topla . 
             * Sonra I ve III ededi bir birine yapishdir ve bir eded al.
I neticeden II neticeni cix.
            Alinan cavabin 10% tap.
            Neticenin uzerine V ve VI ededleri gel.
            Yekunda alinan cavabin 11% tap.
             */
            double a = 123456;
            double b = 654321;
            double c = 111111;
            double d = 222222;
            double e = 333333;
            double f = 444444;
            if (!(a >= 100000 && a < 1000000))
            {
                Console.WriteLine($"{a}-6 reqemli deyil");
                return;
            }
            if (!(b >= 100000 && b < 1000000))
            {
                Console.WriteLine($"{b}-6 reqemli deyil");
                return;
            }
            if (!(c >= 100000 && c < 1000000))
            {
                Console.WriteLine($"{c}-6 reqemli deyil");
                return;
            }
            if (!(d >= 100000 && d < 1000000))
            {
                Console.WriteLine($"{d}-6 reqemli deyil");
                return;
            }
            if (!(e >= 100000 && e < 1000000))
            {
                Console.WriteLine($"{e}-6 reqemli deyil");
                return;
            }
            if (!(f >= 100000 && f < 1000000))
            {
                Console.WriteLine($"{f}-6 reqemli deyil");
                return;
            }
            double sum = a + b + c + d + e + f;
            double ac = a * 1000000 + c;
            double sub = sum - ac;
            sub = sub * 10 / 100.0;
            double sum1 = sub + e + f;
            sum1 = sum1 * 11 / 100.0;
            Console.WriteLine(sum1);

        }
    }
}
