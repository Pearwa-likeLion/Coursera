using System;

namespace openone
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int[] alltime = new int[480];
            for(int i = 1; i < alltime.Length; i++)
            {
                alltime[i] = 0;
                Console.WriteLine(alltime[i]);
            }                

        }
    }
}
