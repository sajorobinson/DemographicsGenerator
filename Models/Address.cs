namespace DemographicsGenerator.Models
{
    public class Address
    {
        public string? Street { get; set; }
        public Town? Town { get; set; }

        public static string GetStreet()
        {
            string street = "123 Fake Street";
            return street;
        }

        public static Town GetTown()
        {
            Town town = Models.Town.GetRandomTown();
            return town;
        }
    }
}