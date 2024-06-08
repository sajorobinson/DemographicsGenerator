namespace Program
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(Models.Town.Get().Name);
            Console.WriteLine(Models.Town.Get().State);
            Console.WriteLine(Models.Gender.Get().Name);
            Console.WriteLine(Models.Occupation.Get().Name);
        }
    }
}