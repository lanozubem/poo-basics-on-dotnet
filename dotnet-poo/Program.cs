using System;
using dotnet_poo.src.Entities;

namespace dotnet_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            var human = new Human(){ Name = "Ithan", Type = "Human", Level = 1 };
            var superMutant = new Mutant(){ Name = "Strong", Type = "Mutant", Level = 10 };

            Console.WriteLine($@"
                {human.Talk()}
                {superMutant.Talk()}
                {human.Attack(superMutant.Name, 5)}
            ");
        }
    }
}
