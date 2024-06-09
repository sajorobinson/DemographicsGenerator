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
                HealthStatus = new HealthStatus(),
                Religion = new Religion(),
                PoliticalOrientation = new PoliticalOrientation(),
                Address = new Address()
            };

            person.Name.First = Models.Name.GetFirst();
            person.Name.Middle = Models.Name.GetMiddle();
            person.Name.Last = Models.Name.GetLast();

            person.Gender = Models.Gender.Get();
            person.SexualOrientation = Models.SexualOrientation.Get();

            person.Ethnicity = Models.Ethnicity.Get();

            person.EducationalAttainment = Models.EducationalAttainment.Get();
            person.Occupation = Models.Occupation.Get();
            person.HealthStatus = Models.HealthStatus.Get();

            person.Religion = Models.Religion.Get();

            person.PoliticalOrientation = Models.PoliticalOrientation.GetPoliticalOrientation();
            person.PoliticalOrientation.Name = Models.PoliticalOrientation.GetPoliticalOrientationName(person.PoliticalOrientation);
            
            Console.WriteLine(person.Name.First);
            Console.WriteLine(person.Name.Middle);
            Console.WriteLine(person.Name.Last);
            Console.WriteLine(person.Gender.Name);
            Console.WriteLine(person.SexualOrientation.Name);
            Console.WriteLine(person.Ethnicity.Name);
            Console.WriteLine(person.EducationalAttainment.Name);
            Console.WriteLine(person.Occupation.Name);
            Console.WriteLine(person.HealthStatus.Name);
            Console.WriteLine(person.Religion.Name);

        }
    }
}