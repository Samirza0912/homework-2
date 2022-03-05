using System;

namespace task_15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*7 dene eded verilib.
             * Bunlardan 2 denesi 3 reqemlidir. 
             * 2 denesi 4 reqemlidir. 
             * 2 denesi 5 reqemlidir.
             * 1 denesi ise 6 reqemlidir.
3 reqemli ededleri topla ,
            sonra bunlarin ustune gel 4 reqemli ededlerin bir birine vurulmasindan alinan cavabi.
Sonra neticenin axirina 7 reqemini artir.
            Sonra cavabin ustune gel 5 reqemli ededlerin cemini.
Sonra neticeden cix 3 reqemli ededlerin bir birine vurulmasindan alinan cavabin axirina 1 artirilmish variantini.
Sonra alinan cavabin ustune gel 6 reqemli ededi.
Sonra alinan cavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini.
Sonra alinan cavabin 18% -ni sonra 3%-ni sonra 1% tap.
Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel.
             */
            double a = 111;
            double b = 222;
            double c = 3333;
            double d = 4444;
            double e = 55555;
            double f = 66666;
            double g = 777777;
            if (!(a > 99 && a < 1000))
            {
                Console.WriteLine($"{a}-uc reqemli deyil");
                return;
            }
            if (!(b > 99 && b < 1000))
            {
                Console.WriteLine($"{b}-uc reqemli deyil");
                return;
            }
            if (!(c >= 1000 && c < 10000))
            {
                Console.WriteLine($"{c}-dord reqemli deyil");
                return;
            }
            if (!(d >= 1000 && d < 10000))
            {
                Console.WriteLine($"{d}-dord reqemli deyil");
                return;
            }
            if (!(e > 9999 && e < 100000))
            {
                Console.WriteLine($"{e}-5 reqemli deyil");
                return;
            }
            if (!(f > 9999 && f < 100000))
            {
                Console.WriteLine($"{f}-5 reqemli deyil");
                return;
            }
            if (!(g > 99999 && g < 1000000))
            {
                Console.WriteLine($"{g}-6 reqemli deyil");
                return;
            }
            double sum = a + b;
            double multi = c * d;
            double sum1 = sum + multi;
            sum1 = sum1 * 10 + 7;
            double sum2 = e + f;
            double sum3 = sum1 + sum2;
            double multi2 = a * b * 10 + 1;
            double subtract = sum3 - multi2;
            double sum4 = subtract + g;
            double sum5 = sum + c + d;
            double substrackt = sum4 - sum5;
            substrackt = substrackt * 18 / 100.0;
            substrackt = substrackt * 3 / 100.0;
            substrackt = substrackt * 1 / 100.0;
            double sum6 = substrackt + sum2;
            Console.WriteLine(sum6);




        }
    }
}
