using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //test with following conditions
            int x = 3;
            int y = 5;
            decimal a = 13.48M;
            decimal b = 4.2287M;
            int m = 7;
            int n = 12;
            Console.WriteLine(Add(x, y));
            Console.WriteLine(Add(a, b));
            Console.WriteLine(Add(m, n, true));
            Console.WriteLine(Add(0, 1, true));
            Console.WriteLine(Add(m, n, false));

            Console.WriteLine(Add2(m, n, true));
            Console.WriteLine(Add2(0, 1, true));
            Console.WriteLine(Add2(m, n, false));
            Console.WriteLine(Add2(0, 0, true));
        }

        public static int Add(int x, int y)
            => x + y;

        public static decimal Add(decimal x, decimal y)
            => x + y;
        public static string Add(int x, int y, bool isTrue)
        {
            if (isTrue == true)
            {
                return (x + y == 1) ? "1 dollar" : $"{x + y} dollars";
            }
            else
            {
                return (x + y).ToString();
            }
                
        }

        //class answer
        public static string Add2(int x, int y, bool isTrue)
        {
            var sum = x + y;

            if (isTrue && sum > 1 || sum == 0)
            {
                return $"{sum} dollars";
            }
            else if (isTrue && sum == 1)
            {
                return $"{sum} dollar";
            }
            else
            {
                return sum.ToString();
            }
        }
    }
}
