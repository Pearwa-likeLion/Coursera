using System;

namespace leapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            
            int numYear = Convert.ToInt32( Console.ReadLine());
            if (numYear % 4 == 0 && numYear % 100 == 0 && numYear % 400 == 0)
            {
                Console.WriteLine("Yes");
            }
            else if (numYear % 4 == 0 && numYear % 100 == 0)
            {
                Console.WriteLine("NO");
            }
            else if (numYear % 4 == 0)
            {
                Console.WriteLine("Yes");
            }
            else if (numYear%4 != 0)
            {
                Console.WriteLine("No");
            }

        }
    }
}
