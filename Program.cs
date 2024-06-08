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
            PoliticalOrientation politicalOrientation = Models.PoliticalOrientation.GetPoliticalOrientation();
            politicalOrientation.Name = Models.PoliticalOrientation.GetPoliticalOrientationName(politicalOrientation);
            Console.WriteLine(politicalOrientation.SpectrumX.ToString());
            Console.WriteLine(politicalOrientation.SpectrumY.ToString());
            Console.WriteLine(politicalOrientation.Name);
            
        }
    }
}