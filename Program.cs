using Models;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            Town town = Models.Town.Get();
            Console.WriteLine(town.Name);
            Console.WriteLine(town.State);
            Console.WriteLine(Models.Gender.Get().Name);
            Console.WriteLine(Models.Occupation.Get().Name);
        }
    }
}