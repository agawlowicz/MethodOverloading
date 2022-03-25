using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            bool addTrue = true;
            int x = 3;
            int y = 5;
            float a = 13.48F;
            float b = 4.2287F;
            int m = 7;
            int n = 12;
            Console.WriteLine(Add(x, y));
            Console.WriteLine(Add(a, b));
            Console.WriteLine(Add(m, n, addTrue));
            Console.WriteLine(Add(0, 1, addTrue));
        }

        public static int Add(int x, int y)
            => x + y;

        public static float Add(float x, float y)
            => x + y;
        public static string Add(int x, int y, bool isTrue)
        {
            if (isTrue == true)
            {
                return (x + y == 1) ? "1 dollar" : $"{x + y} dollars";
            }
            else
            {
                return "Entered values cannot be added together";
            }
                
        }
    }
}
