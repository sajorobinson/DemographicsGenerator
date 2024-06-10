using Models;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            Person person = new Person
            {
                Name = new Name(),
                Birthday = new DateOnly(1985, 10, 11),
                Gender = new Gender(),
                SexualOrientation = new SexualOrientation(),
                Ethnicity = new Ethnicity(),
                EducationalAttainment = new EducationalAttainment(),
                Occupation = new Occupation(),
                Hobby = new Hobby(),
                HealthStatus = new HealthStatus(),
                Religion = new Religion(),
                PoliticalOrientation = new PoliticalOrientation(),
                Address = new Address()
            };

            Console.WriteLine(person.SexualOrientation.GetRandomName());
            Console.WriteLine(person.Hobby.GetRandomName());
            Console.WriteLine(person.Address.Street);
        }
    }
}