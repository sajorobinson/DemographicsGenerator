namespace DemographicsGenerator.Models
{
    public class Language
    {
        public string Name { get; set; } = Constants.Models.DefaultName;
        public static Language GetRandomLanguage()
        {
            Language language = Helpers.Utility.GetResource<Language>(Constants.Resources.LanguageFilePath);
            return language;
        }
    }
}