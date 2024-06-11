namespace DemographicsGenerator.Helpers
{
    public static class Json
    {
        public static string GetJsonString(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);
            return jsonString;
        }
    }
}