using System;

namespace Prática
{
    class Program
    {
        static void Main(string[] args)
        {
            looping(1);
        }

        public static void looping(int a)
        {
            Console.WriteLine(a);
            if (a < 3)
            {
                looping(a + 1);
            }
        }
    }
}
