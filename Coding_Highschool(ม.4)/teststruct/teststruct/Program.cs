using System;
struct city
{
    public string nameCity;
    public string foodCity;
}
namespace teststruct
{
        class Program
    {
        
        static void Main(string[] args)
        {
            city city1;

            city1.nameCity = "New York";
            city1.foodCity = "Hamberger";

            Console.WriteLine("Name City : " + city1.nameCity);
            Console.WriteLine("Name City : " + city1.foodCity);
            Console.WriteLine("good luck! enjoy you trip!");
        }
    }
}
