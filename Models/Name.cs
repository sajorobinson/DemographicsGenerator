namespace DemographicsGenerator.Models
{
    public class Name
    {
        public string? First { get; set; }
        public string? Middle { get; set; }
        public string? Last { get; set; }

        public static string GetFirst()
        {
            return "PlaceholderFirst";
        }

        public static string GetMiddle()
        {
            return "PlaceholderMiddle";
        }

        public static string GetLast()
        {
            return "PlaceholderLast";
        }
    }
}