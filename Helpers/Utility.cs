using System.Text.Json;

namespace Helpers
{
    public class Utility
    {
        public static T GetRandomItem<T>(List<T> list)
        {
            Random random = new Random();
            int randomIndex = random.Next(list.Count);
            return list[randomIndex];
        }
        public static T GetResource<T>(string filePath)
        {
            string json = Json.ReadJsonFile(filePath);
            List<T> objects = JsonSerializer.Deserialize<List<T>>(json)!;
            var target = GetRandomItem(objects);
            return target;
        }
    }
}