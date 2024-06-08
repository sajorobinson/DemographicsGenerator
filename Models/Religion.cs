namespace Models
{
    public class Religion
    {
        string? Name { get; set; }
        public static Religion Get()
        {
            Religion religion = Helpers.Utility.GetResource<Religion>(Constants.Resources.ReligionFilePath);
            return religion;
        }
    }
}