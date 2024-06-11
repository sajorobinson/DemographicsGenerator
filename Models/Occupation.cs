namespace DemographicsGenerator.Models
{
    public class Occupation
    {
        public string Name { get; set; } = Constants.Models.DefaultName;
        public static Occupation GetRandomOccupation()
        {
            Occupation occupation = Helpers.Utility.GetResource<Occupation>(Constants.Resources.OccupationFilePath);
            return occupation;
        }
    }
}