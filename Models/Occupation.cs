namespace DemographicsGenerator.Models
{
    public class Occupation
    {
        public string Name { get; set; } = Constants.Models.DefaultResponse;
        public int EducationalLevel { get; set; }

        public static Occupation OccupationRoulette(int educationLevel, int possibleDeviation)
        {
            List<string> options = new List<string>
            {
                "random",
                "relevant",
                "deviation"
            };
            string choice = Helpers.Utility.GetRandomItem<string>(options);

            if (choice == "random")
            {
                return GetRandomOccupation();
            }
            else if (choice == "relevant")
            {
                return GetRandomOccupationRelevantToEducation(educationLevel);
            }
            else if (choice == "deviation")
            {
                return GetRandomOccupationWithinDeviationToEducation(educationLevel, possibleDeviation);
            }
            else
            {
                return GetRandomOccupation();
            }
        }

        public static Occupation GetRandomOccupation()
        {
            List<Occupation> occupationList = Helpers.Utility.GetRandomResourceList<Occupation>(Constants.Resources.OccupationFilePath);
            Occupation occupation = Helpers.Utility.GetRandomResource<Occupation>(occupationList);
            return occupation;
        }

        public static Occupation GetRandomOccupationRelevantToEducation(int educationLevel)
        {
            List<Occupation> occupationList = Helpers.Utility.GetRandomResourceList<Occupation>(Constants.Resources.OccupationFilePath);
            var matchingOccupations = occupationList.Where(occupation => occupation.EducationalLevel == educationLevel).ToList();
            Occupation matchingOccupation = Helpers.Utility.GetRandomResource<Occupation>(matchingOccupations);
            return matchingOccupation;
        }

        public static Occupation GetRandomOccupationWithinDeviationToEducation(int educationLevel, int randomDeviation)
        {
            if (randomDeviation > 10)
            {
                randomDeviation = 10;
            }
            int deviation = Math.Abs(educationLevel - randomDeviation);
            List<Occupation> occupationList = Helpers.Utility.GetRandomResourceList<Occupation>(Constants.Resources.OccupationFilePath);
            List<Occupation> matchingOccupations = occupationList.Where(occupation => occupation.EducationalLevel == deviation).ToList();
            Occupation matchingOccupation = Helpers.Utility.GetRandomResource<Occupation>(matchingOccupations);
            return matchingOccupation;
        }
    }
}
