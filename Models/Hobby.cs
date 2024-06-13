namespace DemographicsGenerator.Models
{
    public class Hobby
    {
        public string Name { get; set; } = Constants.Models.DefaultResponse;
        public int Passion { get; set; }
        public string? PassionDesc { get; set; }
        public string? Desc { get; set; }

        public static Hobby GetRandomHobby()
        {
            List<Hobby> hobbyList = Helpers.Utility.GetRandomResourceList<Hobby>(Constants.Resources.HobbyFilePath);
            Hobby hobby = Helpers.Utility.GetRandomResource<Hobby>(hobbyList);
            return hobby;
        }

        public static int GetHobbyPassion()
        {
            int passion = Helpers.Utility.GetRandomNumber(0, 101);
            return passion;
        }
    }
}
