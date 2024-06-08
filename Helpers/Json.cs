namespace Helpers
{
    public class Json
    {
        public static string ReadJsonFile(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);
            return jsonString;
        }
    }
}


