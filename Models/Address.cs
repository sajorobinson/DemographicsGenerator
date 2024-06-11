using System.Text;
using DemographicsGenerator.Helpers;

namespace DemographicsGenerator.Models
{
    public class Address
    {
        public string? Street { get; set; }
        public Town? Town { get; set; }

        public static string GetStreet()
        {
            List<string> directions = new List<string>();
            directions.Add("N");
            directions.Add("S");
            directions.Add("E");
            directions.Add("W");
            directions.Add("");
            int number = Utility.GetRandomNumber(0, 1000);
            string direction = Utility.GetRandomItem(directions);
            Street street = Helpers.Utility.GetResource<Street>(Constants.Resources.StreetFilePath);
            StringBuilder fullStreet = new StringBuilder();
            fullStreet.Append($"{number.ToString()} ");
            fullStreet.Append($"{direction} ");
            fullStreet.Append(street.Name);
            return fullStreet.ToString();
        }

        public static Town GetTown()
        {
            Town town = Models.Town.GetRandomTown();
            return town;
        }
    }
}