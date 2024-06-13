namespace DemographicsGenerator.Models
{
    public class Language
    {
        public string Name { get; set; } = Constants.Models.DefaultResponse;

        public static Language GetRandomLanguage()
        {
            List<Language> languageList = Helpers.Utility.GetRandomResourceList<Language>(Constants.Resources.LanguageFilePath);
            Language language = Helpers.Utility.GetRandomResource<Language>(languageList);
            return language;
        }
    }
}
