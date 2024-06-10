namespace Models
{
    public class Hobby
    {
        public string Name { get; set; } = Constants.Models.DefaultName;
        public int Passion { get; set; }
        public string? PassionDesc { get; set; }
        public string? Desc { get; set; }
        public string GetRandomName()
        {
            Hobby hobby = Helpers.Utility.GetResource<Hobby>(Constants.Resources.HobbyFilePath);
            return hobby.Name;
        }
        public int GetHobbyPassion()
        {
            int passion = Helpers.Utility.GetRandomNumber(0, 101);
            return passion;
        }
    }
}