namespace DemographicsGenerator.Models
{
    public class Language
    {
        public string Name { get; set; } = Constants.Models.DefaultResponse;

        public static Language GetRandomLanguage()
        {
            Language language = Helpers.Utility.GetResource<Language>(Constants.Resources.LanguageFilePath);
            return language;
        }
    }
}