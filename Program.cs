using System;

namespace GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 8703029615, 870302961955, 870302961962, 870302961969, 870302961976 };



            var lowestnumber = numbers[0];
            long gcd = 0;

            //for (long i = 1; i < numbers.Length; i++)
            //{
            //    gcd = GetGcd(numbers[i], gcd);
            //}
            //Console.WriteLine($"GCD Is: {gcd}");
            //Console.ReadLine();

            for (long i=1; i<numbers.Length; i++)
            {
                if(lowestnumber >= numbers[i])
                {
                    lowestnumber = numbers[i];
                }
            }
            for(long i = lowestnumber; i >= 1; i--)
            {
                for (long j = 0; j < numbers.Length; j++)
                {
                    if (numbers[j] % i  != 0)
                    {
                        gcd = 0;
                        break;
                    }
                    gcd = i;
                }
                if(gcd != 0)
                {
                    break;
                }
            }
            Console.WriteLine($"GCD Is: {gcd}");
            Console.ReadLine();
        }
        //static long GetGcd(long x, long y)
        //{
        //    if (x == 0)
        //    {
        //        return y;
        //    }
        //    return GetGcd(y % x, x);
        //}
    }
}
