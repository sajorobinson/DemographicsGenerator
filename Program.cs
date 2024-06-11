using DemographicsGenerator.Helpers;
using DemographicsGenerator.Models;

namespace DemographicsGenerator
{
    public static class Program
    {
        public static void Main()
        {
            Person person = new Person()
            {
                Name = new Name(),
                Address = new Address(),
                Birthday = new DateOnly(1985, 10, 11),
                EducationalAttainment = new EducationalAttainment(),
                Ethnicity = new Ethnicity(),
                Gender = new Gender(),
                HealthStatus = new HealthStatus(),
                Hobby = new Hobby(),
                Occupation = new Occupation(),
                PoliticalOrientation = new PoliticalOrientation()
            };
            person.Name.First = Name.GetFirst();
            person.Name.Middle = Name.GetMiddle();
            person.Name.Last = Name.GetLast();
            person.Address.Street = Address.GetStreet();
            person.Address.Town = Address.GetTown();
            person.EducationalAttainment = EducationalAttainment.GetRandomEducationalAttainment();
            person.Ethnicity = Ethnicity.GetRandomEthnicity();
            person.Gender = Gender.GetRandomGender();
            person.HealthStatus = HealthStatus.GetRandomHealthStatus();
            person.Hobby = Hobby.GetRandomHobby();
            person.Occupation = Occupation.GetRandomOccupation();
            person.PoliticalOrientation.Name = PoliticalOrientation.GetPoliticalOrientationName(person.PoliticalOrientation);
            
            Console.WriteLine(person.Name.First);
            Console.WriteLine(person.Name.Middle);
            Console.WriteLine(person.Name.Last);
            Console.WriteLine(person.Address.Street);
            Console.WriteLine(person.Address.Town.Name);
            Console.WriteLine(person.Address.Town.State);
            Console.WriteLine(person.Address.Town.Country);
            Console.WriteLine(person.EducationalAttainment.Name);
            Console.WriteLine(person.Ethnicity.Name);
            Console.WriteLine(person.Gender.Name);
            Console.WriteLine(person.HealthStatus.Name);
            Console.WriteLine(person.Hobby.Name);
            Console.WriteLine(person.Occupation.Name);
            Console.WriteLine(person.PoliticalOrientation.Name);
        }
    }
}