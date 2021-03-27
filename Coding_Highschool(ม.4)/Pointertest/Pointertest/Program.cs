using System;

namespace Pointertest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            unsafe
            {
                int x = 100;

                /* The &x gives the memory address of the variable x,
                 * which we can assign to a pointer variable */

                int* ptr = &x;
                Console.WriteLine((int)ptr); // Displays the memory address
                Console.WriteLine(*ptr); // Displays the value at the memory 
                Console.ReadLine();
            }
        }
    }
}
