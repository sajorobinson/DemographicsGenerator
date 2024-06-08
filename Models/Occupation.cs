namespace Models
{
    public class Occupation
    {
        public string? Name { get; set; }
        public static Occupation Get()
        {
            Occupation occupation = Helpers.Utility.GetResource<Occupation>(Constants.Resources.OccupationFilePath);
            return occupation;
        }
    }
}