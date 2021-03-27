using System;

namespace switchreal
{
    class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input your grade : ");
        char i = Convert.ToChar( Console.ReadLine());
        switch (i)
        {
            case 'A' :
                Console.WriteLine("Well Done!!!");
                break;
            default :
                Console.WriteLine("Error");
                break;

        }
    }
}
}
