using DemographicsGenerator.Models;

namespace DemographicsGenerator
{
    public static class Program
    {
        public static void Main()
        {
            Town town = new Town();
            Town randomTown = Models.Town.GetRandomTown();
            town.Name = randomTown.Name;
            town.State = randomTown.State;
            town.Country = randomTown.Country;
            Console.WriteLine(town.Name);
            Console.WriteLine(town.State);
            Console.WriteLine(town.Country);
        }
    }
}