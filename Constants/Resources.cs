namespace DemographicsGenerator.Constants
{
    public static class Resources
    {
        private static string BaseFilePath => Directory.GetCurrentDirectory();
        public static string EducationalAttainmentFilePath => Path.Combine(BaseFilePath, "Resources", "EducationalAttainment.json");
        public static string EthnicityFilePath => Path.Combine(BaseFilePath, "Resources", "Ethnicity.json");
        public static string GenderFilePath => Path.Combine(BaseFilePath, "Resources", "Gender.json");
        public static string HealthStatusFilePath => Path.Combine(BaseFilePath, "Resources", "HealthStatus.json");
        public static string HobbyFilePath => Path.Combine(BaseFilePath, "Resources", "Hobby.json");
        public static string LanguageFilePath => Path.Combine(BaseFilePath, "Resources", "Language.json");
        public static string OccupationFilePath => Path.Combine(BaseFilePath, "Resources", "Occupation.json");
        public static string ReligionFilePath => Path.Combine(BaseFilePath, "Resources", "Religion.json");
        public static string SexualOrientationFilePath => Path.Combine(BaseFilePath, "Resources", "SexualOrientation.json");
        public static string StreetFilePath => Path.Combine(BaseFilePath, "Resources", "Street.json");
        public static string TownFilePath => Path.Combine(BaseFilePath, "Resources", "Town.json");
    }
}
