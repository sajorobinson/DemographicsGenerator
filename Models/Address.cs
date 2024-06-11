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
            List<string> directions =
            [
                "N",
                "S",
                "E",
                "W",
                ""
            ];
            int number = Utility.GetRandomNumber(0, 1000);
            string direction = Utility.GetRandomItem(directions);
            Street street = Helpers.Utility.GetResource<Street>(Constants.Resources.StreetFilePath);
            return $"{number} {direction} {street.Name}";
        }

        public static Town GetTown()
        {
            Town town = Models.Town.GetRandomTown();
            return town;
        }
    }
}