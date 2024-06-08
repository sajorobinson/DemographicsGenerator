namespace Models
{
    public class Country
    {
        public string? Name { get; set; }
        public static Country Get()
        {
            Country country = Helpers.Utility.GetResource<Country>(Constants.Resources.CountryFilePath);
            return country;
        }
    }
}