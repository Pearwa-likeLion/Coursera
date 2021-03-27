using System;

namespace testRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Random n = new Random();
            int nRandom = Convert.ToInt32(n.Next(0,50));
            for (int i = 0; i < 1000000000;i++)
            {
                Console.Write("Input Number : ");
                int numInput = Convert.ToInt32(Console.ReadLine());

                if (numInput == nRandom)
                {
                    Console.WriteLine(numInput + " is correct number.");
                    i = 1000000000;
                }
                else if (numInput < nRandom)
                {
                    Console.WriteLine(numInput + ">");
                }
                else if (numInput > nRandom)
                {
                    Console.WriteLine(numInput + "<");
                }
                else if (numInput == 'A')
                {
                    Console.WriteLine(numInput + " is correct number.");
                    i = 1000000000;
                }

            }Console.ReadKey();
        }
    }
}
