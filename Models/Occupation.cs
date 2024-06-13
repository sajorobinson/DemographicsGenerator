namespace DemographicsGenerator.Models
{
    public class Occupation
    {
        public string Name { get; set; } = Constants.Models.DefaultResponse;
        public int EducationalLevel { get; set; }

        public static Occupation GetRandomOccupation()
        {
            List<Occupation> occupationList = Helpers.Utility.GetRandomResourceList<Occupation>(Constants.Resources.OccupationFilePath);
            Occupation occupation = Helpers.Utility.GetRandomResource<Occupation>(occupationList);
            return occupation;
        }

        public static Occupation GetOccupationRelevantToEducation(int educationLevel)
        {
            List<Occupation> occupationList = Helpers.Utility.GetRandomResourceList<Occupation>(Constants.Resources.OccupationFilePath);
            var matchingOccupations = occupationList.Where(occupation => occupation.EducationalLevel == educationLevel).ToList();
            Occupation matchingOccupation = Helpers.Utility.GetRandomResource<Occupation>(matchingOccupations);
            return matchingOccupation;
        }
    }
}
