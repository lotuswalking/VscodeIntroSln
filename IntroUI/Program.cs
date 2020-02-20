using System;
using IntroLibrary;
//Document: Https://docs.microsoft.com/en-us/dotnet/core/tools/?tabs=netcore2x
namespace IntroUI
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel p = new PersonModel
            {
                Firstname = "Junyan",
                LastName = "Li"
            };
            System.Console.WriteLine($"{p.Firstname} {p.LastName} is my name.");
            Console.WriteLine("Hello World!");
            Console.WriteLine("this is a test"); 
            Console.WriteLine("The End");
        }
    }
}
