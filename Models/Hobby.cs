namespace DemographicsGenerator.Models
{
    public class Hobby
    {
        public string Name { get; set; } = Constants.Models.DefaultName;
        public int Passion { get; set; }
        public string? PassionDesc { get; set; }
        public string? Desc { get; set; }
        public static Hobby GetRandomHobby()
        {
            Hobby hobby = Helpers.Utility.GetResource<Hobby>(Constants.Resources.HobbyFilePath);
            return hobby;
        }
        public static int GetHobbyPassion()
        {
            int passion = Helpers.Utility.GetRandomNumber(0, 101);
            return passion;
        }
    }
}