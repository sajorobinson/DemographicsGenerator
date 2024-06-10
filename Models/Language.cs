namespace Models
{
    public class Language
    {
        public string Name { get; set; } = Constants.Models.DefaultName;
        public string GetRandomName()
        {
            Language language = Helpers.Utility.GetResource<Language>(Constants.Resources.LanguageFilePath);
            return language.Name;
        }
    }
}