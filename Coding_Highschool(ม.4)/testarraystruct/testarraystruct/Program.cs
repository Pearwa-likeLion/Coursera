
using System;
    struct schoolDataArray
        {
    public string namestd;
    public int passWordStd;
    public int pinStd;
        }

namespace testarraystruct
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            schoolDataArray[] dataArrayStd = new schoolDataArray[5];
            Console.WriteLine("Hello teacher!!!!");
            Console.WriteLine("---------------------------------------");
            for (i = 0;i<dataArrayStd.Length;i++)
            {
                Console.Write("Please enter your students name : ");
                dataArrayStd[i].namestd = Console.ReadLine();
            }
            Console.WriteLine("----------------------------------");
            for(int k = 0; k < dataArrayStd.Length; k++)
            {
                
                Console.WriteLine("Name student "+k+" :"+dataArrayStd[k].namestd);
                Console.WriteLine("-------------------------------");
            }

        }
    }
}
