using System;

namespace dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] numberInput = new int[2001];
            /*Console.Write("Input you number : ");
            numberInput = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.Write("Input your number : ");
                numberInput = Convert.ToInt32( Console.ReadLine());
                Console.WriteLine("Number : "+numberInput);
            } while (numberInput != 1001);*/
            for (int i = 0; i <numberInput.Length;i++)
            {
                while (numberInput[i] != 1001)
                {
                    Console.Write("Input your number : ");
                    numberInput[i] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Number : "+numberInput[i]);
                }
                if (numberInput[i] == 1001)
                {
                    break;
                }

            }
           
        }
    }
}
